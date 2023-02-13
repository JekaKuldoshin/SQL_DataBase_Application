using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.OleDb;
using Course_Work_aplication.Client;
using Course_Work_aplication.Order.Search;
using Course_Work_aplication.Order.Search.Kharkov;
using Course_Work_aplication.Order.Search.Kiev;
using Course_Work_aplication.Order.Search.Lviv;
using Course_Work_aplication.Order.Search.Odessa;
using Course_Work_aplication.Order.Search.Dnepr;

namespace Course_Work_aplication.Order
{
    public partial class AddDataOrder : Form
    {
        public AddDataOrder()
        {
            InitializeComponent();
        }

        private void order_clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.order_clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void AddDataOrder_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet11.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.dataSet11.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet11.Order_client". При необходимости она может быть перемещена или удалена.
            this.order_clientTableAdapter.Fill(this.dataSet11.Order_client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet11.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.dataSet11.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Information_only_Cleaner". При необходимости она может быть перемещена или удалена.
            this.information_only_CleanerTableAdapter.Fill(this.dataSet1.Information_only_Cleaner);
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


            order_clientBindingSource.AddNew();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            order_clientBindingSource.EndEdit();
            order_clientTableAdapter.Update(dataSet1);

            DialogResult dialog = MessageBox.Show(
        "Ваши данные сформированны. Продолжить запись данных?",
        "Успех",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning
       );
            if (dialog == DialogResult.Yes)
            {
                order_clientBindingSource.AddNew();
            }
            else
            {
                this.Close();
            }
        }

        private void AddDataOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            Order_Form f = new Order_Form();
            f.Left = this.Left;
            f.Top = this.Top;
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchDataOrder_Client a = new SearchDataOrder_Client();
            a.ShowDialog();

            if (string.IsNullOrWhiteSpace(a.textBox1.Text))
                return;

            var values = a.textBox1.Text;


            clientIDComboBox.Text = values;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = branchIDListBox.SelectedIndex;
       
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




            //SearchDataOrder_Staff a = new SearchDataOrder_Staff();
            //a.ShowDialog();

            
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
       "   Формирование заказа:\n\n   1.Поле ID присваивается автоматически.\n   2.Убедитесь что Ваш клиент заранее внесен в базу данных.\n   3.Можете выбрать вручную (по фамилии или id) или воспользоваться поиском для автоматического заполнения.\n   4.Заполните адрес выполнения заказа, распишите в деталях.\n   5.Выберите филиал для выполнения заказа, от данного выбора будет зависить выбор сотрудников (Клинеров).\n   5.Поле для выбора выполняющего заказа можно выбрать вручную (по фамилии или id сотрудника) или воспользоваться поиском для автоматического заполнения.\n   7.Выберите дату для проведения клининга.\n   8.Выберите пакет уборки.\n   9.По нажатию кнопки «Сохранить» в базу заноситься заказ.\n\n   Для расшифровки значений нажмите i, правее от поля выбора",
       "Справка",
       MessageBoxButtons.OK,
       MessageBoxIcon.Information
      );
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
        "   Выбор клиента:\n\n   1  -  Вручную (выбор со списка)\n   2  -  Автоматически (воспользуйтесь кнопкой «Поиск»)",
        "Поиск",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
        );
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                    "   Выбор сотрудника:\n\n   1  -  Вручную (выбор со списка)\n   2  -  Автоматически (воспользуйтесь кнопкой «Поиск»)",
                    "Поиск",
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
