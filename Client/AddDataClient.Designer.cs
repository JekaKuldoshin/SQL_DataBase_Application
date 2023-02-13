namespace Course_Work_aplication.Client
{
    partial class AddDataClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDataClient));
            this.dataSet1 = new Course_Work_aplication.DataSet1();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Course_Work_aplication.DataSet1TableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new Course_Work_aplication.DataSet1TableAdapters.TableAdapterManager();
            this.clientIDTextBox = new System.Windows.Forms.TextBox();
            this.client_surnameTextBox = new System.Windows.Forms.TextBox();
            this.client_initialsTextBox = new System.Windows.Forms.TextBox();
            this.client_genderTextBox = new System.Windows.Forms.TextBox();
            this.citiesIDComboBox = new System.Windows.Forms.ComboBox();
            this.type_of_customerIDComboBox = new System.Windows.Forms.ComboBox();
            this.client_phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            iDLabel = new System.Windows.Forms.Label();
            фамилииLabel = new System.Windows.Forms.Label();
            инициалыLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            городLabel = new System.Windows.Forms.Label();
            type_of_customerIDLabel = new System.Windows.Forms.Label();
            client_phone_numberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            iDLabel.Location = new System.Drawing.Point(80, 84);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(35, 25);
            iDLabel.TabIndex = 26;
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
            фамилииLabel.Location = new System.Drawing.Point(80, 132);
            фамилииLabel.Name = "фамилииLabel";
            фамилииLabel.Size = new System.Drawing.Size(91, 25);
            фамилииLabel.TabIndex = 27;
            фамилииLabel.Text = "Фамилии:";
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
            инициалыLabel.Location = new System.Drawing.Point(80, 183);
            инициалыLabel.Name = "инициалыLabel";
            инициалыLabel.Size = new System.Drawing.Size(102, 25);
            инициалыLabel.TabIndex = 28;
            инициалыLabel.Text = "Инициалы:";
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
            полLabel.Location = new System.Drawing.Point(80, 235);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(49, 25);
            полLabel.TabIndex = 29;
            полLabel.Text = "Пол:";
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
            городLabel.Location = new System.Drawing.Point(80, 292);
            городLabel.Name = "городLabel";
            городLabel.Size = new System.Drawing.Size(64, 25);
            городLabel.TabIndex = 30;
            городLabel.Text = "Город:";
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
            type_of_customerIDLabel.Location = new System.Drawing.Point(80, 346);
            type_of_customerIDLabel.Name = "type_of_customerIDLabel";
            type_of_customerIDLabel.Size = new System.Drawing.Size(119, 25);
            type_of_customerIDLabel.TabIndex = 31;
            type_of_customerIDLabel.Text = "Тип клиента:";
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
            client_phone_numberLabel.Location = new System.Drawing.Point(80, 397);
            client_phone_numberLabel.Name = "client_phone_numberLabel";
            client_phone_numberLabel.Size = new System.Drawing.Size(151, 25);
            client_phone_numberLabel.TabIndex = 32;
            client_phone_numberLabel.Text = "Номер телефона:";
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
            // clientIDTextBox
            // 
            this.clientIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientID", true));
            this.clientIDTextBox.Location = new System.Drawing.Point(269, 84);
            this.clientIDTextBox.Name = "clientIDTextBox";
            this.clientIDTextBox.ReadOnly = true;
            this.clientIDTextBox.Size = new System.Drawing.Size(95, 22);
            this.clientIDTextBox.TabIndex = 1;
            // 
            // client_surnameTextBox
            // 
            this.client_surnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.client_surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Client_surname", true));
            this.client_surnameTextBox.Location = new System.Drawing.Point(269, 132);
            this.client_surnameTextBox.Name = "client_surnameTextBox";
            this.client_surnameTextBox.Size = new System.Drawing.Size(95, 22);
            this.client_surnameTextBox.TabIndex = 3;
            // 
            // client_initialsTextBox
            // 
            this.client_initialsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.client_initialsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Client_initials", true));
            this.client_initialsTextBox.Location = new System.Drawing.Point(269, 183);
            this.client_initialsTextBox.Name = "client_initialsTextBox";
            this.client_initialsTextBox.Size = new System.Drawing.Size(95, 22);
            this.client_initialsTextBox.TabIndex = 5;
            // 
            // client_genderTextBox
            // 
            this.client_genderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.client_genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Client_gender", true));
            this.client_genderTextBox.Location = new System.Drawing.Point(269, 235);
            this.client_genderTextBox.Name = "client_genderTextBox";
            this.client_genderTextBox.Size = new System.Drawing.Size(95, 22);
            this.client_genderTextBox.TabIndex = 7;
            // 
            // citiesIDComboBox
            // 
            this.citiesIDComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.citiesIDComboBox.Location = new System.Drawing.Point(269, 292);
            this.citiesIDComboBox.Name = "citiesIDComboBox";
            this.citiesIDComboBox.Size = new System.Drawing.Size(95, 24);
            this.citiesIDComboBox.TabIndex = 9;
            // 
            // type_of_customerIDComboBox
            // 
            this.type_of_customerIDComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.type_of_customerIDComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.type_of_customerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Type_of_customerID", true));
            this.type_of_customerIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_of_customerIDComboBox.FormattingEnabled = true;
            this.type_of_customerIDComboBox.Items.AddRange(new object[] {
            "",
            "1",
            "2"});
            this.type_of_customerIDComboBox.Location = new System.Drawing.Point(269, 346);
            this.type_of_customerIDComboBox.Name = "type_of_customerIDComboBox";
            this.type_of_customerIDComboBox.Size = new System.Drawing.Size(95, 24);
            this.type_of_customerIDComboBox.TabIndex = 11;
            // 
            // client_phone_numberTextBox
            // 
            this.client_phone_numberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.client_phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Client_phone_number", true));
            this.client_phone_numberTextBox.Location = new System.Drawing.Point(269, 397);
            this.client_phone_numberTextBox.Name = "client_phone_numberTextBox";
            this.client_phone_numberTextBox.Size = new System.Drawing.Size(95, 22);
            this.client_phone_numberTextBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 9F);
            this.button1.Location = new System.Drawing.Point(80, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 66);
            this.button1.TabIndex = 18;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(458, 28);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
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
            this.pictureBox4.Location = new System.Drawing.Point(370, 84);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 34;
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
            this.pictureBox1.Location = new System.Drawing.Point(370, 292);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(370, 346);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // AddDataClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(458, 597);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(iDLabel);
            this.Controls.Add(фамилииLabel);
            this.Controls.Add(инициалыLabel);
            this.Controls.Add(полLabel);
            this.Controls.Add(городLabel);
            this.Controls.Add(type_of_customerIDLabel);
            this.Controls.Add(client_phone_numberLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clientIDTextBox);
            this.Controls.Add(this.client_surnameTextBox);
            this.Controls.Add(this.client_initialsTextBox);
            this.Controls.Add(this.client_genderTextBox);
            this.Controls.Add(this.citiesIDComboBox);
            this.Controls.Add(this.type_of_customerIDComboBox);
            this.Controls.Add(this.client_phone_numberTextBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "AddDataClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JK-Fast&Clean - Клиенты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddDataClient_FormClosing);
            this.Load += new System.EventHandler(this.AddDataClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DataSet1TableAdapters.ClientTableAdapter clientTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox clientIDTextBox;
        private System.Windows.Forms.TextBox client_surnameTextBox;
        private System.Windows.Forms.TextBox client_initialsTextBox;
        private System.Windows.Forms.TextBox client_genderTextBox;
        private System.Windows.Forms.ComboBox citiesIDComboBox;
        private System.Windows.Forms.ComboBox type_of_customerIDComboBox;
        private System.Windows.Forms.TextBox client_phone_numberTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}