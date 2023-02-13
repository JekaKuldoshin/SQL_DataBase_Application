using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work_aplication
{
    public partial class AddDataStaff : Form
    {
        public AddDataStaff()
        {
            InitializeComponent();
        }

        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (MessageBox.Show("Закрыть?", "Message", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
        //        e.Cancel = true;
        //    else
        //        e.Cancel = false;
        //}

        //   private void AddDataStaff_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        //   {
        //       DialogResult dialog = MessageBox.Show(
        // "Вы действительно хотите выйти из программы?",
        // "Завершение программы",
        // MessageBoxButtons.YesNo,
        // MessageBoxIcon.Warning
        //);
        //       if (dialog == DialogResult.Yes)
        //       {
        //           e.Cancel = true;
        //       }
        //       else
        //       {
        //           this.Close();
        //           this.Dispose();
        //           Staff_Form f = new Staff_Form();
        //           f.ShowDialog();
        //           e.Cancel = false;
        //       }



        //   }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.dataSet1.Staff);
            staffBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            staffBindingSource.EndEdit();
            staffTableAdapter.Update(dataSet1);

            DialogResult dialog = MessageBox.Show(
        "Ваши данные сформированны. Продолжить запись данных?",
        "Успех",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning
       );
            if (dialog == DialogResult.Yes)
            {
                staffBindingSource.AddNew();
            }
            else
            {
                this.Close();
            }

            
        }

        private void AddDataStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            //    DialogResult dialog = MessageBox.Show(
            // "Вы действительно хотите выйти?",
            // "Завершение программы",
            // MessageBoxButtons.YesNo,
            // MessageBoxIcon.Warning
            //);
            //    if (dialog == DialogResult.Yes)
            //    {
            //        e.Cancel = false;
            //        Staff_Form f = new Staff_Form();
            //        f.ShowDialog();
            //    }
            //    else
            //    {

            //        e.Cancel = true;
            //    }

            e.Cancel = false;
            Staff_Form f = new Staff_Form();
            f.Left = this.Left;
            f.Top = this.Top;
            f.Show();
            this.Hide();
            
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
        "Для расшифровки значений нажмите i, правее от поля выбора",
        "Справка",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
       );
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
   "   ID для сотрудника заполняется автоматически, ввод заблокирован.",
   "ID",
   MessageBoxButtons.OK,
   MessageBoxIcon.Information
  );
        }

        private void staffIDTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void staff_surnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (staffIDTextBox.Text.Length == 0 | staff_surnameTextBox.Text.Length == 0 | staff_initialsTextBox.Text.Length == 0 | staff_genderTextBox.Text.Length == 0 | salaryTextBox.Text.Length == 0)
            {
                button1.Enabled = false;
            }
            else button1.Enabled = true;
        }

        private void staff_initialsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (staffIDTextBox.Text.Length == 0 | staff_surnameTextBox.Text.Length == 0 | staff_initialsTextBox.Text.Length == 0 | staff_genderTextBox.Text.Length == 0 | salaryTextBox.Text.Length == 0)
            {
                button1.Enabled = false;
            }
            else button1.Enabled = true;
        }

        private void staff_genderTextBox_TextChanged(object sender, EventArgs e)
        {
            if (staffIDTextBox.Text.Length == 0 | staff_surnameTextBox.Text.Length == 0 | staff_initialsTextBox.Text.Length == 0 | staff_genderTextBox.Text.Length == 0 | salaryTextBox.Text.Length == 0)
            {
                button1.Enabled = false;
            }
            else button1.Enabled = true;
        }

        private void citiesIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            citiesIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void postIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            postIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void branchIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            branchIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void salaryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (staffIDTextBox.Text.Length == 0 | staff_surnameTextBox.Text.Length == 0 | staff_initialsTextBox.Text.Length == 0 | staff_genderTextBox.Text.Length == 0 | salaryTextBox.Text.Length == 0)
            {
                button1.Enabled = false;
            }
            else button1.Enabled = true;
        }

        
    }
}
//insert into Branch(CitiesID, Branch_name) values(1, N'JK-Fast&Clean - Ха. (Проспект Гагарина 110в.)')
//insert into Branch(CitiesID, Branch_name) values(1, N'JK-Fast&Clean - Ха. (Пушкинская 39а.)')

//insert into Branch(CitiesID, Branch_name) values(2, N'JK-Fast&Clean - Ки. (Проспект Льва Ландау 21г.)')
//insert into Branch(CitiesID, Branch_name) values(2, N'JK-Fast&Clean - Ки. (ул. Машиниста 10.)')
//insert into Branch(CitiesID, Branch_name) values(2, N'JK-Fast&Clean - Ки. (ул. Валентины 30г.)')

//insert into Branch(CitiesID, Branch_name) values(3, N'JK-Fast&Clean - Од. (ул. Моисея 44.)')
//insert into Branch(CitiesID, Branch_name) values(3, N'JK-Fast&Clean - Од. (ул. Урицкого 101.)')

//insert into Branch(CitiesID, Branch_name) values(4, N'JK-Fast&Clean - Ль. (ул. Западная 22.)')

//insert into Branch(CitiesID, Branch_name) values(5, N'JK-Fast&Clean - Дн. (ул. Вокзальная 85.)')
