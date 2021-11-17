﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show();
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(aBox.Text);
            b = Convert.ToDouble(bBox.Text);
            c = Convert.ToDouble(cBox.Text);
            Triangle triangle = new Triangle(a, b, c);
            listView1.Items.Add("Существует?");
            listView1.Items.Add("Сторона a");
            listView1.Items.Add("Сторона b");
            listView1.Items.Add("Сторона c");
            listView1.Items.Add("Периметр");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Тип");
            listView1.Items[0].SubItems.Add(triangle.RealityCheck() ? "Да" : "Нет");
            listView1.Items[1].SubItems.Add(triangle.getA());
            listView1.Items[2].SubItems.Add(triangle.getB());
            listView1.Items[3].SubItems.Add(triangle.getC());
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Perimeter()));
            listView1.Items[5].SubItems.Add(Convert.ToString(triangle.Area()));
            listView1.Items[6].SubItems.Add(triangle.typeDef());
         
            
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
