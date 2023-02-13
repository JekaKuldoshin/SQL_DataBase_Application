using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work_aplication
{
    public partial class Staff_Form : Form
    {
        public Staff_Form()
        {
            InitializeComponent();
        }

        private void Staff_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.ALL_DATA_BASE". При необходимости она может быть перемещена или удалена.
            this.aLL_DATA_BASETableAdapter.Fill(this.dataSet1.ALL_DATA_BASE);

        }

        //private void Staff_FormClosed(object sender, EventArgs e)
        //{
        //    Main_Form ifrm = new Main_Form();
        //    ifrm.Left = this.Left;
        //    ifrm.Top = this.Top;
        //    ifrm.Show();
        //    this.Hide();
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            //aLL_DATA_BASEBindingSource.EndEdit();
            //SqlDataAdapter adapter = new SqlDataAdapter(this.dataSet1.ALL_DATA_BASE);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDataStaff a = new AddDataStaff();
            a.ShowDialog();
        }

        private void Staff_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            Main_Form f = new Main_Form();
            f.Left = this.Left;
            f.Top = this.Top;
            f.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ChangeDataStaff a = new ChangeDataStaff();
            a.ShowDialog();
        }

        private void aLL_DATA_BASEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
