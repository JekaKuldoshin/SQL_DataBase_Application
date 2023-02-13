namespace Course_Work_aplication.Client
{
    partial class ChangeDataClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeDataClient));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSet1 = new Course_Work_aplication.DataSet1();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Course_Work_aplication.DataSet1TableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new Course_Work_aplication.DataSet1TableAdapters.TableAdapterManager();
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDTextBox = new System.Windows.Forms.TextBox();
            this.client_surnameTextBox = new System.Windows.Forms.TextBox();
            this.client_initialsTextBox = new System.Windows.Forms.TextBox();
            this.client_genderTextBox = new System.Windows.Forms.TextBox();
            this.citiesIDComboBox = new System.Windows.Forms.ComboBox();
            this.type_of_customerIDComboBox = new System.Windows.Forms.ComboBox();
            this.client_phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            iDLabel = new System.Windows.Forms.Label();
            фамилииLabel = new System.Windows.Forms.Label();
            инициалыLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            городLabel = new System.Windows.Forms.Label();
            type_of_customerIDLabel = new System.Windows.Forms.Label();
            client_phone_numberLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            iDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            iDLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            iDLabel.Location = new System.Drawing.Point(60, 619);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(35, 25);
            iDLabel.TabIndex = 44;
            iDLabel.Text = "ID:";
            // 
            // фамилииLabel
            // 
            фамилииLabel.AutoSize = true;
            фамилииLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            фамилииLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            фамилииLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            фамилииLabel.Location = new System.Drawing.Point(60, 667);
            фамилииLabel.Name = "фамилииLabel";
            фамилииLabel.Size = new System.Drawing.Size(91, 25);
            фамилииLabel.TabIndex = 45;
            фамилииLabel.Text = "Фамилии:";
            // 
            // инициалыLabel
            // 
            инициалыLabel.AutoSize = true;
            инициалыLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            инициалыLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            инициалыLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            инициалыLabel.Location = new System.Drawing.Point(60, 718);
            инициалыLabel.Name = "инициалыLabel";
            инициалыLabel.Size = new System.Drawing.Size(102, 25);
            инициалыLabel.TabIndex = 46;
            инициалыLabel.Text = "Инициалы:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            полLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            полLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            полLabel.Location = new System.Drawing.Point(60, 770);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(49, 25);
            полLabel.TabIndex = 47;
            полLabel.Text = "Пол:";
            // 
            // городLabel
            // 
            городLabel.AutoSize = true;
            городLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            городLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            городLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            городLabel.Location = new System.Drawing.Point(60, 827);
            городLabel.Name = "городLabel";
            городLabel.Size = new System.Drawing.Size(64, 25);
            городLabel.TabIndex = 48;
            городLabel.Text = "Город:";
            // 
            // type_of_customerIDLabel
            // 
            type_of_customerIDLabel.AutoSize = true;
            type_of_customerIDLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            type_of_customerIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            type_of_customerIDLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            type_of_customerIDLabel.Location = new System.Drawing.Point(60, 881);
            type_of_customerIDLabel.Name = "type_of_customerIDLabel";
            type_of_customerIDLabel.Size = new System.Drawing.Size(119, 25);
            type_of_customerIDLabel.TabIndex = 49;
            type_of_customerIDLabel.Text = "Тип клиента:";
            // 
            // client_phone_numberLabel
            // 
            client_phone_numberLabel.AutoSize = true;
            client_phone_numberLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            client_phone_numberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            client_phone_numberLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            client_phone_numberLabel.Location = new System.Drawing.Point(60, 932);
            client_phone_numberLabel.Name = "client_phone_numberLabel";
            client_phone_numberLabel.Size = new System.Drawing.Size(151, 25);
            client_phone_numberLabel.TabIndex = 50;
            client_phone_numberLabel.Text = "Номер телефона:";
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
            this.menuStrip1.Size = new System.Drawing.Size(1305, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.dataSet1;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ALL_DATA_BASE_TABLETableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BranchTableAdapter = null;
            this.tableAdapterManager.CitiesTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.Order_clientTableAdapter = null;
            this.tableAdapterManager.PostTableAdapter = null;
            this.tableAdapterManager.Service_typeTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.Type_of_customerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Course_Work_aplication.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientDataGridView
            // 
            this.clientDataGridView.AutoGenerateColumns = false;
            this.clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.clientDataGridView.DataSource = this.clientBindingSource;
            this.clientDataGridView.Location = new System.Drawing.Point(34, 53);
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.RowHeadersWidth = 51;
            this.clientDataGridView.RowTemplate.Height = 24;
            this.clientDataGridView.Size = new System.Drawing.Size(1238, 536);
            this.clientDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ClientID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Client_surname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Client_initials";
            this.dataGridViewTextBoxColumn3.HeaderText = "Инициалы";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Client_gender";
            this.dataGridViewTextBoxColumn4.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CitiesID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Город";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Type_of_customerID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Тип клиента";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Client_phone_number";
            this.dataGridViewTextBoxColumn7.HeaderText = "Номер телефона";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // clientIDTextBox
            // 
            this.clientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientID", true));
            this.clientIDTextBox.Location = new System.Drawing.Point(249, 619);
            this.clientIDTextBox.Name = "clientIDTextBox";
            this.clientIDTextBox.ReadOnly = true;
            this.clientIDTextBox.Size = new System.Drawing.Size(126, 22);
            this.clientIDTextBox.TabIndex = 37;
            // 
            // client_surnameTextBox
            // 
            this.client_surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Client_surname", true));
            this.client_surnameTextBox.Location = new System.Drawing.Point(249, 667);
            this.client_surnameTextBox.Name = "client_surnameTextBox";
            this.client_surnameTextBox.Size = new System.Drawing.Size(126, 22);
            this.client_surnameTextBox.TabIndex = 38;
            // 
            // client_initialsTextBox
            // 
            this.client_initialsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Client_initials", true));
            this.client_initialsTextBox.Location = new System.Drawing.Point(249, 718);
            this.client_initialsTextBox.Name = "client_initialsTextBox";
            this.client_initialsTextBox.Size = new System.Drawing.Size(126, 22);
            this.client_initialsTextBox.TabIndex = 39;
            // 
            // client_genderTextBox
            // 
            this.client_genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Client_gender", true));
            this.client_genderTextBox.Location = new System.Drawing.Point(249, 770);
            this.client_genderTextBox.Name = "client_genderTextBox";
            this.client_genderTextBox.Size = new System.Drawing.Size(126, 22);
            this.client_genderTextBox.TabIndex = 40;
            // 
            // citiesIDComboBox
            // 
            this.citiesIDComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.citiesIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CitiesID", true));
            this.citiesIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.citiesIDComboBox.FormattingEnabled = true;
            this.citiesIDComboBox.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.citiesIDComboBox.Location = new System.Drawing.Point(249, 827);
            this.citiesIDComboBox.Name = "citiesIDComboBox";
            this.citiesIDComboBox.Size = new System.Drawing.Size(126, 24);
            this.citiesIDComboBox.TabIndex = 41;
            // 
            // type_of_customerIDComboBox
            // 
            this.type_of_customerIDComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.type_of_customerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Type_of_customerID", true));
            this.type_of_customerIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_of_customerIDComboBox.FormattingEnabled = true;
            this.type_of_customerIDComboBox.Items.AddRange(new object[] {
            "",
            "1",
            "2"});
            this.type_of_customerIDComboBox.Location = new System.Drawing.Point(249, 881);
            this.type_of_customerIDComboBox.Name = "type_of_customerIDComboBox";
            this.type_of_customerIDComboBox.Size = new System.Drawing.Size(126, 24);
            this.type_of_customerIDComboBox.TabIndex = 42;
            // 
            // client_phone_numberTextBox
            // 
            this.client_phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Client_phone_number", true));
            this.client_phone_numberTextBox.Location = new System.Drawing.Point(249, 932);
            this.client_phone_numberTextBox.Name = "client_phone_numberTextBox";
            this.client_phone_numberTextBox.Size = new System.Drawing.Size(126, 22);
            this.client_phone_numberTextBox.TabIndex = 43;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightBlue;
            this.button3.Font = new System.Drawing.Font("Sitka Small", 9F);
            this.button3.Location = new System.Drawing.Point(649, 667);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 64);
            this.button3.TabIndex = 56;
            this.button3.Text = "Поиск";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Font = new System.Drawing.Font("Sitka Small", 9F);
            this.button2.Location = new System.Drawing.Point(882, 833);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 64);
            this.button2.TabIndex = 55;
            this.button2.Text = "Удалить данные";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 9F);
            this.button1.Location = new System.Drawing.Point(882, 667);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 64);
            this.button1.TabIndex = 54;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(381, 827);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 58;
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
            this.pictureBox3.Location = new System.Drawing.Point(381, 881);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 59;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
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
            // ChangeDataClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1305, 1055);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
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
            this.Controls.Add(this.clientIDTextBox);
            this.Controls.Add(this.client_surnameTextBox);
            this.Controls.Add(this.client_initialsTextBox);
            this.Controls.Add(this.client_genderTextBox);
            this.Controls.Add(this.citiesIDComboBox);
            this.Controls.Add(this.type_of_customerIDComboBox);
            this.Controls.Add(this.client_phone_numberTextBox);
            this.Controls.Add(this.clientDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChangeDataClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JK-Fast&Clean - Клиенты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangeDataClient_FormClosing);
            this.Load += new System.EventHandler(this.ChangeDataClient_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DataSet1TableAdapters.ClientTableAdapter clientTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView clientDataGridView;
        private System.Windows.Forms.TextBox clientIDTextBox;
        private System.Windows.Forms.TextBox client_surnameTextBox;
        private System.Windows.Forms.TextBox client_initialsTextBox;
        private System.Windows.Forms.TextBox client_genderTextBox;
        private System.Windows.Forms.ComboBox citiesIDComboBox;
        private System.Windows.Forms.ComboBox type_of_customerIDComboBox;
        private System.Windows.Forms.TextBox client_phone_numberTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}