using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;


namespace Demo {
   class Program 
   {

      public static List<string> listWords = new List<string>();
      static void Main(string[] args) 
      {
      
         string _verse = Console.ReadLine();
         LetsGo(_verse);
         string verse = string.Join(" ", listWords);
         Console.WriteLine(verse);
      }
      
      
      static void LetsGo(string Verse){
         string[] words = Verse.Split(new char[] {':', ' '},StringSplitOptions.RemoveEmptyEntries);
         foreach (string word in words)
         {
            Console.WriteLine(word);
            listWords.Add(word);
         }
            
        
      }


   }
}
