using Npgsql;

namespace ImportaXML
{
    public class Conexao
    {
        public string server { get; set; }
        public string porta { get; set; }
        public string banco { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }

        public NpgsqlConnection conecta()
        {
            NpgsqlConnection conn = new NpgsqlConnection($"Server={this.server};Port={this.porta};User Id={this.usuario};Password={this.senha};Database={this.banco};");
            conn.Open();
            return conn;
        }
    }
}
