using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        int A = 0, B = 1;
        double Totle;
        string[] Menu = new string[50];
        string[] Bth = new string[50];
        string cd,mm;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Totle += 50;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Esspresso Frappe";
            Bth[A] = "50";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Totle += 35;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Esspresso Hot";
            Bth[A] = "35";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }
        public void LM()
        {
            ListViewItem flame = new ListViewItem();
            flame.Text = Menu[A];
            flame.SubItems.Add(Bth[A]);
            oo.Items.Add(flame);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Totle += 45;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Esspresso Ice";
            Bth[A] = "45";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Totle += 35;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Americano Hot";
            Bth[A] = "35";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Totle += 45;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Americano Ice";
            Bth[A] = "45";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Totle += 35;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Latte Hot";
            Bth[A] = "35";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Totle += 45;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Latte Ice";
            Bth[A] = "45";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Totle += 50;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Latte Frappe";
            Bth[A] = "50";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Totle += 35;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Mocha Hot";
            Bth[A] = "35";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Totle += 45;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Mocha Ice";
            Bth[A] = "45";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Totle += 50;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Mocha Frappe";
            Bth[A] = "50";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Totle += 35;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Cappuccino Hot";
            Bth[A] = "35";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Totle += 45;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Cappuccino Ice";
            Bth[A] = "45";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Totle += 50;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Cappuccino Frappe";
            Bth[A] = "50";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Totle += 20;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "GreenTea Hot";
            Bth[A] = "20";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Totle += 25;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "GreenTea Ice";
            Bth[A] = "25";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Totle += 30;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "GreenTea Frappe";
            Bth[A] = "30";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Totle += 20;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "ThaiTea Hot";
            Bth[A] = "20";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Totle += 25;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "ThaiTea Ice";
            Bth[A] = "25";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Totle += 30;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "ThaiTea Frappe";
            Bth[A] = "30";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Totle += 20;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Cocoa Hot";
            Bth[A] = "20";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Totle += 25;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Cocoa Ice";
            Bth[A] = "25";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Totle += 30;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Cocoa Frappe";
            Bth[A] = "30";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Totle += 20;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Milk Hot";
            Bth[A] = "20";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Totle += 25;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Milk Ice";
            Bth[A] = "25";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Totle += 30;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Milk Frappe";
            Bth[A] = "30";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Totle += 25;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "MilkTea Ice";
            Bth[A] = "25";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Totle += 30;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "MilkTea Feappe";
            Bth[A] = "30";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Totle += 25;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "LemonTea Ice";
            Bth[A] = "25";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Totle += 30;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "LemonTea Feappe";
            Bth[A] = "30";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Totle += 20;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Milo Hot";
            Bth[A] = "20";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Totle += 25;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Milo Ice";
            Bth[A] = "25";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Totle += 30;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Milo Frappe";
            Bth[A] = "30";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Totle += 20;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Nescafe Hot";
            Bth[A] = "20";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Totle += 25;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Nescafe Ice";
            Bth[A] = "25";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Totle += 30;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Nescafe Frappe";
            Bth[A] = "30";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Totle += 20;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "NesteaTea Hot";
            Bth[A] = "20";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Totle += 25;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "NesteaTea Ice";
            Bth[A] = "25";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Totle += 30;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "NesteaTea Frappe";
            Bth[A] = "30";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Totle += 25;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Italian Soda";
            Bth[A] = "25";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Totle += 25;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Red Lime Soda";
            Bth[A] = "25";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Totle += 25;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Honey Lime Soda";
            Bth[A] = "25";
            mm += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            LM();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("โปรเลือกรายการ", "คำเตือน!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("ต้องการบันทึกรายการ", "ตกลง!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            A = 0;
            textBox1.Text = "";
            oo.Items.Clear();
            Totle = 0;
            File.WriteAllText("opor1" + (B) + ".txt", mm);
            B++;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            oo.Items.Clear();
            Totle = 0;
        }
    }
}
