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

namespace CreateWriteReadFromFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"F:\Downloads\NewFile.txt";
            File.Create(path);
            MessageBox.Show("File Created");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"F:\Downloads\NewFile.txt";
            File.WriteAllText(path, textBox1.Text);
            MessageBox.Show("successfully write in file");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = @"F:\Downloads\NewFile.txt";
            
            textBox1.Text += File.ReadAllText(path);
           // MessageBox.Show("successfully write in file");
        }
    }
}
