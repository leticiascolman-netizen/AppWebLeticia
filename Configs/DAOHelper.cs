using MySql.Data.MySqlClient;

namespace AppWebLeticia.Configs
{
    public static class DAOHelper
    {
        public static string GetString(MySqlDataReader reader, string columnName)
        {
            if (reader.IsDBNull(reader.GetOrdinal(columnName)))
                return string.Empty;

            return reader.GetString(columnName);
        }

        public static DateOnly? GetDateOnly(MySqlDataReader reader, string columnName)
        {
            if (reader.IsDBNull(reader.GetOrdinal(columnName)))
                return null;

            return DateOnly.FromDateTime(reader.GetDateTime(columnName));
        }

        public static bool IsNull(MySqlDataReader reader, string columnName)
        {
            return reader.IsDBNull(reader.GetOrdinal(columnName));
        }
    }
}
