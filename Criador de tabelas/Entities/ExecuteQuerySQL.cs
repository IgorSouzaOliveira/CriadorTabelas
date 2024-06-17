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
        LogCreate oLogCreate = new LogCreate();

        public void Connection()
        {
            SqlConnection cnn;

            try
            {
                string directory = AppDomain.CurrentDomain.BaseDirectory;
                string path = Path.Combine(directory, $"Config\\Config.xml");

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(path);

                XmlNodeList xnList = xmlDoc.GetElementsByTagName("ConnectionData");

                foreach (XmlNode xn in xnList)
                {
                    var dataSource = xn["ServerDB"].InnerText;
                    var dataBase = xn["CompanyDB"].InnerText;
                    var userDB = xn["UserDB"].InnerText;
                    var passwordDB = xn["PasswordDB"].InnerText;

                    connectionString = $@"Data Source={dataSource};Initial Catalog={dataBase};User ID={userDB};Password={passwordDB}";

                }


                
                
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
            List<string> createdProcedures = new List<string>();

            foreach (string procedures in procedure)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand Query = new SqlCommand(procedures, connection);
                        Query.ExecuteNonQuery();

                        // Consulta para recuperar o nome da última procedure criada
                        string queryLastCreatedProcedure = "SELECT TOP 1 ROUTINE_NAME FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE = 'PROCEDURE' ORDER BY CREATED DESC";
                        using (SqlCommand command = new SqlCommand(queryLastCreatedProcedure, connection))
                        {
                            string lastCreatedProcedure = (string)command.ExecuteScalar();
                            createdProcedures.Add(lastCreatedProcedure); // Adiciona o nome da procedure criada à lista                           
                        }

                        connection.Close();
                    }

                }
                catch (SqlException ex)
                {
                    LogCreate.Log($"[Erro] - {ex.Message}.");
                }
            }

            foreach (string procedureName in createdProcedures)
            {
                LogCreate.Log($"[Sucesso] - Procedure: {procedureName} criada com sucesso.");
            }

        }

    }
}
