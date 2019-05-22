using System;
using LinkList;

namespace DotnetLinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            ISinglyLinkedList<long> list = new SinglyLinkedList<long>();

            int i = 0;
            while (i < 10)
            {
                list.Append(i);
                i++;
            }
            Console.WriteLine("init finish");
            while (true)
            {
                int enter = int.Parse(Console.ReadLine());
                switch (enter)
                {
                    case 0:
                        Console.WriteLine("list length is {0}", list.GetLength());
                        break;
                    case 1:
                        list.PrintList();
                        break;
                    case 2:
                        list.InsertHead(909011123);
                        break;
                    case 3:
                        list.Delete(2, 909011123);
                        break;
                    case 4:
                        list.Clear();
                        break;
                    case 5:
                        Console.WriteLine("请输入要删除的编号");
                        int del = int.Parse(Console.ReadLine());
                        list.Delete(del);
                        break;

                }
            }
        }
    }
}
