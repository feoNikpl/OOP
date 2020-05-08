using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XML
{
    public partial class Form1 : Form
    {
        public List<Book_Shop> book_Shops = new List<Book_Shop>();
        public Dictionary<int, Book_Shop> book_shopD = new Dictionary<int, Book_Shop>();
        public string NameB, Genre, Topic, AgeType, GenderType, ColorStyle, Format, Periodicity, Subject;
        public int Cost, SizeB, tag = 0;
        private serializer serializer = new serializer();

        public Form1()
        {
            InitializeComponent();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        public void DictionaryAdd()
        {
            book_shopD.Add(1, new books(NameB, Cost, Genre));
            book_shopD.Add(2, new e_books(NameB, Cost, Genre, SizeB, Format));
            book_shopD.Add(3, new Educational_Literature(NameB, Cost, Subject));
            book_shopD.Add(4, new journal(NameB, Cost, Topic, AgeType, GenderType));
            book_shopD.Add(5, new comics(NameB, Cost, Topic, AgeType, GenderType, ColorStyle));
            book_shopD.Add(6, new NewsPaper(NameB, Cost, Topic, AgeType, GenderType, ColorStyle, Periodicity));
        }

        private void ValueAdd()
        {
            try
            {
                NameB = NameBook.Text;
                Genre = GenerB.Text;
                Subject = Subj.Text;
                Topic = TopicB.Text;
                Format = FormatB.Text;
                Periodicity = Period.Text;
                ColorStyle = Color.Text;
                AgeType = AgeT.Text;
                GenderType = GenderT.Text;
                if (CostB.Text == "")
                    Cost = 0;
                else
                    Cost = int.Parse(CostB.Text);
                if (Size.Text == "")
                    SizeB = 0;
                else
                    SizeB = int.Parse(Size.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Заполните поля правильно!");
            }
        }

        private void ClearBox()
        {
            NameBook.Text = "";
            GenerB.Text = "";
            Subj.Text = "";
            TopicB.Text = "";
            FormatB.Text = "";
            Period.Text = "";
            Color.Text = "";
            AgeT.Text = "";
            GenderT.Text = "";
            CostB.Text = "";
            Size.Text = "";
        }

        private void RefreshProducts()
        {
            Products.Clear();
            foreach (Book_Shop product in book_Shops)
            {
                var listItem = new ListViewItem();
                listItem.Text = product.Name;
                Products.Items.Add(listItem);
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            tag = Convert.ToInt32(button.Tag);
            ValueAdd();
            DictionaryAdd();
            book_Shops.Add(book_shopD[tag]);
            book_shopD.Clear();
            ClearBox();
            RefreshProducts();
        }

        private void Products_SelectedIndexChanged(object sender, EventArgs e)
        {
            info.Clear();
            ClearBox();
            int Nam = Products.SelectedIndices[0];
            NameBook.Text = book_Shops[Nam].Name;
            info.Text = book_Shops[Nam].Name + Environment.NewLine;
            CostB.Text = book_Shops[Nam].Cost.ToString();
            info.Text += book_Shops[Nam].Cost.ToString() + "BYN" + Environment.NewLine;
            if (book_Shops[Nam] is books || book_Shops[Nam] is e_books)
            {
                books books = (books)book_Shops[Nam];
                GenerB.Text = books.Genre;
                info.Text += "" + books.Genre + Environment.NewLine;
                tag = 1;
                if (book_Shops[Nam] is e_books)
                {
                    e_books e_Books = (e_books)book_Shops[Nam];
                    Size.Text = e_Books.Size.ToString();
                    FormatB.Text = e_Books.Format = "1";
                    info.Text += "" + e_Books.Size.ToString() + Environment.NewLine + "" + e_Books.Format + Environment.NewLine;
                    tag = 2;
                }
            }
            if (book_Shops[Nam] is Educational_Literature)
            {
                Educational_Literature Educational_Literature = (Educational_Literature)book_Shops[Nam];
                Subj.Text = Educational_Literature.Subject;
                info.Text += "" + Educational_Literature.Subject + Environment.NewLine;
                tag = 3;
            }
            if (book_Shops[Nam] is journal || book_Shops[Nam] is comics || book_Shops[Nam] is NewsPaper)
            {
                journal journal = (journal)book_Shops[Nam];
                TopicB.Text = journal.Topic;
                AgeT.Text = journal.AgeType;
                GenderT.Text = journal.GenderType;
                info.Text += "" + journal.Topic + Environment.NewLine + "" + journal.AgeType + Environment.NewLine + "" + journal.GenderType + Environment.NewLine;
                tag = 4;
                if (book_Shops[Nam] is comics || book_Shops[Nam] is NewsPaper)
                {
                    comics comics = (comics)book_Shops[Nam];
                    Color.Text = comics.ColorStyle;
                    info.Text += "" + comics.ColorStyle + Environment.NewLine;
                    tag = 5;
                    if (book_Shops[Nam] is NewsPaper)
                    {
                        NewsPaper newsPaper = (NewsPaper)book_Shops[Nam];
                        Period.Text = newsPaper.Periodicity = "2";
                        info.Text += "" + newsPaper.Periodicity + Environment.NewLine;
                        tag = 6;
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                ValueAdd();
                DictionaryAdd();
                book_Shops[Products.SelectedIndices[0]] = book_shopD[tag];
                book_shopD.Clear();
                ClearBox();
                RefreshProducts();
                info.Clear();
                tag = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Выберите элемент");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                info.Clear();
                ClearBox();
                book_Shops.RemoveAt(Products.SelectedIndices[0]);
                RefreshProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Выберите элемент");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            serializer.Serialize(book_Shops);
            RefreshProducts();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            info.Clear();
            ClearBox();
            book_Shops = serializer.Deserialize();
            RefreshProducts();
        }


    }
}
