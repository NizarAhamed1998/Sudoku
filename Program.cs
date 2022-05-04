using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            SudokuGame sg = new SudokuGame();
            string path = "C:\\Users\\DELL 2021\\Downloads\\Sudoku2 Right.txt";
            sg.Getdata = File.ReadAllLines(path);
            sg.fillvalue(sg);
            Console.WriteLine(sg.check());
            
        }
    }
}
