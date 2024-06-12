using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CBBItem
    {
        public string Value { get; set; } //id
        public string Text { get; set; } // ten
        public override string ToString()
        {
            return Text;
        }
    }
}
