using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
   public class SudokuGame
    {
       string[,] array = new string[9, 9];
       string[] getdata;

       public string[] Getdata
       {
           get { return getdata; }
           set { getdata = value; }
       }
      
       public SudokuGame()
       {

       }
       public void fillvalue(SudokuGame obj)
       {
          
           for (int i = 0; i < 9; i++)
           {
               string[] row = obj.Getdata[i].Split(' ');
             
               for (int j = 0; j < 9; j++)
               {
                   array[i, j] = row[j];
               }
           }
       }
       public string check()
       {
           string x = "";
           for (int i = 0; i < 9; i++)
           {
              
               for (int j = 0; j < 9; j++)
               {
                   int count1 = 0;
                   int count2 = 0;
                   for (int k = 0; k < 9; k++)
                   {
                       if (array[i,j]!=array[i,k])
                       {
                           count1++; 
                       }
                       if (array[i,j]!=array[k,j])
                       {
                           count2++;
                       }
                   }
                   if (count1==8&&count2==8)
                   {
                       x = "True";
                   }
                   else
                   {
                       x = "False";
                       break;
                   }
               }
               if (x=="False")
               {
                   break;
               }
               
           }
           return x;
       }
    }
}
