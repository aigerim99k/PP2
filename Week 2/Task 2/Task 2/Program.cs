﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace W3
{
    class Program
    {
        static bool Isprime(int n)    //checks for the prime of number
        {
            bool t = true;
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return t;
        }
        static void Main(string[] args)
        {
            string path = @"C:\Users\Aigerim\Desktop\Week 2\Task 2\input.txt";
            string path2 = @"C:\Users\Aigerim\Desktop\Week 2\Task 2\output.txt";
            StreamReader sr = new StreamReader(path);            //for the reading the file 1 in path
            StreamWriter sw = new StreamWriter(path2);           //for the writing to the file 2 in path2
            String[] ss = sr.ReadToEnd().Split(' ');             //read strings by the spaces
            foreach (string s in ss)                              //take each elements in file 1 
            {
                int q = int.Parse(s);                            //convert string to integer
                if (Isprime(q))                                  //checks the numbers in file 1 for the prime
                {
                    sw.Write(q + " ");                             //write prime numbers to file 2
                }
            }
            sw.Close();                                          //close the file 2
        }
    }
}