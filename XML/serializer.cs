using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace XML
{
    
    class serializer
    {
        const String path = "bookShop.xml";
        private XmlSerializer xml;
        public serializer()
        {
            xml = new XmlSerializer(typeof(List<Book_Shop>));
        }
        public void Serialize(List<Book_Shop> book_Shops)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                xml.Serialize(fileStream, book_Shops);
            }
        }
        public List<Book_Shop> Deserialize()
        {
            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                try
                {
                    List<Book_Shop> book_Shops = (List<Book_Shop>)xml.Deserialize(fileStream);
                    return book_Shops;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Попытка десериализации пустого потока.");
                    return null;
                }
            }
        }
    }
}
