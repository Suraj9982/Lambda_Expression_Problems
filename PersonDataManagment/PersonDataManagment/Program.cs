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
                Console.WriteLine("CHOOSE OPTION:\n1.Add Records\n2.Retreive Top Two Age Less Than Sixty\n3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        LambdaOperation.Addrecords(Listperson);
                        break;
                    case 2:
                        LambdaOperation.Addrecords(Listperson);
                        LambdaOperation.Retreiving_TopTwoRecords_Age_LessThanSixty(Listperson);
                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Your choice between 1 to 3");
                        break;
                }
            }
        }  
    }
}
