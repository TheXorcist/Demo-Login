using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Parts.UserChecks
{
    class UserChecks
    {
        public static bool sql(string a)
        {
            const string sqlString = @"server=127.0.0.1;userid=root;password=123456;database=temp";
            using var sqlConnection = new MySqlConnection(sqlString);

            sqlConnection.Open();

            bool flag = false;

            string useDbString = "USE temp;";
            var useDbCommand = new MySqlCommand(useDbString, sqlConnection);
            useDbCommand.ExecuteNonQuery();

            string command = "SELECT * FROM users;";
            var newCommand = new MySqlCommand(command, sqlConnection);

            using var reader = newCommand.ExecuteReader();

            while(reader.Read())
            {
                if(reader[0].ToString()==a)
                {
                    flag = true;
                    return flag;
                }
            }
            return flag;        
            
        }  

    }
}