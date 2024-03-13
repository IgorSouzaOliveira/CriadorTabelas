using SAPbobsCOM;
using System.Windows.Forms;

namespace CriadorTabelas.Entities
{
    class ConnectionDB
    {
        public static Company oCompany = new Company();
        private long RetCode;
        public ConnectionDB()
        {

        }

        public void OpenConnection()
        {
            /* Dados de conexão - HOMOLOGAÇÃO */
            oCompany.Server = "DESKTOP-HONU6IK";
            oCompany.CompanyDB = "SBODemoBR";
            oCompany.UserName = "manager";
            oCompany.Password = "manager";
            oCompany.language = BoSuppLangs.ln_Portuguese_Br;
            oCompany.DbServerType = BoDataServerTypes.dst_MSSQL2019;
            oCompany.DbUserName = "sa";
            oCompany.DbPassword = "x1234";
            oCompany.LicenseServer = "DESKTOP-HONU6IK";

            /*
             * Dados de conexão - PRODUÇÃO 
             */

            //oCompany.Server = "srv-sap-hmlg01";
            //oCompany.CompanyDB = "SBOPRODMR";
            //oCompany.UserName = "manager";
            //oCompany.Password = "lago287";
            //oCompany.language = BoSuppLangs.ln_Portuguese_Br;
            //oCompany.DbServerType = BoDataServerTypes.dst_MSSQL2019;
            //oCompany.DbUserName = "sa";
            //oCompany.DbPassword = "mar&rio287";
            //oCompany.LicenseServer = "srv-sap-hmlg01";

            RetCode = oCompany.Connect();

            if (RetCode != 0)
            {
                int errorCode;
                string errorMsg;
                oCompany.GetLastError(out errorCode, out errorMsg);
                MessageBox.Show($"[Erro]: {errorCode}, Mensagem: {errorMsg}");
            }
        }

        public void CloseConnection()
        {
            oCompany.Disconnect();
        }

    }


}
