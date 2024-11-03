using CriadorTabelas.Entities;
using SAPbobsCOM;
using System;
using System.Windows.Forms;

namespace CriadorTabelas.Classes
{
    class CreateFieldsHand : CommonBase
    {        
        UserFieldsMD oUserFieldsMD;

        private int lRetCode;
        private string Tablename { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        private object Type { get; set; }
        private object Subtype { get; set; }
        private int Size { get; set; }
        public CreateFieldsHand(string tablename, string name, string description, BoFieldTypes type, BoFldSubTypes subtype, int size)
        {
            Tablename = tablename;
            Name = name;
            Description = description;
            Type = type;
            Size = size;
            Subtype = subtype;
            CreateFields();
        }
        private void CreateFields()
        {
        
            oUserFieldsMD = (UserFieldsMD)oCompany.GetBusinessObject(BoObjectTypes.oUserFields);

            try
            {
                switch (Type)
                {
                    case BoFieldTypes.db_Alpha:

                        oUserFieldsMD.TableName = Tablename;
                        oUserFieldsMD.Name = Name;
                        oUserFieldsMD.Description = Description;
                        oUserFieldsMD.Type = (BoFieldTypes)Type;
                        oUserFieldsMD.Size = Size;
                        lRetCode = oUserFieldsMD.Add();
                        ValidaErro(lRetCode, oUserFieldsMD);
                        break;

                    case BoFieldTypes.db_Numeric:

                        oUserFieldsMD.TableName = Tablename;
                        oUserFieldsMD.Name = Name;
                        oUserFieldsMD.Description = Description;
                        oUserFieldsMD.Type = (BoFieldTypes)Type;
                        oUserFieldsMD.EditSize = Size;
                        lRetCode = oUserFieldsMD.Add();
                        ValidaErro(lRetCode, oUserFieldsMD);
                        break;

                    case BoFieldTypes.db_Date:
                        oUserFieldsMD.TableName = Tablename;
                        oUserFieldsMD.Name = Name;
                        oUserFieldsMD.Description = Description;
                        oUserFieldsMD.Type = (BoFieldTypes)Type;
                        oUserFieldsMD.SubType = (BoFldSubTypes)Subtype;
                        lRetCode = oUserFieldsMD.Add();
                        ValidaErro(lRetCode, oUserFieldsMD);
                        break;

                    case BoFieldTypes.db_Float:

                        oUserFieldsMD.TableName = Tablename;
                        oUserFieldsMD.Name = Name;
                        oUserFieldsMD.Description = Description;
                        oUserFieldsMD.Type = (BoFieldTypes)Type;
                        oUserFieldsMD.SubType = (BoFldSubTypes)Subtype;
                        lRetCode = oUserFieldsMD.Add();
                        ValidaErro(lRetCode, oUserFieldsMD);
                        break;

                }

                System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserFieldsMD);
                oUserFieldsMD = null;
                GC.Collect();
                CloseConnection();

            }
            catch (Exception ex)
            {
                ex.GetHashCode();
            }
        }
        private void ValidaErro(int lretcode, UserFieldsMD oUserFieldsMD)
        {            
            int errorCode = lretcode;
            string errorMsg;

            switch (errorCode)
            {
                case 0:
                    MessageBox.Show($"[Sucesso] - Campo: {oUserFieldsMD.Name} criado com sucesso na Tabela:{oUserFieldsMD.TableName}");
                    break;

                case -2035:
                    MessageBox.Show($"[Aviso] - Campo: {oUserFieldsMD.Name}, já existe na base de dados.");
                    break;

                case -5002:
                    MessageBox.Show($"[Aviso] - Campo: {oUserFieldsMD.Name}, já existe na base de dados.");
                    break;

                default:
                    oCompany.GetLastError(out errorCode, out errorMsg);
                    MessageBox.Show($"[Erro]: {errorCode}, Mensagem: {errorMsg}");
                    break;
            }

        }

    }
}
