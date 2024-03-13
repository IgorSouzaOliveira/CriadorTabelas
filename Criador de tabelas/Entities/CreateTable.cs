using CriadorTabelas.Entities;
using SAPbobsCOM;
using System;
using System.IO;
using System.Windows.Forms;

namespace CriadorTabelas
{
    class CreateTable
    {

        StreamWriter sw = new StreamWriter("C:\\LogCriadorTabelas.txt");
        private Company oCompany = new Company();
        UserTablesMD oUserTablesMD;
        private int lRetCode;
        public ConnectionDB oConnectionDB { get; set; } = new ConnectionDB();
        public void CreateTableSAP()
        {

            oConnectionDB.OpenConnection();
            oUserTablesMD = (UserTablesMD)ConnectionDB.oCompany.GetBusinessObject(BoObjectTypes.oUserTables);

            /* Tabela de configuraçao do Add-on*/

            oUserTablesMD.TableName = "SOCONF";
            oUserTablesMD.TableDescription = "SO:Configuração SOSolutions";
            oUserTablesMD.TableType = BoUTBTableType.bott_MasterData;
            lRetCode = oUserTablesMD.Add();
            ExceptionError(lRetCode, oUserTablesMD);

            /* Tabela de controle das aprovações */

            oUserTablesMD.TableName = "SOAPROVPED";
            oUserTablesMD.TableDescription = "SO: Aprovação de pedido";
            oUserTablesMD.TableType = BoUTBTableType.bott_NoObjectAutoIncrement;
            lRetCode = oUserTablesMD.Add();
            ExceptionError(lRetCode, oUserTablesMD);

            /* Tabela do form: Cadastro de desconto cabeçalho*/

            oUserTablesMD.TableName = "MERCADDESC";
            oUserTablesMD.TableDescription = "SO: Cadastro de desconto";
            oUserTablesMD.TableType = BoUTBTableType.bott_MasterData;
            lRetCode = oUserTablesMD.Add();
            ExceptionError(lRetCode, oUserTablesMD);

            /* Tabela do form: Cadastro de desconto linha */

            oUserTablesMD.TableName = "MERLCADDESC";
            oUserTablesMD.TableDescription = "SO: Cadastro de desconto linha";
            oUserTablesMD.TableType = BoUTBTableType.bott_MasterDataLines;
            lRetCode = oUserTablesMD.Add();
            ExceptionError(lRetCode, oUserTablesMD);

            System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserTablesMD);
            oUserTablesMD = null;
            GC.Collect();
            sw.Close();
            oConnectionDB.CloseConnection();
            MessageBox.Show("Processo de criação finalizado.");
        }
        private void ExceptionError(int lretcode, UserTablesMD oUserTablesMD)
        {
            int errorCode = lretcode;
            string errorMsg;

            switch (errorCode)
            {
                case 0:
                    MessageBox.Show($"[Sucesso] - Tabela: [@{oUserTablesMD.TableName}] criada com sucesso.");
                    break;

                case -2035:
                    MessageBox.Show($"[Aviso] - Tabela: [@{oUserTablesMD.TableName}], já existe na base de dados.");
                    break;

                case -5002:
                    MessageBox.Show($"[Aviso] - Campo: [@{oUserTablesMD.TableName}], já existe na base de dados.");
                    break;

                default:
                    oCompany.GetLastError(out errorCode, out errorMsg);
                    MessageBox.Show($"[Erro]: {errorCode}, Mensagem: {errorMsg}");
                    break;
            }
        }
    }
}
