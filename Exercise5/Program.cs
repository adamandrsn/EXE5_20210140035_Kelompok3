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
                    Console.WriteLine("1. memasukkan data");
                    Console.WriteLine("2. hapus data");
                    Console.WriteLine("3. menampilkan data");
                    Console.WriteLine("4. keluar");
                    Console.WriteLine("\nMasukkan pilihan anda (1-4):   ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                q.insert();
                                break;
                            }
                        case '2':
                            {
                                q.delete();
                                break;
                            }
                        case '3':
                            {
                                q.display();
                                break;
                            }
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid option!!");
                            }
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered.");
                }
            }
        }
    }
}
