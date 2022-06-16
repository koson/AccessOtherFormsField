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
        public Form2()          // ไม่ใช้ default constructor 
        {
            InitializeComponent();
        }

        public Form2(Form1 f1)  // ใช้ constructor ที่รับ reference ของ Form1
        {
            this.f1 = f1;       // เก็บ reference ของ Form1 ไว้ใช้ใน method อื่น ๆ 
            InitializeComponent(); // วาด element ต่างๆ บน Form2 
            textBox1.Text = f1.TextBox1; // ดึงค่าจาก Form1 มา update ใน Form2
        }

        private Form1 f1;

        private void buttonUpdateForm1Var_Click(object sender, EventArgs e)
        {
            f1.TextBox1 = textBox2.Text; // ส่งค่าจาก Form2 ไป update บน Form1
        }
    }
}
