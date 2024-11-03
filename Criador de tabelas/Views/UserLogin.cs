using CriadorTabelas.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriadorTabelas
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SAPbobsCOM.Recordset oRst = CommonBase.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);

            try
            {
                oRst.DoQuery($"SELECT COUNT('A') [Count] FROM OUSR T0 WHERE T0.User_Code = '{txtUserName.Text}' AND SuperUser = 'Y'");
                int count = oRst.Fields.Item("Count").Value;

                if (count == 0)
                    throw new Exception("Usuário sem permissão ou não encontrado.");

                new TesteCriadorTabelas.formCriadorTabelas().Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtUserName.Clear();
                txtPasswords.Clear();
                txtUserName.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
