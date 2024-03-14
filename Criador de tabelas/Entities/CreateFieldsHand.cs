using CriadorTabelas.Entities;
using SAPbobsCOM;
using System;
using System.Windows.Forms;

namespace CriadorTabelas.Classes
{
    public class CreateFieldsHand
    {
        public Company oCompany = new Company();
        
        private int lRetCode;
        private string tablename { get; set; }
        private string name { get; set; }
        private string description { get; set; }
        private object type { get; set; }
        private object subtype { get; set; }
        private int size { get; set; }

        ConnectionDB oConnectionDB = new ConnectionDB();

        public CreateFieldsHand(string tablename, string name, string description, BoFieldTypes type, BoFldSubTypes subtype, int size)
        {
            this.tablename = tablename;
            this.name = name;
            this.description = description;
            this.type = type;
            this.size = size;
            this.subtype = subtype;
            CreateFields();
        }

        private void CreateFields()
        {
            oConnectionDB.OpenConnection();
            UserFieldsMD oUserFieldsMD = null;
            oUserFieldsMD = ((UserFieldsMD)ConnectionDB.oCompany.GetBusinessObject(BoObjectTypes.oUserFields));

            System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserFieldsMD);
            oUserFieldsMD = null;
            GC.Collect();
            oUserFieldsMD = (UserFieldsMD)ConnectionDB.oCompany.GetBusinessObject(BoObjectTypes.oUserFields);

            try
            {
                switch (type)
                {
                    case BoFieldTypes.db_Alpha:

                        oUserFieldsMD.TableName = tablename;
                        oUserFieldsMD.Name = name;
                        oUserFieldsMD.Description = description;
                        oUserFieldsMD.Type = (BoFieldTypes)type;
                        oUserFieldsMD.Size = size;
                        lRetCode = oUserFieldsMD.Add();
                        ExceptionError(lRetCode, oUserFieldsMD);
                        break;

                    case BoFieldTypes.db_Numeric:

                        oUserFieldsMD.TableName = tablename;
                        oUserFieldsMD.Name = name;
                        oUserFieldsMD.Description = description;
                        oUserFieldsMD.Type = (BoFieldTypes)type;
                        oUserFieldsMD.EditSize = size;
                        lRetCode = oUserFieldsMD.Add();
                        ExceptionError(lRetCode, oUserFieldsMD);
                        break;

                    case BoFieldTypes.db_Date:
                        oUserFieldsMD.TableName = tablename;
                        oUserFieldsMD.Name = name;
                        oUserFieldsMD.Description = description;
                        oUserFieldsMD.Type = (BoFieldTypes)type;
                        oUserFieldsMD.SubType = (BoFldSubTypes)subtype;
                        lRetCode = oUserFieldsMD.Add();
                        ExceptionError(lRetCode, oUserFieldsMD);
                        break;

                    case BoFieldTypes.db_Float:

                        oUserFieldsMD.TableName = tablename;
                        oUserFieldsMD.Name = name;
                        oUserFieldsMD.Description = description;
                        oUserFieldsMD.Type = (BoFieldTypes)type;
                        oUserFieldsMD.SubType = (BoFldSubTypes)subtype;
                        lRetCode = oUserFieldsMD.Add();
                        ExceptionError(lRetCode, oUserFieldsMD);
                        break;

                }

                System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserFieldsMD);
                oUserFieldsMD = null;
                GC.Collect();
                oConnectionDB.CloseConnection();
                MessageBox.Show("Processo finalizado. Verificar Log no caminho: 'C:\\LogCreate.txt'");

            }
            catch (Exception ex)
            {
                ex.GetHashCode();
            }
        }
        private void ExceptionError(int lretcode, UserFieldsMD oUserFieldsMD)
        {
            LogCreate oLogCreate = new LogCreate();
            int errorCode = lretcode;
            string errorMsg;            

            switch (errorCode)
            {
                case 0:
                     oLogCreate.Log($"[Sucesso] - Campo: {oUserFieldsMD.Name} criado com sucesso na Tabela:{oUserFieldsMD.TableName}");
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
