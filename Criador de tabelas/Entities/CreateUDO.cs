using System;
using System.IO;
using System.Windows.Forms;
using CriadorTabelas.Entities;
using SAPbobsCOM;


namespace CriadorTabelas
{
    class CreateUDO
    {
        StreamWriter sw = new StreamWriter("C:\\LogCriadorUDO.txt");
        public Company oCompany = new Company();
        UserObjectsMD oUserObjectsMD;
        private int lRetCode;
        public ConnectionDB oConnectionDB { get; set; } = new ConnectionDB();

        public void CreateUDOSAP()
        {
            try
            {
                oConnectionDB.OpenConnection();
                oUserObjectsMD = (UserObjectsMD)ConnectionDB.oCompany.GetBusinessObject(BoObjectTypes.oUserObjectsMD);
                
                oUserObjectsMD.Code = "SOCONF";
                oUserObjectsMD.Name = "SO: Configuração SO Solutions";
                oUserObjectsMD.ObjectType = BoUDOObjType.boud_MasterData;
                oUserObjectsMD.TableName = "SOCONF";
                oUserObjectsMD.CanDelete = BoYesNoEnum.tNO;
                oUserObjectsMD.CanLog = BoYesNoEnum.tYES;
                lRetCode = oUserObjectsMD.Add();
                ExceptionError(lRetCode, oUserObjectsMD);

                oUserObjectsMD.Code = "MERCADDESC";
                oUserObjectsMD.Name = "SO: Cadastro desconto";
                oUserObjectsMD.ObjectType = BoUDOObjType.boud_MasterData;
                oUserObjectsMD.TableName = "MERCADDESC";
                oUserObjectsMD.CanDelete = BoYesNoEnum.tNO;
                oUserObjectsMD.CanLog = BoYesNoEnum.tYES;
                lRetCode = oUserObjectsMD.Add();                              

                ExceptionError(lRetCode, oUserObjectsMD);

                System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserObjectsMD);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                sw.Close();
                oConnectionDB.CloseConnection();
                MessageBox.Show("Processo de criação finalizado.");
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void ExceptionError(int lretcode, UserObjectsMD oUserObjectsMD)
        {
            int errorCode = lretcode;
            string errorMsg;

            switch (errorCode)
            {
                case 0:
                    sw.WriteLine($"[Sucesso] - Objeto: {oUserObjectsMD.Name} criado com sucesso.");
                    break;

                case -2035:
                    sw.WriteLine($"[Aviso] - Objeto: {oUserObjectsMD.Name}, já existe na base de dados.");
                    break;

                case -5002:
                    sw.WriteLine($"[Aviso] - Objeto: {oUserObjectsMD.Name}, já existe na base de dados.");
                    break;

                default:
                    oCompany.GetLastError(out errorCode, out errorMsg);
                    sw.WriteLine($"[Erro]: {errorCode}, Mensagem: {errorMsg}");
                    break;
            }

        }
    }
}
