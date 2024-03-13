
using System.Windows.Forms;

namespace TesteCriadorTabelas
{
    partial class formCriadorTabelas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

    


        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCriadorTabelas));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.geralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPag0 = new System.Windows.Forms.TabPage();
            this.cbxVersionDB = new System.Windows.Forms.ComboBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.a = new System.Windows.Forms.Panel();
            this.txtLicenServer = new System.Windows.Forms.TextBox();
            this.lblLicenseServer = new System.Windows.Forms.Label();
            this.txtUPasswBD = new System.Windows.Forms.TextBox();
            this.btnDesconect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtUserDB = new System.Windows.Forms.TextBox();
            this.lblDbUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserC = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabPag2 = new System.Windows.Forms.TabPage();
            this.btnRegUDO = new System.Windows.Forms.Button();
            this.btnCriarCol = new System.Windows.Forms.Button();
            this.txtAviso = new System.Windows.Forms.TextBox();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb = new System.Windows.Forms.TabPage();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTabela = new System.Windows.Forms.TextBox();
            this.lblTabela = new System.Windows.Forms.Label();
            this.txtDefault = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.checkObrig = new System.Windows.Forms.CheckBox();
            this.checkDefault = new System.Windows.Forms.CheckBox();
            this.cbxValid = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxEstru = new System.Windows.Forms.ComboBox();
            this.lblEstru = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblComp = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPag0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPag2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.Silver;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geralToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStripMain.Size = new System.Drawing.Size(753, 24);
            this.menuStripMain.TabIndex = 26;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // geralToolStripMenuItem
            // 
            this.geralToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.geralToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuSair});
            this.geralToolStripMenuItem.Name = "geralToolStripMenuItem";
            this.geralToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.geralToolStripMenuItem.Text = "Geral";
            // 
            // StripMenuSair
            // 
            this.StripMenuSair.Name = "StripMenuSair";
            this.StripMenuSair.Size = new System.Drawing.Size(93, 22);
            this.StripMenuSair.Text = "Sair";
            this.StripMenuSair.Click += new System.EventHandler(this.StripMenuSair_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPag0);
            this.tabControl.Controls.Add(this.tabPag2);
            this.tabControl.Controls.Add(this.tb);
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(753, 538);
            this.tabControl.TabIndex = 52;
            // 
            // tabPag0
            // 
            this.tabPag0.BackColor = System.Drawing.Color.White;
            this.tabPag0.Controls.Add(this.cbxVersionDB);
            this.tabPag0.Controls.Add(this.panel8);
            this.tabPag0.Controls.Add(this.panel7);
            this.tabPag0.Controls.Add(this.panel6);
            this.tabPag0.Controls.Add(this.panel5);
            this.tabPag0.Controls.Add(this.panel4);
            this.tabPag0.Controls.Add(this.panel3);
            this.tabPag0.Controls.Add(this.panel2);
            this.tabPag0.Controls.Add(this.a);
            this.tabPag0.Controls.Add(this.txtLicenServer);
            this.tabPag0.Controls.Add(this.lblLicenseServer);
            this.tabPag0.Controls.Add(this.txtUPasswBD);
            this.tabPag0.Controls.Add(this.btnDesconect);
            this.tabPag0.Controls.Add(this.label4);
            this.tabPag0.Controls.Add(this.btnConnect);
            this.tabPag0.Controls.Add(this.txtUserDB);
            this.tabPag0.Controls.Add(this.lblDbUser);
            this.tabPag0.Controls.Add(this.label3);
            this.tabPag0.Controls.Add(this.txtUserPass);
            this.tabPag0.Controls.Add(this.label2);
            this.tabPag0.Controls.Add(this.txtUserC);
            this.tabPag0.Controls.Add(this.lblUser);
            this.tabPag0.Controls.Add(this.txtCompany);
            this.tabPag0.Controls.Add(this.lblBase);
            this.tabPag0.Controls.Add(this.txtServer);
            this.tabPag0.Controls.Add(this.lblServer);
            this.tabPag0.Controls.Add(this.label1);
            this.tabPag0.Controls.Add(this.pictureBox3);
            this.tabPag0.Location = new System.Drawing.Point(4, 22);
            this.tabPag0.Name = "tabPag0";
            this.tabPag0.Padding = new System.Windows.Forms.Padding(3);
            this.tabPag0.Size = new System.Drawing.Size(745, 512);
            this.tabPag0.TabIndex = 2;
            this.tabPag0.Text = "Conexão BD";
            // 
            // cbxVersionDB
            // 
            this.cbxVersionDB.Enabled = false;
            this.cbxVersionDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxVersionDB.FormattingEnabled = true;
            this.cbxVersionDB.Items.AddRange(new object[] {
            "dts_DB_2",
            "dst_HANADB",
            "dst_MAXDB",
            "dst_MSSQL",
            "dst_MSSQL2005",
            "dst_MSSQL2008",
            "dst_MSSQL2012",
            "dst_MSSQL2014",
            "dst_MSSQL2016",
            "dst_MSSQL2017",
            "dst_MSSQL2019",
            "dst_SYBASE"});
            this.cbxVersionDB.Location = new System.Drawing.Point(319, 248);
            this.cbxVersionDB.Name = "cbxVersionDB";
            this.cbxVersionDB.Size = new System.Drawing.Size(173, 21);
            this.cbxVersionDB.TabIndex = 131;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Enabled = false;
            this.panel8.Location = new System.Drawing.Point(256, 347);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(236, 1);
            this.panel8.TabIndex = 130;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Enabled = false;
            this.panel7.Location = new System.Drawing.Point(256, 322);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(236, 1);
            this.panel7.TabIndex = 126;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Enabled = false;
            this.panel6.Location = new System.Drawing.Point(256, 296);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(236, 1);
            this.panel6.TabIndex = 129;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Enabled = false;
            this.panel5.Location = new System.Drawing.Point(256, 270);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(236, 1);
            this.panel5.TabIndex = 128;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(256, 242);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 1);
            this.panel4.TabIndex = 125;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(256, 216);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 1);
            this.panel3.TabIndex = 127;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(256, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 124;
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.Color.Black;
            this.a.Enabled = false;
            this.a.Location = new System.Drawing.Point(256, 164);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(236, 1);
            this.a.TabIndex = 123;
            // 
            // txtLicenServer
            // 
            this.txtLicenServer.BackColor = System.Drawing.Color.White;
            this.txtLicenServer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLicenServer.Enabled = false;
            this.txtLicenServer.Location = new System.Drawing.Point(366, 331);
            this.txtLicenServer.Name = "txtLicenServer";
            this.txtLicenServer.Size = new System.Drawing.Size(126, 13);
            this.txtLicenServer.TabIndex = 111;
            // 
            // lblLicenseServer
            // 
            this.lblLicenseServer.AutoSize = true;
            this.lblLicenseServer.Enabled = false;
            this.lblLicenseServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblLicenseServer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLicenseServer.Location = new System.Drawing.Point(253, 329);
            this.lblLicenseServer.Name = "lblLicenseServer";
            this.lblLicenseServer.Size = new System.Drawing.Size(114, 15);
            this.lblLicenseServer.TabIndex = 122;
            this.lblLicenseServer.Text = "Servidor de licença:";
            // 
            // txtUPasswBD
            // 
            this.txtUPasswBD.BackColor = System.Drawing.Color.White;
            this.txtUPasswBD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUPasswBD.Enabled = false;
            this.txtUPasswBD.Location = new System.Drawing.Point(317, 306);
            this.txtUPasswBD.Name = "txtUPasswBD";
            this.txtUPasswBD.PasswordChar = '*';
            this.txtUPasswBD.Size = new System.Drawing.Size(175, 13);
            this.txtUPasswBD.TabIndex = 110;
            // 
            // btnDesconect
            // 
            this.btnDesconect.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDesconect.Enabled = false;
            this.btnDesconect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconect.ForeColor = System.Drawing.Color.Black;
            this.btnDesconect.Location = new System.Drawing.Point(381, 385);
            this.btnDesconect.Name = "btnDesconect";
            this.btnDesconect.Size = new System.Drawing.Size(111, 23);
            this.btnDesconect.TabIndex = 113;
            this.btnDesconect.Text = "Desconectar";
            this.btnDesconect.UseVisualStyleBackColor = false;
            this.btnDesconect.Click += new System.EventHandler(this.btnDesconect_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(253, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 121;
            this.label4.Text = "Senha DB:";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnConnect.Enabled = false;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.ForeColor = System.Drawing.Color.Black;
            this.btnConnect.Location = new System.Drawing.Point(256, 385);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(111, 23);
            this.btnConnect.TabIndex = 112;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtUserDB
            // 
            this.txtUserDB.BackColor = System.Drawing.Color.White;
            this.txtUserDB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserDB.Enabled = false;
            this.txtUserDB.Location = new System.Drawing.Point(325, 280);
            this.txtUserDB.Name = "txtUserDB";
            this.txtUserDB.Size = new System.Drawing.Size(167, 13);
            this.txtUserDB.TabIndex = 109;
            // 
            // lblDbUser
            // 
            this.lblDbUser.AutoSize = true;
            this.lblDbUser.Enabled = false;
            this.lblDbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDbUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDbUser.Location = new System.Drawing.Point(253, 278);
            this.lblDbUser.Name = "lblDbUser";
            this.lblDbUser.Size = new System.Drawing.Size(73, 15);
            this.lblDbUser.TabIndex = 120;
            this.lblDbUser.Text = "Usuário DB:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(253, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 119;
            this.label3.Text = "Versão DB:";
            // 
            // txtUserPass
            // 
            this.txtUserPass.BackColor = System.Drawing.Color.White;
            this.txtUserPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserPass.Enabled = false;
            this.txtUserPass.Location = new System.Drawing.Point(298, 226);
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.PasswordChar = '*';
            this.txtUserPass.Size = new System.Drawing.Size(194, 13);
            this.txtUserPass.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(253, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 118;
            this.label2.Text = "Senha:";
            // 
            // txtUserC
            // 
            this.txtUserC.BackColor = System.Drawing.Color.White;
            this.txtUserC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserC.Enabled = false;
            this.txtUserC.Location = new System.Drawing.Point(304, 200);
            this.txtUserC.Name = "txtUserC";
            this.txtUserC.Size = new System.Drawing.Size(188, 13);
            this.txtUserC.TabIndex = 106;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Enabled = false;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUser.Location = new System.Drawing.Point(253, 198);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(53, 15);
            this.lblUser.TabIndex = 117;
            this.lblUser.Text = "Usuário:";
            // 
            // txtCompany
            // 
            this.txtCompany.BackColor = System.Drawing.Color.White;
            this.txtCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCompany.Enabled = false;
            this.txtCompany.Location = new System.Drawing.Point(351, 174);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(141, 13);
            this.txtCompany.TabIndex = 105;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Enabled = false;
            this.lblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblBase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBase.Location = new System.Drawing.Point(253, 172);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(99, 15);
            this.lblBase.TabIndex = 116;
            this.lblBase.Text = "Banco de dados:";
            // 
            // txtServer
            // 
            this.txtServer.AcceptsReturn = true;
            this.txtServer.AcceptsTab = true;
            this.txtServer.BackColor = System.Drawing.Color.White;
            this.txtServer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServer.Enabled = false;
            this.txtServer.Location = new System.Drawing.Point(307, 147);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(185, 13);
            this.txtServer.TabIndex = 104;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Enabled = false;
            this.lblServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblServer.Location = new System.Drawing.Point(253, 145);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(55, 15);
            this.lblServer.TabIndex = 115;
            this.lblServer.Text = "Servidor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(293, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 114;
            this.label1.Text = "Dados de conexão";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CriadorTabelas.Properties.Resources.SAP_Business_One;
            this.pictureBox3.Location = new System.Drawing.Point(0, 439);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(97, 73);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 77;
            this.pictureBox3.TabStop = false;
            // 
            // tabPag2
            // 
            this.tabPag2.Controls.Add(this.btnRegUDO);
            this.tabPag2.Controls.Add(this.btnCriarCol);
            this.tabPag2.Controls.Add(this.txtAviso);
            this.tabPag2.Controls.Add(this.btnCreateTable);
            this.tabPag2.Controls.Add(this.pictureBox1);
            this.tabPag2.Location = new System.Drawing.Point(4, 22);
            this.tabPag2.Name = "tabPag2";
            this.tabPag2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPag2.Size = new System.Drawing.Size(745, 512);
            this.tabPag2.TabIndex = 0;
            this.tabPag2.Text = "Criador AddOn ";
            this.tabPag2.UseVisualStyleBackColor = true;
            // 
            // btnRegUDO
            // 
            this.btnRegUDO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegUDO.ForeColor = System.Drawing.Color.Black;
            this.btnRegUDO.Location = new System.Drawing.Point(8, 243);
            this.btnRegUDO.Name = "btnRegUDO";
            this.btnRegUDO.Size = new System.Drawing.Size(111, 23);
            this.btnRegUDO.TabIndex = 58;
            this.btnRegUDO.Text = "3º Registrar UDO";
            this.btnRegUDO.UseVisualStyleBackColor = true;
            this.btnRegUDO.Click += new System.EventHandler(this.btnRegUDO_Click_1);
            // 
            // btnCriarCol
            // 
            this.btnCriarCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarCol.ForeColor = System.Drawing.Color.Black;
            this.btnCriarCol.Location = new System.Drawing.Point(8, 214);
            this.btnCriarCol.Name = "btnCriarCol";
            this.btnCriarCol.Size = new System.Drawing.Size(111, 23);
            this.btnCriarCol.TabIndex = 56;
            this.btnCriarCol.Text = "2º Criar Coluna(s)";
            this.btnCriarCol.UseVisualStyleBackColor = true;
            this.btnCriarCol.Click += new System.EventHandler(this.btnCriarCol_Click_1);
            // 
            // txtAviso
            // 
            this.txtAviso.BackColor = System.Drawing.Color.White;
            this.txtAviso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAviso.Enabled = false;
            this.txtAviso.ForeColor = System.Drawing.Color.Red;
            this.txtAviso.Location = new System.Drawing.Point(8, 20);
            this.txtAviso.Multiline = true;
            this.txtAviso.Name = "txtAviso";
            this.txtAviso.Size = new System.Drawing.Size(729, 159);
            this.txtAviso.TabIndex = 53;
            this.txtAviso.Text = "ATENÇÃO !\r\n\r\nExecutar somente se houver necessidade para o Add-on.\r\n\r\nA etapa de " +
    "criação, deve ser executada na seguinte ordem:\r\n\r\n1º - Criar Tabela(s).\r\n\r\n2º - " +
    "Criar Coluna(s).\r\n\r\n3º - Registrar UDO.";
            this.txtAviso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTable.ForeColor = System.Drawing.Color.Black;
            this.btnCreateTable.Location = new System.Drawing.Point(8, 185);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(111, 23);
            this.btnCreateTable.TabIndex = 52;
            this.btnCreateTable.Text = "1º Criar Tabela(s)";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CriadorTabelas.Properties.Resources.SAP_Business_One;
            this.pictureBox1.Location = new System.Drawing.Point(0, 439);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // tb
            // 
            this.tb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb.Controls.Add(this.dtGridView);
            this.tb.Controls.Add(this.txtTabela);
            this.tb.Controls.Add(this.lblTabela);
            this.tb.Controls.Add(this.txtDefault);
            this.tb.Controls.Add(this.btnAdd);
            this.tb.Controls.Add(this.checkObrig);
            this.tb.Controls.Add(this.checkDefault);
            this.tb.Controls.Add(this.cbxValid);
            this.tb.Controls.Add(this.label6);
            this.tb.Controls.Add(this.cbxEstru);
            this.tb.Controls.Add(this.lblEstru);
            this.tb.Controls.Add(this.txtSize);
            this.tb.Controls.Add(this.lblComp);
            this.tb.Controls.Add(this.cbxTipo);
            this.tb.Controls.Add(this.lblTipo);
            this.tb.Controls.Add(this.txtDescricao);
            this.tb.Controls.Add(this.lblDesc);
            this.tb.Controls.Add(this.txtTitulo);
            this.tb.Controls.Add(this.lblTitulo);
            this.tb.Controls.Add(this.lblInfo);
            this.tb.Controls.Add(this.pictureBox2);
            this.tb.Location = new System.Drawing.Point(4, 22);
            this.tb.Name = "tb";
            this.tb.Padding = new System.Windows.Forms.Padding(3);
            this.tb.Size = new System.Drawing.Size(745, 512);
            this.tb.TabIndex = 1;
            this.tb.Text = "Campo(s) Avulso(s)";
            this.tb.UseVisualStyleBackColor = true;
            // 
            // dtGridView
            // 
            this.dtGridView.BackgroundColor = System.Drawing.Color.White;
            this.dtGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dtGridView.Enabled = false;
            this.dtGridView.Location = new System.Drawing.Point(281, 177);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.Size = new System.Drawing.Size(245, 132);
            this.dtGridView.TabIndex = 71;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Valor";
            this.Column1.Name = "Column1";
            this.Column1.Width = 101;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descrição";
            this.Column2.Name = "Column2";
            this.Column2.Width = 101;
            // 
            // txtTabela
            // 
            this.txtTabela.Location = new System.Drawing.Point(120, 62);
            this.txtTabela.Name = "txtTabela";
            this.txtTabela.Size = new System.Drawing.Size(115, 20);
            this.txtTabela.TabIndex = 0;
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Location = new System.Drawing.Point(28, 65);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(40, 13);
            this.lblTabela.TabIndex = 70;
            this.lblTabela.Text = "Tabela";
            // 
            // txtDefault
            // 
            this.txtDefault.Enabled = false;
            this.txtDefault.Location = new System.Drawing.Point(51, 254);
            this.txtDefault.Name = "txtDefault";
            this.txtDefault.Size = new System.Drawing.Size(166, 20);
            this.txtDefault.TabIndex = 69;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(31, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // checkObrig
            // 
            this.checkObrig.AutoSize = true;
            this.checkObrig.Location = new System.Drawing.Point(31, 292);
            this.checkObrig.Name = "checkObrig";
            this.checkObrig.Size = new System.Drawing.Size(111, 17);
            this.checkObrig.TabIndex = 8;
            this.checkObrig.Text = "Campo obrigatório";
            this.checkObrig.UseVisualStyleBackColor = true;
            // 
            // checkDefault
            // 
            this.checkDefault.AutoSize = true;
            this.checkDefault.Location = new System.Drawing.Point(31, 231);
            this.checkDefault.Name = "checkDefault";
            this.checkDefault.Size = new System.Drawing.Size(186, 17);
            this.checkDefault.TabIndex = 7;
            this.checkDefault.Text = "Definir valor padrão para o campo";
            this.checkDefault.UseVisualStyleBackColor = true;
            this.checkDefault.CheckedChanged += new System.EventHandler(this.checkDefault_CheckedChanged);
            // 
            // cbxValid
            // 
            this.cbxValid.FormattingEnabled = true;
            this.cbxValid.Items.AddRange(new object[] {
            "Nenhum",
            "Vinculado a entidades",
            "Valores válidos",
            "Avançado"});
            this.cbxValid.Location = new System.Drawing.Point(352, 132);
            this.cbxValid.Name = "cbxValid";
            this.cbxValid.Size = new System.Drawing.Size(115, 21);
            this.cbxValid.TabIndex = 5;
            this.cbxValid.SelectedIndexChanged += new System.EventHandler(this.cbxValid_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Validação";
            // 
            // cbxEstru
            // 
            this.cbxEstru.FormattingEnabled = true;
            this.cbxEstru.Location = new System.Drawing.Point(120, 169);
            this.cbxEstru.Name = "cbxEstru";
            this.cbxEstru.Size = new System.Drawing.Size(115, 21);
            this.cbxEstru.TabIndex = 6;
            this.cbxEstru.SelectedIndexChanged += new System.EventHandler(this.cbxEstru_SelectedIndexChanged);
            // 
            // lblEstru
            // 
            this.lblEstru.AutoSize = true;
            this.lblEstru.Location = new System.Drawing.Point(28, 177);
            this.lblEstru.Name = "lblEstru";
            this.lblEstru.Size = new System.Drawing.Size(49, 13);
            this.lblEstru.TabIndex = 62;
            this.lblEstru.Text = "Estrutura";
            // 
            // txtSize
            // 
            this.txtSize.Enabled = false;
            this.txtSize.Location = new System.Drawing.Point(352, 96);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(115, 20);
            this.txtSize.TabIndex = 3;
            this.txtSize.Text = "0";
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Location = new System.Drawing.Point(278, 99);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(68, 13);
            this.lblComp.TabIndex = 60;
            this.lblComp.Text = "Comprimento";
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Alfanumérico",
            "Númerico",
            "Data/hora",
            "Unidades e totais",
            "Geral"});
            this.cbxTipo.Location = new System.Drawing.Point(120, 132);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(115, 21);
            this.cbxTipo.TabIndex = 4;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(28, 135);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 58;
            this.lblTipo.Text = "Tipo";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(352, 62);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(115, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(278, 65);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(55, 13);
            this.lblDesc.TabIndex = 56;
            this.lblDesc.Text = "Descrição";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(120, 96);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(115, 20);
            this.txtTitulo.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(28, 99);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(86, 13);
            this.lblTitulo.TabIndex = 54;
            this.lblTitulo.Text = "Nome da Coluna";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(28, 19);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(88, 13);
            this.lblInfo.TabIndex = 53;
            this.lblInfo.Text = "Dados do campo";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CriadorTabelas.Properties.Resources.SAP_Business_One;
            this.pictureBox2.Location = new System.Drawing.Point(0, 439);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Silver;
            this.lblVersion.Location = new System.Drawing.Point(682, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(67, 13);
            this.lblVersion.TabIndex = 72;
            this.lblVersion.Text = "Versão 1.0.6";
            // 
            // formCriadorTabelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(753, 565);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "formCriadorTabelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criador de tabelas";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPag0.ResumeLayout(false);
            this.tabPag0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPag2.ResumeLayout(false);
            this.tabPag2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tb.ResumeLayout(false);
            this.tb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem geralToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPag2;
        private System.Windows.Forms.TabPage tb;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRegUDO;
        private System.Windows.Forms.Button btnCriarCol;
        private System.Windows.Forms.TextBox txtAviso;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.TabPage tabPag0;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel a;
        private TextBox txtLicenServer;
        private Label lblLicenseServer;
        private TextBox txtUPasswBD;
        private Button btnDesconect;
        private Label label4;
        private Button btnConnect;
        private TextBox txtUserDB;
        private Label lblDbUser;
        private Label label3;
        private TextBox txtUserPass;
        private Label label2;
        private TextBox txtUserC;
        private Label lblUser;
        private TextBox txtCompany;
        private Label lblBase;
        private TextBox txtServer;
        private Label lblServer;
        private Label label1;
        private ToolStripMenuItem StripMenuSair;
        private ComboBox cbxEstru;
        private Label lblEstru;
        private TextBox txtSize;
        private Label lblComp;
        private ComboBox cbxTipo;
        private Label lblTipo;
        private TextBox txtDescricao;
        private Label lblDesc;
        private TextBox txtTitulo;
        private Label lblTitulo;
        private Label lblInfo;
        private CheckBox checkDefault;
        private ComboBox cbxValid;
        private Label label6;
        private CheckBox checkObrig;
        private Button btnAdd;
        private TextBox txtDefault;
        private TextBox txtTabela;
        private Label lblTabela;
        private DataGridView dtGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private ComboBox cbxVersionDB;
        private Label lblVersion;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}

