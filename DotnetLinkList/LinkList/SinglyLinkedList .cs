using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    public class SinglyLinkedList<T> : ISinglyLinkedList<T>
    {
        //头指针
       protected SNode<T> HEAD;





        public SinglyLinkedList()
        {
            HEAD = new SNode<T>();
        }


        public void Append(T data)
        {
            SNode<T> newNode = new SNode<T>(data);

            if (ListIsEmpty())
            {
                HEAD.Next = newNode;
            }
            else
            {
                SNode<T> temp = HEAD.Next;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }



        public void InsertFix(T data, int i)
        {

            SNode<T> newNode = new SNode<T>(data);


            SNode<T> temp = HEAD.Next;
            int j = 0;

            while (j < i && temp.Next != null)
            {
                temp = temp.Next;
                j++;
            }


            if (temp.Next == null)
            {
                temp.Next = newNode;
            }
            else
            {
                SNode<T> next = temp.Next;
                temp.Next = newNode;
                newNode.Next = next;
            }

        }



        #region 在链表表头插入
        public void InsertHead(T data)
        {
            if (HEAD.Next != null)
            {
                SNode<T> newNode = new SNode<T>(data, HEAD.Next);
                HEAD.Next = newNode;
            }
            else
            {
                HEAD.Next = new SNode<T>(data);
            }
        }
        #endregion

        #region 取第一个节点的值
        public T GetFirst()
        {
            if (ListIsEmpty())
            {
                return default;
            }
            else
            {
                return HEAD.Next.Data;
            }
        }
        #endregion



        public void Delete(int i)
        {
            if (!ListIsEmpty())
            {
                SNode<T> temp;
                if (i == 0)
                    temp = HEAD;
                else
                    temp = HEAD.Next;
                int j = 0;
                while (j < i - 1 && temp.Next != null)
                {
                    temp = temp.Next;
                    j++;
                }

                if (temp.Next == null)
                {
                    return;
                }
                else
                {
                    SNode<T> pre = temp;
                    temp = temp.Next;
                    pre.Next = temp.Next;
                    temp.Dispose();
                }
            }
        }


        /// <summary>
        /// 删除前N个值为data的元素
        /// </summary>
        /// <param name="n">个数，0为全部</param>
        /// <param name="data">元素的值</param>
        public void Delete(int n,T data)
        {
            if (!ListIsEmpty())
            {
                SNode<T> temp = HEAD;
                if (n == 0)
                {
                    while (temp.Next != null)
                    {
                        if (temp.Next.Data.Equals(data))
                        {
                            SNode<T> next = temp.Next.Next;
                            temp.Next = next;
                        }
                        else
                        {
                            temp = temp.Next;
                        }
                    }
                }
                else
                {
                    int j = 0;
                    while (temp != null)
                    {
                        if (temp.Next.Data.Equals(data))
                        {
                            temp.Next = temp.Next.Next;
                            j++;
                        }
                        else
                        {
                            temp = temp.Next;
                        }
                        if (j == n)
                            break;
                    }
                }
                GC.Collect();
            }
        }






        #region 清空链表
        public void Clear()
        {
            HEAD.Next = null;
            GC.Collect();
        }
        #endregion




        #region
        public void PrintList()
        {
            if (ListIsEmpty())
            {
                Console.WriteLine("List is empty!");
            }
            else
            {
                SNode<T> n = HEAD.Next;
                int i = 0;

                while (n.Next != null)
                {
                    Console.WriteLine("{0}:{1}", i, n.Data);
                    i++;
                    n = n.Next;
                }

                Console.WriteLine("{0}:{1}", i, n.Data);


            }



            Console.WriteLine("");
        }
        #endregion

        #region 长度

        public int GetLength()
        {
            if (ListIsEmpty())
            {
                return 0;
            }
            else
            {
                int i = 1;
                SNode<T> SNode = HEAD.Next;
                while (SNode.Next != null)
                {
                    SNode = SNode.Next;
                    i++;
                }
                return i;
            }
        }

        #endregion

        #region 判空
        public bool ListIsEmpty()
        {
            if (HEAD.Next == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

    }
}