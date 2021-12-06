using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagment
{
    class LambdaOperation
    {
        public static void Addrecords(List<Person> Listperson)
        {
            Listperson.Add(new Person("226547", "John", "11,newyorkCity", 15));
            Listperson.Add(new Person("226576", "ronny", "12,faridabad", 22));
            Listperson.Add(new Person("226543", "suraj", "45,delhi", 65));
            Listperson.Add(new Person("226590", "Aman", "15,texas", 55));
            Listperson.Add(new Person("226532", "sahil", "22,mumbai", 80));
            Listperson.Add(new Person("226523", "nitish", "11,barely", 61));
            Listperson.Add(new Person("226554", "guddu", "789,gorakhpur", 18));
            Listperson.Add(new Person("226563", "munna", "11,buxar", 30));
            Listperson.Add(new Person("226562", "tom", "15,washington", 21));
            foreach(var item in Listperson)
            {
                Console.WriteLine("SSN:"+item.SSN+"\t"+"Name:"+item.Name+"\t"+"Address:"+item.Address+"\t"+"Age:"+item.Age);
            }
        }
        public static void Retreiving_TopTwoRecords_Age_LessThanSixty(List<Person> Listperson)
        {
            foreach(Person person in Listperson.FindAll(e => e.Age <= 60).Take(2).ToList())
            {
                Console.WriteLine("Name:"+person.Name+"\t"+"Age:"+person.Age);
            }
        }
        public static void Retreiving_Records_Age_BetweenThirteenToEighteen(List<Person> Listperson)
        {
            if (Listperson.Any(e => e.Age >= 13 && e.Age <= 19))
            {
                Console.WriteLine("There are tenagers in List");
            }
            else
            {
                Console.WriteLine("There is no tenagers");
            }
        }
        public static void Retreiving_Records_Average_Age(List<Person> Listperson)
        {
            double averge=Listperson.Average(e=>e.Age);
            Console.WriteLine("Averge of Age in list:"+averge);
        }
        public static void Retreiving_Records_Check_Specific_Name(List<Person> Listperson)
        {
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
            if (Listperson.Any(e => e.Name == name))
            {
                Console.WriteLine("This name exist in the list");
            }
            else
            {
                Console.WriteLine("This name does not exist in the list");
            }
        }
    }
}
