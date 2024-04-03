using System;
using System.IO;
using System.Windows.Forms;
using CriadorTabelas.Entities;
using SAPbobsCOM;


namespace CriadorTabelas
{
    class CreateUDO : ConnectionDB
    {
        private int lRetCode;

        public void CreateUDOSAP()
        {
            try
            {
                OpenConnection();
                UserObjectsMD oUserObjectsMD = null;
                oUserObjectsMD = (UserObjectsMD)oCompany.GetBusinessObject(BoObjectTypes.oUserObjectsMD);

                System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserObjectsMD);
                oUserObjectsMD = null;
                GC.Collect();
                oUserObjectsMD = (UserObjectsMD)oCompany.GetBusinessObject(BoObjectTypes.oUserObjectsMD);

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
                oUserObjectsMD = null;
                GC.Collect();
                CloseConnection();

            }
            catch (Exception)
            {

                throw;
            }

        }
        private void ExceptionError(int lretcode, UserObjectsMD oUserObjectsMD)
        {
            LogCreate oLogCreate = new LogCreate();

            int errorCode = lretcode;
            string errorMsg;

            switch (errorCode)
            {
                case 0:
                    oLogCreate.Log($"[Sucesso] - Objeto: {oUserObjectsMD.Name} criado com sucesso.");
                    break;

                case -2035:
                    oLogCreate.Log($"[Aviso] - Objeto: {oUserObjectsMD.Name}, já existe na base de dados.");
                    break;

                case -5002:
                    oLogCreate.Log($"[Aviso] - Objeto: {oUserObjectsMD.Name}, já existe na base de dados.");
                    break;

                default:
                    oCompany.GetLastError(out errorCode, out errorMsg);
                    oLogCreate.Log($"[Erro]: {errorCode}, Mensagem: {errorMsg}");
                    break;
            }

        }
    }
}
