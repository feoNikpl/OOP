using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint2._0
{
    public partial class MainForm : Form
    {
        Graphics canv;
        int tag = 1,size = 1;
        List<Figure> figures_lab1 = new List<Figure>();
        List<Figure> figures_lab2 = new List<Figure>();
        Dictionary<int, Figure> figures_dict = new Dictionary<int, Figure>();
        Pen pen;
        Point StartPoint, LastPoint, MiddlePoint;
        int x, y, width, height;
        public Color color = Color.Black;



        public MainForm()
        {
            InitializeComponent();
        }


        private void DrawAllBtn_Click(object sender, EventArgs e)
        {
            foreach (Figure figure in figures_lab1)                       
                figure.Draw(canv);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            canv.Clear(MainCanvas.BackColor);
            figures_lab1.Clear();
            figures_lab2.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            size = Convert.ToInt32(comboBox1.Text);
        }
 

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult Res = colorDialog.ShowDialog();
            if (Res == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog.Color;
                color = colorDialog.Color;
            }
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {
            canv = MainCanvas.CreateGraphics();

            figures_lab1.Add(new Line(new Pen(Color.Red, 7), new Point(30, 20), new Point(30, 100)));
            figures_lab1.Add(new Square(new Pen(Color.Orange, 7), 60, 120, 80));
            figures_lab1.Add(new Rectangle(new Pen(Color.Yellow, 7), 60, 20, 80, 120));
            figures_lab1.Add(new Circle(new Pen(Color.Green, 7), 240, 20, 80));
            figures_lab1.Add(new Ellipse(new Pen(Color.Blue, 7), 180, 120, 80, 120));
            figures_lab1.Add(new Triangle(new Pen(Color.Purple, 7), new Point(370, 20), new Point(320, 200), new Point(420, 200)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            tag = Convert.ToInt32(button.Tag);
        }

        public void DictionaryAdd ()
        {
            figures_dict.Add(1, new Line(pen, StartPoint, LastPoint));
            figures_dict.Add(2, new Rectangle(pen, x, y, height, width));
            figures_dict.Add(3, new Square(pen, x, y, height));
            figures_dict.Add(4, new Ellipse(pen, x, y, height, width));
            figures_dict.Add(5, new Circle(pen, x, y, height));
            figures_dict.Add(6, new Triangle(pen, StartPoint, MiddlePoint, LastPoint));
        }

        private void MainCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            LastPoint.X = e.X;
            LastPoint.Y = e.Y;
            height = Math.Abs(StartPoint.Y - LastPoint.Y);
            width = Math.Abs(StartPoint.X - LastPoint.X);
            MiddlePoint.X= LastPoint.X + width;
            pen = new Pen(color, size);
            DictionaryAdd();
            figures_lab2.Add(figures_dict[tag]);
            foreach (Figure figure in figures_lab2)
                figure.Draw(canv);
            figures_dict.Clear();
        }

        private void MainCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint.X = x = e.X;
            MiddlePoint.Y = StartPoint.Y = y = e.Y;
        }

    }
}
