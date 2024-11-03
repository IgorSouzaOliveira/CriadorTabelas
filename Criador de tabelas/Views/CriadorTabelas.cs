using System;
using System.Windows.Forms;
using SAPbobsCOM;
using CriadorTabelas;
using CriadorTabelas.Classes;
using CriadorTabelas.Entities;
using System.IO;
using System.Threading.Tasks;

namespace TesteCriadorTabelas
{
    public partial class formCriadorTabelas : Form
    {        
        public formCriadorTabelas()
        {
            InitializeComponent();
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {


            switch (cbxTipo.SelectedItem.ToString())
            {
                case "Alfanumérico":
                    cbxEstru.Items.Clear();
                    cbxEstru.Items.AddRange(new object[] { "Padrão", "Endereço", "Nº de telefone", "Texto" });
                    break;

                case "Data/hora":
                    cbxEstru.Items.Clear();
                    cbxEstru.Items.AddRange(new object[] { "Data", "Hora" });
                    break;

                case "Unidades e totais":
                    cbxEstru.Items.Clear();
                    cbxEstru.Items.AddRange(new object[] { "Taxa", "Valor", "Preço", "Quantidade", "Porcentagens", "Medida" });
                    break;

                case "Geral":
                    cbxEstru.Items.Clear();
                    cbxEstru.Items.AddRange(new object[] { "Conexão", "Imagem" });
                    break;

                case "Númerico":
                    cbxEstru.Items.Clear();
                    break;

            }

            switch (cbxTipo.SelectedItem.ToString())
            {
                case "Alfanumérico":
                    txtSize.Enabled = true;
                    break;

                case "Númerico":
                    txtSize.Enabled = true;
                    break;

                default:
                    txtSize.Enabled = false;
                    break;
            }

        }
        private void checkDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDefault.Checked)
            {
                txtDefault.Enabled = true;
            }
            else
            {
                txtDefault.Enabled = false;
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                BoFieldTypes type = 0;
                BoFldSubTypes subtype = 0;

                switch (cbxTipo.SelectedItem.ToString())
                {
                    case "Alfanumérico":
                        type = BoFieldTypes.db_Alpha;
                        break;

                    case "Data/hora":
                        type = BoFieldTypes.db_Date;
                        break;

                    case "Númerico":
                        type = BoFieldTypes.db_Numeric;
                        break;

                    case "Unidades e totais":
                        type = BoFieldTypes.db_Float;
                        break;

                    case "Geral":
                        type = BoFieldTypes.db_Memo;
                        break;

                }


                if (!string.IsNullOrEmpty(cbxEstru.Text))
                {
                    switch (cbxEstru.SelectedItem.ToString())
                    {
                        case "Data":
                            subtype = BoFldSubTypes.st_None;
                            break;

                        case "Hora":
                            subtype = BoFldSubTypes.st_Time;
                            break;

                        case "Taxa":
                            subtype = BoFldSubTypes.st_Rate;
                            break;

                        case "Valor":
                            subtype = BoFldSubTypes.st_Sum;
                            break;

                        case "Preço":
                            subtype = BoFldSubTypes.st_Price;
                            break;

                        case "Quantidade":
                            subtype = BoFldSubTypes.st_Quantity;
                            break;

                        case "Porcentagens":
                            subtype = BoFldSubTypes.st_Percentage;
                            break;

                        case "Medida":
                            subtype = BoFldSubTypes.st_Measurement;
                            break;

                        case "Conexão":
                            subtype = BoFldSubTypes.st_Link;
                            break;

                        case "Imagem":
                            subtype = BoFldSubTypes.st_Image;
                            break;
                    }
                }

                CreateFieldsHand oCreateFieldsHand = new CreateFieldsHand(txtTabela.Text, txtTitulo.Text, txtDescricao.Text, type, subtype, int.Parse(txtSize.Text));


            }
            catch (Exception)
            {

                throw;
            }


        }
        private void cbxEstru_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxEstru.SelectedItem.ToString())
            {
                case "Padrão":
                    txtSize.Enabled = true;
                    break;

                default:
                    txtSize.Enabled = false;
                    break;
            }
        }
        private void cbxValid_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxValid.SelectedItem.ToString())
            {
                case "Valores válidos":
                    dtGridView.Enabled = true;
                    break;

                default:
                    dtGridView.Enabled = false;
                    break;

            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLog.LinkVisited = true;
            System.Diagnostics.Process.Start(@"C:\LogDeCriação.txt");
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnExec_Click(object sender, EventArgs e)
        {
            UserTableManager tableManager = new UserTableManager(this);
            ExecuteQuerySQL oExecuteQuerySQL = new ExecuteQuerySQL();            

            const string path = @"C:\LogDeCriação.txt";
            File.Delete(path);

            lblReturn.Text = "Processo em andamento. Aguarde...";
            lblReturn.Refresh();

            progressBar.Minimum = 0;
            progressBar.Maximum = 91; // Número total de métodos
            progressBar.Value = 0;

            /* Criar Tabelas de Usuário */

            tableManager.AddUserTable("BONECONFMAIN", "BOne: Configuração Add-on", BoUTBTableType.bott_NoObject);
            tableManager.AddUserTable("BONMODAPROV", "BOne: Modelos de aprovação", BoUTBTableType.bott_NoObject);
            tableManager.AddUserTable("BONEAPROV", "BOne: Tabela de aprovação", BoUTBTableType.bott_NoObjectAutoIncrement);
            tableManager.AddUserTable("BONEXMLDATA", "BOne: Tabela de xml", BoUTBTableType.bott_NoObjectAutoIncrement);

            /* Tabela: BONECONFMAIN */
            tableManager.AddUserFields("BONECONFMAIN", "BOne_AtivoAprov", "Utilizar Aprovação", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 1, 0);
            tableManager.AddUserFields("BONECONFMAIN", "FechaDocRecusa", "Fecha Documento Rec", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 1, 0);
            tableManager.AddUserFields("BONECONFMAIN", "UrlSL", "Url SL", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 254, 0);
            tableManager.AddUserFields("BONECONFMAIN", "PortaSL", "Porta SL", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 20, 0);
            tableManager.AddUserFields("BONECONFMAIN", "ServidorSL", "Servidor SL", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 100, 0);
            tableManager.AddUserFields("BONECONFMAIN", "UsuarioSL", "Usuário SL", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 100, 0);
            tableManager.AddUserFields("BONECONFMAIN", "SenhaSL", "Senha SL", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 100, 0);

            /* Tabela: BONMODAPROV */
            tableManager.AddUserFields("BONMODAPROV", "BOne_ObjectType", "ObjectType", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 20, 0);
            tableManager.AddUserFields("BONMODAPROV", "BOne_NomeConsulta", "Nome Consulta", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 100, 0);
            tableManager.AddUserFields("BONMODAPROV", "BOne_Query", "Query", BoFieldTypes.db_Memo, BoFldSubTypes.st_None, 0, 0);
            tableManager.AddUserFields("BONMODAPROV", "BOne_CodeEtapa", "Codigo Etapa", BoFieldTypes.db_Numeric, BoFldSubTypes.st_None, 0, 11);
            tableManager.AddUserFields("BONMODAPROV", "BOne_EtapaAut", "Etapa de autorização", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 50, 0);
            tableManager.AddUserFields("BONMODAPROV", "BOne_Ativo", "Ativo", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 1, 0);

            /* Tabela: BONEAPROV */
            tableManager.AddUserFields("BONEAPROV", "BOneDocDate", "DocDate", BoFieldTypes.db_Date, BoFldSubTypes.st_None, 0, 0);
            tableManager.AddUserFields("BONEAPROV", "BOneTipoDoc", "TipoDoc", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 50, 0);
            tableManager.AddUserFields("BONEAPROV", "BOneNumDoc", "NumDoc", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 50, 0);
            tableManager.AddUserFields("BONEAPROV", "BOneCardCode", "CardCode", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 50, 0);
            tableManager.AddUserFields("BONEAPROV", "BOneCardName", "CardName", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 150, 0);
            tableManager.AddUserFields("BONEAPROV", "BOneBplID", "BplID", BoFieldTypes.db_Numeric, BoFldSubTypes.st_None, 0, 11);
            tableManager.AddUserFields("BONEAPROV", "BOneBplName", "BplName", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 150, 0);
            tableManager.AddUserFields("BONEAPROV", "BOneSlpCode", "SlpCode", BoFieldTypes.db_Numeric, BoFldSubTypes.st_None, 0, 11);
            tableManager.AddUserFields("BONEAPROV", "BOneUserSign", "UserSign", BoFieldTypes.db_Numeric, BoFldSubTypes.st_None, 0, 11);
            tableManager.AddUserFields("BONEAPROV", "BOnePaymentCode", "PaymentCode", BoFieldTypes.db_Numeric, BoFldSubTypes.st_None, 0, 11);
            tableManager.AddUserFields("BONEAPROV", "BOnePaymentMethod", "PaymentMethod", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 50, 0);
            tableManager.AddUserFields("BONEAPROV", "BOneDocTotal", "DocTotal", BoFieldTypes.db_Float, BoFldSubTypes.st_Price, 0, 0);
            tableManager.AddUserFields("BONEAPROV", "BOneCodEtapa", "CodigoEtapa", BoFieldTypes.db_Numeric, BoFldSubTypes.st_None, 0, 11);
            tableManager.AddUserFields("BONEAPROV", "BOneNameEtapa", "EtapaNome", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 254, 0);
            tableManager.AddUserFields("BONEAPROV", "BOneModeloAut", "NomeModelo", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 254, 0);
            tableManager.AddUserFields("BONEAPROV", "BOneQueryAut", "QueryAut", BoFieldTypes.db_Memo, BoFldSubTypes.st_None, 0, 0);
            tableManager.AddUserFields("BONEAPROV", "BOneAutorizado", "Autorizado", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 10, 0);
            tableManager.AddUserFields("BONEAPROV", "BOneProcessado", "Processado", BoFieldTypes.db_Numeric, BoFldSubTypes.st_None, 0, 1);

            /* Tabela: BONEXMLDATA */

            /* Campos da Tag: <ide> */
            tableManager.AddUserFields("BONEXMLDATA", "ChaveAcesso", "ChaveAcesso", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 100, 0);
            tableManager.AddUserFields("BONEXMLDATA", "idecUF", "idecUF", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 10, 0);
            tableManager.AddUserFields("BONEXMLDATA", "idecNF", "idecNF", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 100, 0);
            tableManager.AddUserFields("BONEXMLDATA", "ideMod", "ideMod", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 50, 0);
            tableManager.AddUserFields("BONEXMLDATA", "ideSerie", "ideSerie", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 10, 0);
            tableManager.AddUserFields("BONEXMLDATA", "idenNF", "idenNF", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 50, 0);
            tableManager.AddUserFields("BONEXMLDATA", "idedhEmi", "idedhEmi", BoFieldTypes.db_Date, BoFldSubTypes.st_None, 0, 0);

            /* Campos da Tag: <emit> */
            tableManager.AddUserFields("BONEXMLDATA", "emitCNPJ", "emitCNPJ", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 20, 0);
            tableManager.AddUserFields("BONEXMLDATA", "emitxNome", "emitxNome", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 254, 0);
            tableManager.AddUserFields("BONEXMLDATA", "emitxFant", "emitxFant", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 254, 0);
            tableManager.AddUserFields("BONEXMLDATA", "enderEmitxLgr", "enderEmitxLgr", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 254, 0);
            tableManager.AddUserFields("BONEXMLDATA", "enderEmitNro", "enderEmitNro", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 20, 0);
            tableManager.AddUserFields("BONEXMLDATA", "enderEmitxBairro", "enderEmitxBairro", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 254, 0);
            tableManager.AddUserFields("BONEXMLDATA", "enderEmitcMun", "enderEmitcMun", BoFieldTypes.db_Numeric, BoFldSubTypes.st_None, 0, 11);
            tableManager.AddUserFields("BONEXMLDATA", "enderEmitxMun", "enderEmitxMun", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 254, 0);
            tableManager.AddUserFields("BONEXMLDATA", "enderEmitUF", "enderEmitUF", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 5, 0);
            tableManager.AddUserFields("BONEXMLDATA", "enderEmitCEP", "enderEmitCEP", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 10, 0);
            tableManager.AddUserFields("BONEXMLDATA", "enderEmitcPais", "enderEmitcPais", BoFieldTypes.db_Numeric, BoFldSubTypes.st_None, 0, 11);
            tableManager.AddUserFields("BONEXMLDATA", "enderEmitxPais", "enderEmitxPais", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 50, 0);
            //tableManager.AddUserFields("BONEXMLDATA", "enderEmitfone", "enderEmitfone", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 20, 0));
            //tableManager.AddUserFields("BONEXMLDATA", "enderEmitIE", "enderEmitIE", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 50, 0));
            //tableManager.AddUserFields("BONEXMLDATA", "enderEmitIM", "enderEmitIM", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 30, 0));
            //tableManager.AddUserFields("BONEXMLDATA", "enderEmitCNAE", "enderEmitCNAE", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 30, 0));
            tableManager.AddUserFields("BONEXMLDATA", "enderEmitCRT", "enderEmitCRT", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 10, 0);

            /* Campos da Tag: <dest> */
            tableManager.AddUserFields("BONEXMLDATA", "destCNPJ", "destCNPJ", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 20, 0);
            tableManager.AddUserFields("BONEXMLDATA", "destxNome", "destxNome", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 254, 0);
            tableManager.AddUserFields("BONEXMLDATA", "enderDestxLgr", "enderDestxLgr", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 254, 0);
            tableManager.AddUserFields("BONEXMLDATA", "enderDestNro", "enderDestNro", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 20, 0);
            tableManager.AddUserFields("BONEXMLDATA", "enderDestxCpl", "enderDestxCpl", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 30, 0);
            tableManager.AddUserFields("BONEXMLDATA", "enderDestxBairro", "enderDestxBairro", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 50, 0);
            tableManager.AddUserFields("BONEXMLDATA", "enderDestcMun", "enderDestcMun", BoFieldTypes.db_Numeric, BoFldSubTypes.st_None, 0, 11);
            tableManager.AddUserFields("BONEXMLDATA", "enderDestxMun", "enderDestxMun", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 254, 0);
            tableManager.AddUserFields("BONEXMLDATA", "enderDestUF", "enderDestUF", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 5, 0);
            tableManager.AddUserFields("BONEXMLDATA", "enderDestCEP", "enderDestCEP", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 10, 0);
            tableManager.AddUserFields("BONEXMLDATA", "enderDestcPais", "enderDestcPais", BoFieldTypes.db_Numeric, BoFldSubTypes.st_None, 0, 11);
            tableManager.AddUserFields("BONEXMLDATA", "enderDestxPais", "enderDestxPais", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 50, 0);
            tableManager.AddUserFields("BONEXMLDATA", "enderDestfone", "enderDestfone", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 20, 0);
            tableManager.AddUserFields("BONEXMLDATA", "indIEDest", "indIEDest", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 10, 0);
            tableManager.AddUserFields("BONEXMLDATA", "enderDestIE", "enderDestIE", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 50, 0);
            tableManager.AddUserFields("BONEXMLDATA", "enderDestEmail", "enderDestEmail", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 100, 0);

            /* Campos da Tag: <det nItem> */
            tableManager.AddUserFields("BONEXMLDATA", "prodcProd", "prodcProd", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 50, 0);
            tableManager.AddUserFields("BONEXMLDATA", "prodcEAN", "prodcEAN", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 50, 0);
            tableManager.AddUserFields("BONEXMLDATA", "prodxProd", "prodxProd", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 254, 0);
            tableManager.AddUserFields("BONEXMLDATA", "prodNCM", "prodNCM", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 50, 0);
            tableManager.AddUserFields("BONEXMLDATA", "prodCFOP", "prodCFOP", BoFieldTypes.db_Numeric, BoFldSubTypes.st_None, 0, 10);
            tableManager.AddUserFields("BONEXMLDATA", "produCom", "produCom", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 50, 0);
            tableManager.AddUserFields("BONEXMLDATA", "prodqCom", "prodqCom", BoFieldTypes.db_Float, BoFldSubTypes.st_Quantity, 0, 0);
            tableManager.AddUserFields("BONEXMLDATA", "prodvUnCom", "prodvUnCom", BoFieldTypes.db_Float, BoFldSubTypes.st_Price, 0, 0);
            //tableManager.AddUserFields("BONEXMLDATA", "prodvProd", "prodvProd", BoFieldTypes.db_Float, BoFldSubTypes.st_Quantity, 0, 0));
            //tableManager.AddUserFields("BONEXMLDATA", "prodcEANTrib", "prodcEANTrib", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 20, 0));
            //tableManager.AddUserFields("BONEXMLDATA", "produTrib", "produTrib", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 20, 0));
            //tableManager.AddUserFields("BONEXMLDATA", "prodvUnTrib", "prodvUnTrib", BoFieldTypes.db_Float, BoFldSubTypes.st_Quantity, 0, 0));
            //tableManager.AddUserFields("BONEXMLDATA", "prodindTot", "prodindTot", BoFieldTypes.db_Numeric, BoFldSubTypes.st_Quantity, 0, 10));

            /* Campos da Tag: <imposto> */
            /*ICMS*/
            tableManager.AddUserFields("BONEXMLDATA", "ICMSorig", "ICMSorig", BoFieldTypes.db_Numeric, BoFldSubTypes.st_None, 0, 11);
            tableManager.AddUserFields("BONEXMLDATA", "ICMSCST", "ICMSCST", BoFieldTypes.db_Numeric, BoFldSubTypes.st_None, 0, 11);
            tableManager.AddUserFields("BONEXMLDATA", "ICMSmodBC", "ICMSmodBC", BoFieldTypes.db_Numeric, BoFldSubTypes.st_None, 0, 11);
            tableManager.AddUserFields("BONEXMLDATA", "ICMSpRedBC", "ICMSpRedBC", BoFieldTypes.db_Float, BoFldSubTypes.st_Quantity, 0, 0);
            tableManager.AddUserFields("BONEXMLDATA", "ICMSvBC", "ICMSvBC", BoFieldTypes.db_Float, BoFldSubTypes.st_Quantity, 0, 0);
            tableManager.AddUserFields("BONEXMLDATA", "ICMSpICMS", "ICMSpICMS", BoFieldTypes.db_Float, BoFldSubTypes.st_Quantity, 0, 0);
            tableManager.AddUserFields("BONEXMLDATA", "ICMSvICMS", "ICMSvICMS", BoFieldTypes.db_Float, BoFldSubTypes.st_Quantity, 0, 0);

            /*IPI*/
            tableManager.AddUserFields("BONEXMLDATA", "IPIcEnq", "IPIcEnq", BoFieldTypes.db_Numeric, BoFldSubTypes.st_None, 0, 11);
            tableManager.AddUserFields("BONEXMLDATA", "IPINtCST", "IPINtCST", BoFieldTypes.db_Numeric, BoFldSubTypes.st_None, 0, 11);

            /*PIS*/
            tableManager.AddUserFields("BONEXMLDATA", "PisNtCST", "PisNtCST", BoFieldTypes.db_Numeric, BoFldSubTypes.st_None, 0, 11);

            /*COFINS*/
            tableManager.AddUserFields("BONEXMLDATA", "CofinsNtCST", "CofinsNtCST", BoFieldTypes.db_Numeric, BoFldSubTypes.st_None, 0, 10);

            /*OUSG*/
            tableManager.AddUserFields("OUSG", "UtilImpXml", "Utilizar na importação de XML?", BoFieldTypes.db_Alpha, BoFldSubTypes.st_None, 1, 0);

            /* Consultas de usuário*/
            tableManager.CreateQueryCategories("Modelos de Aprovação - SO Soluções", "MOD - Pedido de compra", "SELECT 'TRUE' FROM OPOR T0 WHERE T0.DocEntry = @DocEntry AND T0.DocTotal > 10000");

            /* Registrar Objeto */
            //tableManager.AddUDO("SOCONF", "SO: Configuração SO Solutions", BoUDOObjType.boud_MasterData, "SOCONF", BoYesNoEnum.tNO, BoYesNoEnum.tYES, 0);

            oExecuteQuerySQL.CreateProc();
            lblReturn.Text = "Processo Finalizado.";
        }
        public void UpdateProgressWithText(string msg)
        {
            lblReturn.Text = msg;
            lblReturn.Refresh();
            progressBar.Value += 1;
        }
    }

}
