namespace Course_Work_aplication
{
    partial class ChangeDataStaff
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
            System.Windows.Forms.Label должностьLabel;
            System.Windows.Forms.Label филиалLabel;
            System.Windows.Forms.Label зарплатаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeDataStaff));
            this.dataSet1 = new Course_Work_aplication.DataSet1();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new Course_Work_aplication.DataSet1TableAdapters.StaffTableAdapter();
            this.tableAdapterManager = new Course_Work_aplication.DataSet1TableAdapters.TableAdapterManager();
            this.staffDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIDTextBox = new System.Windows.Forms.TextBox();
            this.staff_surnameTextBox = new System.Windows.Forms.TextBox();
            this.staff_initialsTextBox = new System.Windows.Forms.TextBox();
            this.staff_genderTextBox = new System.Windows.Forms.TextBox();
            this.postIDComboBox = new System.Windows.Forms.ComboBox();
            this.branchIDComboBox = new System.Windows.Forms.ComboBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citiesIDComboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            iDLabel = new System.Windows.Forms.Label();
            фамилииLabel = new System.Windows.Forms.Label();
            инициалыLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            городLabel = new System.Windows.Forms.Label();
            должностьLabel = new System.Windows.Forms.Label();
            филиалLabel = new System.Windows.Forms.Label();
            зарплатаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            iDLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            iDLabel.Location = new System.Drawing.Point(62, 603);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(35, 25);
            iDLabel.TabIndex = 33;
            iDLabel.Text = "ID:";
            // 
            // фамилииLabel
            // 
            фамилииLabel.AutoSize = true;
            фамилииLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            фамилииLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            фамилииLabel.Location = new System.Drawing.Point(62, 642);
            фамилииLabel.Name = "фамилииLabel";
            фамилииLabel.Size = new System.Drawing.Size(91, 25);
            фамилииLabel.TabIndex = 34;
            фамилииLabel.Text = "Фамилии:";
            // 
            // инициалыLabel
            // 
            инициалыLabel.AutoSize = true;
            инициалыLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            инициалыLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            инициалыLabel.Location = new System.Drawing.Point(62, 685);
            инициалыLabel.Name = "инициалыLabel";
            инициалыLabel.Size = new System.Drawing.Size(102, 25);
            инициалыLabel.TabIndex = 35;
            инициалыLabel.Text = "Инициалы:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            полLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            полLabel.Location = new System.Drawing.Point(62, 726);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(49, 25);
            полLabel.TabIndex = 36;
            полLabel.Text = "Пол:";
            // 
            // городLabel
            // 
            городLabel.AutoSize = true;
            городLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            городLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            городLabel.Location = new System.Drawing.Point(62, 768);
            городLabel.Name = "городLabel";
            городLabel.Size = new System.Drawing.Size(64, 25);
            городLabel.TabIndex = 37;
            городLabel.Text = "Город:";
            // 
            // должностьLabel
            // 
            должностьLabel.AutoSize = true;
            должностьLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            должностьLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            должностьLabel.Location = new System.Drawing.Point(62, 808);
            должностьLabel.Name = "должностьLabel";
            должностьLabel.Size = new System.Drawing.Size(107, 25);
            должностьLabel.TabIndex = 38;
            должностьLabel.Text = "Должность:";
            // 
            // филиалLabel
            // 
            филиалLabel.AutoSize = true;
            филиалLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            филиалLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            филиалLabel.Location = new System.Drawing.Point(62, 847);
            филиалLabel.Name = "филиалLabel";
            филиалLabel.Size = new System.Drawing.Size(79, 25);
            филиалLabel.TabIndex = 39;
            филиалLabel.Text = "Филиал:";
            // 
            // зарплатаLabel
            // 
            зарплатаLabel.AutoSize = true;
            зарплатаLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            зарплатаLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            зарплатаLabel.Location = new System.Drawing.Point(62, 890);
            зарплатаLabel.Name = "зарплатаLabel";
            зарплатаLabel.Size = new System.Drawing.Size(93, 25);
            зарплатаLabel.TabIndex = 40;
            зарплатаLabel.Text = "Зарплата:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.dataSet1;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ALL_DATA_BASE_TABLETableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BranchTableAdapter = null;
            this.tableAdapterManager.CitiesTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.Order_clientTableAdapter = null;
            this.tableAdapterManager.PostTableAdapter = null;
            this.tableAdapterManager.Service_typeTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.Type_of_customerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Course_Work_aplication.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // staffDataGridView
            // 
            this.staffDataGridView.AutoGenerateColumns = false;
            this.staffDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.staffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.staffDataGridView.DataSource = this.staffBindingSource;
            this.staffDataGridView.Location = new System.Drawing.Point(30, 59);
            this.staffDataGridView.Name = "staffDataGridView";
            this.staffDataGridView.RowHeadersWidth = 51;
            this.staffDataGridView.RowTemplate.Height = 24;
            this.staffDataGridView.Size = new System.Drawing.Size(903, 526);
            this.staffDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StaffID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 49;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Staff_surname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 95;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Staff_initials";
            this.dataGridViewTextBoxColumn3.HeaderText = "Инициалы";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 103;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Staff_gender";
            this.dataGridViewTextBoxColumn4.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 62;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CitiesID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Город";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PostID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 107;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BranchID";
            this.dataGridViewTextBoxColumn7.HeaderText = "Филиал";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 87;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Salary";
            this.dataGridViewTextBoxColumn8.HeaderText = "Зарплата";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // staffIDTextBox
            // 
            this.staffIDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.staffIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "StaffID", true));
            this.staffIDTextBox.Location = new System.Drawing.Point(182, 602);
            this.staffIDTextBox.Name = "staffIDTextBox";
            this.staffIDTextBox.Size = new System.Drawing.Size(121, 22);
            this.staffIDTextBox.TabIndex = 3;
            // 
            // staff_surnameTextBox
            // 
            this.staff_surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Staff_surname", true));
            this.staff_surnameTextBox.Location = new System.Drawing.Point(182, 645);
            this.staff_surnameTextBox.Name = "staff_surnameTextBox";
            this.staff_surnameTextBox.Size = new System.Drawing.Size(121, 22);
            this.staff_surnameTextBox.TabIndex = 5;
            // 
            // staff_initialsTextBox
            // 
            this.staff_initialsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Staff_initials", true));
            this.staff_initialsTextBox.Location = new System.Drawing.Point(182, 688);
            this.staff_initialsTextBox.Name = "staff_initialsTextBox";
            this.staff_initialsTextBox.Size = new System.Drawing.Size(121, 22);
            this.staff_initialsTextBox.TabIndex = 7;
            // 
            // staff_genderTextBox
            // 
            this.staff_genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Staff_gender", true));
            this.staff_genderTextBox.Location = new System.Drawing.Point(182, 729);
            this.staff_genderTextBox.Name = "staff_genderTextBox";
            this.staff_genderTextBox.Size = new System.Drawing.Size(121, 22);
            this.staff_genderTextBox.TabIndex = 9;
            // 
            // postIDComboBox
            // 
            this.postIDComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.postIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "PostID", true));
            this.postIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.postIDComboBox.FormattingEnabled = true;
            this.postIDComboBox.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.postIDComboBox.Location = new System.Drawing.Point(182, 809);
            this.postIDComboBox.Name = "postIDComboBox";
            this.postIDComboBox.Size = new System.Drawing.Size(121, 24);
            this.postIDComboBox.TabIndex = 13;
            this.postIDComboBox.SelectedIndexChanged += new System.EventHandler(this.postIDComboBox_SelectedIndexChanged);
            // 
            // branchIDComboBox
            // 
            this.branchIDComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.branchIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "BranchID", true));
            this.branchIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchIDComboBox.FormattingEnabled = true;
            this.branchIDComboBox.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.branchIDComboBox.Location = new System.Drawing.Point(182, 848);
            this.branchIDComboBox.Name = "branchIDComboBox";
            this.branchIDComboBox.Size = new System.Drawing.Size(121, 24);
            this.branchIDComboBox.TabIndex = 15;
            this.branchIDComboBox.SelectedIndexChanged += new System.EventHandler(this.branchIDComboBox_SelectedIndexChanged);
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Salary", true));
            this.salaryTextBox.Location = new System.Drawing.Point(182, 893);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(121, 22);
            this.salaryTextBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 9F);
            this.button1.Location = new System.Drawing.Point(672, 642);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 64);
            this.button1.TabIndex = 18;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(309, 771);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Font = new System.Drawing.Font("Sitka Small", 9F);
            this.button2.Location = new System.Drawing.Point(672, 808);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 64);
            this.button2.TabIndex = 32;
            this.button2.Text = "Удалить данные";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(309, 813);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(309, 850);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(962, 28);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // citiesIDComboBox1
            // 
            this.citiesIDComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.citiesIDComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "CitiesID", true));
            this.citiesIDComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.citiesIDComboBox1.FormattingEnabled = true;
            this.citiesIDComboBox1.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.citiesIDComboBox1.Location = new System.Drawing.Point(182, 769);
            this.citiesIDComboBox1.Name = "citiesIDComboBox1";
            this.citiesIDComboBox1.Size = new System.Drawing.Size(121, 24);
            this.citiesIDComboBox1.TabIndex = 44;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightBlue;
            this.button3.Font = new System.Drawing.Font("Sitka Small", 9F);
            this.button3.Location = new System.Drawing.Point(439, 642);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 64);
            this.button3.TabIndex = 45;
            this.button3.Text = "Поиск";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // ChangeDataStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 935);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.citiesIDComboBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(iDLabel);
            this.Controls.Add(фамилииLabel);
            this.Controls.Add(инициалыLabel);
            this.Controls.Add(полLabel);
            this.Controls.Add(городLabel);
            this.Controls.Add(должностьLabel);
            this.Controls.Add(филиалLabel);
            this.Controls.Add(зарплатаLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.staffIDTextBox);
            this.Controls.Add(this.staff_surnameTextBox);
            this.Controls.Add(this.staff_initialsTextBox);
            this.Controls.Add(this.staff_genderTextBox);
            this.Controls.Add(this.postIDComboBox);
            this.Controls.Add(this.branchIDComboBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.staffDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChangeDataStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JK-Fast&Clean - Сотрудники";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangeDataStaff_FormClosing);
            this.Load += new System.EventHandler(this.ChangeDataStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private DataSet1TableAdapters.StaffTableAdapter staffTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        public System.Windows.Forms.DataGridView staffDataGridView;
        private System.Windows.Forms.TextBox staffIDTextBox;
        private System.Windows.Forms.TextBox staff_surnameTextBox;
        private System.Windows.Forms.TextBox staff_initialsTextBox;
        private System.Windows.Forms.TextBox staff_genderTextBox;
        private System.Windows.Forms.ComboBox postIDComboBox;
        private System.Windows.Forms.ComboBox branchIDComboBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.ComboBox citiesIDComboBox1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}