﻿using System;
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
                CustomLinkedList linkedList = new CustomLinkedList();
                linkedList.AddAtLast(30);
                linkedList.AddAtLast(40);
                linkedList.AddAtLast(50);
                linkedList.Display();
                Console.ReadLine();
            }


        }
    
}
