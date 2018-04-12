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
            this.panelTopNavigation = new System.Windows.Forms.Panel();
            this.buttonDrivers = new System.Windows.Forms.Button();
            this.buttonTrucks = new System.Windows.Forms.Button();
            this.buttonPastDeliveries = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelPastDeliveries = new System.Windows.Forms.Panel();
            this.panelBottomLayer = new System.Windows.Forms.Panel();
            this.dataGridViewPastDeliveries = new System.Windows.Forms.DataGridView();
            this.labelPastDeliveries = new System.Windows.Forms.Label();
            this.panelTrucks = new System.Windows.Forms.Panel();
            this.dataGridViewTruckInformation = new System.Windows.Forms.DataGridView();
            this.labelTruckInformation = new System.Windows.Forms.Label();
            this.panelDriver = new System.Windows.Forms.Panel();
            this.dataGridViewDriverInformation = new System.Windows.Forms.DataGridView();
            this.labelDriverInfo = new System.Windows.Forms.Label();
            this.groupBoxFilterControls = new System.Windows.Forms.GroupBox();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerAddress = new System.Windows.Forms.TextBox();
            this.labelSearchCustomerName = new System.Windows.Forms.Label();
            this.labelSearchCustomerAddress = new System.Windows.Forms.Label();
            this.buttonClearFilters = new System.Windows.Forms.Button();
            this.groupBoxFilterControlsPast = new System.Windows.Forms.GroupBox();
            this.buttonClearFiltersPast = new System.Windows.Forms.Button();
            this.labelSearchCustomerAddressPast = new System.Windows.Forms.Label();
            this.labelSearchCutomerNamePast = new System.Windows.Forms.Label();
            this.textBoxCustomerAddressPast = new System.Windows.Forms.TextBox();
            this.textBoxCustomerNamePast = new System.Windows.Forms.TextBox();
            this.buttonExportData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrentDeliveries)).BeginInit();
            this.panelActiveDeliveries.SuspendLayout();
            this.panelTopNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelPastDeliveries.SuspendLayout();
            this.panelBottomLayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPastDeliveries)).BeginInit();
            this.panelTrucks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTruckInformation)).BeginInit();
            this.panelDriver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDriverInformation)).BeginInit();
            this.groupBoxFilterControls.SuspendLayout();
            this.groupBoxFilterControlsPast.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReseedData
            // 
            this.buttonReseedData.Location = new System.Drawing.Point(1406, 1136);
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
            this.dataGridViewCurrentDeliveries.Location = new System.Drawing.Point(21, 110);
            this.dataGridViewCurrentDeliveries.Name = "dataGridViewCurrentDeliveries";
            this.dataGridViewCurrentDeliveries.RowTemplate.Height = 33;
            this.dataGridViewCurrentDeliveries.Size = new System.Drawing.Size(1558, 650);
            this.dataGridViewCurrentDeliveries.TabIndex = 1;
            // 
            // buttonNewDelivery
            // 
            this.buttonNewDelivery.Location = new System.Drawing.Point(1211, 790);
            this.buttonNewDelivery.Name = "buttonNewDelivery";
            this.buttonNewDelivery.Size = new System.Drawing.Size(163, 58);
            this.buttonNewDelivery.TabIndex = 2;
            this.buttonNewDelivery.Text = "New Delivery";
            this.buttonNewDelivery.UseVisualStyleBackColor = true;
            this.buttonNewDelivery.Click += new System.EventHandler(this.buttonNewDelivery_Click);
            // 
            // buttonRefreshData
            // 
            this.buttonRefreshData.Location = new System.Drawing.Point(1402, 790);
            this.buttonRefreshData.Name = "buttonRefreshData";
            this.buttonRefreshData.Size = new System.Drawing.Size(177, 58);
            this.buttonRefreshData.TabIndex = 3;
            this.buttonRefreshData.Text = "Refresh Data";
            this.buttonRefreshData.UseVisualStyleBackColor = true;
            this.buttonRefreshData.Click += new System.EventHandler(this.buttonRefreshData_Click);
            // 
            // panelActiveDeliveries
            // 
            this.panelActiveDeliveries.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelActiveDeliveries.Controls.Add(this.groupBoxFilterControls);
            this.panelActiveDeliveries.Controls.Add(this.buttonReseedData);
            this.panelActiveDeliveries.Controls.Add(this.dataGridViewCurrentDeliveries);
            this.panelActiveDeliveries.Controls.Add(this.buttonNewDelivery);
            this.panelActiveDeliveries.Controls.Add(this.buttonRefreshData);
            this.panelActiveDeliveries.Controls.Add(this.labelUpcomingDeliveries);
            this.panelActiveDeliveries.Location = new System.Drawing.Point(0, -7);
            this.panelActiveDeliveries.Name = "panelActiveDeliveries";
            this.panelActiveDeliveries.Size = new System.Drawing.Size(1614, 1291);
            this.panelActiveDeliveries.TabIndex = 4;
            // 
            // labelUpcomingDeliveries
            // 
            this.labelUpcomingDeliveries.AutoSize = true;
            this.labelUpcomingDeliveries.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpcomingDeliveries.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelUpcomingDeliveries.Location = new System.Drawing.Point(14, 51);
            this.labelUpcomingDeliveries.Name = "labelUpcomingDeliveries";
            this.labelUpcomingDeliveries.Size = new System.Drawing.Size(290, 40);
            this.labelUpcomingDeliveries.TabIndex = 4;
            this.labelUpcomingDeliveries.Text = "Upcoming Deliveries";
            // 
            // panelTopNavigation
            // 
            this.panelTopNavigation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelTopNavigation.Controls.Add(this.buttonDrivers);
            this.panelTopNavigation.Controls.Add(this.buttonTrucks);
            this.panelTopNavigation.Controls.Add(this.buttonPastDeliveries);
            this.panelTopNavigation.Controls.Add(this.buttonDashboard);
            this.panelTopNavigation.Controls.Add(this.buttonCloseForm);
            this.panelTopNavigation.Controls.Add(this.pictureBoxLogo);
            this.panelTopNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelTopNavigation.Name = "panelTopNavigation";
            this.panelTopNavigation.Size = new System.Drawing.Size(1614, 73);
            this.panelTopNavigation.TabIndex = 5;
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
            // panelPastDeliveries
            // 
            this.panelPastDeliveries.Controls.Add(this.buttonExportData);
            this.panelPastDeliveries.Controls.Add(this.groupBoxFilterControlsPast);
            this.panelPastDeliveries.Controls.Add(this.labelPastDeliveries);
            this.panelPastDeliveries.Controls.Add(this.dataGridViewPastDeliveries);
            this.panelPastDeliveries.Location = new System.Drawing.Point(0, 0);
            this.panelPastDeliveries.Name = "panelPastDeliveries";
            this.panelPastDeliveries.Size = new System.Drawing.Size(1614, 1206);
            this.panelPastDeliveries.TabIndex = 5;
            // 
            // panelBottomLayer
            // 
            this.panelBottomLayer.Controls.Add(this.panelPastDeliveries);
            this.panelBottomLayer.Controls.Add(this.panelActiveDeliveries);
            this.panelBottomLayer.Controls.Add(this.panelDriver);
            this.panelBottomLayer.Controls.Add(this.panelTrucks);
            this.panelBottomLayer.Location = new System.Drawing.Point(0, 74);
            this.panelBottomLayer.Name = "panelBottomLayer";
            this.panelBottomLayer.Size = new System.Drawing.Size(1613, 1209);
            this.panelBottomLayer.TabIndex = 6;
            // 
            // dataGridViewPastDeliveries
            // 
            this.dataGridViewPastDeliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPastDeliveries.Location = new System.Drawing.Point(22, 85);
            this.dataGridViewPastDeliveries.Name = "dataGridViewPastDeliveries";
            this.dataGridViewPastDeliveries.RowTemplate.Height = 33;
            this.dataGridViewPastDeliveries.Size = new System.Drawing.Size(1548, 613);
            this.dataGridViewPastDeliveries.TabIndex = 0;
            // 
            // labelPastDeliveries
            // 
            this.labelPastDeliveries.AutoSize = true;
            this.labelPastDeliveries.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPastDeliveries.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPastDeliveries.Location = new System.Drawing.Point(16, 28);
            this.labelPastDeliveries.Name = "labelPastDeliveries";
            this.labelPastDeliveries.Size = new System.Drawing.Size(208, 40);
            this.labelPastDeliveries.TabIndex = 5;
            this.labelPastDeliveries.Text = "Past Deliveries";
            // 
            // panelTrucks
            // 
            this.panelTrucks.Controls.Add(this.dataGridViewTruckInformation);
            this.panelTrucks.Controls.Add(this.labelTruckInformation);
            this.panelTrucks.Location = new System.Drawing.Point(0, 0);
            this.panelTrucks.Name = "panelTrucks";
            this.panelTrucks.Size = new System.Drawing.Size(1613, 1208);
            this.panelTrucks.TabIndex = 6;
            // 
            // dataGridViewTruckInformation
            // 
            this.dataGridViewTruckInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTruckInformation.Location = new System.Drawing.Point(37, 116);
            this.dataGridViewTruckInformation.Name = "dataGridViewTruckInformation";
            this.dataGridViewTruckInformation.RowTemplate.Height = 33;
            this.dataGridViewTruckInformation.Size = new System.Drawing.Size(1532, 618);
            this.dataGridViewTruckInformation.TabIndex = 0;
            // 
            // labelTruckInformation
            // 
            this.labelTruckInformation.AutoSize = true;
            this.labelTruckInformation.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTruckInformation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTruckInformation.Location = new System.Drawing.Point(30, 42);
            this.labelTruckInformation.Name = "labelTruckInformation";
            this.labelTruckInformation.Size = new System.Drawing.Size(252, 40);
            this.labelTruckInformation.TabIndex = 6;
            this.labelTruckInformation.Text = "Truck Information";
            // 
            // panelDriver
            // 
            this.panelDriver.Controls.Add(this.labelDriverInfo);
            this.panelDriver.Controls.Add(this.dataGridViewDriverInformation);
            this.panelDriver.Location = new System.Drawing.Point(0, 0);
            this.panelDriver.Name = "panelDriver";
            this.panelDriver.Size = new System.Drawing.Size(1613, 1208);
            this.panelDriver.TabIndex = 7;
            // 
            // dataGridViewDriverInformation
            // 
            this.dataGridViewDriverInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDriverInformation.Location = new System.Drawing.Point(257, 215);
            this.dataGridViewDriverInformation.Name = "dataGridViewDriverInformation";
            this.dataGridViewDriverInformation.RowTemplate.Height = 33;
            this.dataGridViewDriverInformation.Size = new System.Drawing.Size(1075, 819);
            this.dataGridViewDriverInformation.TabIndex = 0;
            // 
            // labelDriverInfo
            // 
            this.labelDriverInfo.AutoSize = true;
            this.labelDriverInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDriverInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelDriverInfo.Location = new System.Drawing.Point(30, 93);
            this.labelDriverInfo.Name = "labelDriverInfo";
            this.labelDriverInfo.Size = new System.Drawing.Size(262, 40);
            this.labelDriverInfo.TabIndex = 7;
            this.labelDriverInfo.Text = "Driver Information";
            // 
            // groupBoxFilterControls
            // 
            this.groupBoxFilterControls.Controls.Add(this.buttonClearFilters);
            this.groupBoxFilterControls.Controls.Add(this.labelSearchCustomerAddress);
            this.groupBoxFilterControls.Controls.Add(this.labelSearchCustomerName);
            this.groupBoxFilterControls.Controls.Add(this.textBoxCustomerAddress);
            this.groupBoxFilterControls.Controls.Add(this.textBoxCustomerName);
            this.groupBoxFilterControls.Location = new System.Drawing.Point(25, 785);
            this.groupBoxFilterControls.Name = "groupBoxFilterControls";
            this.groupBoxFilterControls.Size = new System.Drawing.Size(1156, 402);
            this.groupBoxFilterControls.TabIndex = 5;
            this.groupBoxFilterControls.TabStop = false;
            this.groupBoxFilterControls.Text = "Filter Data";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(432, 92);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(272, 31);
            this.textBoxCustomerName.TabIndex = 0;
            // 
            // textBoxCustomerAddress
            // 
            this.textBoxCustomerAddress.Location = new System.Drawing.Point(432, 159);
            this.textBoxCustomerAddress.Name = "textBoxCustomerAddress";
            this.textBoxCustomerAddress.Size = new System.Drawing.Size(272, 31);
            this.textBoxCustomerAddress.TabIndex = 1;
            // 
            // labelSearchCustomerName
            // 
            this.labelSearchCustomerName.AutoSize = true;
            this.labelSearchCustomerName.Location = new System.Drawing.Point(89, 92);
            this.labelSearchCustomerName.Name = "labelSearchCustomerName";
            this.labelSearchCustomerName.Size = new System.Drawing.Size(275, 25);
            this.labelSearchCustomerName.TabIndex = 2;
            this.labelSearchCustomerName.Text = "Search by Customer Name:";
            // 
            // labelSearchCustomerAddress
            // 
            this.labelSearchCustomerAddress.AutoSize = true;
            this.labelSearchCustomerAddress.Location = new System.Drawing.Point(89, 162);
            this.labelSearchCustomerAddress.Name = "labelSearchCustomerAddress";
            this.labelSearchCustomerAddress.Size = new System.Drawing.Size(298, 25);
            this.labelSearchCustomerAddress.TabIndex = 3;
            this.labelSearchCustomerAddress.Text = "Search by Customer Address:";
            // 
            // buttonClearFilters
            // 
            this.buttonClearFilters.Location = new System.Drawing.Point(432, 244);
            this.buttonClearFilters.Name = "buttonClearFilters";
            this.buttonClearFilters.Size = new System.Drawing.Size(140, 47);
            this.buttonClearFilters.TabIndex = 4;
            this.buttonClearFilters.Text = "Clear";
            this.buttonClearFilters.UseVisualStyleBackColor = true;
            this.buttonClearFilters.Click += new System.EventHandler(this.buttonClearFilters_Click);
            // 
            // groupBoxFilterControlsPast
            // 
            this.groupBoxFilterControlsPast.Controls.Add(this.buttonClearFiltersPast);
            this.groupBoxFilterControlsPast.Controls.Add(this.labelSearchCustomerAddressPast);
            this.groupBoxFilterControlsPast.Controls.Add(this.labelSearchCutomerNamePast);
            this.groupBoxFilterControlsPast.Controls.Add(this.textBoxCustomerAddressPast);
            this.groupBoxFilterControlsPast.Controls.Add(this.textBoxCustomerNamePast);
            this.groupBoxFilterControlsPast.Location = new System.Drawing.Point(23, 761);
            this.groupBoxFilterControlsPast.Name = "groupBoxFilterControlsPast";
            this.groupBoxFilterControlsPast.Size = new System.Drawing.Size(1156, 402);
            this.groupBoxFilterControlsPast.TabIndex = 6;
            this.groupBoxFilterControlsPast.TabStop = false;
            this.groupBoxFilterControlsPast.Text = "Filter Data";
            // 
            // buttonClearFiltersPast
            // 
            this.buttonClearFiltersPast.Location = new System.Drawing.Point(432, 244);
            this.buttonClearFiltersPast.Name = "buttonClearFiltersPast";
            this.buttonClearFiltersPast.Size = new System.Drawing.Size(140, 47);
            this.buttonClearFiltersPast.TabIndex = 4;
            this.buttonClearFiltersPast.Text = "Clear";
            this.buttonClearFiltersPast.UseVisualStyleBackColor = true;
            this.buttonClearFiltersPast.Click += new System.EventHandler(this.buttonClearFiltersPast_Click);
            // 
            // labelSearchCustomerAddressPast
            // 
            this.labelSearchCustomerAddressPast.AutoSize = true;
            this.labelSearchCustomerAddressPast.Location = new System.Drawing.Point(89, 162);
            this.labelSearchCustomerAddressPast.Name = "labelSearchCustomerAddressPast";
            this.labelSearchCustomerAddressPast.Size = new System.Drawing.Size(298, 25);
            this.labelSearchCustomerAddressPast.TabIndex = 3;
            this.labelSearchCustomerAddressPast.Text = "Search by Customer Address:";
            // 
            // labelSearchCutomerNamePast
            // 
            this.labelSearchCutomerNamePast.AutoSize = true;
            this.labelSearchCutomerNamePast.Location = new System.Drawing.Point(89, 92);
            this.labelSearchCutomerNamePast.Name = "labelSearchCutomerNamePast";
            this.labelSearchCutomerNamePast.Size = new System.Drawing.Size(275, 25);
            this.labelSearchCutomerNamePast.TabIndex = 2;
            this.labelSearchCutomerNamePast.Text = "Search by Customer Name:";
            // 
            // textBoxCustomerAddressPast
            // 
            this.textBoxCustomerAddressPast.Location = new System.Drawing.Point(432, 159);
            this.textBoxCustomerAddressPast.Name = "textBoxCustomerAddressPast";
            this.textBoxCustomerAddressPast.Size = new System.Drawing.Size(272, 31);
            this.textBoxCustomerAddressPast.TabIndex = 1;
            // 
            // textBoxCustomerNamePast
            // 
            this.textBoxCustomerNamePast.Location = new System.Drawing.Point(432, 92);
            this.textBoxCustomerNamePast.Name = "textBoxCustomerNamePast";
            this.textBoxCustomerNamePast.Size = new System.Drawing.Size(272, 31);
            this.textBoxCustomerNamePast.TabIndex = 0;
            // 
            // buttonExportData
            // 
            this.buttonExportData.Location = new System.Drawing.Point(1357, 1101);
            this.buttonExportData.Name = "buttonExportData";
            this.buttonExportData.Size = new System.Drawing.Size(212, 62);
            this.buttonExportData.TabIndex = 7;
            this.buttonExportData.Text = "Export All Data";
            this.buttonExportData.UseVisualStyleBackColor = true;
            this.buttonExportData.Click += new System.EventHandler(this.buttonExportData_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 1284);
            this.Controls.Add(this.panelBottomLayer);
            this.Controls.Add(this.panelTopNavigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrentDeliveries)).EndInit();
            this.panelActiveDeliveries.ResumeLayout(false);
            this.panelActiveDeliveries.PerformLayout();
            this.panelTopNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelPastDeliveries.ResumeLayout(false);
            this.panelPastDeliveries.PerformLayout();
            this.panelBottomLayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPastDeliveries)).EndInit();
            this.panelTrucks.ResumeLayout(false);
            this.panelTrucks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTruckInformation)).EndInit();
            this.panelDriver.ResumeLayout(false);
            this.panelDriver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDriverInformation)).EndInit();
            this.groupBoxFilterControls.ResumeLayout(false);
            this.groupBoxFilterControls.PerformLayout();
            this.groupBoxFilterControlsPast.ResumeLayout(false);
            this.groupBoxFilterControlsPast.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReseedData;
        private System.Windows.Forms.DataGridView dataGridViewCurrentDeliveries;
        private System.Windows.Forms.Button buttonNewDelivery;
        private System.Windows.Forms.Button buttonRefreshData;
        private System.Windows.Forms.Panel panelActiveDeliveries;
        private System.Windows.Forms.Panel panelTopNavigation;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Button buttonDrivers;
        private System.Windows.Forms.Button buttonTrucks;
        private System.Windows.Forms.Button buttonPastDeliveries;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Label labelUpcomingDeliveries;
        private System.Windows.Forms.Panel panelPastDeliveries;
        private System.Windows.Forms.Panel panelBottomLayer;
        private System.Windows.Forms.Label labelPastDeliveries;
        private System.Windows.Forms.DataGridView dataGridViewPastDeliveries;
        private System.Windows.Forms.Panel panelTrucks;
        private System.Windows.Forms.DataGridView dataGridViewTruckInformation;
        private System.Windows.Forms.Label labelTruckInformation;
        private System.Windows.Forms.Panel panelDriver;
        private System.Windows.Forms.Label labelDriverInfo;
        private System.Windows.Forms.DataGridView dataGridViewDriverInformation;
        private System.Windows.Forms.GroupBox groupBoxFilterControls;
        private System.Windows.Forms.Label labelSearchCustomerAddress;
        private System.Windows.Forms.Label labelSearchCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerAddress;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Button buttonClearFilters;
        private System.Windows.Forms.GroupBox groupBoxFilterControlsPast;
        private System.Windows.Forms.Button buttonClearFiltersPast;
        private System.Windows.Forms.Label labelSearchCustomerAddressPast;
        private System.Windows.Forms.Label labelSearchCutomerNamePast;
        private System.Windows.Forms.TextBox textBoxCustomerAddressPast;
        private System.Windows.Forms.TextBox textBoxCustomerNamePast;
        private System.Windows.Forms.Button buttonExportData;
    }
}

