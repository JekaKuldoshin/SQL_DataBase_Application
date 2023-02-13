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
    public partial class AddDataClient : Form
    {
        public AddDataClient()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void AddDataClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.dataSet1.Client);
            clientBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientBindingSource.EndEdit();
            clientTableAdapter.Update(dataSet1);

            DialogResult dialog = MessageBox.Show(
        "Ваши данные сформированны. Продолжить запись данных?",
        "Успех",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning
       );
            if (dialog == DialogResult.Yes)
            {
                clientBindingSource.AddNew();
            }
            else
            {
                this.Close();
            }
        }

        private void AddDataClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            Client_Form f = new Client_Form();
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
   "   ID для клиента заполняется автоматически, ввод заблокирован.",
   "ID",
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
       "   Тип клиента:\n\n   1  -  Физическое лицо\n   2  -  Юридическое лицо",
       "Тип клиента",
       MessageBoxButtons.OK,
       MessageBoxIcon.Information
      );
        }

       

        
    }
}
