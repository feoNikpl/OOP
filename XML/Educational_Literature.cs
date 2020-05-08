using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    [Serializable]
    public class Educational_Literature : Book_Shop
    {
        public string Subject;
        public Educational_Literature() { }
        public Educational_Literature(string Name, int Cost, string Subject) : base(Name, Cost)
        {
            this.Subject = Subject;
        }
    }
}
