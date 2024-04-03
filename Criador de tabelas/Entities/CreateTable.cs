using CriadorTabelas.Entities;
using SAPbobsCOM;
using System;
using System.IO;
using System.Windows.Forms;

namespace CriadorTabelas
{
    class CreateTable : ConnectionDB
    {
        private int lRetCode;

        public void CreateTableSAP()
        {
            OpenConnection();
            UserTablesMD oUserTablesMD = null;
            oUserTablesMD = (UserTablesMD)oCompany.GetBusinessObject(BoObjectTypes.oUserTables);

            System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserTablesMD);
            oUserTablesMD = null;
            GC.Collect();
            oUserTablesMD = (UserTablesMD)oCompany.GetBusinessObject(BoObjectTypes.oUserTables);

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
            CloseConnection();

        }
        private void ExceptionError(int lretcode, UserTablesMD oUserTablesMD)
        {
            LogCreate oLogCreate = new LogCreate();

            int errorCode = lretcode;
            string errorMsg;

            switch (errorCode)
            {
                case 0:
                    oLogCreate.Log($"[Sucesso] - Tabela: [@{oUserTablesMD.TableName}] criada com sucesso.");
                    break;

                case -2035:
                    oLogCreate.Log($"[Aviso] - Tabela: [@{oUserTablesMD.TableName}], já existe na base de dados.");
                    break;

                case -5002:
                    oLogCreate.Log($"[Aviso] - Campo: [@{oUserTablesMD.TableName}], já existe na base de dados.");
                    break;

                default:
                    oCompany.GetLastError(out errorCode, out errorMsg);
                    oLogCreate.Log($"[Erro]: {errorCode}, Mensagem: {errorMsg}");
                    break;
            }
        }
    }
}
