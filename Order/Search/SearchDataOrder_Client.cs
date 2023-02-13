using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Course_Work_aplication.Order
{
    public partial class SearchDataOrder_Client : Form
    {
        public SearchDataOrder_Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchDataOrder_Client_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.ALL_DATA_Client". При необходимости она может быть перемещена или удалена.
            this.aLL_DATA_ClientTableAdapter.Fill(this.dataSet1.ALL_DATA_Client);

        }

        

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            aLL_DATA_ClientBindingSource.Filter = "Фамилии like'%" + searchTextBox.Text + "%'";
            
        }

        private void aLL_DATA_ClientDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = aLL_DATA_ClientDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Close();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
     "   Поиск клиента по базе данных:\n\n   1.Вручную (выбор со списка).\n   2.Автоматически (воспользуйтесь полем для ввода), дважды шелкните на необходимую строку данных для выбора.",
     "Справка",
     MessageBoxButtons.OK,
     MessageBoxIcon.Information
    );
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            aLL_DATA_ClientBindingSource.Filter = "Номер_телефона like'%" + textBox2.Text + "%'";
        }
    }
    }

