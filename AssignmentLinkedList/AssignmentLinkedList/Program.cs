using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentLinkedList
{
    class LinkedListDemo
    {
        static void Main()
        {

            LinkedList<String> my_list = new LinkedList<String>();


            // Using AddLast() method 
            my_list.AddLast("Akash");
            my_list.AddLast("Ankit");
            my_list.AddLast("Sayantan");
            my_list.AddLast("Arindam");
            my_list.AddLast("Sovondip");
            my_list.AddLast("Bikramjit");

            Console.WriteLine("-----------------List of Associates--------------------");


            // LinkedList Using foreach loop 
            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("-----------------List of Associates--------------------");

            my_list.Remove(my_list.First);

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }



            Console.WriteLine("-----------------List of Associates--------------------");

            my_list.RemoveLast();

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }


            my_list.Clear();
            Console.WriteLine("Number of students: {0}",
                                         my_list.Count);

            Console.ReadLine();
        }
    }
}