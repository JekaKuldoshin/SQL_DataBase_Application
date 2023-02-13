namespace Course_Work_aplication.Order.Search.Odessa
{
    partial class Search_Od2_Cleaner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Od2_Cleaner));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.dataSet1 = new Course_Work_aplication.DataSet1();
            this.information_only_Cleaner_Od2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.information_only_Cleaner_Od2TableAdapter = new Course_Work_aplication.DataSet1TableAdapters.Information_only_Cleaner_Od2TableAdapter();
            this.tableAdapterManager = new Course_Work_aplication.DataSet1TableAdapters.TableAdapterManager();
            this.information_only_Cleaner_Od2DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.information_only_Cleaner_Od2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.information_only_Cleaner_Od2DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 28);
            this.menuStrip1.TabIndex = 78;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            iDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            iDLabel.Font = new System.Drawing.Font("Sitka Small", 9F);
            iDLabel.Location = new System.Drawing.Point(41, 397);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(144, 25);
            iDLabel.TabIndex = 98;
            iDLabel.Text = "Поле для ввода:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(380, 397);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(129, 22);
            this.textBox1.TabIndex = 100;
            this.textBox1.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(333, 397);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 99;
            this.pictureBox4.TabStop = false;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Location = new System.Drawing.Point(198, 397);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(129, 22);
            this.searchTextBox.TabIndex = 97;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // information_only_Cleaner_Od2BindingSource
            // 
            this.information_only_Cleaner_Od2BindingSource.DataMember = "Information_only_Cleaner_Od2";
            this.information_only_Cleaner_Od2BindingSource.DataSource = this.dataSet1;
            // 
            // information_only_Cleaner_Od2TableAdapter
            // 
            this.information_only_Cleaner_Od2TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ALL_DATA_BASE_TABLETableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BranchTableAdapter = null;
            this.tableAdapterManager.CitiesTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Order_clientTableAdapter = null;
            this.tableAdapterManager.PostTableAdapter = null;
            this.tableAdapterManager.Service_typeTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.Type_of_customerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Course_Work_aplication.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // information_only_Cleaner_Od2DataGridView
            // 
            this.information_only_Cleaner_Od2DataGridView.AutoGenerateColumns = false;
            this.information_only_Cleaner_Od2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.information_only_Cleaner_Od2DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.information_only_Cleaner_Od2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.information_only_Cleaner_Od2DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.information_only_Cleaner_Od2DataGridView.DataSource = this.information_only_Cleaner_Od2BindingSource;
            this.information_only_Cleaner_Od2DataGridView.Location = new System.Drawing.Point(12, 43);
            this.information_only_Cleaner_Od2DataGridView.Name = "information_only_Cleaner_Od2DataGridView";
            this.information_only_Cleaner_Od2DataGridView.ReadOnly = true;
            this.information_only_Cleaner_Od2DataGridView.RowHeadersWidth = 51;
            this.information_only_Cleaner_Od2DataGridView.RowTemplate.Height = 24;
            this.information_only_Cleaner_Od2DataGridView.Size = new System.Drawing.Size(748, 334);
            this.information_only_Cleaner_Od2DataGridView.TabIndex = 101;
            this.information_only_Cleaner_Od2DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.information_only_Cleaner_Od2DataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 49;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Фамилии";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилии";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 96;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Должность";
            this.dataGridViewTextBoxColumn3.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 107;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Филиал";
            this.dataGridViewTextBoxColumn4.HeaderText = "Филиал";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 87;
            // 
            // Search_Od2_Cleaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.information_only_Cleaner_Od2DataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search_Od2_Cleaner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JK-Fast&Clean - Заказы (поиск сотрудника Одесса 2)";
            this.Load += new System.EventHandler(this.Search_Od2_Cleaner_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.information_only_Cleaner_Od2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.information_only_Cleaner_Od2DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.TextBox searchTextBox;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource information_only_Cleaner_Od2BindingSource;
        private DataSet1TableAdapters.Information_only_Cleaner_Od2TableAdapter information_only_Cleaner_Od2TableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView information_only_Cleaner_Od2DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}