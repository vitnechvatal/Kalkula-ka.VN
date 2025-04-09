using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulačka.VN
{
    

    public partial class Form1 : Form
    {
        double dblCislo1, dblCislo2, dblVysledek;
        string strOperace;

        public Form1()
        {
            InitializeComponent();

            // nastavení proměnných
            strOperace = "";
            dblCislo1 = dblCislo2 = 0;

        }

        private void btRovno_Click(object sender, EventArgs e)
        {
            dblCislo2 = Convert.ToDouble(txtDisplay.Text);
           
            // je požadováno sčítání
            if (strOperace == "+") 
                dblVysledek=dblCislo1 + dblCislo2;
            //vypsat na disply
            txtDisplay.Text = dblVysledek.ToString(); 
        }

        private void btPlusClick(object sender, EventArgs e)
        {
            strOperace = "+";

            dblCislo1 =Convert.ToDouble( txtDisplay.Text);
        }
    }
}
