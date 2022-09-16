using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2_3kurs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xor_but_Click(object sender, EventArgs e)
        {
            // 2 code
            string strP = textBox_P.Text;
            int intP = Convert.ToInt32(strP, 2);
            string strKey = textBox_Key.Text;
            int intKey = Convert.ToInt32(strKey, 2);
            int intC = intP ^ intKey;
            string strC = Convert.ToString(intC, 2);
            //16 code
            int P16 = Convert.ToInt32(strP, 16);
            int Key16 = Convert.ToInt32(strKey, 16);
            int C16 = Convert.ToInt32(strC, 16);

            textBox_C_.Text = strC;
            textBox_Key_.Text = strKey;
            textBox_P_.Text = strP;
            //
            StrC16.Text = C16.ToString();
            StrKey16.Text = Key16.ToString();
            StrP16.Text = P16.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_P.Text = "";
            textBox_Key.Text = "";
            textBox_C.Text = "";
        }
    }
}
