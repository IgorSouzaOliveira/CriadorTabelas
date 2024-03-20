using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            try
            {
                SqlConnection cnn;
                connectionString = @"Data Source=DESKTOP-HONU6IK;Initial Catalog=SBODemoBR;User ID=sa;Password=x1234";
                cnn = new SqlConnection(connectionString);

            }
            catch (SqlException error)
            {

                MessageBox.Show(error.Message);
            }
        }

        public void CloseConnection()
        {
        }

        public void CreateProc()
        {
            Connection();

            string[] procedure = { Resources.Resource.SO_ExecutaAprovacao_proc, Resources.Resource.SO_Soluções };
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
                catch (SqlException error)
                {
                    oLogCreate.Log($"[Erro] - {error.Message}.");
                }
            }

            foreach (string procedureName in createdProcedures)
            {
                oLogCreate.Log($"[Sucesso] - Procedure {procedureName} criada com suceso.");
            }

        }

    }
}
