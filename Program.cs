using Course_Work_aplication.Client;
using Course_Work_aplication.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work_aplication
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Form());

            //Application.Run(new Client_Form());
            //Application.Run(new Order_Form());
            //Application.Run(new AddDataOrder());
            //Application.Run(new SearchDataOrder_Client());


            //Application.Run(new ChangeDataStaff());

            //Application.Run(new ChangeDataClient());
        }
    }
}
