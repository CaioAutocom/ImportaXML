
namespace ImportaXML
{
    partial class Form1
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
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cfop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Val = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusnfce = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnImporta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultaBancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(11, 62);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(286, 20);
            this.txtCaminho.TabIndex = 0;
            this.txtCaminho.TextChanged += new System.EventHandler(this.txtCaminho_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caminho da pasta dos XMLs";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Num,
            this.mod,
            this.dat,
            this.cfop,
            this.Val,
            this.statusnfce});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 88);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(421, 404);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Num
            // 
            this.Num.Text = "Número";
            // 
            // mod
            // 
            this.mod.Text = "Modelo";
            // 
            // dat
            // 
            this.dat.Text = "Data de emissão";
            this.dat.Width = 100;
            // 
            // cfop
            // 
            this.cfop.Text = "CFOP";
            // 
            // Val
            // 
            this.Val.Text = "Valor";
            // 
            // statusnfce
            // 
            this.statusnfce.Text = "Status";
            // 
            // btnImporta
            // 
            this.btnImporta.Location = new System.Drawing.Point(357, 62);
            this.btnImporta.Name = "btnImporta";
            this.btnImporta.Size = new System.Drawing.Size(75, 20);
            this.btnImporta.TabIndex = 4;
            this.btnImporta.Text = "Importar";
            this.btnImporta.UseVisualStyleBackColor = true;
            this.btnImporta.Click += new System.EventHandler(this.btnImporta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantidade de XMLs na pasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor total dos XML:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(172, 517);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(0, 13);
            this.lblQtd.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(172, 540);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(357, 534);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Exportar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaBancoDeDadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(445, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultaBancoDeDadosToolStripMenuItem
            // 
            this.consultaBancoDeDadosToolStripMenuItem.Name = "consultaBancoDeDadosToolStripMenuItem";
            this.consultaBancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.consultaBancoDeDadosToolStripMenuItem.Text = "Consulta Banco de dados";
            this.consultaBancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.consultaBancoDeDadosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 580);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnImporta);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Importa XML";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnImporta;
        private System.Windows.Forms.ColumnHeader Num;
        private System.Windows.Forms.ColumnHeader mod;
        private System.Windows.Forms.ColumnHeader dat;
        private System.Windows.Forms.ColumnHeader Val;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader statusnfce;
        private System.Windows.Forms.ColumnHeader cfop;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultaBancoDeDadosToolStripMenuItem;
    }
}

