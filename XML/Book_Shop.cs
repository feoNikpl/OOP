using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML
{
    [Serializable]
    [XmlInclude(typeof(Educational_Literature)), XmlInclude(typeof(NewsPaper)), XmlInclude(typeof(books)), XmlInclude(typeof(e_books)), XmlInclude(typeof(journal)), XmlInclude(typeof(comics))]
    public class Book_Shop
    {
        public string Name;
        public int Cost;
        public Book_Shop() { }

        public Book_Shop(string Name, int Cost)
        {
            this.Name = Name;
            this.Cost = Cost;
        }
    }
}
