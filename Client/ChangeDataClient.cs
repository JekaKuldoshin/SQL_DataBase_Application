using Course_Work_aplication.Staff;
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
    public partial class ChangeDataClient : Form
    {
        public ChangeDataClient()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void ChangeDataClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.dataSet1.Client);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
       "Вы точно хотите сохранить данные в базу?",
       "Сохранение данных",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Warning
      );
            if (dialog == DialogResult.Yes)
            {
                clientBindingSource.EndEdit();
                clientTableAdapter.Update(dataSet1);
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
        "Вы точно хотите удалить данные с базы?",
        "Удаление данных",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning
       );
            if (dialog == DialogResult.Yes)
            {
                clientBindingSource.RemoveCurrent();
                clientBindingSource.EndEdit();
                clientTableAdapter.Update(dataSet1);
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {



            clientDataGridView.ClearSelection();

            SearchDataClient a = new SearchDataClient();
            a.ShowDialog();


            int rowIndex = 0;

            if (string.IsNullOrWhiteSpace(a.staffIDTextBox.Text))
                return;


            var values = a.staffIDTextBox.Text.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);






            for (int i = 0; i < clientDataGridView.RowCount - 1; i++)
            {
                foreach (string value in values)
                {
                    var row = clientDataGridView.Rows[i];
                    rowIndex++;

                    if (row.Cells["dataGridViewTextBoxColumn1"].Value.ToString().Equals(value) ||
                        row.Cells["dataGridViewTextBoxColumn2"].Value.ToString().Equals(value)||
                        row.Cells["dataGridViewTextBoxColumn7"].Value.ToString().Equals(value))
                    {
                        rowIndex--;
                        DataGridViewRow selectedRow = clientDataGridView.Rows[rowIndex];
                        row.Selected = true;
                        clientDataGridView.FirstDisplayedScrollingRowIndex = rowIndex;
                        clientDataGridView.CurrentCell = clientDataGridView.Rows[rowIndex].Cells[0];

                        clientIDTextBox.Text = selectedRow.Cells[0].Value.ToString();
                        client_surnameTextBox.Text = selectedRow.Cells[1].Value.ToString();
                        client_initialsTextBox.Text = selectedRow.Cells[2].Value.ToString();
                        client_genderTextBox.Text = selectedRow.Cells[3].Value.ToString();
                        citiesIDComboBox.Text = selectedRow.Cells[4].Value.ToString();
                        type_of_customerIDComboBox.Text = selectedRow.Cells[5].Value.ToString();
                        client_phone_numberTextBox.Text = selectedRow.Cells[6].Value.ToString();
                        return;
                        //staffDataGridView.SelectedRows[0];
                        //row.HeaderCell.Selected = true;
                    }

                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
       "   Города:\n\n   1  -  Харьков\n   2  -  Киев\n   3  -  Одесса\n   4  -  Львов\n   5  -  Днепр",
       "Города",
       MessageBoxButtons.OK,
       MessageBoxIcon.Information
       );
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
      "   Тип клиента:\n\n   1  -  Физическое лицо\n   2  -  Юридическое лицо",
      "Тип клиента",
      MessageBoxButtons.OK,
      MessageBoxIcon.Information
     );
        }

        private void ChangeDataClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            Client_Form f = new Client_Form();
            f.Left = this.Left;
            f.Top = this.Top;
            f.Show();
            this.Hide();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
