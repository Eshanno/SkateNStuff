using System;
using System.Collections.Generic;
using System.Text;

namespace OneUpTricks.Models
{
    
    public class Trick
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Image { get; set; }


        public Step[] Steps;

        public override string ToString()
        {
            return Name;
        }
    }
}
