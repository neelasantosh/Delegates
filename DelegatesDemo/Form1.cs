using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatesDemo
{
    public partial class Form1 : Form
    {

        public delegate void del(string str);

        public del obj;

        public void getData(string str)
        {
            MessageBox.Show(str);
        }
        public void setData(string str)
        {
            //obj(str);
            
            MessageBox.Show("Set Data: " + str);
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj = new del(getData);
            obj += new del(setData);
            obj += delegate(string s)
            {
                MessageBox.Show("Annonymous: " + s);
            };
            obj("Mohsin Khan is the game!");
           
        }
    }
}
