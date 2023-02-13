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
    public partial class SearchDataClient : Form
    {
        public SearchDataClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
       "   Для того, чтобы воспользоваться поиском, для начало\n   необходимо ввести данные в поле для ввода.\n   Для поиска воспользуйтесь (ID,Фамилией или номером телефона)",
       "Справка",
       MessageBoxButtons.OK,
       MessageBoxIcon.Information
      );
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
      "   Поиск по:\n\n   1  -  ID\n   2  -  Фамилии\n   3  -  Номера телефонов",
      "Поиск",
      MessageBoxButtons.OK,
      MessageBoxIcon.Information
      );
        }

        private void SearchDataClient_Load(object sender, EventArgs e)
        {

        }
    }
}
