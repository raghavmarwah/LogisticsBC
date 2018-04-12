using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogisticsBCApp.EF_Classes;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using System.Windows;

namespace LogisticsBCApp
{
    public partial class FormDashboard : Form
    {
        //context to database
        LogisticsDbEntities context;
        //this color is for the selected navbar item
        Color selectedButtonColor = System.Drawing.ColorTranslator.FromHtml("#a5a5a5");

        public FormDashboard()
        {
            InitializeComponent();
            context = new LogisticsDbEntities();

            //additional visual attributes
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            buttonCloseForm.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonPastDeliveries.FlatAppearance.BorderSize = 0;
            buttonTrucks.FlatAppearance.BorderSize = 0;
            buttonDrivers.FlatAppearance.BorderSize = 0;
            this.Width = 805;
            this.Height = 670;
            ButtonColorDefault();
            buttonDashboard.BackColor = selectedButtonColor;

            // setting debug log
            context.Database.Log = (s => Debug.Write(s));
            context.SaveChanges();

            //setting all panels to hidden except panelActiveDeliveries
            HideAllPanels();
            panelActiveDeliveries.Visible = true;

            //defining event handlers
            textBoxCustomerName.TextChanged += TextBoxCustomerName_TextChanged;
            textBoxCustomerAddress.TextChanged += TextBoxCustomerAddress_TextChanged;
            textBoxCustomerNamePast.TextChanged += TextBoxCustomerNamePast_TextChanged;
            textBoxCustomerAddressPast.TextChanged += TextBoxCustomerAddressPast_TextChanged;
        }

        private void TextBoxCustomerAddressPast_TextChanged(object sender, EventArgs e)
        {
            FeedDataPastDeliveries();
        }

        private void TextBoxCustomerNamePast_TextChanged(object sender, EventArgs e)
        {
            FeedDataPastDeliveries();
        }

        private void TextBoxCustomerAddress_TextChanged(object sender, EventArgs e)
        {
            FeedDataCurrentDeliveries();
        }

        private void TextBoxCustomerName_TextChanged(object sender, EventArgs e)
        {
            FeedDataCurrentDeliveries();
        }

        private void buttonReseedData_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            //loading data from context and updating DataSource for dataGridViews
            context.Areas.Load();
            context.Drivers.Load();
            context.Packages.Load();
            context.Trucks.Load();
            InitialiseDataGridView();
        }

        private void ReloadData()
        {
            // reset ident for all tables
            context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Areas', RESEED, 0)");
            context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Drivers', RESEED, 0)");
            context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Packages', RESEED, 0)");
            context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Trucks', RESEED, 0)");

            //clearing data in the tables
            context.Areas.RemoveRange(context.Areas);
            context.Drivers.RemoveRange(context.Drivers);
            context.Packages.RemoveRange(context.Packages);
            context.Trucks.RemoveRange(context.Trucks);
            context.SaveChanges();

            //creating blank lists for data
            List<Area> areaList = new List<Area>();
            List<Driver> driverList = new List<Driver>();
            List<Package> packageList = new List<Package>();
            List<Truck> truckList = new List<Truck>();

            String tempLine;
            BackgroundActivity backgroundAct = new BackgroundActivity();

            //opening 'Data_Areas.csv' to populate areaList
            try
            {
                StreamReader areaFile = File.OpenText("Data_Areas.csv");
                while (!areaFile.EndOfStream)
                {
                    tempLine = areaFile.ReadLine();
                    areaList.Add(new Area
                    {
                        AreaName = tempLine
                    });
                }
                areaFile.Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Error: Data_Areas.csv doesn't exist, contact DB admin.");
            }
            context.Areas.AddRange(areaList);
            context.SaveChanges();

            //opening 'Data_Drivers.csv' to populate driverList
            try
            {
                StreamReader driverFile = File.OpenText("Data_Drivers.csv");
                while (!driverFile.EndOfStream)
                {
                    tempLine = driverFile.ReadLine();
                    string[] temp = tempLine.Split(',');
                    driverList.Add(new Driver
                    {
                        DriverName = temp[0],
                        TotalEarnings = decimal.Parse(temp[1])
                    });
                }
                driverFile.Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Error: Data_Drivers.csv doesn't exist, contact DB admin.");
            }
            context.Drivers.AddRange(driverList);
            context.SaveChanges();

            //opening 'Data_Trucks.csv' to populate truckList
            try
            {
                StreamReader truckFile = File.OpenText("Data_Trucks.csv");
                while (!truckFile.EndOfStream)
                {
                    tempLine = truckFile.ReadLine();
                    string[] temp = tempLine.Split(',');
                    truckList.Add(new Truck
                    {
                        MaxLoad = decimal.Parse(temp[0]),
                        CurrentLoad = decimal.Parse(temp[1]),
                        AreaId = int.Parse(temp[2]),
                        DriverId = int.Parse(temp[3])

                    });
                }
                truckFile.Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Error: Data_Trucks.csv doesn't exist, contact DB admin.");
            }
            context.Trucks.AddRange(truckList);
            context.SaveChanges();

            //opening 'Data_Packages.csv' to populate packageList
            try
            {
                StreamReader packageFile = File.OpenText("Data_Packages.csv");
                while (!packageFile.EndOfStream)
                {
                    tempLine = packageFile.ReadLine();
                    string[] temp = tempLine.Split(',');

                    //checking delivery status by date
                    bool packageDelivered = false;
                    if (DateTime.Parse(temp[4]).CompareTo(DateTime.Now) <= 0)
                        packageDelivered = true;

                    packageList.Add(new Package
                    {
                        CustomerName = temp[0],
                        Address = temp[1],
                        AreaId = int.Parse(temp[2]),
                        Weight = decimal.Parse(temp[3]),
                        DeliveryDate = DateTime.Parse(temp[4]),
                        StatusDelivered = packageDelivered

                    });
                    //updating the driver earnings, initially the areaId is the same as driverId
                    //our drivers get $10 per delivery
                    backgroundAct.UpdateDriverEarnings(int.Parse(temp[2]));
                }
                packageFile.Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Error: Data_Packages.csv doesn't exist, contact DB admin.");
            }
            context.Packages.AddRange(packageList);
            context.SaveChanges();

            //populating DataGridView
            InitialiseDataGridView();
        }

        private void InitialiseDataGridView()
        {
            //setting attributes for dataGridViewCurrentDeliveries
            dataGridViewCurrentDeliveries.ReadOnly = true;
            dataGridViewCurrentDeliveries.AllowUserToAddRows = false;
            dataGridViewCurrentDeliveries.AllowUserToDeleteRows = false;
            dataGridViewCurrentDeliveries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCurrentDeliveries.AutoGenerateColumns = false;

            //setting attributes for dataGridViewPastDeliveries
            dataGridViewPastDeliveries.ReadOnly = true;
            dataGridViewPastDeliveries.AllowUserToAddRows = false;
            dataGridViewPastDeliveries.AllowUserToDeleteRows = false;
            dataGridViewPastDeliveries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPastDeliveries.AutoGenerateColumns = false;

            //setting attributes for dataGridViewTruckInformation
            dataGridViewTruckInformation.ReadOnly = true;
            dataGridViewTruckInformation.AllowUserToAddRows = false;
            dataGridViewTruckInformation.AllowUserToDeleteRows = false;
            dataGridViewTruckInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTruckInformation.AutoGenerateColumns = false;

            //setting attributes for dataGridViewDriverInformation
            dataGridViewDriverInformation.ReadOnly = true;
            dataGridViewDriverInformation.AllowUserToAddRows = false;
            dataGridViewDriverInformation.AllowUserToDeleteRows = false;
            dataGridViewDriverInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDriverInformation.AutoGenerateColumns = false;

            //defining columns
            DataGridViewTextBoxColumn[] currentDeliveryInfo = new DataGridViewTextBoxColumn[]
            {
                new DataGridViewTextBoxColumn() {Name = "Customer Name" },
                new DataGridViewTextBoxColumn() {Name = "Address" },
                new DataGridViewTextBoxColumn() {Name = "Area Name" },
                new DataGridViewTextBoxColumn() {Name = "Weight (lbs)" },
                new DataGridViewTextBoxColumn() {Name = "Delivery Date" }
            };
            DataGridViewTextBoxColumn[] pastDeliveryInfo = new DataGridViewTextBoxColumn[]
            {
                new DataGridViewTextBoxColumn() {Name = "Customer Name" },
                new DataGridViewTextBoxColumn() {Name = "Address" },
                new DataGridViewTextBoxColumn() {Name = "Area Name" },
                new DataGridViewTextBoxColumn() {Name = "Weight (lbs)" },
                new DataGridViewTextBoxColumn() {Name = "Delivery Date" }
            };
            DataGridViewTextBoxColumn[] truckInfo = new DataGridViewTextBoxColumn[]
            {
                new DataGridViewTextBoxColumn() {Name = "Truck Id" },
                new DataGridViewTextBoxColumn() {Name = "Max Load" },
                new DataGridViewTextBoxColumn() {Name = "Area Name" },
                new DataGridViewTextBoxColumn() {Name = "Driver Name" }
            };
            DataGridViewTextBoxColumn[] driverInfo = new DataGridViewTextBoxColumn[]
            {
                new DataGridViewTextBoxColumn() {Name = "Driver Id" },
                new DataGridViewTextBoxColumn() {Name = "Name" },
                new DataGridViewTextBoxColumn() {Name = "Total Earnings" }
            };

            //clearing columns for all DataGridViews
            dataGridViewCurrentDeliveries.Columns.Clear();
            dataGridViewPastDeliveries.Columns.Clear();
            dataGridViewTruckInformation.Columns.Clear();
            dataGridViewDriverInformation.Columns.Clear();

            //adding columns to all DataGridViews
            dataGridViewCurrentDeliveries.Columns.AddRange(currentDeliveryInfo);
            dataGridViewPastDeliveries.Columns.AddRange(pastDeliveryInfo);
            dataGridViewTruckInformation.Columns.AddRange(truckInfo);
            dataGridViewDriverInformation.Columns.AddRange(driverInfo);

            //calling method to populate the DataGridViews
            FeedDataCurrentDeliveries();
            FeedDataPastDeliveries();
            FeedDataTrucks();
            FeedDataDrivers();

        }

        private void FeedDataCurrentDeliveries()
        {
            //dataGridViewCurrentDeliveries
            //querying context.Packages for deliveries which aren't delivered yet.
            //Join: context.Packages and context.Areas to extract the AreaName using AreaId
            var deliveryQuery = from packages in context.Packages
                                join areas in context.Areas on packages.AreaId equals areas.AreaId
                                where packages.StatusDelivered == false
                                orderby packages.DeliveryDate
                                select new
                                {
                                    CustomerName = packages.CustomerName,
                                    Address = packages.Address,
                                    AreaName = areas.AreaName,
                                    Weight = packages.Weight,
                                    DeliveryDate = packages.DeliveryDate
                                };

            //filtering data by customer name
            if (textBoxCustomerName.TextLength > 0)
            {
                deliveryQuery = deliveryQuery.Where(x => x.CustomerName.Contains(textBoxCustomerName.Text)).Select(x => x);
            }
            //filtering data by customer address
            if (textBoxCustomerAddress.TextLength > 0)
            {
                deliveryQuery = deliveryQuery.Where(x => x.Address.Contains(textBoxCustomerAddress.Text)).Select(x => x);
            }

            dataGridViewCurrentDeliveries.Rows.Clear();
            //populating dataGridViewCurrentDeliveries with data from query
            foreach (var tempDelivery in deliveryQuery)
            {
                dataGridViewCurrentDeliveries.Rows.Add(tempDelivery.CustomerName, tempDelivery.Address, tempDelivery.AreaName, tempDelivery.Weight, tempDelivery.DeliveryDate.ToString("MM/dd/yyyy"));
            }
        }
        private void FeedDataPastDeliveries()
        {
            //dataGridViewPastDeliveries
            //querying context.Packages for deliveries which are delivered.
            //Join: context.Packages and context.Areas to extract the AreaName using AreaId
            var pastDeliveryQuery = from packages in context.Packages
                                    join areas in context.Areas on packages.AreaId equals areas.AreaId
                                    where packages.StatusDelivered == true
                                    orderby packages.DeliveryDate
                                    select new
                                    {
                                        CustomerName = packages.CustomerName,
                                        Address = packages.Address,
                                        AreaName = areas.AreaName,
                                        Weight = packages.Weight,
                                        DeliveryDate = packages.DeliveryDate
                                    };

            //filtering data by customer name
            if (textBoxCustomerNamePast.TextLength > 0)
            {
                pastDeliveryQuery = pastDeliveryQuery.Where(x => x.CustomerName.Contains(textBoxCustomerNamePast.Text)).Select(x => x);
            }
            //filtering data by customer address
            if (textBoxCustomerAddressPast.TextLength > 0)
            {
                pastDeliveryQuery = pastDeliveryQuery.Where(x => x.Address.Contains(textBoxCustomerAddressPast.Text)).Select(x => x);
            }

            dataGridViewPastDeliveries.Rows.Clear();
            //populating dataGridViewPastDeliveries with data from query
            foreach (var tempDelivery in pastDeliveryQuery)
            {
                dataGridViewPastDeliveries.Rows.Add(tempDelivery.CustomerName, tempDelivery.Address, tempDelivery.AreaName, tempDelivery.Weight, tempDelivery.DeliveryDate.ToString("MM/dd/yyyy"));
            }
        }
        private void FeedDataTrucks()
        {
            //dataGridViewTruckInformation
            //querying context.Trucks for truck information in the db
            //Join: context.Trucks and context.Areas to extract the AreaName using AreaId
            //Join: context.Trucks and context.Drivers to extract the DriverName using DriverId
            var truckInfoQuery = from trucks in context.Trucks
                                 join areas in context.Areas on trucks.AreaId equals areas.AreaId
                                 join drivers in context.Drivers on trucks.DriverId equals drivers.DriverId
                                 orderby trucks.TruckId
                                 select new
                                 {
                                     TruckId = trucks.TruckId,
                                     MaxLoad = trucks.MaxLoad,
                                     AreaName = areas.AreaName,
                                     DriverName = drivers.DriverName

                                 };
            dataGridViewTruckInformation.Rows.Clear();
            //populating dataGridViewTruckInformation with data from query
            foreach (var tempTruck in truckInfoQuery)
            {
                dataGridViewTruckInformation.Rows.Add(tempTruck.TruckId, tempTruck.MaxLoad, tempTruck.AreaName, tempTruck.DriverName);
            }
        }
        private void FeedDataDrivers()
        {
            //dataGridViewDriverInformation
            //querying context.Drivers for driver information in the db
            var driverInfoQuery = from drivers in context.Drivers
                                  orderby drivers.TotalEarnings descending
                                  select drivers;

            dataGridViewDriverInformation.Rows.Clear();
            //populating dataGridViewDriverInformation with data from query
            foreach (var tempDriver in driverInfoQuery)
            {
                dataGridViewDriverInformation.Rows.Add(tempDriver.DriverId, tempDriver.DriverName, tempDriver.TotalEarnings.ToString("c2"));
            }
        }

        private void buttonRefreshData_Click(object sender, EventArgs e)
        {
            InitialiseDataGridView();
            FeedDataCurrentDeliveries();
        }

        private void buttonNewDelivery_Click(object sender, EventArgs e)
        {
            FormNewDelivery newDeiliveryForm = new FormNewDelivery();
            newDeiliveryForm.Show();
        }

        private void HideAllPanels()
        {
            panelActiveDeliveries.Visible = false;
        }
        private void ButtonColorDefault()
        {
            Color defaultNavButtonColor = System.Drawing.ColorTranslator.FromHtml("#6D6D6D");
            buttonDashboard.BackColor = defaultNavButtonColor;
            buttonPastDeliveries.BackColor = defaultNavButtonColor;
            buttonTrucks.BackColor = defaultNavButtonColor;
            buttonDrivers.BackColor = defaultNavButtonColor;
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            ButtonColorDefault();
            buttonDashboard.BackColor = selectedButtonColor;
            HideAllPanels();
            panelActiveDeliveries.Visible = true;
            panelActiveDeliveries.BringToFront();
        }

        private void buttonPastDeliveries_Click(object sender, EventArgs e)
        {
            ButtonColorDefault();
            buttonPastDeliveries.BackColor = selectedButtonColor;
            HideAllPanels();
            panelPastDeliveries.Visible = true;
            panelPastDeliveries.BringToFront();
        }

        private void buttonTrucks_Click(object sender, EventArgs e)
        {
            ButtonColorDefault();
            buttonTrucks.BackColor = selectedButtonColor;
            HideAllPanels();
            panelTrucks.Visible = true;
            panelTrucks.BringToFront();
        }

        private void buttonDrivers_Click(object sender, EventArgs e)
        {
            ButtonColorDefault();
            buttonDrivers.BackColor = selectedButtonColor;
            HideAllPanels();
            panelDriver.Visible = true;
            panelDriver.BringToFront();
        }

        private void buttonClearFilters_Click(object sender, EventArgs e)
        {
            textBoxCustomerName.Text = "";
            textBoxCustomerAddress.Text = "";
        }

        private void buttonClearFiltersPast_Click(object sender, EventArgs e)
        {
            textBoxCustomerNamePast.Text = "";
            textBoxCustomerAddressPast.Text = "";
        }
    }
}
