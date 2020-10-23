using System;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp4
{
    public class Database
    {
        public MySqlConnection getConn()
        {
            String strConnection = "server=localhost;User id = root;password=123456;Database=c#;Charset=utf8;";
            MySqlConnection conn = new MySqlConnection(strConnection);
            return conn;
        }
    }
}