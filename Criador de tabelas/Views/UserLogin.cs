using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            if (txtUserName.Text == "sapb1" && txtPasswords.Text == "sapb1")
            {
                new TesteCriadorTabelas.formCriadorTabelas().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Usuário ou Senha inválidos, tente novamente.");
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
