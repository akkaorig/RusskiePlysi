using System;
using System.Windows.Forms;

namespace RusskiePlysi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Translate()
        {
            string temp = richTextBox1.Text;
            temp = temp.Replace("#подключить", "#include");
            temp = temp.Replace("<студия>", "<stdio.h>");
            temp = temp.Replace("<системная>", "<windows.h>");
            temp = temp.Replace("фвз ", "int ");
            temp = temp.Replace("тело(", "main(");
            temp = temp.Replace("вывести(", "printf(");
            temp = temp.Replace("подождать;", "system(\"pause\");");
            temp = temp.Replace("выйти;", "return 0;");
            temp = temp.Replace("вернуть ", "return ");
            temp = temp.Replace("число ", "int ");
            temp = temp.Replace("строка ", "std::string ");
            temp = temp.Replace("символ ", "char ");
            temp = temp.Replace("символы ", "char *");
            temp = temp.Replace("фнз ", "void ");
            temp = temp.Replace("завершить;", "ExitProcess(0);");
            temp = temp.Replace("цикл(", "while(");
            temp = temp.Replace("при(", "for(");
            temp = temp.Replace("делать {", "do {");
            temp = temp.Replace("длинна(", "strlen(");
            temp = temp.Replace("вставить(", "strcpy(");
            temp = temp.Replace("<файлы>", "<fstream>");
            temp = temp.Replace("фввод", "std::ofstream");
            temp = temp.Replace("фвывод", "std::ifstream");
            temp = temp.Replace(".закрыть;", ".close();");
            temp = temp.Replace("ввести(", "scanf(");
            temp = temp.Replace("%т", "%s");
            temp = temp.Replace("%ч", "%d");
            temp = temp.Replace("логичный ", "bool ");
            temp = temp.Replace("класс {", "class {");
            richTextBox1.Text = temp;
        }

        void Translit()
        {
            string temp = richTextBox1.Text;
            temp = temp.Replace("а", "a");
            temp = temp.Replace("б", "b");
            temp = temp.Replace("ц", "c");
            temp = temp.Replace("д", "d");
            temp = temp.Replace("е", "e");
            temp = temp.Replace("ф", "f");
            temp = temp.Replace("г", "g");
            temp = temp.Replace("х", "h");
            temp = temp.Replace("и", "i");
            temp = temp.Replace("к", "k");
            temp = temp.Replace("л", "l");
            temp = temp.Replace("м", "m");
            temp = temp.Replace("н", "n");
            temp = temp.Replace("о", "o");
            temp = temp.Replace("п", "p");
            temp = temp.Replace("ю", "q");
            temp = temp.Replace("р", "r");
            temp = temp.Replace("с", "s");
            temp = temp.Replace("т", "t");
            temp = temp.Replace("у", "u");
            temp = temp.Replace("в", "v");
            temp = temp.Replace("ь", "");
            temp = temp.Replace("ъ", "");
            temp = temp.Replace("ы", "");
            temp = temp.Replace("ч", "ch");
            temp = temp.Replace("я", "ya");
            temp = temp.Replace("ё", "e");
            temp = temp.Replace("з", "z");
            richTextBox1.Text = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Translate();
            Translit();
        }
    }
}
