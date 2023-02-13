using Course_Work_aplication.Staff;
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


    public partial class ChangeDataStaff : Form
    {
        public ChangeDataStaff()
        {
            InitializeComponent();
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void ChangeDataStaff_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.dataSet1.Staff);

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
                staffBindingSource.EndEdit();
                staffTableAdapter.Update(dataSet1);
            }
            else
            {

            }


        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

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
                staffBindingSource.RemoveCurrent();
                staffBindingSource.EndEdit();
                staffTableAdapter.Update(dataSet1);
            }
            else
            {

            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
        "   Города:\n\n   1  -  Харьков\n   2  -  Киев\n   3  -  Одесса\n   4  -  Львов\n   5  -  Днепр",
        "Города",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
        );
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
   "   Должности:\n\n   1  -  Собственник бизнеса\n   2  -  Директор филиала\n   3  -  Заместитель директора\n   4  -  Бухгалтер\n   5  -  Юрист\n   6  -  Менеджер по продажам услуг\n   7  -  Клинер\n   8  -  Уборщик филиала",
   "Должности",
   MessageBoxButtons.OK,
   MessageBoxIcon.Information
  );
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
"   Филиалы:\n\n   1  -  JK-Fast&Clean - Ха. (Проспект Гагарина 110в.)\n   2  -  JK-Fast&Clean - Ха. (Пушкинская 39а.)\n   3  -  JK-Fast&Clean - Ки. (Проспект Льва Ландау 21г.)\n   4  -  JK-Fast&Clean - Ки. (ул. Машиниста 10.)\n   5  -  JK-Fast&Clean - Ки. (ул. Валентины 30г.)\n   6  -  JK-Fast&Clean - Од. (ул. Моисея 44.)\n   7  -  JK-Fast&Clean - Од. (ул. Урицкого 101.)\n   8  -  JK-Fast&Clean - Ль. (ул. Западная 22.)\n   8  -  JK-Fast&Clean - Дн. (ул. Вокзальная 85.)",
"Филиалы",
MessageBoxButtons.OK,
MessageBoxIcon.Information
);
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
      "    Редактирование:\n\n    " + "Для редактирования данных, выберите соответствующую ячейку и произведите изменение данных в соответствующих полях, которые расположены ниже (ID, Фамилия...)" + "\n    После изменений необходимо воспользоваться кнопкой (Сохранить изменения)." + "\n\n    Удаление:\n\n    " + "Для удаления данных,   выберите соответствующую ячейку и воспользуйтесь кнопкой (Удалить данные).\n\n    Поиск:\n\n    Переходите в новое окно для ввода данных, осуществляется поиск.",
      "Справка",
      MessageBoxButtons.OK,
      MessageBoxIcon.Information
     );
        }

        //private void citiesIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    citiesIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        //}

        private void postIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            postIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void branchIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            branchIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ChangeDataStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            Staff_Form f = new Staff_Form();
            f.Left = this.Left;
            f.Top = this.Top;
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {



            staffDataGridView.ClearSelection();

            SearchDataStaff a = new SearchDataStaff();
            a.ShowDialog();


            int rowIndex = 0;

            if (string.IsNullOrWhiteSpace(a.staffIDTextBox.Text))
                return;


            var values = a.staffIDTextBox.Text.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);






            for (int i = 0; i < staffDataGridView.RowCount - 1; i++)
            {
                foreach (string value in values)
                {
                    var row = staffDataGridView.Rows[i];
                    rowIndex++;

                    if (row.Cells["dataGridViewTextBoxColumn1"].Value.ToString().Equals(value) ||
                        row.Cells["dataGridViewTextBoxColumn2"].Value.ToString().Equals(value))
                    {
                        rowIndex--;
                        DataGridViewRow selectedRow = staffDataGridView.Rows[rowIndex];
                        row.Selected = true;
                        staffDataGridView.FirstDisplayedScrollingRowIndex = rowIndex;
                        staffDataGridView.CurrentCell = staffDataGridView.Rows[rowIndex].Cells[0];

                        staffIDTextBox.Text = selectedRow.Cells[0].Value.ToString();
                        staff_surnameTextBox.Text = selectedRow.Cells[1].Value.ToString();
                        staff_initialsTextBox.Text = selectedRow.Cells[2].Value.ToString();
                        staff_genderTextBox.Text = selectedRow.Cells[3].Value.ToString();
                        citiesIDComboBox1.Text = selectedRow.Cells[4].Value.ToString();
                        postIDComboBox.Text = selectedRow.Cells[5].Value.ToString();
                        branchIDComboBox.Text = selectedRow.Cells[6].Value.ToString();
                        salaryTextBox.Text = selectedRow.Cells[7].Value.ToString();
                        return;
                        //staffDataGridView.SelectedRows[0];
                        //row.HeaderCell.Selected = true;
                    }

                }
            }


            DialogResult dialog = MessageBox.Show(
             "   Данные не найдены!\n\n   Проверьте правильность ввода и повторите попытку.",
             "Ошибка",
             MessageBoxButtons.OK,
             MessageBoxIcon.Error);


            }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
        }
    




//private void toolStripTextBox2_TextChanged(object sender, EventArgs e)//поиск тут

//{
//    for (int i = 0; i < dataGridView1.RowCount; i++)//тут выделяем строки с символоми из строки поиска
//    {
//        dataGridView1.Rows[i].Selected = false;
//        for (int j = 0; j < dataGridView1.ColumnCount; j++)
//            if (dataGridView1.Rows[i].Cells[j].Value != null)
//            {
//                if (toolStripTextBox2.Text != " " || toolStripTextBox2.Text != String.Empty)
//                {
//                    if (dataGridView1.Rows[i].Cells[j].Value.ToString().ToLower().Contains(toolStripTextBox2.Text.ToLower()))
//                    {
//                        if (!dataGridView1.Rows[i].Visible)
//                        {
//                            dataGridView1.Rows[i].Visible = true;
//                        }
//                        dataGridView1.Rows[i].Selected = true;
//                        break;
//                    }
//                }
//            }
//    }

//    for (int i = 0; i < dataGridView1.RowCount; i++)// а тут, делаем невидимыми все остальные 
//    {
//        if (dataGridView1.Rows[i].Selected != true)
//        {
//            dataGridView1.CurrentCell = null;
//            if (dataGridView1.Rows[i].Cells[0].Value != null)
//            {

//                dataGridView1.Rows[i].Visible = false;
//            }

//        }


//    }