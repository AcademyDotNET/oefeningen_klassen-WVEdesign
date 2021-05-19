using System;
using System.Collections.Generic;
using System.Text;

namespace Politiek
{
    class President : Minister
    {
        public int _JaarVerder { get; set; } = 4;

        public void JaarVerder()
        {
            _JaarVerder--;
        }
    }
}


