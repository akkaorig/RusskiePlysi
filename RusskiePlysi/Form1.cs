using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RusskiePlysi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = richTextBox1.Text;
            temp = temp.Replace("#подключить","#include");
            temp = temp.Replace("<студия>", "<stdio.h>");
            temp = temp.Replace("<системная>", "<windows.h>");
            temp = temp.Replace("фсз ", "int ");
            temp = temp.Replace("тело(", "main(");
            temp = temp.Replace("вывести(", "printf(");
            temp = temp.Replace("подождать;", "system(\"pause\");");
            temp = temp.Replace("выйти;}", "return 0;");
            temp = temp.Replace("вернуть ", "return ");
            temp = temp.Replace("число ", "int ");
            temp = temp.Replace("строка ", "std::string ");
            temp = temp.Replace("символ ", "char ");
            temp = temp.Replace("символы ", "char *");
            temp = temp.Replace("нвз ", "void ");
            temp = temp.Replace("завершить;", "ExitProcess(0);");
            richTextBox1.Text = temp;
        }
    }
}
