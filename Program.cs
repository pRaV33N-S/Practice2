using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string password;
            Console.WriteLine("UserName :\t");
            userName=Console.ReadLine();
            Console.WriteLine("Password :\t");
            password=Console.ReadLine();
            if (string.Equals(userName, "admin1256") && string.Equals(password, "admin@1256@1256"))
                Console.WriteLine("SignIn success");
            else if (string.Equals(userName, "") && string.Equals(password, ""))
                Console.WriteLine("Please Provide UserName and Password");
            else
                Console.WriteLine("Invalid User");
        }
    }
}
