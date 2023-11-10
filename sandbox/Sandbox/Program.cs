using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;


namespace Demo {
   class Program 
   {
      static public void Main(){
         Console.WriteLine("How many Seconds");
         string input = Console.ReadLine();
         int length = int.Parse(input);
         Breath breath = new Breath();
         breath.Time(length); 
      }

   }

}
