using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonDataManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> Listperson = new List<Person>();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("CHOOSE OPTION:\n1.Add Records\n2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        LambdaOperation.Addrecords(Listperson);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }  
    }
}
