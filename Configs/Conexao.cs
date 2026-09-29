using MySql.Data.MySqlClient;

namespace AppWebLeticia.Configs
{
    public class Conexao
    {
        private readonly string _connectionString;

        // A IConfiguration é injetada automaticamente e permite ler o appsetting.json
        public Conexao(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("MySqlConnection") ?? "";
        }

        // Cria e ABRE uma nova conexão com o banco
        public MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(_connectionString);

            conn.Open();
            return conn;
        }

        // Cria um comando SQL. Se nehuma conexão for passada, abre uma nova.
        public MySqlCommand CreateCommand(string query, MySqlConnection? conn = null)
        {
            conn ??= GetConnection();
            return new MySqlCommand(query, conn)
;        }
   

    }
}
