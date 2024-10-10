using CriadorTabelas.Entities;
using System;
using System.IO;
using System.Windows.Forms;

namespace CriadorTabelas
{
    static class Program
    {                   
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CommonBase.OpenConnection();
            Application.Run(new UserLogin());
                       
        }
    }
}
