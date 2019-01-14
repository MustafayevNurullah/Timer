using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public  bool Baku=false;
        public  bool London = false;
        private void Form1_Load(object sender, EventArgs e)
        { 
        }
        private void label1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            if(Baku==true)
            {
                Image i = Image.FromFile("Baku.jpg");
                label1.Image = i;
                label1.Text = dateTime.ToString();
            }
            else
            {
                Image i = Image.FromFile("London.jpg");
                label1.Image = i;
                var a = dateTime.Hour + 4;
                if (dateTime.Hour == 05)
                {
                    DateTime dateTime1 = new DateTime(dateTime.Year, dateTime.Month+1, dateTime.Day, a, dateTime.Minute, dateTime.Second);
                    label1.Text = dateTime1.ToString();
                }
                else
                {
                    DateTime dateTime1 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, a, dateTime.Minute, dateTime.Second);
                    label1.Text = dateTime1.ToString();
                }
            }
        }
        private void Baku_Button_Click(object sender, EventArgs e)
        {
            Baku = true;
            London = false;    
            Timer timer = new Timer();         
            timer.Start();
            timer.Tick += new EventHandler(label1_Click);
            timer.Interval = 1000;          
        }
        private void London_Button_Click(object sender, EventArgs e)
        {
            Baku = false;  
            London = true;          
            Timer timer = new Timer();
            timer.Start();
            timer.Tick += new EventHandler(label1_Click);
            timer.Interval = 1000;
        }
    }
}
