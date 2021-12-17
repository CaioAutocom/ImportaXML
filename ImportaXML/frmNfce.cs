using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ImportaXML
{
    public partial class frmNfce : Form
    {
        Conexao cn = new Conexao();
        List<string> chaves = new List<string>();
        string rootPath = @"C:\AutoCom\eSistemNFCe\NFCe";
        string rootPathXml = "";
        string target = @"C:\Users\Caio\Desktop\Sintegra-Banco\";
        decimal valorTotal;
        int qtdXmlCopiados = 0;
        int qtdXmlEncontrados = 0;
        int i = 0;

        public frmNfce(ListView xmlLidos)
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmNfce_Load(object sender, EventArgs e)
        {

        }

        private void btnConecta_Click(object sender, EventArgs e)
        {
            cn.server = txtServer.Text;
            cn.banco = txtBanco.Text;
            cn.porta = txtPorta.Text;
            cn.usuario = txtUser.Text;
            cn.senha = txtSenha.Text;
            try
            {
                cn.conecta();
                btnConecta.BackColor = Color.SeaGreen;
            }
            catch (Exception f)
            {
                MessageBox.Show(f.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstNFCE.Items.Clear();
            valorTotal = 0;
            lstNFCE.View = View.Details;



            NpgsqlConnection cnn = cn.conecta();
            string sql = $"select numero, modelo, serie, emissao::date, valortotal , chaveacesso, codigostatus,descricaostatus from nfce where codigostatus in ('100','101') and movimento::date between'{dtpInicial.Text}' and '{dtpFinal.Text}'";

            NpgsqlCommand com = new NpgsqlCommand(sql, cnn);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(com);
            da.SelectCommand = com;
            DataSet ds = new DataSet();
            da.Fill(ds, "table");
            DataTable dt = new DataTable();
            dt = ds.Tables["table"];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chaves.Add(dt.Rows[i].ItemArray[5].ToString());
                valorTotal += Convert.ToDecimal(dt.Rows[i].ItemArray[4]);

                lstNFCE.Items.Add(new ListViewItem(new[] {
               dt.Rows[i].ItemArray[0].ToString(),
               dt.Rows[i].ItemArray[1].ToString(),
               dt.Rows[i].ItemArray[2].ToString(),
               dt.Rows[i].ItemArray[3].ToString(),
               dt.Rows[i].ItemArray[4].ToString(),
               dt.Rows[i].ItemArray[5].ToString(),
               dt.Rows[i].ItemArray[6].ToString(),
               dt.Rows[i].ItemArray[7].ToString()

            }));

            }
            lblValorVendas.Text = valorTotal.ToString();

            lblTotVendas.Text = lstNFCE.Items.Count.ToString();
        }



        private void lstNFCE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (string chave in chaves)
            {

                var files = Directory.GetFiles(rootPath, $"*{chave}*.*", SearchOption.AllDirectories);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    try
                    {
                        File.Copy(file, target + fileName, true);
                        qtdXmlCopiados += 1;
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Erro" + er.ToString());
                        qtdXmlCopiados -= 1;
                    }
                }
            }

            lblTrans.Text = qtdXmlCopiados.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {


            procura();

        }

        public void procura()
        {
            //await Task.Run(() =>
            //{
            foreach (string chave in chaves)
            {
                var files = Directory.GetFiles(rootPath, $"*{chave}*.*", SearchOption.AllDirectories);
                foreach (string file in files)
                {
                    //string fileName = Path.GetFileName(file);
                    //File.Copy(file, target + fileName, true);

                    lblEncontrados.Text = (qtdXmlEncontrados += 1).ToString();

                }
            }
            //});
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    //string[] files = Directory.GetFiles(fbd.SelectedPath);
                    txtCaminho.Text = Environment.CurrentDirectory = (fbd.SelectedPath);
                    rootPathXml = txtCaminho.Text;
                    //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }
        }

        private void txtCaminho_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCompara_Click(object sender, EventArgs e)
        {


            List<string> numeros = new List<string>();
            var files = Directory.GetFiles(rootPathXml, "*.xml", SearchOption.AllDirectories);
            
        }

        private void lstXmls_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

       
    }
