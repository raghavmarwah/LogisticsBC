using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticsBCApp
{
    public partial class FormNewDelivery : Form
    {
        public FormNewDelivery()
        {
            InitializeComponent();

            //setting initial settings
            //MinDate is set to DateTime.Now so the user can't add a delivery with an old date.
            dateTimePickerDeliveryDate.MinDate = DateTime.Now;
            dateTimePickerDeliveryDate.Value = DateTime.Now;
            listBoxAreaNames.SelectedIndex = 0;
        }

        private void buttonAddDelivery_Click(object sender, EventArgs e)
        {

        }
    }
}
