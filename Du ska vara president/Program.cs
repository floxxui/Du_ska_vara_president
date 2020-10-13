using System;

namespace Du_ska_vara_president
{
    class Program
    {
        static void Main(string[] args)
        {
            President p = new President();

            while (true)
            {
                System.Console.WriteLine("What should the president be called?");
                
                p.name = Console.ReadLine();

                System.Console.WriteLine("Is the name " + p.name + " alright? (y/n)");

                string playerAnswer = Console.ReadLine();

                if (playerAnswer.ToLower() == "y")
                {
                    System.Console.WriteLine("The presidents name is now " + p.name);
                    break;
                }
                else if (playerAnswer.ToLower() == "no")
                {
                    System.Console.WriteLine("");
                }
    
                
            }
        }
    }
}
