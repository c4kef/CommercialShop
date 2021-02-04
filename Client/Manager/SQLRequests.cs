using MySql.Data.MySqlClient;

namespace Client.Manager
{
    class SQLRequests
    {
        private MySqlConnection sql;

        public MySqlConnection GetInstance() => sql;

        public void Connect(string server, string user, string password, string database)
        {
            string connectionString = $"server={server};user={user};database={database};password={password};charset=utf8;";
            sql = new MySqlConnection(connectionString);
        }

        public string GetAnswer(string request)
        {
            sql?.Open();
            MySqlCommand command = new MySqlCommand(request, sql);
            string str = "";

            if (!request.Contains("INSERT") && !request.Contains("UPDATE") && !request.Contains("DELETE"))
                str = command.ExecuteScalar().ToString();
            else
                command.ExecuteScalar();

            sql.Close();
            return str;
        }
    }
}
