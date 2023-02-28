// See https://aka.ms/new-console-template for more information
using System;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Your Password:");
            string? password = Console.ReadLine();
            int passwordlength = password.Length;
            while (passwordlength != 6)
            {
                Console.WriteLine("Input Your Password:");
                password = Console.ReadLine();
                passwordlength = password.Length;
            }
            Console.WriteLine("Your Password is " + password);
            Console.WriteLine("Input Your Section ( CIA, FBI, NSA):");
            string section = Console.ReadLine();
            
            char n1 = password[0];
            Console.WriteLine(n1);
            int check1 = n1 - '0';

            char n2 = password[1];
            Console.WriteLine(n2);
            int check2 = n2 - '0';

            char n3 = password[2];
            Console.WriteLine(n3);
            int check3 = n3 - '0';

            char n4 = password[3];
            Console.WriteLine(n4);
            int check4 = n4 - '0';

            char n5 = password[4];
            Console.WriteLine(n5);
            int check5 = n5 - '0';

            char n6 = password[5];
            Console.WriteLine(n6);
            int check6 = n6 - '0';
            
            
            switch (section)
            {
                case "CIA":
                    if ((check6 % 3 == 0)&&(check2 != 8)&&(check2 >= 6)&&(check5 != 1)&&(check5 != 3)&&(check5 != 5))
                    {
                        Console.WriteLine("Correct /(>w<)/");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!!!");
                    }
                    break;

                case "FBI":
                    if ((check1>=4)&&(check1<=7)&&(check4%2 ==0)&&(check4!=6)&&(check2%2!=0))
                    {
                        Console.WriteLine("Correct /(>w<)/");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!!!");
                    }
                    break;
                case "NSA":
                    if ((30%check6 ==0)&&(check4%3 ==0)&&(check4%2 !=0)&&((check1 == 7)||(check2 == 7||(check3 == 7)||(check4 == 7)||(check5 == 7)||(check6 == 7))))
                    {
                        Console.WriteLine("Correct /(>w<)/");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!!!");
                    }
                    break;
                default :
                    Console.WriteLine("Incorrect!!!");
                    break;
                
            }
        }
    }
}
