using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai2
{
     class  MyCollection<T>
    {
        List<T> list = new List<T>();
        public MyCollection() { }
        public MyCollection(List<T> list)
        {
            this.list = list;
        }

        public void Add(T obj)
        {
            list.Add(obj);
        }
        public void Add(T obj, int k)
        {
            list.Insert(k,obj);
        }

        public void DisplayItems()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }


        //ArrayList list = new ArrayList();
        //public void Add(T obj)
        //{
        //    list.Add(obj);
        //}
        //public void Add(T obj, int k)
        //{
        //    list.Insert(k,obj);
        //}
        //public void DisplayItems()
        //{
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        Console.WriteLine(list[i]);
        //    }
        //}
    }
}
