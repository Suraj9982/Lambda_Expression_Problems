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
            Console.WriteLine("Addrecords is compulsary to perform all this operation");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("CHOOSE OPTION:\n1.Add Records\n2.Retreive Top Two Age Less Than Sixty\n3.Retreiving Teenagers\n4.Find Average Age\n5.Check for specific name\n6.Skip Which Age is less than Sixty\n7.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        LambdaOperation.Addrecords(Listperson);
                        break;
                    case 2:
                        LambdaOperation.Retreiving_TopTwoRecords_Age_LessThanSixty(Listperson);
                        break;
                    case 3:
                        LambdaOperation.Retreiving_Records_Age_BetweenThirteenToEighteen(Listperson);
                        break;
                    case 4:
                        LambdaOperation.Retreiving_Records_Average_Age(Listperson);
                        break;
                    case 5:
                        LambdaOperation.Retreiving_Records_Check_Specific_Name(Listperson);
                        break;
                    case 6:
                        LambdaOperation.Retreiving_Records_Skip_Age_LessThanSixty(Listperson);
                        break;
                    case 7:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Your choice between 1 to 7");
                        break;
                }
            }
        }  
    }
}
