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
            this.panelActiveDeliveries = new System.Windows.Forms.Panel();
            this.labelUpcomingDeliveries = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDrivers = new System.Windows.Forms.Button();
            this.buttonTrucks = new System.Windows.Forms.Button();
            this.buttonPastDeliveries = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrentDeliveries)).BeginInit();
            this.panelActiveDeliveries.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReseedData
            // 
            this.buttonReseedData.Location = new System.Drawing.Point(1412, 1144);
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
            this.dataGridViewCurrentDeliveries.Location = new System.Drawing.Point(27, 118);
            this.dataGridViewCurrentDeliveries.Name = "dataGridViewCurrentDeliveries";
            this.dataGridViewCurrentDeliveries.RowTemplate.Height = 33;
            this.dataGridViewCurrentDeliveries.Size = new System.Drawing.Size(1558, 650);
            this.dataGridViewCurrentDeliveries.TabIndex = 1;
            // 
            // buttonNewDelivery
            // 
            this.buttonNewDelivery.Location = new System.Drawing.Point(614, 866);
            this.buttonNewDelivery.Name = "buttonNewDelivery";
            this.buttonNewDelivery.Size = new System.Drawing.Size(163, 58);
            this.buttonNewDelivery.TabIndex = 2;
            this.buttonNewDelivery.Text = "New Delivery";
            this.buttonNewDelivery.UseVisualStyleBackColor = true;
            this.buttonNewDelivery.Click += new System.EventHandler(this.buttonNewDelivery_Click);
            // 
            // buttonRefreshData
            // 
            this.buttonRefreshData.Location = new System.Drawing.Point(827, 866);
            this.buttonRefreshData.Name = "buttonRefreshData";
            this.buttonRefreshData.Size = new System.Drawing.Size(177, 58);
            this.buttonRefreshData.TabIndex = 3;
            this.buttonRefreshData.Text = "Refresh Data";
            this.buttonRefreshData.UseVisualStyleBackColor = true;
            this.buttonRefreshData.Click += new System.EventHandler(this.buttonRefreshData_Click);
            // 
            // panelActiveDeliveries
            // 
            this.panelActiveDeliveries.Controls.Add(this.labelUpcomingDeliveries);
            this.panelActiveDeliveries.Controls.Add(this.buttonRefreshData);
            this.panelActiveDeliveries.Controls.Add(this.buttonNewDelivery);
            this.panelActiveDeliveries.Controls.Add(this.dataGridViewCurrentDeliveries);
            this.panelActiveDeliveries.Controls.Add(this.buttonReseedData);
            this.panelActiveDeliveries.Location = new System.Drawing.Point(0, 77);
            this.panelActiveDeliveries.Name = "panelActiveDeliveries";
            this.panelActiveDeliveries.Size = new System.Drawing.Size(1614, 1207);
            this.panelActiveDeliveries.TabIndex = 4;
            // 
            // labelUpcomingDeliveries
            // 
            this.labelUpcomingDeliveries.AutoSize = true;
            this.labelUpcomingDeliveries.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpcomingDeliveries.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelUpcomingDeliveries.Location = new System.Drawing.Point(20, 59);
            this.labelUpcomingDeliveries.Name = "labelUpcomingDeliveries";
            this.labelUpcomingDeliveries.Size = new System.Drawing.Size(290, 40);
            this.labelUpcomingDeliveries.TabIndex = 4;
            this.labelUpcomingDeliveries.Text = "Upcoming Deliveries";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.buttonDrivers);
            this.panel1.Controls.Add(this.buttonTrucks);
            this.panel1.Controls.Add(this.buttonPastDeliveries);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.buttonCloseForm);
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1614, 71);
            this.panel1.TabIndex = 5;
            // 
            // buttonDrivers
            // 
            this.buttonDrivers.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDrivers.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDrivers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDrivers.Location = new System.Drawing.Point(965, 0);
            this.buttonDrivers.Name = "buttonDrivers";
            this.buttonDrivers.Size = new System.Drawing.Size(188, 72);
            this.buttonDrivers.TabIndex = 13;
            this.buttonDrivers.Text = "Drivers";
            this.buttonDrivers.UseVisualStyleBackColor = false;
            this.buttonDrivers.Click += new System.EventHandler(this.buttonDrivers_Click);
            // 
            // buttonTrucks
            // 
            this.buttonTrucks.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonTrucks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrucks.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrucks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTrucks.Location = new System.Drawing.Point(771, 0);
            this.buttonTrucks.Name = "buttonTrucks";
            this.buttonTrucks.Size = new System.Drawing.Size(188, 71);
            this.buttonTrucks.TabIndex = 12;
            this.buttonTrucks.Text = "Trucks";
            this.buttonTrucks.UseVisualStyleBackColor = false;
            this.buttonTrucks.Click += new System.EventHandler(this.buttonTrucks_Click);
            // 
            // buttonPastDeliveries
            // 
            this.buttonPastDeliveries.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonPastDeliveries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPastDeliveries.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPastDeliveries.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPastDeliveries.Location = new System.Drawing.Point(526, 0);
            this.buttonPastDeliveries.Name = "buttonPastDeliveries";
            this.buttonPastDeliveries.Size = new System.Drawing.Size(239, 71);
            this.buttonPastDeliveries.TabIndex = 11;
            this.buttonPastDeliveries.Text = "Past Deliveries";
            this.buttonPastDeliveries.UseVisualStyleBackColor = false;
            this.buttonPastDeliveries.Click += new System.EventHandler(this.buttonPastDeliveries_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDashboard.Location = new System.Drawing.Point(332, 0);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(188, 71);
            this.buttonDashboard.TabIndex = 4;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = false;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseForm.Font = new System.Drawing.Font("Eras Bold ITC", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseForm.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCloseForm.Location = new System.Drawing.Point(1535, 0);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(79, 71);
            this.buttonCloseForm.TabIndex = 10;
            this.buttonCloseForm.Text = "X";
            this.buttonCloseForm.UseVisualStyleBackColor = false;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Image = global::LogisticsBCApp.Properties.Resources.Logo1;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 1);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(270, 67);
            this.pictureBoxLogo.TabIndex = 6;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 1284);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelActiveDeliveries);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrentDeliveries)).EndInit();
            this.panelActiveDeliveries.ResumeLayout(false);
            this.panelActiveDeliveries.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReseedData;
        private System.Windows.Forms.DataGridView dataGridViewCurrentDeliveries;
        private System.Windows.Forms.Button buttonNewDelivery;
        private System.Windows.Forms.Button buttonRefreshData;
        private System.Windows.Forms.Panel panelActiveDeliveries;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Button buttonDrivers;
        private System.Windows.Forms.Button buttonTrucks;
        private System.Windows.Forms.Button buttonPastDeliveries;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Label labelUpcomingDeliveries;
    }
}

