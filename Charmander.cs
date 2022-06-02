using System;
using System.Collections.Generic;
using System.Text;

namespace Objektorientering
{
    public interface IFire
    {

    }
    public class Charmander : Pokemon, IFire
    {
        public Charmander()
        {
            Name = "Charmander";
            Health = 4000;
        }
    }
}
