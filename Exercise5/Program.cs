using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Node
    {
        public string name;
        public Node next;

    }
    class Queue
    {
        Node Adam, Yuniarto;
        public Queue()
        {
            Adam = null;
            Yuniarto = null;
        }
        public void insert()
        {
            string nm;
            Node newNode = new Node();
            Console.WriteLine("Masukkan Data:   ");
            nm = Console.ReadLine();
            newNode.name = nm;
            newNode.next = null;
            if (Adam == null)
            {
                Adam = newNode;
                Yuniarto = newNode;
            }
            Yuniarto.next = newNode;
            Yuniarto = newNode;
        }
        public void delete()
        {
            if (Adam == null)
            {
                Console.WriteLine("Queue Kosong");
                return;
            }
            Adam = Adam.next;
            if (Adam == null)
                Yuniarto = null;
        }
        public void display()
        {
            if (Adam == null)
            {
                Console.WriteLine("Queue Kosong");
                return;
            }
        }
        static void Main(string[] args)
        {
            Queue q = new Queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\nEnter your choice (1-4):   ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    { }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered.");
                }
            }
        }
    }
}
