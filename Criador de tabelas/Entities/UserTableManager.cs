using SAPbobsCOM;
using System;
using System.Windows.Forms;
using TesteCriadorTabelas;

namespace CriadorTabelas.Entities
{
    public class UserTableManager : CommonBase
    {
        private UserTablesMD oUserTablesMD { get; set; } = null;
        private UserFieldsMD oUserFieldsMD { get; set; } = null;
        private UserObjectsMD oUserObjectsMD { get; set; } = null;

        private static formCriadorTabelas _form;
        private String Mensagem { get; set; }

        public UserTableManager(formCriadorTabelas criadorTabelas)
        {
            _form = criadorTabelas;
        }

        public void AddUserTable(string tableName, string tableDescription, BoUTBTableType tableType)
        {
            oUserTablesMD = oCompany.GetBusinessObject(BoObjectTypes.oUserTables);

            try
            {
                if (oUserTablesMD.GetByKey(tableName))
                {
                    oUserTablesMD.TableName = tableName;
                    oUserTablesMD.TableDescription = tableDescription;
                    oUserTablesMD.TableType = tableType;
                    oUserTablesMD.DisplayMenu = BoYesNoEnum.tNO;
                    int lRet = oUserTablesMD.Add();

                    if (lRet != 0)
                    {
                        throw new Exception(oCompany.GetLastErrorDescription());
                    }

                    LogCreate.Log($"Tabela: @{oUserTablesMD.TableName}, criado com sucesso.");
                    Mensagem = $"Tabela: @{oUserTablesMD.TableName}, criado com sucesso.";

                }
            }
            catch (Exception ex)
            {
                LogCreate.Log($"Tabela: @{oUserTablesMD.TableName} - {ex.Message}");
                Mensagem = $"Tabela: @{oUserTablesMD.TableName} - {ex.Message}";
            }
            finally
            {
                if (oUserTablesMD != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserTablesMD);
                }
            }

            _form.UpdateProgressWithText(Mensagem);

        }
        public void AddUserFields(string tableName, string name, string description, BoFieldTypes boFieldTypes, BoFldSubTypes boFldSubTypes, int size, int editSize)
        {
            oUserFieldsMD = oCompany.GetBusinessObject(BoObjectTypes.oUserFields);

            try
            {


                switch (boFieldTypes)
                {
                    case BoFieldTypes.db_Numeric:
                        oUserFieldsMD.TableName = tableName;
                        oUserFieldsMD.Name = name;
                        oUserFieldsMD.Description = description;
                        oUserFieldsMD.Type = boFieldTypes;
                        oUserFieldsMD.SubType = boFldSubTypes;
                        oUserFieldsMD.EditSize = editSize;
                        break;

                    default:
                        switch (tableName)
                        {
                            case "OUSG":
                                oUserFieldsMD.TableName = tableName;
                                oUserFieldsMD.Name = name;
                                oUserFieldsMD.Description = description;
                                oUserFieldsMD.Type = boFieldTypes;
                                oUserFieldsMD.SubType = boFldSubTypes;
                                oUserFieldsMD.Size = size;
                                oUserFieldsMD.ValidValues.Add();
                                oUserFieldsMD.ValidValues.SetCurrentLine(0);
                                oUserFieldsMD.ValidValues.Value = "S";
                                oUserFieldsMD.ValidValues.Description = "Sim";
                                oUserFieldsMD.ValidValues.Add();
                                oUserFieldsMD.ValidValues.SetCurrentLine(1);
                                oUserFieldsMD.ValidValues.Value = "N";
                                oUserFieldsMD.ValidValues.Description = "Não";
                                break;

                            default:
                                oUserFieldsMD.TableName = tableName;
                                oUserFieldsMD.Name = name;
                                oUserFieldsMD.Description = description;
                                oUserFieldsMD.Type = boFieldTypes;
                                oUserFieldsMD.SubType = boFldSubTypes;
                                oUserFieldsMD.Size = size;
                                break;
                        }
                        break;
                }


                int lRet = oUserFieldsMD.Add();

                if (lRet != 0)
                {
                    throw new Exception(CommonBase.oCompany.GetLastErrorDescription());
                }

                Mensagem = $"Campo: {oUserFieldsMD.Name}, criado com sucesso.";
                LogCreate.Log($"Campo: {oUserFieldsMD.Name}, criado com sucesso.");

            }
            catch (Exception ex)
            {
                LogCreate.Log($"Campo: {oUserFieldsMD.Name} - {ex.Message}");
                Mensagem = $"Campo: {oUserFieldsMD.Name} - {ex.Message}";
            }
            finally
            {
                if (oUserFieldsMD != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserFieldsMD);
                }
            }

            _form.UpdateProgressWithText(Mensagem);
        }
        public void AddUDO(string code, string name, BoUDOObjType boUDOObjType, string tableName, BoYesNoEnum boYesNoEnum, BoYesNoEnum boYesNoEnum1)
        {

            oUserObjectsMD = CommonBase.oCompany.GetBusinessObject(BoObjectTypes.oUserObjectsMD);

            try
            {
                oUserObjectsMD.Code = code;
                oUserObjectsMD.Name = name;
                oUserObjectsMD.ObjectType = boUDOObjType;
                oUserObjectsMD.TableName = tableName;
                oUserObjectsMD.CanDelete = boYesNoEnum;
                oUserObjectsMD.CanLog = boYesNoEnum1;

                int lRet = oUserObjectsMD.Add();

                if (lRet != 0)
                {
                    throw new Exception(CommonBase.oCompany.GetLastErrorDescription());
                }

                Mensagem = $"Objeto: {oUserObjectsMD.Name}, criado com sucesso.";
                LogCreate.Log($"Objeto: {oUserObjectsMD.Name}, criado com sucesso.");

            }
            catch (Exception ex)
            {
                Mensagem = $"Objeto: @{oUserObjectsMD.Name} - {ex.Message}";
                LogCreate.Log($"Objeto: @{oUserObjectsMD.Name} - {ex.Message}");
            }
            finally
            {
                if (oUserObjectsMD != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserObjectsMD);
                }
            }

            _form.UpdateProgressWithText(Mensagem);
        }
    }
}
