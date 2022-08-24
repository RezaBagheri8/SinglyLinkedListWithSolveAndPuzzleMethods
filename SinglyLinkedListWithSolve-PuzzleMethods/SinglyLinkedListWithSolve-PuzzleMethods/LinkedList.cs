using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedListWithSolve_PuzzleMethods
{
    public class LinkedList
    {
        public Node head;

        public void InsertNodeAtFirst(int value)
        {
            if (head == null)
            {
                Node newItem = new Node();
                newItem.value = value;

                head = newItem;
            }
            else
            {
                Node temp = head;
                Node newItem = new Node();
                newItem.value = value;
                newItem.next = temp;
                head = newItem;
            }
        }

        public void InsertNodeAtLast(int value)
        {
            if (head == null)
            {
                Node newItem = new Node();
                newItem.value = value;
                head = newItem;
            }
            else
            {
                Node node = head;
                while (node.next != null)
                {
                    node = node.next;
                }

                Node newItem = new Node();
                newItem.value = value;

                node.next = newItem;
            }
        }

        public void Solve(Node start)
        {
            if (start == null)
            {
                return;
            }

            Console.WriteLine(start.value);

            if (start.next != null)
            {
                Solve(start.next.next);
            }

            Console.WriteLine(start.value);
        }

        int Puzzle(Node head)
        {
            if (head == null)
            {
                return 0;
            }
            else
            {
                return 1 + Puzzle(head.next);
            }
        }

        public void Print()
        {
            if (head == null)
            {
                Console.WriteLine("The list is empty!");
            }
            else
            {
                Node node = head;
                while (node != null)
                {
                    Console.WriteLine(node.value);
                    node = node.next;
                }
            }
        }

        public void PrintSolveMethod()
        {
            Solve(head);
        }

        public void PrintPuzzleMethod()
        {
            Console.WriteLine(Puzzle(head));
        }
    }
}
