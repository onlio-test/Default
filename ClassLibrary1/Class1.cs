using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Class1
    {
        public int Test(string value)
        {
            if (value == null) throw new ArgumentNullException("value");
            return value.Length;
        }
    }
}
