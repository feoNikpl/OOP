using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace XML
{
    [Serializable]
    public class books : Book_Shop
    {
        public string Genre;
        public books() { }
        public books (string Name, int Cost, string Genre) : base(Name, Cost)
        {
            this.Genre = Genre;
        }
    }
}
