using MySql.Data.MySqlClient;
using System.Net.NetworkInformation;

namespace AppWebLeticia.Configs
{
    public static class DAOHelper
    {
        // Lê uma string; se a coluna for NULL, devolve string vazia
        public static string GetString(MySqlDataReader reader, string column_name)
        {
            string text = string.Empty;
            if (!reader.IsDBNull(reader.GetOrdinal(column_name)))

                text = reader.GetString(column_name);
            return text;
        }

        // Lê um double; se a coluna for NULL, devolve 0.0
        public static DateTime? GetDateTime(MySqlDataReader reader, string column_name)
        {
            DateTime? value = null;
            if (!reader.IsDBNull(reader.GetOrdinal(column_name)))
                value = reader.GetDateTime(column_name);
            return value;
        }

        // Indica se uma coluna está NULL
        public static bool IsNull(MySqlDataReader reader, string column_name)
        {
            return reader.IsDBNull(reader.GetOrdinal(column_name));
        }

    }
}
