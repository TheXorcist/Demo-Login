using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using Parts.Sqlcheck;

namespace Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            string uid;
            string pas;

            Console.WriteLine("Enter your userid : ");
            uid = Console.ReadLine();

            Console.WriteLine("Enter your passoword : ");
            pas = Console.ReadLine();

            bool output = Sqlcheck.sql(uid, pas);
            if (output==true)
            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Login Unsuccessful");
            }
        }
    }
}