using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
            // LinkedList<int> my_line = new LinkedList<int>();
            // my_line.AddLast(10);
            // my_line.AddLast(70);
            //my_line.AddFirst(300);
            // CustomLinkedList linkedList = new CustomLinkedList();
            //  linkedList.AddAtFirst(30);
            //  linkedList.AddAtFirst(40);
            //  linkedList.AddAtFirst(60);
            //  linkedList.Display();
            //   Console.ReadLine();
            CustomLinkedList linkedList = new CustomLinkedList();
            linkedList.Append(30);
            linkedList.Append(40);
            linkedList.Append(60);
            linkedList.Display();
            Console.ReadLine();
        }


    }
    
}
