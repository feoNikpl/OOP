using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    [Serializable]
    public class comics : journal
    {
        public string ColorStyle;
        public comics() { }
        public comics(string Name, int Cost, string Topic, string AgeType, string GenderType, string ColorStyle) : base(Name, Cost, Topic, AgeType, GenderType)
        {
            this.ColorStyle = ColorStyle;
        }
    }
}
