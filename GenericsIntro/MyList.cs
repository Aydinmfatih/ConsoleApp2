using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
         T[] items;

        //constructor = bir clas newlendiğinde çalşan blok
        public MyList()
        {
            items = new T[0];     
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            //array 0 dan başladığı için -1 veriyoruz
            items[items.Length - 1] = item;
        }
    }
}
