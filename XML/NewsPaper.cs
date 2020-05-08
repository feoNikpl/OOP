using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    [Serializable]
    public class NewsPaper : comics
    {
        public string Periodicity;
        public NewsPaper() { }
        public NewsPaper(string Name, int Cost, string Topic, string AgeType, string GenderType, string ColorStyle, string Periodicity) : base(Name, Cost, Topic, AgeType, GenderType, ColorStyle)
        {
            this.Periodicity = Periodicity;
        }
    }
}
