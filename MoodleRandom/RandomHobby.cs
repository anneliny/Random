
namespace MoodleRandom
{
    internal class RandomHobby
    {
        public static void Run()
        {
            Console.WriteLine("Hello! Write your name and get a random hobby.");
            var input = Console.ReadLine();
            Console.Clear();
            
            Random randomHobby = new Random();
            int randomNumber = randomHobby.Next(0, 2);

            
            if (randomNumber == 0)
            {
                Console.WriteLine("Kjære" + " " + (input) + ", " + "din hobby ble strikking, regner med at du er 74 år.");
            }
            else if (randomNumber ==1){
                Console.WriteLine("Kjære" + " " + (input) + ", " + "din hobby ble hekling, du er så kul altså, hekling er best.");
            }
            else if (randomNumber == 1)
            {
                Console.WriteLine("Kjære" + " " + (input) + ", " + "din hobby ble fotografi, så ta ett bilde av meg da vel!.");
            }




        }
    }
}
