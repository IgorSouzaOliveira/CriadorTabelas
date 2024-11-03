using SAPbobsCOM;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace CriadorTabelas.Entities
{
    public class SAPService
    {
        public static Company oCompany = new Company();
        public static void OpenConnection()
        {
            try
            {

                string directory = AppDomain.CurrentDomain.BaseDirectory;
                string path = Path.Combine(directory, $"Config\\Config.xml");
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(path);

                oCompany.SLDServer = xmlDoc.GetElementsByTagName("SLDServer")[0].InnerText;
                oCompany.Server = xmlDoc.GetElementsByTagName("Server")[0].InnerText;
                oCompany.CompanyDB = xmlDoc.GetElementsByTagName("CompanyDB")[0].InnerText;
                oCompany.UserName = xmlDoc.GetElementsByTagName("UserName")[0].InnerText;
                oCompany.Password = xmlDoc.GetElementsByTagName("Password")[0].InnerText;
                oCompany.language = BoSuppLangs.ln_Portuguese_Br;
                oCompany.DbServerType = BoDataServerTypes.dst_MSSQL2019;

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
