using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using LogisticsBCApp.EF_Classes;

namespace LogisticsBCApp
{
    public partial class FormNewDelivery : Form
    {
        LogisticsDbEntities context;

        public FormNewDelivery()
        {
            InitializeComponent();
            context = new LogisticsDbEntities();

            listBoxAreaNames.SelectedIndexChanged += ListBoxAreaNames_SelectedIndexChanged;
        }

        private void ListBoxAreaNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAvailableTrucks(listBoxAreaNames.SelectedIndex+1);
        }

        private void buttonAddDelivery_Click(object sender, EventArgs e)
        {
            BackgroundActivity backgroundAct = new BackgroundActivity();
            try
            {
                context.Packages.Add(new Package
                {
                    CustomerName = textBoxCustomerName.Text,
                    Address = richTextBoxAddress.Text,
                    AreaId = listBoxAreaNames.SelectedIndex + 1,
                    Weight = decimal.Parse(textBoxWeight.Text),
                    DeliveryDate = dateTimePickerDeliveryDate.Value,
                    StatusDelivered = false
                    //by default a new package is added as not delivered
                });
                //updating the driver earnings, areaId is the same as driverId
                //our drivers get $10 per delivery
                backgroundAct.UpdateDriverEarnings(listBoxAreaNames.SelectedIndex + 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check input data and try again!");
            }
            context.SaveChanges();
            MessageBox.Show("Delivery added successfully!");
            this.Close();
        }

        private void FormNewDelivery_Load(object sender, EventArgs e)
        {
            //setting initial settings
            //MinDate is set to DateTime.Now +1 so the user can't add a delivery with an old date.
            dateTimePickerDeliveryDate.MinDate = DateTime.Now.AddDays(1);

            //updating listBoxAreaNames
            listBoxAreaNames.Items.Clear();
            var areaNamesQuery = context.Areas.Select(x => x);
            foreach (var tempArea in areaNamesQuery)
                listBoxAreaNames.Items.Add(tempArea.AreaName);
            listBoxAreaNames.SelectedIndex = 0;
        }

        private void UpdateAvailableTrucks(int areaId)
        {
            comboBoxTrucks.Items.Clear();
            var availableTrucksQuery = context.Trucks.Where(x => x.AreaId == areaId).Select(x => x);
            int count = 0;
            foreach(var truck in availableTrucksQuery)
            {
                if (count == 0)
                {
                    String dataLine = $"Id: {truck.TruckId}, Current Load: {truck.CurrentLoad}, Max Load: {truck.MaxLoad}";
                    comboBoxTrucks.Items.Add(dataLine);
                    comboBoxTrucks.Text = dataLine;
                }
                else
                    comboBoxTrucks.Items.Add($"Id: {truck.TruckId}, Current Load: {truck.CurrentLoad}, Max Load: {truck.MaxLoad}");
                count++;
            }
        }
    }
}
