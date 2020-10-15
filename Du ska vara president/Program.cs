using System;

namespace Du_ska_vara_president
{
    class Program
    {
        static void Main(string[] args)
        {
            President p = new President();

            System.Console.WriteLine("What should the president be called?");
            while (true)
            {                
                p.name = Console.ReadLine();

                while (true)
                {
                    System.Console.WriteLine("Is the name " + p.name + " alright? (y/n)");
                    string playerAnswer = Console.ReadLine();

                    if (playerAnswer.ToLower() == "y"){
                       System.Console.WriteLine("The presidents name is now " + p.name);
                       break;
                    }
                    else if (playerAnswer.ToLower() == "n"){
                        System.Console.WriteLine("What should the president be called?");
                        p.name = "";
                        break;
                    }
                    else{
                        System.Console.WriteLine("Please answer y or n");
                    }
                }
    
                if (p.name != ""){
                    break;
                }
            }
            
            p.GivingPriority();
            System.Console.WriteLine("Enviroment priority: " + p.priority[0] + "\nDefense Priority" + p.priority[1] + "Healthcare Priority: " + p.priority[2]);

            Console.ReadLine();
        }

    }
}
