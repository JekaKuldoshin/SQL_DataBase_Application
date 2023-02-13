using Course_Work_aplication.Client;
using Course_Work_aplication.Order;
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
    public partial class Main_Form : Form
    {

        public Main_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff_Form ifrm = new Staff_Form();
            ifrm.Left = this.Left;
            ifrm.Top = this.Top;
            ifrm.Show();
            this.Hide();

            //Staff_Form f = new Staff_Form();
            //f.ShowDialog();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client_Form client_Form = new Client_Form();
            client_Form.Left = this.Left;
            client_Form.Top = this.Top;
            client_Form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Order_Form order_Form = new Order_Form();
            order_Form.Left = this.Left;
            order_Form.Top = this.Top;
            order_Form.Show();
            this.Hide();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
      "    Данная программа была разработана для Клининговой компании, в которой Вы сможете:\n\n   - Добавлять/Удалять/Редактировать данные про сотрудников через базу данных.\n\n   - Добавлять/Удалять/Редактировать данные про клиентов через базу данных.\n\n   - Добавлять/Удалять/Редактировать заказы на чистку помещений через базу данных.\n\n-------------------------------------------------------------------------------\n\n   Данный проект был разработан студентом «Национального технического университета \"Харьковского политехнического института\"», группы КН-320Д - Кулдошин Евгений Ильич.\n\n   Принимающий работу, старший преподаватель, преподаватель практических занятий - Кожин Юрий Николаевич",
      "О программе",
      MessageBoxButtons.OK,
      MessageBoxIcon.Information
     );
        }
    }
}
