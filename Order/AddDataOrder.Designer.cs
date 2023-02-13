namespace Course_Work_aplication.Order
{
    partial class AddDataOrder
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label фамилииLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label городLabel;
            System.Windows.Forms.Label type_of_customerIDLabel;
            System.Windows.Forms.Label client_phone_numberLabel;
            System.Windows.Forms.Label инициалыLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDataOrder));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSet1 = new Course_Work_aplication.DataSet1();
            this.order_clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_clientTableAdapter = new Course_Work_aplication.DataSet1TableAdapters.Order_clientTableAdapter();
            this.tableAdapterManager = new Course_Work_aplication.DataSet1TableAdapters.TableAdapterManager();
            this.branchTableAdapter = new Course_Work_aplication.DataSet1TableAdapters.BranchTableAdapter();
            this.clientTableAdapter = new Course_Work_aplication.DataSet1TableAdapters.ClientTableAdapter();
            this.service_typeTableAdapter = new Course_Work_aplication.DataSet1TableAdapters.Service_typeTableAdapter();
            this.staffTableAdapter = new Course_Work_aplication.DataSet1TableAdapters.StaffTableAdapter();
            this.order_clientIDTextBox = new System.Windows.Forms.TextBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.address_clientTextBox = new System.Windows.Forms.TextBox();
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.date_of_workDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.servicetypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informationonlyCleanerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.information_only_CleanerTableAdapter = new Course_Work_aplication.DataSet1TableAdapters.Information_only_CleanerTableAdapter();
            this.dataSet11 = new Course_Work_aplication.DataSet1();
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKOrdercliClien619B8048BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.branchIDListBox = new System.Windows.Forms.ListBox();
            this.staffIDListBox = new System.Windows.Forms.ListBox();
            this.service_typeIDListBox = new System.Windows.Forms.ListBox();
            this.clientIDComboBox = new System.Windows.Forms.ComboBox();
            this.clientIDListBox = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.staffIDComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            iDLabel = new System.Windows.Forms.Label();
            фамилииLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            городLabel = new System.Windows.Forms.Label();
            type_of_customerIDLabel = new System.Windows.Forms.Label();
            client_phone_numberLabel = new System.Windows.Forms.Label();
            инициалыLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicetypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationonlyCleanerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrdercliClien619B8048BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            iDLabel.AutoSize = true;
            iDLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            iDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            iDLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            iDLabel.Location = new System.Drawing.Point(77, 68);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(35, 25);
            iDLabel.TabIndex = 45;
            iDLabel.Text = "ID:";
            // 
            // фамилииLabel
            // 
            фамилииLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            фамилииLabel.AutoSize = true;
            фамилииLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            фамилииLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            фамилииLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            фамилииLabel.Location = new System.Drawing.Point(77, 116);
            фамилииLabel.Name = "фамилииLabel";
            фамилииLabel.Size = new System.Drawing.Size(171, 25);
            фамилииLabel.TabIndex = 46;
            фамилииLabel.Text = "Фамилии клиентов:";
            // 
            // полLabel
            // 
            полLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            полLabel.AutoSize = true;
            полLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            полLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            полLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            полLabel.Location = new System.Drawing.Point(77, 231);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(184, 25);
            полLabel.TabIndex = 48;
            полLabel.Text = "Филиал выполнения:";
            // 
            // городLabel
            // 
            городLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            городLabel.AutoSize = true;
            городLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            городLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            городLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            городLabel.Location = new System.Drawing.Point(77, 305);
            городLabel.Name = "городLabel";
            городLabel.Size = new System.Drawing.Size(186, 25);
            городLabel.TabIndex = 49;
            городLabel.Text = "Выполняющий заказ:";
            // 
            // type_of_customerIDLabel
            // 
            type_of_customerIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            type_of_customerIDLabel.AutoSize = true;
            type_of_customerIDLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            type_of_customerIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            type_of_customerIDLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            type_of_customerIDLabel.Location = new System.Drawing.Point(77, 383);
            type_of_customerIDLabel.Name = "type_of_customerIDLabel";
            type_of_customerIDLabel.Size = new System.Drawing.Size(162, 25);
            type_of_customerIDLabel.TabIndex = 50;
            type_of_customerIDLabel.Text = "Дата выполнения:";
            // 
            // client_phone_numberLabel
            // 
            client_phone_numberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            client_phone_numberLabel.AutoSize = true;
            client_phone_numberLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            client_phone_numberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            client_phone_numberLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            client_phone_numberLabel.Location = new System.Drawing.Point(77, 448);
            client_phone_numberLabel.Name = "client_phone_numberLabel";
            client_phone_numberLabel.Size = new System.Drawing.Size(126, 25);
            client_phone_numberLabel.TabIndex = 51;
            client_phone_numberLabel.Text = "Пакет уборки:";
            // 
            // инициалыLabel
            // 
            инициалыLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            инициалыLabel.AutoSize = true;
            инициалыLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            инициалыLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            инициалыLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            инициалыLabel.Location = new System.Drawing.Point(77, 185);
            инициалыLabel.Name = "инициалыLabel";
            инициалыLabel.Size = new System.Drawing.Size(64, 25);
            инициалыLabel.TabIndex = 47;
            инициалыLabel.Text = "Адрес:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 9F);
            this.button1.Location = new System.Drawing.Point(209, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(541, 72);
            this.button1.TabIndex = 44;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(916, 28);
            this.menuStrip1.TabIndex = 52;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order_clientBindingSource
            // 
            this.order_clientBindingSource.DataMember = "Order_client";
            this.order_clientBindingSource.DataSource = this.dataSet1;
            // 
            // order_clientTableAdapter
            // 
            this.order_clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ALL_DATA_BASE_TABLETableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BranchTableAdapter = this.branchTableAdapter;
            this.tableAdapterManager.CitiesTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.Order_clientTableAdapter = this.order_clientTableAdapter;
            this.tableAdapterManager.PostTableAdapter = null;
            this.tableAdapterManager.Service_typeTableAdapter = this.service_typeTableAdapter;
            this.tableAdapterManager.StaffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.Type_of_customerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Course_Work_aplication.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // branchTableAdapter
            // 
            this.branchTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // service_typeTableAdapter
            // 
            this.service_typeTableAdapter.ClearBeforeFill = true;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // order_clientIDTextBox
            // 
            this.order_clientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_clientBindingSource, "Order_clientID", true));
            this.order_clientIDTextBox.Location = new System.Drawing.Point(309, 68);
            this.order_clientIDTextBox.Name = "order_clientIDTextBox";
            this.order_clientIDTextBox.ReadOnly = true;
            this.order_clientIDTextBox.Size = new System.Drawing.Size(373, 22);
            this.order_clientIDTextBox.TabIndex = 57;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.dataSet1;
            // 
            // address_clientTextBox
            // 
            this.address_clientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_clientBindingSource, "Address_client", true));
            this.address_clientTextBox.Location = new System.Drawing.Point(309, 185);
            this.address_clientTextBox.Name = "address_clientTextBox";
            this.address_clientTextBox.Size = new System.Drawing.Size(373, 22);
            this.address_clientTextBox.TabIndex = 61;
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataMember = "Branch";
            this.branchBindingSource.DataSource = this.dataSet1;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.dataSet1;
            // 
            // date_of_workDateTimePicker
            // 
            this.date_of_workDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.order_clientBindingSource, "Date_of_work", true));
            this.date_of_workDateTimePicker.Location = new System.Drawing.Point(309, 383);
            this.date_of_workDateTimePicker.Name = "date_of_workDateTimePicker";
            this.date_of_workDateTimePicker.Size = new System.Drawing.Size(373, 22);
            this.date_of_workDateTimePicker.TabIndex = 67;
            // 
            // servicetypeBindingSource
            // 
            this.servicetypeBindingSource.DataMember = "Service_type";
            this.servicetypeBindingSource.DataSource = this.dataSet1;
            // 
            // informationonlyCleanerBindingSource
            // 
            this.informationonlyCleanerBindingSource.DataMember = "Information_only_Cleaner";
            this.informationonlyCleanerBindingSource.DataSource = this.dataSet1;
            // 
            // information_only_CleanerTableAdapter
            // 
            this.information_only_CleanerTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataMember = "Client";
            this.clientBindingSource1.DataSource = this.dataSet11;
            // 
            // fKOrdercliClien619B8048BindingSource
            // 
            this.fKOrdercliClien619B8048BindingSource.DataMember = "FK__Order_cli__Clien__619B8048";
            this.fKOrdercliClien619B8048BindingSource.DataSource = this.clientBindingSource1;
            // 
            // clientBindingSource2
            // 
            this.clientBindingSource2.DataMember = "Client";
            this.clientBindingSource2.DataSource = this.dataSet11;
            // 
            // branchIDListBox
            // 
            this.branchIDListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.order_clientBindingSource, "BranchID", true));
            this.branchIDListBox.DataSource = this.branchBindingSource;
            this.branchIDListBox.DisplayMember = "Branch_name";
            this.branchIDListBox.FormattingEnabled = true;
            this.branchIDListBox.ItemHeight = 16;
            this.branchIDListBox.Location = new System.Drawing.Point(309, 231);
            this.branchIDListBox.Name = "branchIDListBox";
            this.branchIDListBox.Size = new System.Drawing.Size(373, 52);
            this.branchIDListBox.TabIndex = 71;
            this.branchIDListBox.ValueMember = "BranchID";
            // 
            // staffIDListBox
            // 
            this.staffIDListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.order_clientBindingSource, "StaffID", true));
            this.staffIDListBox.DataSource = this.staffBindingSource;
            this.staffIDListBox.DisplayMember = "Staff_surname";
            this.staffIDListBox.FormattingEnabled = true;
            this.staffIDListBox.ItemHeight = 16;
            this.staffIDListBox.Location = new System.Drawing.Point(309, 305);
            this.staffIDListBox.Name = "staffIDListBox";
            this.staffIDListBox.Size = new System.Drawing.Size(373, 68);
            this.staffIDListBox.TabIndex = 72;
            this.staffIDListBox.ValueMember = "StaffID";
            // 
            // service_typeIDListBox
            // 
            this.service_typeIDListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.order_clientBindingSource, "Service_typeID", true));
            this.service_typeIDListBox.DataSource = this.servicetypeBindingSource;
            this.service_typeIDListBox.DisplayMember = "Service_type_name";
            this.service_typeIDListBox.FormattingEnabled = true;
            this.service_typeIDListBox.ItemHeight = 16;
            this.service_typeIDListBox.Location = new System.Drawing.Point(309, 448);
            this.service_typeIDListBox.Name = "service_typeIDListBox";
            this.service_typeIDListBox.Size = new System.Drawing.Size(373, 52);
            this.service_typeIDListBox.TabIndex = 73;
            this.service_typeIDListBox.ValueMember = "Service_typeID";
            // 
            // clientIDComboBox
            // 
            this.clientIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_clientBindingSource, "ClientID", true));
            this.clientIDComboBox.DataSource = this.clientBindingSource;
            this.clientIDComboBox.DisplayMember = "ClientID";
            this.clientIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientIDComboBox.FormattingEnabled = true;
            this.clientIDComboBox.Location = new System.Drawing.Point(707, 100);
            this.clientIDComboBox.Name = "clientIDComboBox";
            this.clientIDComboBox.Size = new System.Drawing.Size(83, 24);
            this.clientIDComboBox.TabIndex = 74;
            this.clientIDComboBox.ValueMember = "ClientID";
            // 
            // clientIDListBox
            // 
            this.clientIDListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.order_clientBindingSource, "ClientID", true));
            this.clientIDListBox.DataSource = this.clientBindingSource;
            this.clientIDListBox.DisplayMember = "Client_surname";
            this.clientIDListBox.FormattingEnabled = true;
            this.clientIDListBox.ItemHeight = 16;
            this.clientIDListBox.Location = new System.Drawing.Point(309, 100);
            this.clientIDListBox.Name = "clientIDListBox";
            this.clientIDListBox.Size = new System.Drawing.Size(373, 68);
            this.clientIDListBox.TabIndex = 75;
            this.clientIDListBox.ValueMember = "ClientID";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightBlue;
            this.button3.Font = new System.Drawing.Font("Sitka Small", 9F);
            this.button3.Location = new System.Drawing.Point(707, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 38);
            this.button3.TabIndex = 77;
            this.button3.Text = "Поиск";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // staffIDComboBox
            // 
            this.staffIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_clientBindingSource, "StaffID", true));
            this.staffIDComboBox.DataSource = this.staffBindingSource;
            this.staffIDComboBox.DisplayMember = "StaffID";
            this.staffIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.staffIDComboBox.FormattingEnabled = true;
            this.staffIDComboBox.Location = new System.Drawing.Point(707, 305);
            this.staffIDComboBox.Name = "staffIDComboBox";
            this.staffIDComboBox.Size = new System.Drawing.Size(83, 24);
            this.staffIDComboBox.TabIndex = 78;
            this.staffIDComboBox.ValueMember = "StaffID";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightBlue;
            this.button2.Font = new System.Drawing.Font("Sitka Small", 9F);
            this.button2.Location = new System.Drawing.Point(707, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 38);
            this.button2.TabIndex = 79;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(811, 116);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 80;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(811, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // AddDataOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(916, 644);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.staffIDComboBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.clientIDListBox);
            this.Controls.Add(this.clientIDComboBox);
            this.Controls.Add(this.service_typeIDListBox);
            this.Controls.Add(this.staffIDListBox);
            this.Controls.Add(this.branchIDListBox);
            this.Controls.Add(this.order_clientIDTextBox);
            this.Controls.Add(this.address_clientTextBox);
            this.Controls.Add(this.date_of_workDateTimePicker);
            this.Controls.Add(iDLabel);
            this.Controls.Add(фамилииLabel);
            this.Controls.Add(инициалыLabel);
            this.Controls.Add(полLabel);
            this.Controls.Add(городLabel);
            this.Controls.Add(type_of_customerIDLabel);
            this.Controls.Add(client_phone_numberLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddDataOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JK-Fast&Clean - Заказы (добавление)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddDataOrder_FormClosing);
            this.Load += new System.EventHandler(this.AddDataOrder_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicetypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationonlyCleanerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrdercliClien619B8048BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource order_clientBindingSource;
        private DataSet1TableAdapters.Order_clientTableAdapter order_clientTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox order_clientIDTextBox;
        private System.Windows.Forms.TextBox address_clientTextBox;
        private System.Windows.Forms.DateTimePicker date_of_workDateTimePicker;
        private DataSet1TableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DataSet1TableAdapters.BranchTableAdapter branchTableAdapter;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private DataSet1TableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private DataSet1TableAdapters.Service_typeTableAdapter service_typeTableAdapter;
        private System.Windows.Forms.BindingSource servicetypeBindingSource;
        private System.Windows.Forms.BindingSource informationonlyCleanerBindingSource;
        private DataSet1TableAdapters.Information_only_CleanerTableAdapter information_only_CleanerTableAdapter;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private System.Windows.Forms.BindingSource fKOrdercliClien619B8048BindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource2;
        private System.Windows.Forms.ListBox branchIDListBox;
        private System.Windows.Forms.ListBox staffIDListBox;
        private System.Windows.Forms.ListBox service_typeIDListBox;
        private System.Windows.Forms.ComboBox clientIDComboBox;
        private System.Windows.Forms.ListBox clientIDListBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox staffIDComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}