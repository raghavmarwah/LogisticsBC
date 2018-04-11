namespace LogisticsBCApp
{
    partial class FormDashboard
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
            this.buttonReseedData = new System.Windows.Forms.Button();
            this.dataGridViewCurrentDeliveries = new System.Windows.Forms.DataGridView();
            this.buttonNewDelivery = new System.Windows.Forms.Button();
            this.buttonRefreshData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrentDeliveries)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReseedData
            // 
            this.buttonReseedData.Location = new System.Drawing.Point(1291, 900);
            this.buttonReseedData.Name = "buttonReseedData";
            this.buttonReseedData.Size = new System.Drawing.Size(173, 51);
            this.buttonReseedData.TabIndex = 0;
            this.buttonReseedData.Text = "Reseed Data";
            this.buttonReseedData.UseVisualStyleBackColor = true;
            this.buttonReseedData.Click += new System.EventHandler(this.buttonReseedData_Click);
            // 
            // dataGridViewCurrentDeliveries
            // 
            this.dataGridViewCurrentDeliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCurrentDeliveries.Location = new System.Drawing.Point(34, 33);
            this.dataGridViewCurrentDeliveries.Name = "dataGridViewCurrentDeliveries";
            this.dataGridViewCurrentDeliveries.RowTemplate.Height = 33;
            this.dataGridViewCurrentDeliveries.Size = new System.Drawing.Size(1442, 650);
            this.dataGridViewCurrentDeliveries.TabIndex = 1;
            // 
            // buttonNewDelivery
            // 
            this.buttonNewDelivery.Location = new System.Drawing.Point(309, 729);
            this.buttonNewDelivery.Name = "buttonNewDelivery";
            this.buttonNewDelivery.Size = new System.Drawing.Size(163, 58);
            this.buttonNewDelivery.TabIndex = 2;
            this.buttonNewDelivery.Text = "New Delivery";
            this.buttonNewDelivery.UseVisualStyleBackColor = true;
            this.buttonNewDelivery.Click += new System.EventHandler(this.buttonNewDelivery_Click);
            // 
            // buttonRefreshData
            // 
            this.buttonRefreshData.Location = new System.Drawing.Point(550, 728);
            this.buttonRefreshData.Name = "buttonRefreshData";
            this.buttonRefreshData.Size = new System.Drawing.Size(177, 58);
            this.buttonRefreshData.TabIndex = 3;
            this.buttonRefreshData.Text = "Refresh Data";
            this.buttonRefreshData.UseVisualStyleBackColor = true;
            this.buttonRefreshData.Click += new System.EventHandler(this.buttonRefreshData_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 1161);
            this.Controls.Add(this.buttonRefreshData);
            this.Controls.Add(this.buttonNewDelivery);
            this.Controls.Add(this.dataGridViewCurrentDeliveries);
            this.Controls.Add(this.buttonReseedData);
            this.Name = "FormDashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrentDeliveries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReseedData;
        private System.Windows.Forms.DataGridView dataGridViewCurrentDeliveries;
        private System.Windows.Forms.Button buttonNewDelivery;
        private System.Windows.Forms.Button buttonRefreshData;
    }
}

