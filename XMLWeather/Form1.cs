using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.Threading;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Form loadScreen = this.FindForm();
            //loadScreen.Controls.Remove(this);
            
            this.Show();
            //this.button1.Refresh();
            //this.label1.Refresh();
            this.Refresh();
            Thread.Sleep(3000);

            loadScreen ls = new loadScreen();
            this.Controls.Add(ls);
            ls.BringToFront();
        }
    }
}