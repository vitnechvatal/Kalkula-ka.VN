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
    double dblCislo1, dblCislo2;
    string strOperace;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // nastavení proměnných
            strOperace = "";
            dblCislo1 = dblCislo2 = 0;

        }

        private void btPlusClick(object sender, EventArgs e)
        {
            strOperace = "+";

            dblCislo1 =Convert.ToDouble( txtDisplay.Text);
        }
    }
}
