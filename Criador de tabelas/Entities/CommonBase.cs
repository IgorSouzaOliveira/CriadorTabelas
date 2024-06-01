using SAPbobsCOM;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace CriadorTabelas.Entities
{
    public class CommonBase
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

                XmlNodeList xnList = xmlDoc.GetElementsByTagName("ConnectionData");

                foreach (XmlNode xn in xnList)
                {
                    oCompany.SLDServer = xn["SLDServer"].InnerText;
                    oCompany.Server = xn["Server"].InnerText;
                    oCompany.CompanyDB = xn["CompanyDB"].InnerText;
                    oCompany.UserName = xn["UserName"].InnerText;
                    oCompany.Password = xn["Password"].InnerText;
                    oCompany.language = BoSuppLangs.ln_Portuguese_Br;
                    oCompany.DbServerType = BoDataServerTypes.dst_MSSQL2019;
                }   

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
