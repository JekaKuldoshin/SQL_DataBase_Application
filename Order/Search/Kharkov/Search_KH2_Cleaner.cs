using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work_aplication.Order.Search.Kharkov
{
    public partial class Search_KH2_Cleaner : Form
    {
        public Search_KH2_Cleaner()
        {
            InitializeComponent();
        }

        private void Search_KH2_Cleaner_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Information_only_Cleaner_KH2". При необходимости она может быть перемещена или удалена.
            this.information_only_Cleaner_KH2TableAdapter.Fill(this.dataSet1.Information_only_Cleaner_KH2);

        }

        private void information_only_Cleaner_KH2DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = information_only_Cleaner_KH2DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Close();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            information_only_Cleaner_KH2BindingSource.Filter = "Фамилии like'%" + searchTextBox.Text + "%'";

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
 "   Поиск сотрудника по базе данных:\n\n   1.Вручную (выбор со списка).\n   2.Автоматически (воспользуйтесь полем для ввода), дважды шелкните на необходимую строку данных для выбора.",
 "Справка",
 MessageBoxButtons.OK,
 MessageBoxIcon.Information
);
        }
    }
}
