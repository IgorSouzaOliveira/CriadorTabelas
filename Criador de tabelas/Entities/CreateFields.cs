using System;
using System.IO;
using System.Windows.Forms;
using CriadorTabelas.Entities;
using SAPbobsCOM;

namespace CriadorTabelas
{
    class CreateFields
    {
        private Company oCompany = new Company();
        
        private int lRetCode;
        public ConnectionDB oConnectionDB { get; set; } = new ConnectionDB();
        public void CreateFieldsSAP()
        {
            oConnectionDB.OpenConnection();
            UserFieldsMD oUserFieldsMD = null;
            oUserFieldsMD = (UserFieldsMD)ConnectionDB.oCompany.GetBusinessObject(BoObjectTypes.oUserFields);

            System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserFieldsMD);
            oUserFieldsMD = null;
            GC.Collect();
            oUserFieldsMD = (UserFieldsMD)ConnectionDB.oCompany.GetBusinessObject(BoObjectTypes.oUserFields);

            try
            {

                /* Table: @SOCONF */
                oUserFieldsMD.TableName = "@SOCONF";
                oUserFieldsMD.Name = "SO_UtilizaAprovacaoPed";
                oUserFieldsMD.Description = "Utiliza Aprovação Ped";
                oUserFieldsMD.Type = BoFieldTypes.db_Alpha;
                oUserFieldsMD.Size = 10;

                lRetCode = oUserFieldsMD.Add();

                ExceptionError(lRetCode, oUserFieldsMD);

                /* Table: @SOAPROVPED */

                oUserFieldsMD.TableName = "@SOAPROVPED";
                oUserFieldsMD.Name = "DocEntry";
                oUserFieldsMD.Description = "Pedido";
                oUserFieldsMD.Type = BoFieldTypes.db_Alpha;
                oUserFieldsMD.Size = 25;

                lRetCode = oUserFieldsMD.Add();

                ExceptionError(lRetCode, oUserFieldsMD);

                oUserFieldsMD = (UserFieldsMD)ConnectionDB.oCompany.GetBusinessObject(BoObjectTypes.oUserFields);
                oUserFieldsMD.TableName = "@SOAPROVPED";
                oUserFieldsMD.Name = "Id";
                oUserFieldsMD.Description = "Id";
                oUserFieldsMD.Type = BoFieldTypes.db_Numeric;
                oUserFieldsMD.EditSize = 10;

                lRetCode = oUserFieldsMD.Add();

                ExceptionError(lRetCode, oUserFieldsMD);

                oUserFieldsMD.TableName = "@SOAPROVPED";
                oUserFieldsMD.Name = "Modelo";
                oUserFieldsMD.Description = "Modelo Aprovação";
                oUserFieldsMD.Type = BoFieldTypes.db_Alpha;
                oUserFieldsMD.Size = 50;

                lRetCode = oUserFieldsMD.Add();

                ExceptionError(lRetCode, oUserFieldsMD);

                oUserFieldsMD = (UserFieldsMD)ConnectionDB.oCompany.GetBusinessObject(BoObjectTypes.oUserFields);
                oUserFieldsMD.TableName = "@SOAPROVPED";
                oUserFieldsMD.Name = "QtdAprov";
                oUserFieldsMD.Description = "Quantidade aprovada";
                oUserFieldsMD.Type = BoFieldTypes.db_Numeric;
                oUserFieldsMD.EditSize = 10;

                lRetCode = oUserFieldsMD.Add();

                ExceptionError(lRetCode, oUserFieldsMD);

                oUserFieldsMD = (UserFieldsMD)ConnectionDB.oCompany.GetBusinessObject(BoObjectTypes.oUserFields);
                oUserFieldsMD.TableName = "@SOAPROVPED";
                oUserFieldsMD.Name = "QtdReprov";
                oUserFieldsMD.Description = "Quantidade Reprovada";
                oUserFieldsMD.Type = BoFieldTypes.db_Numeric;
                oUserFieldsMD.EditSize = 10;

                lRetCode = oUserFieldsMD.Add();

                ExceptionError(lRetCode, oUserFieldsMD);

                oUserFieldsMD = (UserFieldsMD)ConnectionDB.oCompany.GetBusinessObject(BoObjectTypes.oUserFields);
                oUserFieldsMD.TableName = "@SOAPROVPED";
                oUserFieldsMD.Name = "Autor";
                oUserFieldsMD.Description = "Autor";
                oUserFieldsMD.Type = BoFieldTypes.db_Numeric;
                oUserFieldsMD.EditSize = 10;

                lRetCode = oUserFieldsMD.Add();

                ExceptionError(lRetCode, oUserFieldsMD);

                oUserFieldsMD = (UserFieldsMD)ConnectionDB.oCompany.GetBusinessObject(BoObjectTypes.oUserFields);
                oUserFieldsMD.TableName = "@SOAPROVPED";
                oUserFieldsMD.Name = "Aprovador";
                oUserFieldsMD.Description = "Aprovador";
                oUserFieldsMD.Type = BoFieldTypes.db_Numeric;
                oUserFieldsMD.EditSize = 10;

                lRetCode = oUserFieldsMD.Add();

                ExceptionError(lRetCode, oUserFieldsMD);

                oUserFieldsMD.TableName = "@SOAPROVPED";
                oUserFieldsMD.Name = "Querie";
                oUserFieldsMD.Description = "Querie";
                oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha;
                oUserFieldsMD.Size = 200;

                lRetCode = oUserFieldsMD.Add();

                ExceptionError(lRetCode, oUserFieldsMD);

                oUserFieldsMD.TableName = "@SOAPROVPED";
                oUserFieldsMD.Name = "Resultado";
                oUserFieldsMD.Description = "Resultado";
                oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha;
                oUserFieldsMD.Size = 10;

                lRetCode = oUserFieldsMD.Add();

                ExceptionError(lRetCode, oUserFieldsMD);

                oUserFieldsMD.TableName = "@SOAPROVPED";
                oUserFieldsMD.Name = "Autorizado";
                oUserFieldsMD.Description = "Flag";
                oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha;
                oUserFieldsMD.Size = 50;

                lRetCode = oUserFieldsMD.Add();

                ExceptionError(lRetCode, oUserFieldsMD);

                oUserFieldsMD.TableName = "@SOAPROVPED";
                oUserFieldsMD.Name = "DataLib";
                oUserFieldsMD.Description = "Data liberacao";
                oUserFieldsMD.Type = BoFieldTypes.db_Date;

                lRetCode = oUserFieldsMD.Add();

                ExceptionError(lRetCode, oUserFieldsMD);

                oUserFieldsMD.TableName = "@SOAPROVPED";
                oUserFieldsMD.Name = "HoraLib";
                oUserFieldsMD.Description = "Hora liberacao";
                oUserFieldsMD.Type = BoFieldTypes.db_Date;
                oUserFieldsMD.SubType = BoFldSubTypes.st_Time;

                lRetCode = oUserFieldsMD.Add();

                ExceptionError(lRetCode, oUserFieldsMD);

                oUserFieldsMD = (UserFieldsMD)ConnectionDB.oCompany.GetBusinessObject(BoObjectTypes.oUserFields);
                oUserFieldsMD.TableName = "@SOAPROVPED";
                oUserFieldsMD.Name = "DocType";
                oUserFieldsMD.Description = "Tipo do documento";
                oUserFieldsMD.Type = BoFieldTypes.db_Alpha;
                oUserFieldsMD.Size = 50;

                lRetCode = oUserFieldsMD.Add();

                ExceptionError(lRetCode, oUserFieldsMD);

                oUserFieldsMD = (UserFieldsMD)ConnectionDB.oCompany.GetBusinessObject(BoObjectTypes.oUserFields);
                oUserFieldsMD.TableName = "@SOAPROVPED";
                oUserFieldsMD.Name = "Etapa";
                oUserFieldsMD.Description = "Etapa aprovação";
                oUserFieldsMD.Type = BoFieldTypes.db_Alpha;
                oUserFieldsMD.Size = 200;

                lRetCode = oUserFieldsMD.Add();

                ExceptionError(lRetCode, oUserFieldsMD);

                oUserFieldsMD = (UserFieldsMD)ConnectionDB.oCompany.GetBusinessObject(BoObjectTypes.oUserFields);
                oUserFieldsMD.TableName = "@SOAPROVPED";
                oUserFieldsMD.Name = "Texto";
                oUserFieldsMD.Description = "Texto";
                oUserFieldsMD.Type = BoFieldTypes.db_Alpha;
                oUserFieldsMD.Size = 200;

                lRetCode = oUserFieldsMD.Add();

                ExceptionError(lRetCode, oUserFieldsMD);

                oUserFieldsMD = (UserFieldsMD)ConnectionDB.oCompany.GetBusinessObject(BoObjectTypes.oUserFields);
                oUserFieldsMD.TableName = "@SOAPROVPED";
                oUserFieldsMD.Name = "OrdemEtapa";
                oUserFieldsMD.Description = "Ordem etapa";
                oUserFieldsMD.Type = BoFieldTypes.db_Numeric;
                oUserFieldsMD.EditSize = 10;

                lRetCode = oUserFieldsMD.Add();

                ExceptionError(lRetCode, oUserFieldsMD);

                oUserFieldsMD.TableName = "@SOAPROVPED";
                oUserFieldsMD.Name = "StatusEtapa";
                oUserFieldsMD.Description = "Status Etapa";
                oUserFieldsMD.Type = BoFieldTypes.db_Alpha;
                oUserFieldsMD.Size = 50;

                lRetCode = oUserFieldsMD.Add();

                ExceptionError(lRetCode, oUserFieldsMD);

                /* Campos do form: FormCadDesc */

                oUserFieldsMD.TableName = "@MERLCADDESC";
                oUserFieldsMD.Name = "Mr_CodRep";
                oUserFieldsMD.Description = "Código do Representante";
                oUserFieldsMD.Type = BoFieldTypes.db_Numeric;
                oUserFieldsMD.EditSize = 11;
                lRetCode = oUserFieldsMD.Add();

                ExceptionError(lRetCode, oUserFieldsMD);

                /* Table: OWTM 
                  Campo de usuário para ativar aprovação do SO Solutions na tela: Modelos de autorização
                */

                oUserFieldsMD.TableName = "OWTM";
                oUserFieldsMD.Type = BoFieldTypes.db_Alpha;
                oUserFieldsMD.SubType = BoFldSubTypes.st_None;
                oUserFieldsMD.Size = 30;
                oUserFieldsMD.Name = "UtilizarSoSolutions";
                oUserFieldsMD.Description = "Utilizar SO Solutions ?";
                oUserFieldsMD.EditSize = 30;
                oUserFieldsMD.ValidValues.Add();
                oUserFieldsMD.ValidValues.SetCurrentLine(0);
                oUserFieldsMD.ValidValues.Value = "S";
                oUserFieldsMD.ValidValues.Description = "Sim";
                oUserFieldsMD.ValidValues.Add();
                oUserFieldsMD.ValidValues.SetCurrentLine(1);
                oUserFieldsMD.ValidValues.Value = "N";
                oUserFieldsMD.ValidValues.Description = "Não";
                lRetCode = oUserFieldsMD.Add();

                ExceptionError(lRetCode, oUserFieldsMD);

            }
            catch (Exception)
            {

                throw;
            }

            System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserFieldsMD);
            oUserFieldsMD = null;
            GC.Collect();            
            oConnectionDB.CloseConnection();            
        }

        private void ExceptionError(int lretcode, UserFieldsMD oUserFieldsMD)
        {
            LogCreate oLogCreate = new LogCreate();

            int errorCode = lretcode;
            string errorMsg;

            switch (errorCode)
            {
                case 0:
                    oLogCreate.Log($"[Sucesso] - Campo: {oUserFieldsMD.Name} criado com sucesso.");
                    break;

                case -2035:
                    oLogCreate.Log($"[Aviso] - Campo: {oUserFieldsMD.Name}, já existe na base de dados.");
                    break;

                case -5002:
                    oLogCreate.Log($"[Aviso] - Campo: {oUserFieldsMD.Name}, já existe na base de dados.");
                    break;

                default:
                    oCompany.GetLastError(out errorCode, out errorMsg);
                    oLogCreate.Log($"[Erro]: {errorCode}, Mensagem: {errorMsg}");
                    break;
            }

        }
    }
}
