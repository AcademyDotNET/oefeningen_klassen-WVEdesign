using System;
using System.Collections.Generic;
using System.Text;

namespace KaartGokker_RandomInStack
{
    public class Stack
    {
        int position;
        object[] data = new object[52];
        public void Push(object obj) { data[position++] = obj; }
        public object Pop() { return data[--position]; }
    }
}
