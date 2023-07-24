using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(10,"India");
            hashtable.Add(91, "IND");
            hashtable.Add(63, "AUS");
            hashtable.Add(1, "USA");
            hashtable.Remove(63);

            foreach(DictionaryEntry entry in hashtable)
            {
                Console.WriteLine(entry.Key+" "+entry.Value);
            }



            Quee1 queue = new Quee1();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            queue.Dequeue();//remove first element
            Console.WriteLine($"first element in the list{queue.Peek()}");
            Console.WriteLine($"total elements in the queue{queue.Count()}");
           

        }

        }
}
