using SAPbobsCOM;
using System;
using System.Windows.Forms;

namespace CriadorTabelas.Entities
{
    public class UserTableManager
    {
        public static void AddUserTable(string tableName, string tableDescription, BoUTBTableType tableType)
        {
            UserTablesMD oUserTablesMD = null;
            oUserTablesMD = CommonBase.oCompany.GetBusinessObject(BoObjectTypes.oUserTables);

            try
            {
                if (!oUserTablesMD.GetByKey(tableName))
                {
                    oUserTablesMD.TableName = tableName;
                    oUserTablesMD.TableDescription = tableDescription;
                    oUserTablesMD.TableType = tableType;
                    int lRet = oUserTablesMD.Add();

                    if (lRet != 0)
                    {
                        LogCreate.Log(CommonBase.oCompany.GetLastErrorDescription());
                    }

                    LogCreate.Log($"Tabela: @{oUserTablesMD.TableName}, criado com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (oUserTablesMD != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserTablesMD);
                }
            }

        }

        public static void AddUserFields(string tableName, string name, string description, BoFieldTypes boFieldTypes, BoFldSubTypes boFldSubTypes, int size, int editSize)
        {
            UserFieldsMD oUserFieldsMD = null;

            oUserFieldsMD = CommonBase.oCompany.GetBusinessObject(BoObjectTypes.oUserFields);

            try
            {
                oUserFieldsMD.TableName = tableName;
                oUserFieldsMD.Name = name;
                oUserFieldsMD.Description = description;
                oUserFieldsMD.Type = boFieldTypes;
                oUserFieldsMD.SubType = boFldSubTypes;
                oUserFieldsMD.Size = size;
                              

                int lRet = oUserFieldsMD.Add();

                if (lRet != 0)
                {
                    LogCreate.Log(CommonBase.oCompany.GetLastErrorDescription());
                }

                LogCreate.Log($"Campo: @{oUserFieldsMD.Name}, criado com sucesso.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (oUserFieldsMD != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserFieldsMD);
                }
            }
        }

        public static void AddUDO(string code, string name, BoUDOObjType boUDOObjType, string tableName, BoYesNoEnum boYesNoEnum, BoYesNoEnum boYesNoEnum1)
        {
            UserObjectsMD oUserObjectsMD = null;

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
                    LogCreate.Log(CommonBase.oCompany.GetLastErrorDescription());
                }

                LogCreate.Log($"Objeto: @{oUserObjectsMD.Name}, criado com sucesso.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (oUserObjectsMD != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserObjectsMD);
                }
            }
        }
    }
}
