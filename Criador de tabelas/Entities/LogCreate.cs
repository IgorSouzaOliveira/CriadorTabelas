using System;
using System.IO;

namespace CriadorTabelas.Entities
{
    public class LogCreate
    {

        public LogCreate()
        {

        }

        const string path = @"C:\LogDeCriação.txt";

        public static void Log(string swLog)
        {

            try
            {
                var file = File.AppendText(path);
                file.WriteLine($"{DateTime.Now} - {swLog}");
                file.Close();

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
