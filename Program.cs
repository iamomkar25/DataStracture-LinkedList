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
            //CustomLinkedList linkedList = new CustomLinkedList();
            // linkedList.Append(30);
            // linkedList.Append(40);
            //  linkedList.Append(60);
            //  linkedList.Display();
            //  Console.ReadLine();

            //linkedList.AddAtLast(56);
            // linkedList.AddAtLast(30);
            // linkedList.AddAtLast(70);
            // linkedList.Display();                     
            //  linkedList.InsertAtParticularPosition(2, 30);
            // Console.WriteLine("\n{0}is deleted from the Linkedlist",linkedList.DeleteFirstNode());
            //Console.WriteLine("\n{0} is deleted from linkedlist",linkedList.DeleteLastNode());
            // linkedList.Display();
            //Console.WriteLine("\n{0} is present", linkedList.Search(30));
            //  Console.ReadLine();

            // LinkedList<int> my_line = new LinkedList<int>();
            // my_line.AddLast(10);
            // my_line.AddLast(70);
            //my_line.AddFirst(300);
            CustomLinkedList linkedList = new CustomLinkedList();
            // linkedList.AddAtLast(56);
            // linkedList.AddAtLast(30);
            // linkedList.AddAtLast(70);
            // linkedList.Display();
            //  linkedList.InsertAtParticularPosition(2, 30);
            // Console.WriteLine("{0} is deleted from the Linkedlist", linkedList.DeleteLastNode());
            // linkedList.Display();
            //Console.WriteLine("\n{0} is present", linkedList.Search(30));
            // Console.ReadLine();

            linkedList.AddAtLast(56);//adding data in list
            linkedList.AddAtLast(30);//adding data in list
            linkedList.AddAtLast(70);//adding data in list
            linkedList.Display();    //call display method to print data
            linkedList.InsertAfterValue(30, 40);//call InsertAtAfterValue Pass value
            linkedList.Display();
            Console.ReadLine();
        }


    }
    
}
