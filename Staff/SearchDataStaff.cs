using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Course_Work_aplication.Staff
{
    public partial class SearchDataStaff : Form
    {
        public SearchDataStaff()
        {
            InitializeComponent();
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void SearchDataStaff_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Staff". При необходимости она может быть перемещена или удалена.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
       "   Поиск по:\n\n   1  -  ID\n   2  -  Фамилии",
       "Поиск",
       MessageBoxButtons.OK,
       MessageBoxIcon.Information
       );
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
       "   Для того, чтобы воспользоваться поиском, для начало\n   необходимо ввести в поле для ввода.\n   Для поиска воспользуйтесь (ID или Фамилией)",
       "Справка",
       MessageBoxButtons.OK,
       MessageBoxIcon.Information
      );
        }
    }
}
