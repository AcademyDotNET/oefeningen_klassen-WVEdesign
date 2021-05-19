using System;
using System.Collections.Generic;
using System.Text;

namespace GenericListTester
{
    class GenListEngin<T>
    {
        private List<T> Items { get; set; }

        //constuctor
        public GenListEngin(List<T> itemIn)
        {
            Items = itemIn;
        }
        public void PrintList()
        {
            foreach (var item in Items)
            {
                Console.WriteLine($"{Items.IndexOf(item)} {item}");
            }
        }
        //treintjesint.Add(368);


        public void RemoveOfListIndex(int itemIndex)
        {
            //if (Items.Contains(item))
            //{
            Items.RemoveAt(itemIndex);
            //}
            //Items.RemoveAt(itemIndex);
        }

        public void Add2List(T itemValue)
        {

            Items.Add(itemValue);
        }

        public T RequestOfListIndex(int itemIndex)
        {

            return Items[itemIndex];
        }

    }
}
