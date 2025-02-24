namespace Topic_5_assignment_part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int earthWeight, visitingPlanet;
            Double venusGravity, venusWeight, marsGravity, marsWeight, jupiterGravity, jupiterWeight, saturnGravity, saturnWeight, uranusGravity, uranusWeight,neptuneGravity, neptuneWeight;

            venusGravity = 0.78;
            marsGravity = 0.39;
            jupiterGravity = 2.65;
            saturnGravity = 1.17;
            uranusGravity = 1.05;
            neptuneGravity = 1.23; 

            Console.Write("Please enter your Earth weight ");
            earthWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("I have information for the following planets:");
            Console.WriteLine("\t1. Venus\t " + "\t2. Mars\t " + "\t3. Jupiter\t ");
            Console.WriteLine("\t4. Saturn\t " + "\t5. Uranus\t " + "\t6. Neptune\t ");
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Write("Which planet are you visiting? ");
            visitingPlanet = Convert.ToInt32(Console.ReadLine());
            //Below this is the equiations for your gravity on the 6 planets
            venusWeight = earthWeight * venusGravity;
            marsWeight = earthWeight * marsGravity;
            jupiterWeight = earthWeight * jupiterGravity;
            saturnWeight = earthWeight * saturnGravity;
            uranusWeight = earthWeight * uranusGravity;
            neptuneWeight = earthWeight * neptuneGravity;
            //Below this is the if statements and their answers
            Console.WriteLine();
            if (visitingPlanet == 1)
            {
                Console.WriteLine("Your weight on Venus would be " + venusWeight);
            }
            else if (visitingPlanet == 2)
            {
                Console.WriteLine("Your weight on Mars would be " + marsWeight);
            }
            else if (visitingPlanet == 3)
            {
                Console.WriteLine("Your weight on Jupiter would be " + jupiterWeight);
            }
            else if (visitingPlanet == 4)
            {
                Console.WriteLine("Your weight on Saturn would be " + saturnWeight);
            }
            else if (visitingPlanet == 5)
            {
                Console.WriteLine("Your weight on Uranus would be " + uranusWeight);    
            }
            else if (visitingPlanet == 6)
            {
                Console.WriteLine("Your weight on Neptune would be " + neptuneWeight);
            }
            else
            {
                Console.WriteLine("Invalid Planet Number, try again");
            }
        }
    }
}
