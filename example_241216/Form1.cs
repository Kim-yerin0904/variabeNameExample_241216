using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example_241216
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            byte mathTestScore = 98;
            short totalCompanyMember = 2203;
            int todaySalesKRW = 29340000;
            float testScoreAverage = 88.326f;
            double elonmuskPropertytoKRW = 360529380000000.00;
            decimal totalMarketCapitalizationVND_1to50 = 8004416961130740736;

            textBox1.Text += mathTestScore.GetType() + " mathTestScore : " + mathTestScore.ToString() + "\r\n";
            textBox1.Text += totalCompanyMember.GetType() + " totalCompanyMember : " + totalCompanyMember.ToString() + "\r\n";
            textBox1.Text += todaySalesKRW.GetType() + " todaySalesKRW : " + todaySalesKRW.ToString() + "\r\n";
            textBox1.Text += testScoreAverage.GetType() + " testScoreAverage : " + testScoreAverage.ToString() + "\r\n";
            textBox1.Text += elonmuskPropertytoKRW.GetType() + " elonmuskPropertytoKRW : " + elonmuskPropertytoKRW.ToString() + "\r\n";
            textBox1.Text += totalMarketCapitalizationVND_1to50.GetType() + " totalMarketCapitalizationVND_1to50 : " + totalMarketCapitalizationVND_1to50.ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
