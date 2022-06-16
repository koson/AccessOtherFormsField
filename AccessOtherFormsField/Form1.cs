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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string TextBox1  // สร้าง property เพื่อเข้าถึง Text ของ textBox1 (ซึ่งเป็น private)
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; } 
        }

        private void buttonOpenForm2_Click(object sender, EventArgs e)
        {
            Form1 f1 = this;            // เตรียม reference ของ Form1 ที่กำลังแสเดงอยู่ในขณะนี้
            Form2 f2 = new Form2(f1);   // ส่ง reference ของ form1 ไปให้ Form2 
            f2.Show();                  // แสดง Form2 
        }
    }
}
