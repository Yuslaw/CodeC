using System;
using System.Collections.Generic;

namespace CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = "the day is sunny the the the sunny is is";
            FrequencyQuestion3(n);
            // string n = "a";
            // PasswordQuestion2(n);
        }
    
   
        public static void FrequencyQuestion3(string n)
        {
            var sp = n.Split(' ');
            Dictionary<string, int> examples = new Dictionary<string, int>();
            foreach(var st in sp)
            {
                if(st == "")
                {
                    Console.WriteLine("You gonna find nada");
                }
                else
                {
                    
                    if(examples.ContainsKey(st))
                    {
                        examples[st]= examples[st]+1;
                    }
                    else
                    {
                        examples.Add(st, 1);
                    }
                }
            }
             foreach(var item in examples)
            {
                Console.WriteLine($"{item.Key}, {item.Value}");
            }


        }
    
        // public static int PasswordQuestion2(string n)
        // {
        //     int res = 0; 
        //     int a = 1;
        //     int A = 1; 
        //     int d = 1;
        //     char[] take = n.ToCharArray();
        //     int[] arr = new int[take.Length];

        //     for(int i = 0; i < arr.Length;)
        //     {
        //         if(char.IsLower(take[i])) 
        //         {
        //             a=0;
        //         }
        //         if(char.IsUpper(take[i])) 
        //         {
        //             A = 0;
        //         }
        //         if(char.IsDigit(take[i])) 
        //         {
        //             d = 0;
        //         }
        //     }
            


    }
    
}
