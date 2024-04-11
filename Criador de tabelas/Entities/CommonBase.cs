using SAPbobsCOM;
using System;
using System.Windows.Forms;

namespace CriadorTabelas.Entities
{
    public class CommonBase
    {
        public static Company oCompany = new Company();    

        public static void OpenConnection()
        {
            try
            {
                /* ATENÇÃO - Dados de conexão - HOMOLOGAÇÃO */
                oCompany.SLDServer = "desktop-honu6ik:40000";
                oCompany.Server = "DESKTOP-HONU6IK";
                oCompany.CompanyDB = "SBODemoBR";
                oCompany.UserName = "manager";
                oCompany.Password = "manager";
                oCompany.language = BoSuppLangs.ln_Portuguese_Br;
                oCompany.DbServerType = BoDataServerTypes.dst_MSSQL2019;

                /*Dados de conexão - PRODUÇÃO */
                //oCompany.SLDServer = "desktop-honu6ik:40000";
                //oCompany.Server = "DESKTOP-HONU6IK";
                //oCompany.CompanyDB = "SBODemoBR";
                //oCompany.UserName = "manager";
                //oCompany.Password = "manager";
                //oCompany.language = BoSuppLangs.ln_Portuguese_Br;
                //oCompany.DbServerType = BoDataServerTypes.dst_MSSQL2019;

                Int32 lRet = oCompany.Connect();
                if (lRet != 0)
                    throw new Exception(oCompany.GetLastErrorDescription());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void CloseConnection()
        {
            oCompany.Disconnect();
        }

    }


}
