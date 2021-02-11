using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using Parts.Login;
using Parts.Signup;
using Parts.UserChecks;
using Parts.PaswordCheck;
using Parts.CredentialsCheck;

namespace Demo_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            rebirth:
            string uid;
            string pas;

            Console.WriteLine("Menu :");
            Console.WriteLine("1. New User???? => Sign Up");
            Console.WriteLine("2. Existing User???? => Login");
            int ch = Convert.ToInt32(Console.ReadLine());
           
            switch (ch)
            {
                case 1:
                Console.WriteLine("Enter your preferred userid :");
                uid = Console.ReadLine();
                bool check = UserChecks.sql(uid);
                if(check==true)
                {
                    Console.WriteLine("The username already exists !!! \nIf you are an existing user login press Y else N");
                    string t = Console.ReadLine();
                    
                    if(t.Equals('Y')==true)
                    goto case 1;
                    else 
                    goto rebirth;
                }
                rebirth2:
                Console.WriteLine("Enter your desired password :       (THE PASSWORD MUST BE AT LEAST 8 CHARECTERS LONG WITH ONE NUMBER)");
                pas = Console.ReadLine();
                bool check2 = PaswordCheck.chk(pas);
                if(check2==true)
                {
                Signup.sign(uid, pas);
                Console.WriteLine("You Have Successfully Signed Up for this demo to be used by us LOL!!!....now i will hack your facibuk");
                }
                else
                {
                    Console.WriteLine("Bhikari Thik Pasword de re bhai");
                    goto rebirth2;
                }
                break;

                case 2:
                Console.WriteLine("Enter your userid : ");
                uid = Console.ReadLine();

                Console.WriteLine("Enter your passoword : ");
                pas = Console.ReadLine();

                bool output = CredentialsCheck.sql(uid, pas);
                if (output==true)
                {
                    Console.WriteLine("Login Successful!!!!!!! EBAR Ghumo");
                }
                else
                {
                    Console.WriteLine("Login Unsuccessful!!!!! Asikhhito");
                    goto rebirth;
                }
                break;

                default:
                Console.WriteLine("Wrong Choice");
                goto rebirth;
                
                    

            }
            

            
        }
    }
}