using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace _3Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "XSLT-процессор (Турчин Д.Е., каф. ИиАПС";
            this.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            textBox1.Text = @"Лаба2.xml";
            textBox2.Text = @"XSLTFile2.xslt";
            textBox3.Text = @"Сам3.xml";
        }

        private void buttonTrasnform_Click(object sender, EventArgs e)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(textBox2.Text);
            xslt.Transform(textBox1.Text, textBox3.Text);

            StreamReader sr = new StreamReader(textBox3.Text);
            webBrowser1.DocumentText = sr.ReadToEnd();
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XML-файлы (*.xml)|*.xml";
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XSLT-файлы (*.xslt)|*.xslt"+
                "|XSL-файлы(*.xsl)|*xsl";
            openFileDialog1.ShowDialog();
            textBox2.Text = openFileDialog1.FileName;
            /*MessageBox.Show(openFileDialog1.FileName);*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Все файлы (*.*)|*.*";
            openFileDialog1.ShowDialog();
            textBox3.Text = openFileDialog1.FileName;
        }
    }
}
