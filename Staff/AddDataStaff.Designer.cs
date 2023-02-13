namespace Course_Work_aplication
{
    partial class AddDataStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDataStaff));
            this.dataSet1 = new Course_Work_aplication.DataSet1();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new Course_Work_aplication.DataSet1TableAdapters.StaffTableAdapter();
            this.tableAdapterManager = new Course_Work_aplication.DataSet1TableAdapters.TableAdapterManager();
            this.staff_surnameTextBox = new System.Windows.Forms.TextBox();
            this.staff_initialsTextBox = new System.Windows.Forms.TextBox();
            this.staff_genderTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.citiesIDComboBox = new System.Windows.Forms.ComboBox();
            this.postIDComboBox = new System.Windows.Forms.ComboBox();
            this.branchIDComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.staffIDTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
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
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            iDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            iDLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            iDLabel.Location = new System.Drawing.Point(81, 69);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(35, 25);
            iDLabel.TabIndex = 18;
            iDLabel.Text = "ID:";
            // 
            // фамилииLabel
            // 
            фамилииLabel.AutoSize = true;
            фамилииLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            фамилииLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            фамилииLabel.Location = new System.Drawing.Point(81, 117);
            фамилииLabel.Name = "фамилииLabel";
            фамилииLabel.Size = new System.Drawing.Size(91, 25);
            фамилииLabel.TabIndex = 19;
            фамилииLabel.Text = "Фамилии:";
            // 
            // инициалыLabel
            // 
            инициалыLabel.AutoSize = true;
            инициалыLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            инициалыLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            инициалыLabel.Location = new System.Drawing.Point(81, 168);
            инициалыLabel.Name = "инициалыLabel";
            инициалыLabel.Size = new System.Drawing.Size(102, 25);
            инициалыLabel.TabIndex = 20;
            инициалыLabel.Text = "Инициалы:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            полLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            полLabel.Location = new System.Drawing.Point(81, 220);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(49, 25);
            полLabel.TabIndex = 21;
            полLabel.Text = "Пол:";
            // 
            // городLabel
            // 
            городLabel.AutoSize = true;
            городLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            городLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            городLabel.Location = new System.Drawing.Point(81, 277);
            городLabel.Name = "городLabel";
            городLabel.Size = new System.Drawing.Size(64, 25);
            городLabel.TabIndex = 22;
            городLabel.Text = "Город:";
            // 
            // должностьLabel
            // 
            должностьLabel.AutoSize = true;
            должностьLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            должностьLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            должностьLabel.Location = new System.Drawing.Point(81, 331);
            должностьLabel.Name = "должностьLabel";
            должностьLabel.Size = new System.Drawing.Size(107, 25);
            должностьLabel.TabIndex = 23;
            должностьLabel.Text = "Должность:";
            // 
            // филиалLabel
            // 
            филиалLabel.AutoSize = true;
            филиалLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            филиалLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            филиалLabel.Location = new System.Drawing.Point(81, 382);
            филиалLabel.Name = "филиалLabel";
            филиалLabel.Size = new System.Drawing.Size(79, 25);
            филиалLabel.TabIndex = 24;
            филиалLabel.Text = "Филиал:";
            // 
            // зарплатаLabel
            // 
            зарплатаLabel.AutoSize = true;
            зарплатаLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            зарплатаLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            зарплатаLabel.Location = new System.Drawing.Point(81, 431);
            зарплатаLabel.Name = "зарплатаLabel";
            зарплатаLabel.Size = new System.Drawing.Size(93, 25);
            зарплатаLabel.TabIndex = 25;
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
            // staff_surnameTextBox
            // 
            this.staff_surnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.staff_surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Staff_surname", true));
            this.staff_surnameTextBox.Location = new System.Drawing.Point(242, 118);
            this.staff_surnameTextBox.Name = "staff_surnameTextBox";
            this.staff_surnameTextBox.Size = new System.Drawing.Size(129, 22);
            this.staff_surnameTextBox.TabIndex = 4;
            this.staff_surnameTextBox.TextChanged += new System.EventHandler(this.staff_surnameTextBox_TextChanged);
            // 
            // staff_initialsTextBox
            // 
            this.staff_initialsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.staff_initialsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Staff_initials", true));
            this.staff_initialsTextBox.Location = new System.Drawing.Point(242, 169);
            this.staff_initialsTextBox.Name = "staff_initialsTextBox";
            this.staff_initialsTextBox.Size = new System.Drawing.Size(129, 22);
            this.staff_initialsTextBox.TabIndex = 6;
            this.staff_initialsTextBox.TextChanged += new System.EventHandler(this.staff_initialsTextBox_TextChanged);
            // 
            // staff_genderTextBox
            // 
            this.staff_genderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.staff_genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Staff_gender", true));
            this.staff_genderTextBox.Location = new System.Drawing.Point(242, 221);
            this.staff_genderTextBox.Name = "staff_genderTextBox";
            this.staff_genderTextBox.Size = new System.Drawing.Size(129, 22);
            this.staff_genderTextBox.TabIndex = 8;
            this.staff_genderTextBox.TextChanged += new System.EventHandler(this.staff_genderTextBox_TextChanged);
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Salary", true));
            this.salaryTextBox.Location = new System.Drawing.Point(242, 432);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(129, 22);
            this.salaryTextBox.TabIndex = 16;
            this.salaryTextBox.TextChanged += new System.EventHandler(this.salaryTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 9F);
            this.button1.Location = new System.Drawing.Point(85, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 62);
            this.button1.TabIndex = 17;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // citiesIDComboBox
            // 
            this.citiesIDComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.citiesIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "CitiesID", true));
            this.citiesIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.citiesIDComboBox.FormattingEnabled = true;
            this.citiesIDComboBox.Items.AddRange(new object[] {
            "",
            "1",
            "2 ",
            "3 ",
            "4 ",
            "5"});
            this.citiesIDComboBox.Location = new System.Drawing.Point(242, 276);
            this.citiesIDComboBox.Name = "citiesIDComboBox";
            this.citiesIDComboBox.Size = new System.Drawing.Size(129, 24);
            this.citiesIDComboBox.TabIndex = 26;
            this.citiesIDComboBox.SelectedIndexChanged += new System.EventHandler(this.citiesIDComboBox_SelectedIndexChanged);
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
            this.postIDComboBox.Location = new System.Drawing.Point(242, 330);
            this.postIDComboBox.Name = "postIDComboBox";
            this.postIDComboBox.Size = new System.Drawing.Size(129, 24);
            this.postIDComboBox.TabIndex = 27;
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
            this.branchIDComboBox.Location = new System.Drawing.Point(242, 381);
            this.branchIDComboBox.Name = "branchIDComboBox";
            this.branchIDComboBox.Size = new System.Drawing.Size(129, 24);
            this.branchIDComboBox.TabIndex = 28;
            this.branchIDComboBox.SelectedIndexChanged += new System.EventHandler(this.branchIDComboBox_SelectedIndexChanged);
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
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(377, 276);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(377, 330);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 31;
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
            this.pictureBox3.Location = new System.Drawing.Point(377, 381);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // staffIDTextBox
            // 
            this.staffIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.staffIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "StaffID", true));
            this.staffIDTextBox.Location = new System.Drawing.Point(242, 70);
            this.staffIDTextBox.Name = "staffIDTextBox";
            this.staffIDTextBox.ReadOnly = true;
            this.staffIDTextBox.Size = new System.Drawing.Size(129, 22);
            this.staffIDTextBox.TabIndex = 2;
            this.staffIDTextBox.TextChanged += new System.EventHandler(this.staffIDTextBox_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(377, 69);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // AddDataStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(458, 628);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.branchIDComboBox);
            this.Controls.Add(this.postIDComboBox);
            this.Controls.Add(this.citiesIDComboBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(фамилииLabel);
            this.Controls.Add(инициалыLabel);
            this.Controls.Add(полLabel);
            this.Controls.Add(городLabel);
            this.Controls.Add(должностьLabel);
            this.Controls.Add(филиалLabel);
            this.Controls.Add(зарплатаLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.staffIDTextBox);
            this.Controls.Add(this.staff_surnameTextBox);
            this.Controls.Add(this.staff_initialsTextBox);
            this.Controls.Add(this.staff_genderTextBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddDataStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JK-Fast&Clean - Сотрудники";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddDataStaff_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private DataSet1TableAdapters.StaffTableAdapter staffTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox staff_surnameTextBox;
        private System.Windows.Forms.TextBox staff_initialsTextBox;
        private System.Windows.Forms.TextBox staff_genderTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox citiesIDComboBox;
        private System.Windows.Forms.ComboBox postIDComboBox;
        private System.Windows.Forms.ComboBox branchIDComboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox staffIDTextBox;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}