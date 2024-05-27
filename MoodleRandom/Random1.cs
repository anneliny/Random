
namespace MoodleRandom
{
    internal class Random1
    {

        public static void Run()
        {
            Random rand = new Random();
            var randomNumber = rand.Next(0,26);

            if (randomNumber == 0)
            {
                Console.WriteLine("Tallet ble 0");
            }
            else if (randomNumber == 16)
            {
                Console.WriteLine("Tallet ble 16");
            }
            else
            {
                Console.WriteLine(randomNumber);
            }
        }
        
    }
}
