using learninterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileBanking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Save Button
        private void button1_Click(object sender, EventArgs e)
        {

            IcoreBanking obj = new CoreBanking();
            obj.updateTransition(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            MessageBox.Show("Transition Successfully Updated....", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //New Button
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "0";
            textBox4.Text = "0";
        }

        //Exist Button
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
