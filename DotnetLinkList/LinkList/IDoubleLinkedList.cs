using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkList
{
    public interface IDoubleLinkedList<T>
    {

        //尾插入
        void Append(T data);


        //在在指定位置插入
        void InsertFix(T data, int i);


        //头插入
        void InsertHead(T data);


        //打印链表
        void PrintList();


        /// <summary>
        /// 删除特点位置的元素
        /// </summary>
        /// <param name="i"></param>
        void Delete(int i);

        /// <summary>
        /// 删除前N个值为data的元素
        /// </summary>
        /// <param name="n">个数，0为全部</param>
        /// <param name="data">元素的值</param>
        void Delete(int n,T data);


        /// <summary>
        /// 获取链表的长度
        /// </summary>
        /// <returns>长度</returns>
        int GetLength();

        /// <summary>
        /// 清空链表
        /// </summary>
        void Clear();

    }
}
