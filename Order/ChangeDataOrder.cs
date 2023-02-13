using Course_Work_aplication.Order.Search.Dnepr;
using Course_Work_aplication.Order.Search.Kharkov;
using Course_Work_aplication.Order.Search.Kiev;
using Course_Work_aplication.Order.Search.Lviv;
using Course_Work_aplication.Order.Search.Odessa;
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

namespace Course_Work_aplication.Order
{
    public partial class ChangeDataOrder : Form
    {
        public ChangeDataOrder()
        {
            InitializeComponent();
        }

        private void order_clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.order_clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void ChangeDataOrder_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Service_type". При необходимости она может быть перемещена или удалена.
            this.service_typeTableAdapter.Fill(this.dataSet1.Service_type);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.dataSet1.Staff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Branch". При необходимости она может быть перемещена или удалена.
            this.branchTableAdapter.Fill(this.dataSet1.Branch);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.dataSet1.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Order_client". При необходимости она может быть перемещена или удалена.
            this.order_clientTableAdapter.Fill(this.dataSet1.Order_client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Branch". При необходимости она может быть перемещена или удалена.
            this.branchTableAdapter.Fill(this.dataSet1.Branch);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.dataSet1.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Order_client". При необходимости она может быть перемещена или удалена.
            this.order_clientTableAdapter.Fill(this.dataSet1.Order_client);

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
                order_clientBindingSource.EndEdit();
                order_clientTableAdapter.Update(dataSet1);
            }
            else
            {

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            order_clientDataGridView.ClearSelection();

            SearchDataStaff a = new SearchDataStaff();
            a.ShowDialog();


            int rowIndex = 0;

            if (string.IsNullOrWhiteSpace(a.staffIDTextBox.Text))
                return;


            var values = a.staffIDTextBox.Text.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);






            for (int i = 0; i < order_clientDataGridView.RowCount - 1; i++)
            {
                foreach (string value in values)
                {
                    var row = order_clientDataGridView.Rows[i];
                    rowIndex++;

                    if (row.Cells["dataGridViewTextBoxColumn1"].Value.ToString().Equals(value) ||
                        row.Cells["dataGridViewTextBoxColumn3"].Value.ToString().Equals(value))
                    {
                        rowIndex--;
                        DataGridViewRow selectedRow = order_clientDataGridView.Rows[rowIndex];
                        row.Selected = true;
                        order_clientDataGridView.FirstDisplayedScrollingRowIndex = rowIndex;
                        order_clientDataGridView.CurrentCell = order_clientDataGridView.Rows[rowIndex].Cells[0];

                        order_clientIDTextBox.Text = selectedRow.Cells[0].Value.ToString();
                        clientIDComboBox.Text = selectedRow.Cells[1].Value.ToString();
                        address_clientTextBox.Text = selectedRow.Cells[2].Value.ToString();
                        branchIDComboBox.Text = selectedRow.Cells[3].Value.ToString();
                        staffIDComboBox.Text = selectedRow.Cells[4].Value.ToString();
                        date_of_workDateTimePicker.Text = selectedRow.Cells[5].Value.ToString();
                        service_typeIDComboBox.Text = selectedRow.Cells[6].Value.ToString();

                        return;
                        //staffDataGridView.SelectedRows[0];
                        //row.HeaderCell.Selected = true;
                    }

                }
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
                order_clientBindingSource.RemoveCurrent();
                order_clientBindingSource.EndEdit();
                order_clientTableAdapter.Update(dataSet1);
            }
            else
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchDataOrder_Client a = new SearchDataOrder_Client();
            a.ShowDialog();

            if (string.IsNullOrWhiteSpace(a.textBox1.Text))
                return;

            var values = a.textBox1.Text;


            clientIDComboBox.Text = values;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int index = branchIDComboBox.SelectedIndex;

            switch (index)
            {
                case 0:
                    Search_KH1_Cleaner kh1 = new Search_KH1_Cleaner();
                    kh1.ShowDialog();
                    if (string.IsNullOrWhiteSpace(kh1.textBox1.Text))
                        return;

                    var valueskh1 = kh1.textBox1.Text;


                    staffIDComboBox.Text = valueskh1;
                    break;

                case 1:
                    Search_KH2_Cleaner kh2 = new Search_KH2_Cleaner();
                    kh2.ShowDialog();
                    if (string.IsNullOrWhiteSpace(kh2.textBox1.Text))
                        return;

                    var valueskh2 = kh2.textBox1.Text;


                    staffIDComboBox.Text = valueskh2;
                    break;

                case 2:
                    Search_Kiev1_Cleaner ki1 = new Search_Kiev1_Cleaner();
                    ki1.ShowDialog();
                    if (string.IsNullOrWhiteSpace(ki1.textBox1.Text))
                        return;

                    var valueski1 = ki1.textBox1.Text;


                    staffIDComboBox.Text = valueski1;
                    break;
                case 3:
                    Search_Kiev2_Cleaner ki2 = new Search_Kiev2_Cleaner();
                    ki2.ShowDialog();
                    if (string.IsNullOrWhiteSpace(ki2.textBox1.Text))
                        return;

                    var valueski2 = ki2.textBox1.Text;


                    staffIDComboBox.Text = valueski2;
                    break;
                case 4:
                    Search_Kiev3_Cleaner ki3 = new Search_Kiev3_Cleaner();
                    ki3.ShowDialog();
                    if (string.IsNullOrWhiteSpace(ki3.textBox1.Text))
                        return;

                    var valueski3 = ki3.textBox1.Text;


                    staffIDComboBox.Text = valueski3;
                    break;
                case 5:
                    Search_Od1_Cleaner od1 = new Search_Od1_Cleaner();
                    od1.ShowDialog();
                    if (string.IsNullOrWhiteSpace(od1.textBox1.Text))
                        return;

                    var valuesod1 = od1.textBox1.Text;


                    staffIDComboBox.Text = valuesod1;
                    break;
                case 6:
                    Search_Od2_Cleaner od2 = new Search_Od2_Cleaner();
                    od2.ShowDialog();
                    if (string.IsNullOrWhiteSpace(od2.textBox1.Text))
                        return;

                    var valuesod2 = od2.textBox1.Text;


                    staffIDComboBox.Text = valuesod2;
                    break;
                case 7:
                    Search_Lv1_Cleaner lv1 = new Search_Lv1_Cleaner();
                    lv1.ShowDialog();
                    if (string.IsNullOrWhiteSpace(lv1.textBox1.Text))
                        return;

                    var valueslv1 = lv1.textBox1.Text;


                    staffIDComboBox.Text = valueslv1;
                    break;
                case 8:
                    Search_Dn1_Cleaner dn1 = new Search_Dn1_Cleaner();
                    dn1.ShowDialog();
                    if (string.IsNullOrWhiteSpace(dn1.textBox1.Text))
                        return;

                    var valuesdn1 = dn1.textBox1.Text;


                    staffIDComboBox.Text = valuesdn1;
                    break;
                default:

                    break;
            }
        }

        private void ChangeDataOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            Order_Form f = new Order_Form();
            f.Left = this.Left;
            f.Top = this.Top;
            f.Show();
            this.Hide();
        }

        private void order_clientBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.order_clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
      "    Редактирование:\n\n    " + "Для редактирования данных, выберите соответствующую ячейку (в таблице) и произведите изменение данных в соответствующих полях, которые расположены ниже (ID, Фамилия...)" + "\n    После изменений необходимо воспользоваться кнопкой (Сохранить изменения)." + "\n\n    Удаление:\n\n    " + "Для удаления данных,   выберите соответствующую ячейку (в таблице) и воспользуйтесь кнопкой (Удалить данные).\n\n    Поиск:\n\n    Переходите в новое окно для ввода данных, осуществляется поиск по таблице, выполняется выбор данных для изменения.",
      "Справка",
      MessageBoxButtons.OK,
      MessageBoxIcon.Information
     );
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
