namespace Course_Work_aplication.Order
{
    partial class ChangeDataOrder
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
            System.Windows.Forms.Label инициалыLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label городLabel;
            System.Windows.Forms.Label type_of_customerIDLabel;
            System.Windows.Forms.Label client_phone_numberLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeDataOrder));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataSet1 = new Course_Work_aplication.DataSet1();
            this.order_clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_clientTableAdapter = new Course_Work_aplication.DataSet1TableAdapters.Order_clientTableAdapter();
            this.tableAdapterManager = new Course_Work_aplication.DataSet1TableAdapters.TableAdapterManager();
            this.branchTableAdapter = new Course_Work_aplication.DataSet1TableAdapters.BranchTableAdapter();
            this.clientTableAdapter = new Course_Work_aplication.DataSet1TableAdapters.ClientTableAdapter();
            this.service_typeTableAdapter = new Course_Work_aplication.DataSet1TableAdapters.Service_typeTableAdapter();
            this.staffTableAdapter = new Course_Work_aplication.DataSet1TableAdapters.StaffTableAdapter();
            this.order_clientDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_clientIDTextBox = new System.Windows.Forms.TextBox();
            this.clientIDComboBox = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.address_clientTextBox = new System.Windows.Forms.TextBox();
            this.branchIDComboBox = new System.Windows.Forms.ComboBox();
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffIDComboBox = new System.Windows.Forms.ComboBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.date_of_workDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.service_typeIDComboBox = new System.Windows.Forms.ComboBox();
            this.service_typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_surnameListBox = new System.Windows.Forms.ListBox();
            this.branch_nameListBox = new System.Windows.Forms.ListBox();
            this.staff_surnameListBox = new System.Windows.Forms.ListBox();
            this.service_type_nameListBox = new System.Windows.Forms.ListBox();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            iDLabel = new System.Windows.Forms.Label();
            фамилииLabel = new System.Windows.Forms.Label();
            инициалыLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            городLabel = new System.Windows.Forms.Label();
            type_of_customerIDLabel = new System.Windows.Forms.Label();
            client_phone_numberLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_clientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_typeBindingSource)).BeginInit();
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
            iDLabel.Location = new System.Drawing.Point(12, 570);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(35, 25);
            iDLabel.TabIndex = 76;
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
            фамилииLabel.Location = new System.Drawing.Point(12, 600);
            фамилииLabel.Name = "фамилииLabel";
            фамилииLabel.Size = new System.Drawing.Size(106, 25);
            фамилииLabel.TabIndex = 77;
            фамилииLabel.Text = "ID клиента:";
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
            инициалыLabel.Location = new System.Drawing.Point(12, 633);
            инициалыLabel.Name = "инициалыLabel";
            инициалыLabel.Size = new System.Drawing.Size(162, 25);
            инициалыLabel.TabIndex = 78;
            инициалыLabel.Text = "Фамилия клиента:";
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
            полLabel.Location = new System.Drawing.Point(12, 675);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(169, 25);
            полLabel.TabIndex = 79;
            полLabel.Text = "Адрес выполнения:";
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
            городLabel.Location = new System.Drawing.Point(12, 710);
            городLabel.Name = "городLabel";
            городLabel.Size = new System.Drawing.Size(104, 25);
            городLabel.TabIndex = 80;
            городLabel.Text = "ID филиала";
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
            type_of_customerIDLabel.Location = new System.Drawing.Point(12, 745);
            type_of_customerIDLabel.Name = "type_of_customerIDLabel";
            type_of_customerIDLabel.Size = new System.Drawing.Size(79, 25);
            type_of_customerIDLabel.TabIndex = 81;
            type_of_customerIDLabel.Text = "Филиал:";
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
            client_phone_numberLabel.Location = new System.Drawing.Point(646, 567);
            client_phone_numberLabel.Name = "client_phone_numberLabel";
            client_phone_numberLabel.Size = new System.Drawing.Size(126, 25);
            client_phone_numberLabel.TabIndex = 82;
            client_phone_numberLabel.Text = "ID сотрудника";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.Font = new System.Drawing.Font("Sitka Small", 9F);
            label1.Location = new System.Drawing.Point(646, 601);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(188, 25);
            label1.TabIndex = 122;
            label1.Text = "Фамилия сотрудника:";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label2.Font = new System.Drawing.Font("Sitka Small", 9F);
            label2.Location = new System.Drawing.Point(646, 644);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(219, 25);
            label2.TabIndex = 123;
            label2.Text = "Дата выполнения заказа:";
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label3.Font = new System.Drawing.Font("Sitka Small", 9F);
            label3.Location = new System.Drawing.Point(647, 678);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(135, 25);
            label3.TabIndex = 124;
            label3.Text = "ID пакет услуг:";
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label4.Font = new System.Drawing.Font("Sitka Small", 9F);
            label4.Location = new System.Drawing.Point(646, 712);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(115, 25);
            label4.TabIndex = 125;
            label4.Text = "Пакет услуг:";
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
            this.menuStrip1.Size = new System.Drawing.Size(1218, 28);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightBlue;
            this.button3.Font = new System.Drawing.Font("Sitka Small", 9F);
            this.button3.Location = new System.Drawing.Point(1044, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 64);
            this.button3.TabIndex = 100;
            this.button3.Text = "Поиск ячейки";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Font = new System.Drawing.Font("Sitka Small", 9F);
            this.button2.Location = new System.Drawing.Point(1044, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 64);
            this.button2.TabIndex = 99;
            this.button2.Text = "Удалить данные";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 9F);
            this.button1.Location = new System.Drawing.Point(1044, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 64);
            this.button1.TabIndex = 98;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightBlue;
            this.button4.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(434, 601);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 32);
            this.button4.TabIndex = 126;
            this.button4.Text = "Поиск";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightBlue;
            this.button5.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(1044, 563);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 29);
            this.button5.TabIndex = 127;
            this.button5.Text = "Поиск";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            // order_clientDataGridView
            // 
            this.order_clientDataGridView.AutoGenerateColumns = false;
            this.order_clientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.order_clientDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.order_clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_clientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.order_clientDataGridView.DataSource = this.order_clientBindingSource;
            this.order_clientDataGridView.Location = new System.Drawing.Point(13, 42);
            this.order_clientDataGridView.Name = "order_clientDataGridView";
            this.order_clientDataGridView.RowHeadersWidth = 51;
            this.order_clientDataGridView.RowTemplate.Height = 24;
            this.order_clientDataGridView.Size = new System.Drawing.Size(1012, 488);
            this.order_clientDataGridView.TabIndex = 133;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Order_clientID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 49;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ClientID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID Клиента";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 99;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address_client";
            this.dataGridViewTextBoxColumn3.HeaderText = "Адрес выполнения";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 146;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BranchID";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID филиала";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 102;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StaffID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID сотрудника";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 119;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Date_of_work";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата выполнения";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 138;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Service_typeID";
            this.dataGridViewTextBoxColumn7.HeaderText = "ID пакет услуг";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 119;
            // 
            // order_clientIDTextBox
            // 
            this.order_clientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_clientBindingSource, "Order_clientID", true));
            this.order_clientIDTextBox.Location = new System.Drawing.Point(213, 570);
            this.order_clientIDTextBox.Name = "order_clientIDTextBox";
            this.order_clientIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.order_clientIDTextBox.TabIndex = 134;
            // 
            // clientIDComboBox
            // 
            this.clientIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_clientBindingSource, "ClientID", true));
            this.clientIDComboBox.DataSource = this.clientBindingSource;
            this.clientIDComboBox.DisplayMember = "ClientID";
            this.clientIDComboBox.FormattingEnabled = true;
            this.clientIDComboBox.Location = new System.Drawing.Point(213, 601);
            this.clientIDComboBox.Name = "clientIDComboBox";
            this.clientIDComboBox.Size = new System.Drawing.Size(121, 24);
            this.clientIDComboBox.TabIndex = 135;
            this.clientIDComboBox.ValueMember = "ClientID";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.dataSet1;
            // 
            // address_clientTextBox
            // 
            this.address_clientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_clientBindingSource, "Address_client", true));
            this.address_clientTextBox.Location = new System.Drawing.Point(213, 675);
            this.address_clientTextBox.Name = "address_clientTextBox";
            this.address_clientTextBox.Size = new System.Drawing.Size(215, 22);
            this.address_clientTextBox.TabIndex = 136;
            // 
            // branchIDComboBox
            // 
            this.branchIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_clientBindingSource, "BranchID", true));
            this.branchIDComboBox.DataSource = this.branchBindingSource;
            this.branchIDComboBox.DisplayMember = "BranchID";
            this.branchIDComboBox.FormattingEnabled = true;
            this.branchIDComboBox.Location = new System.Drawing.Point(213, 710);
            this.branchIDComboBox.Name = "branchIDComboBox";
            this.branchIDComboBox.Size = new System.Drawing.Size(121, 24);
            this.branchIDComboBox.TabIndex = 137;
            this.branchIDComboBox.ValueMember = "BranchID";
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataMember = "Branch";
            this.branchBindingSource.DataSource = this.dataSet1;
            // 
            // staffIDComboBox
            // 
            this.staffIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_clientBindingSource, "StaffID", true));
            this.staffIDComboBox.DataSource = this.staffBindingSource;
            this.staffIDComboBox.DisplayMember = "StaffID";
            this.staffIDComboBox.FormattingEnabled = true;
            this.staffIDComboBox.Location = new System.Drawing.Point(895, 565);
            this.staffIDComboBox.Name = "staffIDComboBox";
            this.staffIDComboBox.Size = new System.Drawing.Size(121, 24);
            this.staffIDComboBox.TabIndex = 138;
            this.staffIDComboBox.ValueMember = "StaffID";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.dataSet1;
            // 
            // date_of_workDateTimePicker
            // 
            this.date_of_workDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.order_clientBindingSource, "Date_of_work", true));
            this.date_of_workDateTimePicker.Location = new System.Drawing.Point(895, 644);
            this.date_of_workDateTimePicker.Name = "date_of_workDateTimePicker";
            this.date_of_workDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.date_of_workDateTimePicker.TabIndex = 139;
            // 
            // service_typeIDComboBox
            // 
            this.service_typeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_clientBindingSource, "Service_typeID", true));
            this.service_typeIDComboBox.DataSource = this.service_typeBindingSource;
            this.service_typeIDComboBox.DisplayMember = "Service_typeID";
            this.service_typeIDComboBox.FormattingEnabled = true;
            this.service_typeIDComboBox.Location = new System.Drawing.Point(895, 674);
            this.service_typeIDComboBox.Name = "service_typeIDComboBox";
            this.service_typeIDComboBox.Size = new System.Drawing.Size(121, 24);
            this.service_typeIDComboBox.TabIndex = 140;
            this.service_typeIDComboBox.ValueMember = "Service_typeID";
            // 
            // service_typeBindingSource
            // 
            this.service_typeBindingSource.DataMember = "Service_type";
            this.service_typeBindingSource.DataSource = this.dataSet1;
            // 
            // client_surnameListBox
            // 
            this.client_surnameListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientBindingSource, "Client_surname", true));
            this.client_surnameListBox.DataSource = this.clientBindingSource;
            this.client_surnameListBox.DisplayMember = "Client_surname";
            this.client_surnameListBox.Enabled = false;
            this.client_surnameListBox.FormattingEnabled = true;
            this.client_surnameListBox.ItemHeight = 16;
            this.client_surnameListBox.Location = new System.Drawing.Point(214, 631);
            this.client_surnameListBox.Name = "client_surnameListBox";
            this.client_surnameListBox.Size = new System.Drawing.Size(214, 36);
            this.client_surnameListBox.TabIndex = 141;
            // 
            // branch_nameListBox
            // 
            this.branch_nameListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.branchBindingSource, "Branch_name", true));
            this.branch_nameListBox.DataSource = this.branchBindingSource;
            this.branch_nameListBox.DisplayMember = "Branch_name";
            this.branch_nameListBox.Enabled = false;
            this.branch_nameListBox.FormattingEnabled = true;
            this.branch_nameListBox.ItemHeight = 16;
            this.branch_nameListBox.Location = new System.Drawing.Point(213, 745);
            this.branch_nameListBox.Name = "branch_nameListBox";
            this.branch_nameListBox.Size = new System.Drawing.Size(414, 52);
            this.branch_nameListBox.TabIndex = 142;
            // 
            // staff_surnameListBox
            // 
            this.staff_surnameListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.staffBindingSource, "Staff_surname", true));
            this.staff_surnameListBox.DataSource = this.staffBindingSource;
            this.staff_surnameListBox.DisplayMember = "Staff_surname";
            this.staff_surnameListBox.Enabled = false;
            this.staff_surnameListBox.FormattingEnabled = true;
            this.staff_surnameListBox.ItemHeight = 16;
            this.staff_surnameListBox.Location = new System.Drawing.Point(895, 601);
            this.staff_surnameListBox.Name = "staff_surnameListBox";
            this.staff_surnameListBox.Size = new System.Drawing.Size(200, 36);
            this.staff_surnameListBox.TabIndex = 143;
            // 
            // service_type_nameListBox
            // 
            this.service_type_nameListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.service_typeBindingSource, "Service_type_name", true));
            this.service_type_nameListBox.DataSource = this.service_typeBindingSource;
            this.service_type_nameListBox.DisplayMember = "Service_type_name";
            this.service_type_nameListBox.Enabled = false;
            this.service_type_nameListBox.FormattingEnabled = true;
            this.service_type_nameListBox.ItemHeight = 16;
            this.service_type_nameListBox.Location = new System.Drawing.Point(895, 712);
            this.service_type_nameListBox.Name = "service_type_nameListBox";
            this.service_type_nameListBox.Size = new System.Drawing.Size(200, 36);
            this.service_type_nameListBox.TabIndex = 144;
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
            // ChangeDataOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1218, 826);
            this.Controls.Add(this.service_type_nameListBox);
            this.Controls.Add(this.staff_surnameListBox);
            this.Controls.Add(this.branch_nameListBox);
            this.Controls.Add(this.client_surnameListBox);
            this.Controls.Add(this.service_typeIDComboBox);
            this.Controls.Add(this.date_of_workDateTimePicker);
            this.Controls.Add(this.staffIDComboBox);
            this.Controls.Add(this.branchIDComboBox);
            this.Controls.Add(this.address_clientTextBox);
            this.Controls.Add(this.clientIDComboBox);
            this.Controls.Add(this.order_clientIDTextBox);
            this.Controls.Add(this.order_clientDataGridView);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(фамилииLabel);
            this.Controls.Add(инициалыLabel);
            this.Controls.Add(полLabel);
            this.Controls.Add(городLabel);
            this.Controls.Add(type_of_customerIDLabel);
            this.Controls.Add(client_phone_numberLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeDataOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JK-Fast&Clean - Заказы (редактирование)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangeDataOrder_FormClosing);
            this.Load += new System.EventHandler(this.ChangeDataOrder_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_clientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_typeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource order_clientBindingSource;
        private DataSet1TableAdapters.Order_clientTableAdapter order_clientTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView order_clientDataGridView;
        private DataSet1TableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.TextBox order_clientIDTextBox;
        private System.Windows.Forms.ComboBox clientIDComboBox;
        private System.Windows.Forms.TextBox address_clientTextBox;
        private System.Windows.Forms.ComboBox branchIDComboBox;
        private System.Windows.Forms.ComboBox staffIDComboBox;
        private System.Windows.Forms.DateTimePicker date_of_workDateTimePicker;
        private System.Windows.Forms.ComboBox service_typeIDComboBox;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DataSet1TableAdapters.BranchTableAdapter branchTableAdapter;
        private System.Windows.Forms.ListBox client_surnameListBox;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private DataSet1TableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.ListBox branch_nameListBox;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private DataSet1TableAdapters.Service_typeTableAdapter service_typeTableAdapter;
        private System.Windows.Forms.ListBox staff_surnameListBox;
        private System.Windows.Forms.BindingSource service_typeBindingSource;
        private System.Windows.Forms.ListBox service_type_nameListBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}