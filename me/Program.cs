using System;

namespace session1
{
    class Program
    {
        static void Main(string[] args)
        {

           
             Console.WriteLine("please enter your first string :");
              string sentence1 = Console.ReadLine();
             char[] charArr = sentence1.ToCharArray();

 
             Console.WriteLine("please enter your second string:"); 
             string sentence2 = Console.ReadLine();
             char[] charArr2 = sentence2.ToCharArray();


            for (int i = 0; i<= charArr.Length; i++)
            {
                for (int j = 0; j < charArr2.Length; j++)
                {
                    if (charArr[i]==charArr2[j]){

                         Console.WriteLine(charArr2[j]);

                    }
                }
            
               

               
            }
        }
    }
}
        
     