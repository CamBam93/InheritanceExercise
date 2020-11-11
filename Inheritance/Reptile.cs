using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public Reptile()
        {

        }

    public bool ColdBlooded { get; set; }
    public bool HasScales { get; set; }
    public string Environment { get; set; }
    public string Defense { get; set; }
    }
}
