// Tim Burton
// Program 1
// 02-16-2015
// CIS 199-75-4152
// This program allows users to enter the amount of wallspace they desire painted, the number of coats, and the cost of paint; Then provides the user with the break-down of costs, time consumption, and material usage.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double GallonWallSpace = 325; // used to state the amount of wallspace per gallon of paint
            double GallonTime = 8; // used to state the number of hours of labor per gallon of paint
            double LaborRate = 10.50; // used to state the rate of labor per hour
            double WallSpace; // used to state the amount of wallspace entered by user
            double Coats; // used to state the amount of coats of paint determined by the user
            double CostPerGallon; // used to state the price of each gallon of paint according to the user

            WallSpace = double.Parse(textBox1.Text);
            Coats = double.Parse(textBox2.Text);
            CostPerGallon = double.Parse(textBox3.Text);

            double TotalWallSpace = WallSpace * Coats; // used to state the total wallspace (including the coats)
            double GallonsNeeded = TotalWallSpace / GallonWallSpace; // used to state the total number of gallons of paint needed
            GallonsNeeded = Math.Ceiling(GallonsNeeded);
            double TotalHours = (TotalWallSpace / GallonWallSpace) * GallonTime; // used to state the total hours allocated
            double FixedCosts = CostPerGallon * GallonsNeeded; // used to state the cost of materials (just paint)
            double VariableCosts = LaborRate * TotalHours; // used to state the cost of labor
            double TotalCost = FixedCosts + VariableCosts; // used to state the Total cost (both materials and labor)

            label4.Text = ("The total sq ft is " + TotalWallSpace + "." + " It would take " + GallonsNeeded + " gallons.");
            label5.Text = ("It would take around " + TotalHours.ToString("n1") + " Hours.");
            label6.Text = ("It would cost around " + FixedCosts.ToString("c") + " in paint, and " + VariableCosts.ToString("c") + " in labor.");
            label7.Text = ("The total cost would be " + TotalCost.ToString("c") + ".");
        }
    }
}
