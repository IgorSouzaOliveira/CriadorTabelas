using SAPbobsCOM;
using System;
using System.Windows.Forms;
using TesteCriadorTabelas;

namespace CriadorTabelas.Entities
{
    public class UserTableManager : SAPService
    {
        private UserTablesMD oUserTablesMD { get; set; } = null;
        private UserFieldsMD oUserFieldsMD { get; set; } = null;
        private UserObjectsMD oUserObjectsMD { get; set; } = null;
        private QueryCategories oQueryCategories { get; set; } = null;
        private UserQueries oUserQueries { get; set; } = null;
        private Recordset oRst { get; set; } = null;

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
                    throw new Exception(SAPService.oCompany.GetLastErrorDescription());
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

            oUserObjectsMD = SAPService.oCompany.GetBusinessObject(BoObjectTypes.oUserObjectsMD);

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
                    throw new Exception(SAPService.oCompany.GetLastErrorDescription());
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
        public void CreateQueryCategories(string categorieName, string queryDescription, string sqlQuery)
        {
            oQueryCategories = SAPService.oCompany.GetBusinessObject(BoObjectTypes.oQueryCategories);
            oUserQueries = SAPService.oCompany.GetBusinessObject(BoObjectTypes.oUserQueries);
            oRst = SAPService.oCompany.GetBusinessObject(BoObjectTypes.BoRecordset);

            try
            {

                oQueryCategories.Name = categorieName;                    
                int addResult = oQueryCategories.Add();

                if (addResult != 0)
                {
                    throw new Exception($"[Erro] - Categoria: {oQueryCategories.Name} - {SAPService.oCompany.GetLastErrorDescription()}");
                }

                oRst.DoQuery($"SELECT T0.CategoryId FROM OQCN T0 WHERE T0.CatName = '{categorieName}'");
                int idCategory = oRst.Fields.Item("CategoryId").Value;


                oUserQueries.QueryCategory = idCategory;
                oUserQueries.QueryDescription = queryDescription;
                oUserQueries.Query = sqlQuery;                            

                int result = oUserQueries.Add();

                if (result != 0)
                {
                    throw new Exception($"[Erro] - Consulta de usuário: {oUserQueries.QueryDescription} - {SAPService.oCompany.GetLastErrorDescription()}");
                }
            }
            catch (Exception ex)
            {
                LogCreate.Log($"{ex.Message}");
            }
            finally
            {
                if (oQueryCategories != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oQueryCategories);
                }
                if (oUserQueries != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserQueries);
                }
                if (oRst != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oRst);
                }
            }
        }
    }
}
