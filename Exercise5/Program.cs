using System;
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
            if(Adam == null)
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
    }
}
