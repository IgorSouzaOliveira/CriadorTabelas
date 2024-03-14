using System;
using System.IO;
using System.Windows.Forms;

namespace CriadorTabelas
{
    static class Program
    {

        public static SAPbobsCOM.Company oCompany = null;
        public static SAPbouiCOM.Application Sbo_App = null;
                    
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {   
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserLogin());
                       
        }
    }
}
