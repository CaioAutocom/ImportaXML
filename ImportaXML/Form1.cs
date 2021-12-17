using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace ImportaXML
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        string rootPath = null;


        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    //string[] files = Directory.GetFiles(fbd.SelectedPath);
                    txtCaminho.Text = Environment.CurrentDirectory = (fbd.SelectedPath);
                    rootPath = txtCaminho.Text;
                    //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }

            //OpenFileDialog folderBrowser = new OpenFileDialog();
            //// Set validate names and check file exists to false otherwise windows will
            //// not let you select "Folder Selection."
            //folderBrowser.ValidateNames = false;
            //folderBrowser.CheckFileExists = false;
            //folderBrowser.CheckPathExists = true;
            //// Always default to Folder Selection.
            //folderBrowser.FileName = "selecione a pasta";
            //if (folderBrowser.ShowDialog() == DialogResult.OK)
            //{
            //    //string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
            //    txtCaminho.Text = Path.GetDirectoryName(folderBrowser.FileName);
            //    rootPath = txtCaminho.Text;
            //    // ...
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnImporta.Enabled = false;
            rootPath = txtCaminho.Text;
            //verifica_root();
        }

        private void button2_Click(object sender, EventArgs e)
        {




        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public bool verifica_root()
        {
            if (rootPath is null || string.IsNullOrEmpty(txtCaminho.Text) || string.IsNullOrWhiteSpace(txtCaminho.Text))
            {
                btnImporta.Enabled = false;
                return false;
            }
            btnImporta.Enabled = true;
            return true;
        }
        private async void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "txt";
            saveDialog.AddExtension = true;
            saveDialog.FileName = "Importação_xml";
            saveDialog.InitialDirectory = @"C:\Users\desktop";
            saveDialog.OverwritePrompt = true;
            saveDialog.Title = "Salvar...";
            saveDialog.ValidateNames = true;
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                {
                    foreach (ListViewItem item in lstNFCeLidos.Items)
                    {
                        await writer.WriteLineAsync(item.SubItems[0].Text + "\t" + item.SubItems[1].Text + "\t" + item.SubItems[2].Text + "\t" + item.SubItems[3].Text + "\t" + item.SubItems[4].Text + "\t" + item.SubItems[5].Text);
                    }
                }

            }
        }

        private void txtCaminho_TextChanged(object sender, EventArgs e)
        {
            rootPath = txtCaminho.Text;
            verifica_root();
        }

        private void btnImporta_Click(object sender, EventArgs e)
        {
            int qtd = 0;
            var files = Directory.GetFiles(rootPath, "*.xml", SearchOption.AllDirectories);
            double soma = 0;
            foreach (string file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
                using (XmlReader xml = XmlReader.Create(file))
                {
                    Nfce nota = new Nfce();

                    while (xml.Read())
                    {
                        if (xml.Name == "cStat") nota.status = xml.ReadElementContentAsString();
                        if (xml.Name == "mod") nota.mod = xml.ReadElementContentAsString();
                        if (xml.Name == "vNF") nota.valor = xml.ReadElementContentAsString();
                        if (xml.Name == "nNF") nota.numero = xml.ReadElementContentAsString();
                        if (xml.Name == "dhEmi") nota.data = xml.ReadElementContentAsString();
                        if (xml.Name == "CFOP") nota.cfop = xml.ReadElementContentAsString();
                        if (nota.status == "101") MessageBox.Show("Existe NFCE cancelada dentro da pasta");
                    }
                    qtd += 1;
                    try
                    {
                        lstNFCeLidos.Items.Add(new ListViewItem(new[] { nota.numero, nota.mod, nota.data, nota.cfop, nota.valor, nota.status, })); ;

                        soma = Convert.ToDouble(nota.valor) + soma;
                    }
                    catch (Exception)
                    {
                        lstNFCeLidos.Items.Add(new ListViewItem(new[] { "inválido", "inválido", "inválido", "inválido" })); ;
                    }

            }
                lblTotal.Text = soma.ToString();
                lblQtd.Text = qtd.ToString();
            }
        }




        private void porCFOPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void consultaBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmNfce frm = new frmNfce(this);
            frm.Show();

        }
    }
}
