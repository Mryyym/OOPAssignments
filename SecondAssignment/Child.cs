using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssignment
{
    internal class Child:Parent
    {

        public int z {  get; set; }

        public Child(int _x , int _y , int _z ):base(_x,_y)
        {
            z = _z;
        }

        public new int Product()
        {
            return base.Product()*z;
        }

        public override string ToString()
        {
            return $"({x},{y},{z})";
        }
    }
}
