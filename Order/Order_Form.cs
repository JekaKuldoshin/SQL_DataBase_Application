using Course_Work_aplication.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work_aplication.Order
{
    public partial class Order_Form : Form
    {
        public Order_Form()
        {
            InitializeComponent();
        }

        private void Order_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.ALL_DATA_Order". При необходимости она может быть перемещена или удалена.
            this.aLL_DATA_OrderTableAdapter.Fill(this.dataSet1.ALL_DATA_Order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.ALL_DATA_Client". При необходимости она может быть перемещена или удалена.
            this.aLL_DATA_ClientTableAdapter.Fill(this.dataSet1.ALL_DATA_Client);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDataOrder a = new AddDataOrder();
            a.ShowDialog();
        }

        private void Order_Form_FormClosing(object sender, FormClosingEventArgs e)
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
            ChangeDataOrder a = new ChangeDataOrder();
            a.ShowDialog();
        }
    }
}
