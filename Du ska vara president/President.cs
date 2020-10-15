using System;

namespace Du_ska_vara_president
{
    public class President
    {
        public string name;
        public int[] priority = {0, 0, 0}; 
        //Enviroment, Defense, Healthcare
        public int corruption;
        public int money;

        public void GivingPriority(){
            Random generator = new Random(100);

            for (int i = 0; i < 3; i++)
            {
                priority[i] = generator.Next(100);

            }
        }

//PassLegislation anropas för att försöka få presidenten att godkänna lagstiftning. Man stoppar in hur mycket 
//lagstiftningen berör miljön (e), försvaret (d), sjukvård (h) som int-värden mellan 0–100. Man stoppar också in 
//en summa för "bribe", som är hur mycket pengar man vill muta presidenten med.
//För att passera lagstiftningen (returnera true) så måste värdena för e, d och h vara lägre än presidentens 
//environmentPriority, defensePriority och healthcarePriority.


    }
}
