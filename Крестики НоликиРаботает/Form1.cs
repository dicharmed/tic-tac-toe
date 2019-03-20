using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int i;
        string[] arr = new string[10];
        string t = "X";
        
        public Form1()
        {
            InitializeComponent();
        }

        public string Game(int j)
        {
           
            if (i % 2 == 1)
            {
                t = "X";             
            }
            else {  t = "O";  }           
            //смена крест на ноль
            arr[j] = t;
            i += 1;   
            return t;
        }
        public void pobeditel()
        {
            
            if ((arr[1] == "X" & arr[2] == "X" & arr[3] == "X") | (arr[1] == "X" & arr[5] == "X" & arr[9] == "X") | (arr[1] == "X" & arr[4] == "X" & arr[7] == "X") | (arr[2] == "X" & arr[5] == "X" & arr[8] == "X") | (arr[3] == "X" & arr[6] == "X" & arr[9] == "X") | (arr[3] == "X" & arr[5] == "X" & arr[7] == "X") | (arr[4] == "X" & arr[5] == "X" & arr[6] == "X") | (arr[7] == "X" & arr[8] == "X" & arr[9] == "X"))
            {
                MessageBox.Show("Выиграли крестики!!!");
                refresch();
            }
            if ((arr[1] == "O" & arr[2] == "O" & arr[3] == "O") | (arr[1] == "O" & arr[5] == "O" & arr[9] == "O") | (arr[1] == "O" & arr[4] == "O" & arr[7] == "O") | (arr[2] == "O" & arr[5] == "O" & arr[8] == "O") | (arr[3] == "O" & arr[6] == "O" & arr[9] == "O") | (arr[3] == "O" & arr[5] == "O" & arr[7] == "O") | (arr[4] == "O" & arr[5] == "O" & arr[6] == "O") | (arr[7] == "O" & arr[8] == "O" & arr[9] == "O"))
            {
                MessageBox.Show("Выиграли нолики!!!");
                refresch();
            }
            if ((arr[1] != "") & (arr[2] != "") & (arr[3] != "") & (arr[4] != "") & (arr[5] != "") & (arr[7] != "") & (arr[8] != "") & (arr[9] != ""))
            {                
                MessageBox.Show(" Ничья!");
                refresch();
            }
           
        }
           
        public void refresch()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            for (i = 0; i < 10; i += 1)
            {
                arr[i] = "";
            }
            //i = 1;
        
        }
        private void button10_Click(object sender, EventArgs e)
        {
            refresch();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "X" | button1.Text == "O")
            {
                MessageBox.Show(" Нельзя! ");
            }
            else { button1.Text = Game(1); pobeditel(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "X" | button2.Text == "O")
            {
                MessageBox.Show(" Нельзя!");
            }
            else { button2.Text = Game(2); pobeditel(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "X" | button3.Text == "O")
            {
                MessageBox.Show(" Нельзя!");
            }
            else { button3.Text = Game(3); pobeditel(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "X" | button4.Text == "O")
            {
                MessageBox.Show(" Нельзя!");
            }
            else { button4.Text = Game(4); pobeditel(); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "X" | button5.Text == "O")
            {
                MessageBox.Show(" Нельзя!");
            }
            else { button5.Text = Game(5); pobeditel(); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "X" | button6.Text == "O")
            {
                MessageBox.Show(" Нельзя!");
            }
            else { button6.Text = Game(6); pobeditel(); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "X" | button7.Text == "O")
            {
                MessageBox.Show(" Нельзя!");
            }
            else { button7.Text = Game(7); pobeditel(); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "X" | button8.Text == "O")
            {
                MessageBox.Show(" Нельзя!");
            }
            else { button8.Text = Game(8); pobeditel(); }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "X" | button9.Text == "O")
            {
                MessageBox.Show(" Нельзя!"); 
            }
            else { button9.Text = Game(9); pobeditel(); }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            refresch();
        }

        private void игрокИгрокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refresch();

        }
    }
}
