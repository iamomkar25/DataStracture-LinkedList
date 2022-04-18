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
        private int new_data;

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
            Console.WriteLine("{0} Node inserted into linkedlist", newNode.data);
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
        internal Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position >= 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            Console.WriteLine("\nInserted Value is  ", head);
            return head;

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
        public void Append(int data)
        {
            AddAtLast(data);
        }
        public int DeleteFirstNode()
        {
            if (this.head == null)
            {
                Console.WriteLine("Linked list empty");
                return 0;
            }
            int deleteNode = this.head.data;
            this.head = this.head.next;
            Console.WriteLine("\n{0} is deleted from the list", deleteNode);
            return deleteNode;
        }


    }
    }
