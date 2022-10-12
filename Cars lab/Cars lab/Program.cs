using System.Linq.Expressions;

namespace Cars_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;

            List<Car> carsInventory = new List<Car>();
            carsInventory.Add(new Car("Ford", "tundra", 2000, 2100));
            carsInventory.Add(new Car("Ford", "Fusion", 2010, 6100));
            carsInventory.Add(new Car("Toyota", "Camry", 2020, 30000));
            carsInventory.Add(new UsedCar("Chevy", "Nova", 1984, 800, 400000));
            carsInventory.Add(new UsedCar("Honda", "Civic", 2006, 1500, 100000));
            carsInventory.Add(new UsedCar("Honda", "Accord", 2012, 1500, 34000));


            while (goOn)
            {
                if (carsInventory.Count == 0)
                {
                    Console.WriteLine("I apologies for the inconvinence thy kind gentlemen but it seems you have purchased everything already.");
                    Console.WriteLine("I hope you shall come by again we always appriciate your patronage");
                    break;
                }

                Console.WriteLine("Heres everything we have alright.:");

                int index = 1;

                foreach (Car car in carsInventory)
                {
                    Console.WriteLine(index + ":  " + car);
                    index++;
                }

                Console.WriteLine("Choose a car you want and make it snappy!");

                int input = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (input <= 6)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("We don't have that");
                    break;
                }

                Console.WriteLine($"You purchased our {carsInventory[input].Year} {carsInventory[input].Make} " +
                   $"{carsInventory[input].Model} for {carsInventory[input].Price}.");

                carsInventory.RemoveAt(input - 1);

                goOn = runAgain();


            }

            static bool runAgain()
            {
                Console.WriteLine("Would you like to purchase another vehicle? Y/N?");
                string input = Console.ReadLine().ToLower();

                if (input == "y")
                {
                    Console.WriteLine();
                    return true;
                }
                else if (input == "n")
                {
                    Console.WriteLine("Thank you come again.");
                    return false;
                }
                else
                {
                    Console.WriteLine("Maybe actually put in what I asked next time?");
                    return runAgain();
                }
            }


        }
    }
}