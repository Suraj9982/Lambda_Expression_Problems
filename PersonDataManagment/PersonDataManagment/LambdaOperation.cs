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
    }
}
