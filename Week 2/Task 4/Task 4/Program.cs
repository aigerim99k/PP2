﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"C:\Users\Aigerim\Desktop\PP2\Week 2\Task 4\path1.txt";    //paths for the creating files
            string path2 = @"C:\Users\Aigerim\Desktop\PP2\Week 2\Task 4\path2.txt";
            string text = "Some text";
            StreamWriter sw = new StreamWriter(path1); //for the writing to first file
            sw.Write(text);                            //write the text to first file
            sw.Close();                                 //close the text cause of streamwriter
            File.Copy(path1, path2);                    //copy paste the text from path1 to path2
            File.Delete(path1);                         //delete the path1
        }
    }
}