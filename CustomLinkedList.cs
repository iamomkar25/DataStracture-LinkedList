﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
    internal class CustomLinkedList
    {
        public Node head;


        public void AddAtLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;

            }
            else
            {
                Node lastnode = GetLastNode();
                lastnode.next = newNode;

            }
        }
        private Node GetLastNode()
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void Display()
        {
            Console.WriteLine("Displaying Nodes");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data + "");
                    temp = temp.next;
                }


            }
        }

        public void AddAtFirst(int new_data)
        {
                                                      // creating a node
            Node new_node = new Node(new_data);
                                                     // when we want to add the node at front
            new_node.next = this.head;
                                                    //the previous Head node is no=w the second node of linked list
            this.head = new_node;
            Console.WriteLine("{0} Node inserted into linkedlist", new_node.data);
        }
    }
}
