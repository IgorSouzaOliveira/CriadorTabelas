
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPag2 = new System.Windows.Forms.TabPage();
            this.lblReturn = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnExec = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.linkLog = new System.Windows.Forms.LinkLabel();
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.DateNow = new System.Windows.Forms.DateTimePicker();
            this.tabControl.SuspendLayout();
            this.tabPag2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPag2);
            this.tabControl.Controls.Add(this.tb);
            this.tabControl.Location = new System.Drawing.Point(1, 25);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(748, 540);
            this.tabControl.TabIndex = 52;
            // 
            // tabPag2
            // 
            this.tabPag2.Controls.Add(this.btnExit);
            this.tabPag2.Controls.Add(this.pictureBox3);
            this.tabPag2.Controls.Add(this.lblReturn);
            this.tabPag2.Controls.Add(this.lblStatus);
            this.tabPag2.Controls.Add(this.btnExec);
            this.tabPag2.Controls.Add(this.progressBar);
            this.tabPag2.Controls.Add(this.linkLog);
            this.tabPag2.Controls.Add(this.pictureBox1);
            this.tabPag2.Location = new System.Drawing.Point(4, 22);
            this.tabPag2.Name = "tabPag2";
            this.tabPag2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPag2.Size = new System.Drawing.Size(740, 514);
            this.tabPag2.TabIndex = 0;
            this.tabPag2.Text = "Criador AddOn ";
            this.tabPag2.UseVisualStyleBackColor = true;
            // 
            // lblReturn
            // 
            this.lblReturn.AccessibleDescription = "";
            this.lblReturn.AutoSize = true;
            this.lblReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.ForeColor = System.Drawing.Color.Blue;
            this.lblReturn.Location = new System.Drawing.Point(50, 329);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(0, 15);
            this.lblReturn.TabIndex = 66;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Blue;
            this.lblStatus.Location = new System.Drawing.Point(11, 329);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 15);
            this.lblStatus.TabIndex = 65;
            this.lblStatus.Text = "Status:";
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(8, 379);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(75, 23);
            this.btnExec.TabIndex = 64;
            this.btnExec.Text = "Executar";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(8, 347);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(731, 23);
            this.progressBar.TabIndex = 63;
            // 
            // linkLog
            // 
            this.linkLog.AutoSize = true;
            this.linkLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLog.Location = new System.Drawing.Point(704, 382);
            this.linkLog.Name = "linkLog";
            this.linkLog.Size = new System.Drawing.Size(31, 16);
            this.linkLog.TabIndex = 62;
            this.linkLog.TabStop = true;
            this.linkLog.Text = "Log";
            this.linkLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            this.tb.Size = new System.Drawing.Size(745, 514);
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
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(117, 88);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(501, 181);
            this.pictureBox3.TabIndex = 67;
            this.pictureBox3.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(89, 379);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 68;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DateNow
            // 
            this.DateNow.Enabled = false;
            this.DateNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateNow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateNow.Location = new System.Drawing.Point(648, 12);
            this.DateNow.Name = "DateNow";
            this.DateNow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateNow.Size = new System.Drawing.Size(96, 20);
            this.DateNow.TabIndex = 53;
            // 
            // formCriadorTabelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(749, 565);
            this.Controls.Add(this.DateNow);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formCriadorTabelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criador de tabelas";
            this.tabControl.ResumeLayout(false);
            this.tabPag2.ResumeLayout(false);
            this.tabPag2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tb.ResumeLayout(false);
            this.tb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPag2;
        private System.Windows.Forms.TabPage tb;
        private System.Windows.Forms.PictureBox pictureBox2;
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
        private LinkLabel linkLog;
        private ProgressBar progressBar;
        private Button btnExec;
        private Label lblStatus;
        private Label lblReturn;
        private PictureBox pictureBox3;
        private Button btnExit;
        private DateTimePicker DateNow;
    }
}

