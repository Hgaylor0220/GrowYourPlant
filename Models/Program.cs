using System;
using Garden;
//Front End 
 public class Program
 {
public static void Main()

    {
        
        Plant yourPlant = new Plant(5, 5, "happy");
        Console.WriteLine("Would you like to grow a plant? Y or N");
        string UserInputFeed = Console.ReadLine();
      
        if (UserInputFeed.ToLower() == "y" ) 
        {
            Console.WriteLine("Do you wanna Water your Plant? Type 'water' if you want to Otherwise type No");
            string UserInputforWater = Console.ReadLine();
             if (UserInputforWater.ToLower() == "water") 
             {
                yourPlant.IncreaseLife();
             }
             Console.WriteLine(yourPlant.Life);



        }
            //   Console.WriteLine(IncreaseLife());

        
    }

 }
