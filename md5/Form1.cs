using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace md5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string sifrele;
        private void button1_Click(object sender, EventArgs e)
        {
            sifrele=SifreleM.Md5Sifreleme(textBox2.Text);
            label1.Text = "Oluşturulan Hash..:"+sifrele;

            if (textBox2.Text=="123456")
            {
            label2.Text = "Hash 123456: "+"e10adc3949ba59abbe56e057f20f883e";
            MessageBox.Show("123456 doğru şifrelendi");
            }
            
        


        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.Text="";
        }
    }
}
