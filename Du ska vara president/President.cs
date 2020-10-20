using System;

namespace Du_ska_vara_president
{
    public class President
    {
        public string name;
        public int[] priority = {0, 0, 0}; 
        //Enviroment, Defense, Healthcare

        public int bribe;
        public bool bribed;
        public int corruption;
        public int money;
        public Random generator = new Random(100);

        public void GivingPriority(){

            for (int i = 0; i < 3; i++)
            {
                priority[i] = generator.Next(100);
            }
        }

        public void PassLegislation(){
            int[] referate = {0, 0, 0};
            //Enviroment, Defense, Healthcare

            for (int i = 0; i < 3; i++)
            {
                referate[i] = generator.Next(100);
            }

            System.Console.WriteLine("You suggested a law with the priorities E: " + referate[0] + ", D: " + referate[1] + " and H: " + referate[2]);

            while (true)
            {
                System.Console.WriteLine("Do you wish to bribe the president? (y/n)");
                string playerAnswer = Console.ReadLine();

                if(playerAnswer.ToLower() == "y"){
                     while(true){
                        System.Console.WriteLine("How much do you want to bribe the president with?");
                        string answer = Console.ReadLine();

                        bool successful = int.TryParse(answer, out bribe);

                        if(successful == true){
                            System.Console.WriteLine("You bribed him with " + bribe + " amount of money");
                            bribed = true;
                            break;
                        }
                        else if (successful == false){
                            System.Console.WriteLine("This is not a number, please try again");
                        }
                    }
                }
                else if(playerAnswer.ToLower() == "n"){
                    System.Console.WriteLine("You decided to not bride the president");
                    bribed = false;
                    break;
                }
                else{

                }
            }


        }

//PassLegislation anropas för att försöka få presidenten att godkänna lagstiftning. Man stoppar in hur mycket 
//lagstiftningen berör miljön (e), försvaret (d), sjukvård (h) som int-värden mellan 0–100. Man stoppar också in 
//en summa för "bribe", som är hur mycket pengar man vill muta presidenten med.
//För att passera lagstiftningen (returnera true) så måste värdena för e, d och h vara lägre än presidentens 
//environmentPriority, defensePriority och healthcarePriority.
//Så om presidenten har 40 i environmentPriority, 30 i defensePriority och 20 i healthcarePriority så kommer 
//resultatet att bli misslyckat om e är högre än 40, d högre än 30 eller h högre än 20. Om man anger ett värde 
//för bribe så adderas det dels till presidentens money, och dels räknas de tre variablerna som lika mycket 
//högre. Så om man anger 20 som bribe och presidenten har 40 i environmentPriority, 30 i defensePriority och 20 
//i healthcarePriority så räknas det som att hen har värdena 60, 50 och 40 när jämförelsen görs. Dessutom ökar 
//då presidentens corruption med en tiondel av mängden pengar, så den ökar med 2 om bribe anges som 20.



    }
}
