namespace ObjectOrientedProgramming;
using  System.Linq;
using System;
internal class Student
{
   
     public string Name;
     public string Surname;
     public int YearBorn;
     
     // define method 
     public string Info()
     {
         return $"The student is called {Name} {Surname} and he was born in {YearBorn} and he is {Age()} years old.";
          
          
     }

     public int Age()
     {
         const int ACTUAL_YEAR = 2026;
         return ACTUAL_YEAR - YearBorn;
     }
    
    
}