
namespace ImportaXML
{
    partial class frmNfce
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConecta = new System.Windows.Forms.Button();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lstNFCE = new System.Windows.Forms.ListView();
            this.numero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emissao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chave = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotVendas = new System.Windows.Forms.Label();
            this.lblValorVendas = new System.Windows.Forms.Label();
            this.lblTrans = new System.Windows.Forms.Label();
            this.lblEncontrados = new System.Windows.Forms.Label();
            this.btnEncontrar = new System.Windows.Forms.Button();
            this.lblTotalValor = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalVendas = new System.Windows.Forms.Label();
            this.lblTransferidos = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.txtCompara = new System.Windows.Forms.Button();
            this.lstXmls = new System.Windows.Forms.ListView();
            this.NumXMl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpInicial
            // 
            this.dtpInicial.CustomFormat = "dd-MM-yyyy";
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(445, 26);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(95, 20);
            this.dtpInicial.TabIndex = 6;
            this.dtpInicial.Value = new System.DateTime(2021, 8, 11, 16, 7, 51, 0);
            // 
            // dtpFinal
            // 
            this.dtpFinal.CustomFormat = "dd-MM-yyyy";
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(445, 53);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(95, 20);
            this.dtpFinal.TabIndex = 7;
            this.dtpFinal.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data Final:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Banco:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Porta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Servidor:";
            // 
            // btnConecta
            // 
            this.btnConecta.Location = new System.Drawing.Point(231, 78);
            this.btnConecta.Name = "btnConecta";
            this.btnConecta.Size = new System.Drawing.Size(100, 23);
            this.btnConecta.TabIndex = 5;
            this.btnConecta.Text = "Conecta";
            this.btnConecta.UseVisualStyleBackColor = true;
            this.btnConecta.Click += new System.EventHandler(this.btnConecta_Click);
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(67, 81);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(100, 20);
            this.txtBanco.TabIndex = 2;
            this.txtBanco.Text = "esistemnfce";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(231, 53);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 4;
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(67, 55);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(100, 20);
            this.txtPorta.TabIndex = 1;
            this.txtPorta.Text = "5432";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(231, 26);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 3;
            this.txtUser.Text = "postgres";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(67, 26);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(100, 20);
            this.txtServer.TabIndex = 0;
            this.txtServer.Text = "localhost";
            // 
            // lstNFCE
            // 
            this.lstNFCE.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numero,
            this.modelo,
            this.serie,
            this.emissao,
            this.valor,
            this.chave,
            this.status,
            this.descricao});
            this.lstNFCE.FullRowSelect = true;
            this.lstNFCE.GridLines = true;
            this.lstNFCE.HideSelection = false;
            this.lstNFCE.HoverSelection = true;
            this.lstNFCE.Location = new System.Drawing.Point(15, 119);
            this.lstNFCE.Name = "lstNFCE";
            this.lstNFCE.Size = new System.Drawing.Size(661, 523);
            this.lstNFCE.TabIndex = 23;
            this.lstNFCE.UseCompatibleStateImageBehavior = false;
            this.lstNFCE.View = System.Windows.Forms.View.Details;
            this.lstNFCE.SelectedIndexChanged += new System.EventHandler(this.lstNFCE_SelectedIndexChanged);
            // 
            // numero
            // 
            this.numero.Text = "Número";
            // 
            // modelo
            // 
            this.modelo.Text = "Modelo";
            this.modelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.modelo.Width = 80;
            // 
            // serie
            // 
            this.serie.Text = "Série";
            this.serie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.serie.Width = 40;
            // 
            // emissao
            // 
            this.emissao.Text = "Emissão";
            this.emissao.Width = 100;
            // 
            // valor
            // 
            this.valor.Text = "Valor";
            this.valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chave
            // 
            this.chave.Text = "Chave de acesso";
            this.chave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chave.Width = 250;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descricao
            // 
            this.descricao.Text = "Descrição Status";
            this.descricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.descricao.Width = 200;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(680, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Transferir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotVendas);
            this.groupBox1.Controls.Add(this.lblValorVendas);
            this.groupBox1.Controls.Add(this.lblTrans);
            this.groupBox1.Controls.Add(this.lblEncontrados);
            this.groupBox1.Controls.Add(this.btnEncontrar);
            this.groupBox1.Controls.Add(this.lblTotalValor);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblTotalVendas);
            this.groupBox1.Controls.Add(this.lblTransferidos);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(22, 648);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 100);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumo:";
            // 
            // lblTotVendas
            // 
            this.lblTotVendas.AutoSize = true;
            this.lblTotVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotVendas.Location = new System.Drawing.Point(175, 29);
            this.lblTotVendas.Name = "lblTotVendas";
            this.lblTotVendas.Size = new System.Drawing.Size(0, 20);
            this.lblTotVendas.TabIndex = 26;
            // 
            // lblValorVendas
            // 
            this.lblValorVendas.AutoSize = true;
            this.lblValorVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorVendas.Location = new System.Drawing.Point(175, 60);
            this.lblValorVendas.Name = "lblValorVendas";
            this.lblValorVendas.Size = new System.Drawing.Size(0, 20);
            this.lblValorVendas.TabIndex = 26;
            // 
            // lblTrans
            // 
            this.lblTrans.AutoSize = true;
            this.lblTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrans.Location = new System.Drawing.Point(579, 60);
            this.lblTrans.Name = "lblTrans";
            this.lblTrans.Size = new System.Drawing.Size(0, 20);
            this.lblTrans.TabIndex = 26;
            // 
            // lblEncontrados
            // 
            this.lblEncontrados.AutoSize = true;
            this.lblEncontrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncontrados.Location = new System.Drawing.Point(579, 26);
            this.lblEncontrados.Name = "lblEncontrados";
            this.lblEncontrados.Size = new System.Drawing.Size(0, 20);
            this.lblEncontrados.TabIndex = 26;
            // 
            // btnEncontrar
            // 
            this.btnEncontrar.Location = new System.Drawing.Point(680, 26);
            this.btnEncontrar.Name = "btnEncontrar";
            this.btnEncontrar.Size = new System.Drawing.Size(103, 23);
            this.btnEncontrar.TabIndex = 0;
            this.btnEncontrar.Text = "Encontrar XML";
            this.btnEncontrar.UseVisualStyleBackColor = true;
            this.btnEncontrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblTotalValor
            // 
            this.lblTotalValor.AutoSize = true;
            this.lblTotalValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValor.Location = new System.Drawing.Point(144, 60);
            this.lblTotalValor.Name = "lblTotalValor";
            this.lblTotalValor.Size = new System.Drawing.Size(0, 20);
            this.lblTotalValor.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(72, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Valor total:";
            // 
            // lblTotalVendas
            // 
            this.lblTotalVendas.AutoSize = true;
            this.lblTotalVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVendas.Location = new System.Drawing.Point(144, 26);
            this.lblTotalVendas.Name = "lblTotalVendas";
            this.lblTotalVendas.Size = new System.Drawing.Size(0, 20);
            this.lblTotalVendas.TabIndex = 0;
            // 
            // lblTransferidos
            // 
            this.lblTransferidos.AutoSize = true;
            this.lblTransferidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferidos.Location = new System.Drawing.Point(423, 60);
            this.lblTransferidos.Name = "lblTransferidos";
            this.lblTransferidos.Size = new System.Drawing.Size(160, 20);
            this.lblTransferidos.TabIndex = 0;
            this.lblTransferidos.Text = "XMLs transferidos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(419, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "XMLs encontrados:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Número de vendas:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1191, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 20);
            this.button3.TabIndex = 27;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(899, 28);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(286, 20);
            this.txtCaminho.TabIndex = 26;
            this.txtCaminho.TextChanged += new System.EventHandler(this.txtCaminho_TextChanged);
            // 
            // txtCompara
            // 
            this.txtCompara.Location = new System.Drawing.Point(1150, 60);
            this.txtCompara.Name = "txtCompara";
            this.txtCompara.Size = new System.Drawing.Size(75, 23);
            this.txtCompara.TabIndex = 28;
            this.txtCompara.Text = "Comparar";
            this.txtCompara.UseVisualStyleBackColor = true;
            this.txtCompara.Click += new System.EventHandler(this.txtCompara_Click);
            // 
            // lstXmls
            // 
            this.lstXmls.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumXMl});
            this.lstXmls.FullRowSelect = true;
            this.lstXmls.GridLines = true;
            this.lstXmls.HideSelection = false;
            this.lstXmls.HoverSelection = true;
            this.lstXmls.Location = new System.Drawing.Point(702, 119);
            this.lstXmls.Name = "lstXmls";
            this.lstXmls.Size = new System.Drawing.Size(572, 523);
            this.lstXmls.TabIndex = 29;
            this.lstXmls.UseCompatibleStateImageBehavior = false;
            this.lstXmls.View = System.Windows.Forms.View.Details;
            this.lstXmls.SelectedIndexChanged += new System.EventHandler(this.lstXmls_SelectedIndexChanged);
            // 
            // NumXMl
            // 
            this.NumXMl.Text = "Números XML";
            this.NumXMl.Width = 120;
            // 
            // frmNfce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 758);
            this.Controls.Add(this.lstXmls);
            this.Controls.Add(this.txtCompara);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstNFCE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnConecta);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicial);
            this.Name = "frmNfce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa do banco";
            this.Load += new System.EventHandler(this.frmNfce_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConecta;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.ListView lstNFCE;
        private System.Windows.Forms.ColumnHeader numero;
        private System.Windows.Forms.ColumnHeader modelo;
        private System.Windows.Forms.ColumnHeader serie;
        private System.Windows.Forms.ColumnHeader emissao;
        private System.Windows.Forms.ColumnHeader chave;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader descricao;
        private System.Windows.Forms.ColumnHeader valor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalValor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalVendas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEncontrar;
        private System.Windows.Forms.Label lblEncontrados;
        private System.Windows.Forms.Label lblTransferidos;
        private System.Windows.Forms.Label lblTrans;
        private System.Windows.Forms.Label lblValorVendas;
        private System.Windows.Forms.Label lblTotVendas;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Button txtCompara;
        private System.Windows.Forms.ListView lstXmls;
        private System.Windows.Forms.ColumnHeader NumXMl;
    }
}