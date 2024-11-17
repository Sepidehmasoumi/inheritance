using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tamrin5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string carName = textBox1.Text;
            car myCar = new car();
            myCar.Drive();
            label1.Text = (carName + "The car is very good");
        }
    }
}
public class Vehicle
{
    public virtual void Drive()
    {

        MessageBox.Show("Drive");
    }
}
public class car : Vehicle
{
    public override void Drive()
    {

        MessageBox.Show(" Is Driving");
    }
}
