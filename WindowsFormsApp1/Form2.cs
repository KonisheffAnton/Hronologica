using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{


    public partial class Form2 : Form
    {
       
        public int a;
        public Form2()
        {
            InitializeComponent();
         
        }

        public Form2(string text)
        {
            InitializeComponent();
            text = textBox1.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            Form1 newForm = new Form1(this);
            newForm.Owner = this;
            newForm.Show();
            this.Hide();
        }
    }
}
