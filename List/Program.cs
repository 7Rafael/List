using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            // O add ele pode adicionar item a lista, porém adiciona no final da lista

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            // com o insert é possível escolher onde ira colocar o item
            list.Insert(2, "Marco");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: "+ list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First A: " + s1);
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last A" + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position: "+ pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position: " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-----------------------");

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            list.Remove("Alex");
            Console.WriteLine("-----------------------");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------");
            list.RemoveAt(0);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------");
            list.RemoveRange(0, 1);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}