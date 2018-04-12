namespace LogisticsBCApp
{
    partial class FormNewDelivery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.listBoxAreaNames = new System.Windows.Forms.ListBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.dateTimePickerDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.buttonAddDelivery = new System.Windows.Forms.Button();
            this.richTextBoxAddress = new System.Windows.Forms.RichTextBox();
            this.comboBoxTrucks = new System.Windows.Forms.ComboBox();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelAreaName = new System.Windows.Forms.Label();
            this.labelSelectTruck = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelDeliveryDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(388, 90);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(444, 31);
            this.textBoxCustomerName.TabIndex = 0;
            // 
            // listBoxAreaNames
            // 
            this.listBoxAreaNames.FormattingEnabled = true;
            this.listBoxAreaNames.ItemHeight = 25;
            this.listBoxAreaNames.Location = new System.Drawing.Point(387, 306);
            this.listBoxAreaNames.Name = "listBoxAreaNames";
            this.listBoxAreaNames.Size = new System.Drawing.Size(445, 179);
            this.listBoxAreaNames.TabIndex = 2;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(387, 601);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(445, 31);
            this.textBoxWeight.TabIndex = 3;
            // 
            // dateTimePickerDeliveryDate
            // 
            this.dateTimePickerDeliveryDate.Location = new System.Drawing.Point(388, 674);
            this.dateTimePickerDeliveryDate.Name = "dateTimePickerDeliveryDate";
            this.dateTimePickerDeliveryDate.Size = new System.Drawing.Size(444, 31);
            this.dateTimePickerDeliveryDate.TabIndex = 4;
            // 
            // buttonAddDelivery
            // 
            this.buttonAddDelivery.Location = new System.Drawing.Point(306, 787);
            this.buttonAddDelivery.Name = "buttonAddDelivery";
            this.buttonAddDelivery.Size = new System.Drawing.Size(298, 80);
            this.buttonAddDelivery.TabIndex = 5;
            this.buttonAddDelivery.Text = "Add Delivery";
            this.buttonAddDelivery.UseVisualStyleBackColor = true;
            this.buttonAddDelivery.Click += new System.EventHandler(this.buttonAddDelivery_Click);
            // 
            // richTextBoxAddress
            // 
            this.richTextBoxAddress.Location = new System.Drawing.Point(390, 159);
            this.richTextBoxAddress.Name = "richTextBoxAddress";
            this.richTextBoxAddress.Size = new System.Drawing.Size(442, 108);
            this.richTextBoxAddress.TabIndex = 6;
            this.richTextBoxAddress.Text = "";
            // 
            // comboBoxTrucks
            // 
            this.comboBoxTrucks.FormattingEnabled = true;
            this.comboBoxTrucks.Location = new System.Drawing.Point(387, 524);
            this.comboBoxTrucks.Name = "comboBoxTrucks";
            this.comboBoxTrucks.Size = new System.Drawing.Size(445, 33);
            this.comboBoxTrucks.TabIndex = 7;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(66, 90);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(172, 25);
            this.labelCustomerName.TabIndex = 8;
            this.labelCustomerName.Text = "Customer Name:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(66, 159);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(187, 25);
            this.labelAddress.TabIndex = 9;
            this.labelAddress.Text = "Delivery Address: ";
            // 
            // labelAreaName
            // 
            this.labelAreaName.AutoSize = true;
            this.labelAreaName.Location = new System.Drawing.Point(66, 306);
            this.labelAreaName.Name = "labelAreaName";
            this.labelAreaName.Size = new System.Drawing.Size(129, 25);
            this.labelAreaName.TabIndex = 10;
            this.labelAreaName.Text = "Select Area:";
            // 
            // labelSelectTruck
            // 
            this.labelSelectTruck.AutoSize = true;
            this.labelSelectTruck.Location = new System.Drawing.Point(66, 524);
            this.labelSelectTruck.Name = "labelSelectTruck";
            this.labelSelectTruck.Size = new System.Drawing.Size(138, 25);
            this.labelSelectTruck.TabIndex = 11;
            this.labelSelectTruck.Text = "Select Truck:";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(66, 601);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(223, 25);
            this.labelWeight.TabIndex = 12;
            this.labelWeight.Text = "Package Weight (lbs):";
            // 
            // labelDeliveryDate
            // 
            this.labelDeliveryDate.AutoSize = true;
            this.labelDeliveryDate.Location = new System.Drawing.Point(66, 674);
            this.labelDeliveryDate.Name = "labelDeliveryDate";
            this.labelDeliveryDate.Size = new System.Drawing.Size(204, 25);
            this.labelDeliveryDate.TabIndex = 13;
            this.labelDeliveryDate.Text = "Scheduled Delivery:";
            // 
            // FormNewDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 916);
            this.Controls.Add(this.labelDeliveryDate);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelSelectTruck);
            this.Controls.Add(this.labelAreaName);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.comboBoxTrucks);
            this.Controls.Add(this.richTextBoxAddress);
            this.Controls.Add(this.buttonAddDelivery);
            this.Controls.Add(this.dateTimePickerDeliveryDate);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.listBoxAreaNames);
            this.Controls.Add(this.textBoxCustomerName);
            this.Name = "FormNewDelivery";
            this.Text = "FormNewDelivery";
            this.Load += new System.EventHandler(this.FormNewDelivery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.ListBox listBoxAreaNames;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeliveryDate;
        private System.Windows.Forms.Button buttonAddDelivery;
        private System.Windows.Forms.RichTextBox richTextBoxAddress;
        private System.Windows.Forms.ComboBox comboBoxTrucks;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelAreaName;
        private System.Windows.Forms.Label labelSelectTruck;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelDeliveryDate;
    }
}