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
                Console.WriteLine("CHOOSE OPTION:\n1.Add Records\n2.Retreive Top Two Age Less Than Sixty\n3.Retreiving Teenagers\n4.Find Average Age\n5.Exit");
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
                        LambdaOperation.Addrecords(Listperson);
                        LambdaOperation.Retreiving_Records_Age_BetweenThirteenToEighteen(Listperson);
                        break;
                    case 4:
                        LambdaOperation.Addrecords(Listperson);
                        LambdaOperation.Retreiving_Records_Average_Age(Listperson);
                        break;
                    case 5:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Your choice between 1 to 4");
                        break;
                }
            }
        }  
    }
}
