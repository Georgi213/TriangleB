using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triangleBlinov
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double a, h;
            bool right;
            string type, perimeterA, typeA;
            listView1.Items.Clear();
            a = Convert.ToDouble(aBox.Text);
            h = Convert.ToDouble(hBox.Text);
            if (ravno.Checked)
            {
                type = "ravno";
                typeA = "Равносторонний";
            }
            else if (razno.Checked)
            {
                type = "razno";
                typeA = "Разносторонний";
            }
            else if (twosides.Checked)
            {
                type = "twosides";
                typeA = "Равнобедренный";
            }
            else
            {
                type = "";
                typeA = "";
            }
            
            Triangle triangle = new Triangle(a, h, type);
            if (triangle.Perimeter() == 0.0) perimeterA = "Нельзя посчитать";
            else perimeterA = Convert.ToString(triangle.Perimeter());
            listView1.Items.Add("Сторона a");
            listView1.Items.Add("Высота");
            listView1.Items.Add("Периметр");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Тип");
            listView1.Items[0].SubItems.Add(triangle.getA());
            listView1.Items[1].SubItems.Add(triangle.getH());
            listView1.Items[2].SubItems.Add(perimeterA);
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Area()));
            listView1.Items[4].SubItems.Add(typeA);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double a, h;
            bool right;
            string type, perimeterA, typeA;
            listView1.Items.Clear();
            a = Convert.ToDouble(aBox.Text);
            h = Convert.ToDouble(hBox.Text);
            if (ravno.Checked)
            {
                type = "ravnostr";
                typeA = "Равносторонний";
            }
            else if (razno.Checked)
            {
                type = "raznostr";
                typeA = "Разносторонний";
            }
            else if (twosides.Checked)
            {
                type = "две стороны";
                typeA = "Равнобедренный";
            }
            else
            {
                type = "";
                typeA = "";
            }
            
            Triangle triangle = new Triangle(a, h, type);
            if (triangle.Perimeter() == 0.0) perimeterA = "Нельзя посчитать";
            else perimeterA = Convert.ToString(triangle.Perimeter());
            listView1.Items.Add("Сторона a");
            listView1.Items.Add("Высота");
            listView1.Items.Add("Периметр");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Тип");
            listView1.Items[0].SubItems.Add(triangle.getA());
            listView1.Items[1].SubItems.Add(triangle.getH());
            listView1.Items[2].SubItems.Add(perimeterA);
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Area()));
            listView1.Items[4].SubItems.Add(typeA);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
