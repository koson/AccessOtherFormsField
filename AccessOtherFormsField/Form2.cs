using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessOtherFormsField
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.Text = f1.TextBox1;
        }

        public Form2(Form1 f1)
        {
            this.f1 = f1;
            InitializeComponent();
            textBox1.Text = f1.TextBox1;
        }

        private Form1 f1;

        private void buttonUpdateForm1Var_Click(object sender, EventArgs e)
        {
            f1.TextBox1 = textBox2.Text;
        }
    }
}
