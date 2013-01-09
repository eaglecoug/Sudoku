using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            boardmaker menu = new boardmaker() { Randomizer = new Random() };

            label1.Text = menu.G1().ToString();
            label2.Text = "";
            label3.Text = menu.G4().ToString();
            label4.Text = "";
            label5.Text = menu.G2().ToString();
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = menu.G3().ToString();

            label10.Text = menu.G2().ToString();
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = menu.G4().ToString();
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";

            label19.Text = menu.G3().ToString();
            label20.Text = "";
            label21.Text = menu.G2().ToString();
            label22.Text = "";
            label23.Text = menu.G1().ToString();
            label24.Text = "";
            label25.Text = "";
            label26.Text = "";
            label27.Text = "";

            label28.Text = "";
            label29.Text = "";
            label30.Text = "";
            label31.Text = "";
            label32.Text = menu.G5().ToString();
            label33.Text = menu.G4().ToString();
            label34.Text = menu.G1().ToString();
            label35.Text = "";
            label36.Text = "";

            label37.Text = "";
            label38.Text = menu.G3().ToString();
            label39.Text = "";
            label40.Text = "";
            label41.Text = "";
            label42.Text = menu.G2().ToString();
            label43.Text = menu.G5().ToString();
            label44.Text = "";
            label45.Text = "";

            label46.Text = "";
            label47.Text = "";
            label48.Text = menu.G5().ToString();
            label49.Text = menu.G2().ToString();
            label50.Text = "";
            label51.Text = "";
            label52.Text = "";
            label53.Text = menu.G1().ToString();
            label54.Text = "";

            label55.Text = "";
            label56.Text = menu.G2().ToString();
            label57.Text = menu.G3().ToString();
            label58.Text = menu.G1().ToString();
            label59.Text = "";
            label60.Text = "";
            label61.Text = "";
            label62.Text = "";
            label63.Text = "";

            label64.Text = "";
            label65.Text = "";
            label66.Text = "";
            label67.Text = "";
            label68.Text = menu.G1().ToString();
            label69.Text = menu.G5().ToString();
            label70.Text = menu.G2().ToString();
            label71.Text = "";
            label72.Text = "";

            label73.Text = "";
            label74.Text = "";
            label75.Text = menu.G4().ToString();
            label76.Text = "";
            label77.Text = menu.G3().ToString();
            label78.Text = "";
            label79.Text = menu.G5().ToString();
            label80.Text = "";
            label81.Text = "";
        }

            

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        
        }
}
