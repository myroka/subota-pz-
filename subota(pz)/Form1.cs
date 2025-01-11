using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subota_pz_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioproverka1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isvopros1 =  radioproverka1.Checked;
            bool isvopros2 = rB_1_1.Checked && rB_2_2.Checked && !rB_3_3.Checked;
            bool isvopros3 = uveren2.Checked;

            string result = "Result: \n";

            //1 
            result += isvopros1
                ? "Q1: corect\n"
                : "Q1: Uncorect\n";
            
            result += isvopros2
                ? "Q2: corect\n"
                : "Q2: uncorert\n";
            
            result += isvopros3
                ? "Q3: corect\n"
                : "Q3: uncorert\n";

            MessageBox.Show(result, "Result");

        }

       
    }
}
