using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuDestinatario
{
 
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// 
        /// 
        /// </summary>
        ///         

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var login = new Configuracao.Login();
            string user = "";

            while (true)
            {
                login.ShowDialog();
                if (login.DialogResult == DialogResult.OK)
                {
                    user = login.userAtivo;
                    Application.Run(new Home(user));
                    break;
                }
                if(login.DialogResult == DialogResult.Abort)
                {
                    break;
                }
            }
        }
    }
}
