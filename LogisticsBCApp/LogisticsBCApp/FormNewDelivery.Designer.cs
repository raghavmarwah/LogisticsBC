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
            this.SuspendLayout();
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(388, 90);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(180, 31);
            this.textBoxCustomerName.TabIndex = 0;
            // 
            // listBoxAreaNames
            // 
            this.listBoxAreaNames.FormattingEnabled = true;
            this.listBoxAreaNames.ItemHeight = 25;
            this.listBoxAreaNames.Location = new System.Drawing.Point(387, 306);
            this.listBoxAreaNames.Name = "listBoxAreaNames";
            this.listBoxAreaNames.Size = new System.Drawing.Size(388, 179);
            this.listBoxAreaNames.TabIndex = 2;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(397, 602);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(180, 31);
            this.textBoxWeight.TabIndex = 3;
            // 
            // dateTimePickerDeliveryDate
            // 
            this.dateTimePickerDeliveryDate.Location = new System.Drawing.Point(402, 674);
            this.dateTimePickerDeliveryDate.Name = "dateTimePickerDeliveryDate";
            this.dateTimePickerDeliveryDate.Size = new System.Drawing.Size(348, 31);
            this.dateTimePickerDeliveryDate.TabIndex = 4;
            // 
            // buttonAddDelivery
            // 
            this.buttonAddDelivery.Location = new System.Drawing.Point(335, 778);
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
            this.richTextBoxAddress.Size = new System.Drawing.Size(385, 108);
            this.richTextBoxAddress.TabIndex = 6;
            this.richTextBoxAddress.Text = "";
            // 
            // comboBoxTrucks
            // 
            this.comboBoxTrucks.FormattingEnabled = true;
            this.comboBoxTrucks.Location = new System.Drawing.Point(391, 524);
            this.comboBoxTrucks.Name = "comboBoxTrucks";
            this.comboBoxTrucks.Size = new System.Drawing.Size(441, 33);
            this.comboBoxTrucks.TabIndex = 7;
            // 
            // FormNewDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 916);
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
    }
}