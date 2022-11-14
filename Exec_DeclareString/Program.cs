using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DeclareString
{
    internal class Program
    {
        static void Main(string[] args)
        {  //Q1 顯示C:\temp\a.jpg
            
            string path = "c:\\temp\\a.jpg";
            Console.WriteLine(path);
           
            string path2 = @"c:\temp\a.jpg";
            Console.WriteLine(path2);

                //Q2 顯示我是一個"好學生".

            string value = "我是一個\"好學生\".";
            Console.WriteLine(value);

            string value2 = @"我是一個""好學生"".";
            Console.WriteLine(value2);

            //Q3 折行顯示我是第N行文字

            string sentence = "我是第一行\r\n我是第二行";
            Console.WriteLine(sentence);

        }
    }
}
