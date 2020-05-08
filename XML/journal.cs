using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    [Serializable]
    public class journal : Book_Shop
    {
        public string Topic;
        public string AgeType;
        public string GenderType;
        public journal() { }
        public journal(string Name, int Cost, string Topic, string AgeType, string GenderType) : base(Name,Cost)
        {
            this.Topic = Topic;
            this.AgeType = AgeType;
            this.GenderType = GenderType;
        }
    }
}
