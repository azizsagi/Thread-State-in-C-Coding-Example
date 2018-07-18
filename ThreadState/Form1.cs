using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace ThreadState
{
    public partial class Form1 : Form
    {
        Thread t;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            //textBox1.Text += System.IO.Directory.GetCurrentDirectory();


            textBox1.Text = Path.GetDirectoryName(Application.ExecutablePath);


 

        }

        private void button1_Click(object sender, EventArgs e)
        {

          

            Thread.Sleep(1000);

            t.Start();
            textBox1.Text += "\r\n"+t.ThreadState.ToString();

            

        }


        public void loop()
        {
            while(true)
            {
                int i = 0;
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t.Abort();
            textBox1.Text += "\r\n"+t.ThreadState.ToString();

        }


    }
}
