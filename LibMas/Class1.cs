using System;
using System.IO;

namespace LibMas
{
    public class Class_Mas
    {
        public static void FillRandom(int[] mas)
        {
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(0,20);
            }
        }
    


      
  
        
    }
}


    
   

