﻿// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
// using System;
// using System.Windows.Forms;
// Console.WriteLine("Hello, World!");

// Solver solver = new Solver();

// Console.WriteLine("DFS");
// solver.DFS();

// Console.WriteLine("BFS");
// solver.BFS();


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
