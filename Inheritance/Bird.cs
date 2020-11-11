using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public Bird()
        {

        }

    public bool CanFly { get; set; }
    public string BeakType { get; set; }
    public bool IsNocturnal { get; set; }
    public double WingSpan { get; set; }

    }
     
}
