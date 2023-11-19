using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;


namespace Demo {
   class Program 
   {
      User user = null;
      Program program = new Program();
      bool loop = true;
      bool menuLoop = true;
      string userName = "Error";
      int choice;

      while (menuLoop == true){
         Console.WriteLine("1: Create User");
         Console.WriteLine("2: Load User");
         choice = int.Parse(Console.ReadLine());
         while (loop == true){
         switch (choice)
         {
               case 1:
                  Console.WriteLine("UserName:");
                  userName = Console.ReadLine();
                  user = new User(userName);
                  loop = false;

                  break;
               case 2:
                  Console.WriteLine("UserName:");
                  userName = Console.ReadLine();
                  user = new User(userName);
                  user.LoadUser(userName);
                  loop = false;
                  break;
               default:
                  Console.WriteLine("Please Select a Valid Entry");
                  break;
         }
         }
         user.SaveUser();
         Console.WriteLine("1: Create Simple Goal");
         Console.WriteLine("2: Create CheckBox Goal");
         Console.WriteLine("3: Create Eternal Goal");
         Console.WriteLine("4: Save");
         Console.WriteLine("5: Show Score");
         Console.WriteLine("6: Complete a Goal");


         choice = int.Parse(Console.ReadLine());

         switch (choice)
         {
               case 1:

                  break;
               case 2:
                  break;
               case 3:
                  break;
               case 4:
                  user.SaveUser();
                  break;
               case 5:
                  break;
               case 6:
                  
                  break;
               default:
                  Console.WriteLine("Invalid choice");
                  break;
         }
         
      }
   }

}
