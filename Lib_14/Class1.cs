using System;

namespace Lib_14
{
    public static class Work
    {
        public static int SummArray(int[] mas, int maxValue)
        {
            int num = 0;
            maxValue = 8;
            for(int i = 0; i< mas.Length; i++)
            {
          
                if (mas[i] < maxValue)
                {
                    num +=  mas[i];
                }
            }

            return num;
        }
    }
}
    


