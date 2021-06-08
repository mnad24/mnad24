using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Коростов_Владислав_ЭПбо1_30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            int[] array = { 0, 10, 20, 30, 40, 50 };
            for (int i = 0; i < array.Length; i++)
               
                textBox1.Text += array[i].ToString();
        }
    }
}