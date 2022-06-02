using System;
using System.Collections.Generic;
using System.Text;

namespace Objektorientering
{
    public class Ditto : Pokemon, INormal
    {
        public Ditto()
        {
            Name = "Ditto";
            Health = 2000000;
        }
    }
}
