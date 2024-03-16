using System;
using System.Windows.Forms;
using SAPbobsCOM;
using CriadorTabelas;
using CriadorTabelas.Classes;
using CriadorTabelas.Entities;

namespace TesteCriadorTabelas
{
    public partial class formCriadorTabelas : Form
    {

        public Company oCompany = new Company();
        public string sErrMsg;
        public long lErrCode;
        public long lRetCode;
        CreateTable oCreateTable = new CreateTable();
        CreateFields oCreateFields = new CreateFields();
        CreateUDO oCreateUDO = new CreateUDO();
        
        public formCriadorTabelas()
        {
            InitializeComponent();
        }


        //private void DbServerType(string cbxversiondb)
        //{
        //    switch (cbxVersionDB.Text)
        //    {
        //        case "dts_DB_2":
        //            dbservertype = BoDataServerTypes.dst_DB_2;
        //            break;

        //        case "dst_HANADB":
        //            dbservertype = BoDataServerTypes.dst_HANADB;
        //            break;
        //        case "dst_MAXDB":
        //            dbservertype = BoDataServerTypes.dst_MAXDB;
        //            break;
        //        case "dst_MSSQL":
        //            dbservertype = BoDataServerTypes.dst_MSSQL;
        //            break;
        //        case "dst_MSSQL2005":
        //            dbservertype = BoDataServerTypes.dst_MSSQL2005;
        //            break;
        //        case "dst_MSSQL2008":
        //            dbservertype = BoDataServerTypes.dst_MSSQL2008;
        //            break;
        //        case "dst_MSSQL2012":
        //            dbservertype = BoDataServerTypes.dst_MSSQL2012;
        //            break;
        //        case "dst_MSSQL2014":
        //            dbservertype = BoDataServerTypes.dst_MSSQL2014;
        //            break;
        //        case "dst_MSSQL2016":
        //            dbservertype = BoDataServerTypes.dst_MSSQL2016;
        //            break;
        //        case "dst_MSSQL2017":
        //            dbservertype = BoDataServerTypes.dst_MSSQL2017;
        //            break;
        //        case "dst_MSSQL2019":
        //            dbservertype = BoDataServerTypes.dst_MSSQL2019;
        //            break;

        //        case "dst_SYBASE":
        //            dbservertype = BoDataServerTypes.dst_SYBASE;
        //            break;

        //    }
        //}

        private void StripMenuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();            
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
            System.Diagnostics.Process.Start(@"C:\LogCreate.txt");
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            lblReturn.Text = "Processo em andamento. Aguarde...";
            lblReturn.Refresh();
            progressBar.Value = 50;            
            oCreateTable.CreateTableSAP();
            oCreateFields.CreateFieldsSAP();
            oCreateUDO.CreateUDOSAP();
            progressBar.Value = 100;
            lblReturn.Text = "Processo Finalizado.";
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
