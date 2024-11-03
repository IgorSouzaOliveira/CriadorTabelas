using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace CriadorTabelas.Entities
{
    public class ExecuteQuerySQL
    {

        public ExecuteQuerySQL()
        {
        }

        private string connectionString;
        public void Connection()
        {
            SqlConnection cnn;

            try
            {
                string directory = AppDomain.CurrentDomain.BaseDirectory;
                string path = Path.Combine(directory, $"Config\\Config.xml");

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(path);

                var dataSource = xmlDoc.GetElementsByTagName("ServerDB")[0].InnerText;
                var dataBase = xmlDoc.GetElementsByTagName("CompanyDB")[0].InnerText;
                var userDB = xmlDoc.GetElementsByTagName("UserDB")[0].InnerText;
                var passwordDB = xmlDoc.GetElementsByTagName("PasswordDB")[0].InnerText;

                connectionString = $@"Data Source={dataSource};Initial Catalog={dataBase};User ID={userDB};Password={passwordDB}";

                cnn = new SqlConnection(connectionString);

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void CreateProc()
        {
            Connection();

            string[] procedure = { Resources.Resource.BONE_ExecAprov };

            foreach (string procedures in procedure)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand Query = new SqlCommand(procedures, connection);
                        Query.ExecuteNonQuery();

                        string queryLastCreatedProcedure = "SELECT TOP 1 ROUTINE_NAME FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE = 'PROCEDURE' ORDER BY CREATED DESC";
                        using (SqlCommand command = new SqlCommand(queryLastCreatedProcedure, connection))
                        {
                            string lastCreatedProcedure = (string)command.ExecuteScalar();
                            LogCreate.Log($"[Sucesso] - Procedure: {lastCreatedProcedure} criada com sucesso.");
                        }

                        connection.Close();
                    }

                }
                catch (SqlException ex)
                {
                    LogCreate.Log($"[Erro] - {ex.Message}.");
                }
            }
        }

    }
}
