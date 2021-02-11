using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Parts.Signup
{
    class Signup
    {
        public static void sign(string a, string b)
        {
            const string sqlString = @"server=127.0.0.1;userid=root;password=123456;database=temp";
            using var sqlConnection = new MySqlConnection(sqlString);

            sqlConnection.Open();

            string useDbString = "USE temp;";
            var useDbCommand = new MySqlCommand(useDbString, sqlConnection);
            useDbCommand.ExecuteNonQuery();

            string command = "INSERT INTO users(userid, pass) VALUES('"+a+"','"+b+"');";
            var newCommand = new MySqlCommand(command, sqlConnection);      
            
        }  

    }
}