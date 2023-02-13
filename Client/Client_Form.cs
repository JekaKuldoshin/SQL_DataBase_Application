using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work_aplication.Client
{
    public partial class Client_Form : Form
    {
        public Client_Form()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Client_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.ALL_DATA_BASE". При необходимости она может быть перемещена или удалена.
            this.aLL_DATA_BASETableAdapter.Fill(this.dataSet1.ALL_DATA_BASE);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.ALL_DATA_Client". При необходимости она может быть перемещена или удалена.
            this.aLL_DATA_ClientTableAdapter.Fill(this.dataSet1.ALL_DATA_Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.dataSet1.Client);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDataClient a = new AddDataClient();
            a.ShowDialog();
        }

        private void Client_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            Main_Form f = new Main_Form();
            f.Left = this.Left;
            f.Top = this.Top;
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeDataClient a = new ChangeDataClient();
            a.ShowDialog();
        }
    }
}
