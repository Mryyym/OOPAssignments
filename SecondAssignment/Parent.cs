using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssignment
{
    internal class Parent
    {
        #region properties
        public int x { get; set; }
        public int y { get; set; }
        #endregion

        public Parent(int _x , int _y)
        {
            x= _x;
            y= _y;
        }
        
        public override string ToString()
        {
            return $"({x}, {y})";
        }

        public int Product()
        {
            return x*y;
        }
    }
}
