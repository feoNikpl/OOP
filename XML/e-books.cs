using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    [Serializable]
    public class e_books : books
    {
        public int Size;
        public string Format;
        public e_books() { }
        public e_books (string Name, int Cost, string Genre, int Size, string Format) : base(Name, Cost, Genre)
        {
            this.Size = Size;
            this.Format = Format;
        }
    }
}
