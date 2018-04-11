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

namespace LogisticsBCApp
{
    public partial class FormDashboard : Form
    {
        LogisticsDbEntities context;

        public FormDashboard()
        {
            InitializeComponent();
            context = new LogisticsDbEntities();

            // setting debug log
            context.Database.Log = (s => Debug.Write(s));
            context.SaveChanges();
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
            FeedData();
        }

        private void InitialiseDataGridView()
        {
            //setting attributes
            dataGridViewCurrentDeliveries.ReadOnly = true;
            dataGridViewCurrentDeliveries.AllowUserToAddRows = false;
            dataGridViewCurrentDeliveries.AllowUserToDeleteRows = false;
            dataGridViewCurrentDeliveries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCurrentDeliveries.AutoGenerateColumns = false;

            //defining columns
            DataGridViewTextBoxColumn[] currentDeliveryInfo = new DataGridViewTextBoxColumn[]
            {
                new DataGridViewTextBoxColumn() {Name = "Customer Name" },
                new DataGridViewTextBoxColumn() {Name = "Address" },
                new DataGridViewTextBoxColumn() {Name = "Area Name" },
                new DataGridViewTextBoxColumn() {Name = "Weight (lbs)" },
                new DataGridViewTextBoxColumn() {Name = "Delivery Date" }
            };
            dataGridViewCurrentDeliveries.Columns.Clear();
            dataGridViewCurrentDeliveries.Columns.AddRange(currentDeliveryInfo);

            //calling method to populate the DataGridView
            FeedData();

        }

        private void FeedData()
        {
            //querying context.Packages fow deliveries which aren't delivered yet.
            //context.Packages and context.Areas to extract the AreaName using AreaId
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

            dataGridViewCurrentDeliveries.Rows.Clear();
            //populating dataGridViewCurrentDeliveries with data from query
            foreach (var tempDelivery in deliveryQuery)
            {
                dataGridViewCurrentDeliveries.Rows.Add(tempDelivery.CustomerName, tempDelivery.Address, tempDelivery.AreaName, tempDelivery.Weight, tempDelivery.DeliveryDate.ToString("MM/dd/yyyy"));
            }
        }

        private void buttonRefreshData_Click(object sender, EventArgs e)
        {
            InitialiseDataGridView();
            FeedData();
        }

        private void buttonNewDelivery_Click(object sender, EventArgs e)
        {
            FormNewDelivery newDeiliveryForm = new FormNewDelivery();
            newDeiliveryForm.Show();
        }
    }
}
