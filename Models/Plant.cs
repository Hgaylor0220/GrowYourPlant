using System;
namespace Garden
{
  class Plant 
  {
    public int Life { get; set;}
    public int Hunger { get; set;}
    public string Happiness { get; set;}

    public Plant(int life, int hunger, string happiness)
    {
        Life = 0;
        Hunger = 0;
        Happiness = "happy";
        
    }   

    public int IncreaseLife()
    {
        return Life ++;
    }
    public int FeedPlant()
    {
        return Hunger ++;
    }
    // private void UpdateMood()
    // {
    //     if(Hunger > 4)
    //     {
    //         Happiness = "Happy";
    //     }
    //     else if (Hunger > 3)
    //     {
    //         Happiness = "Neutral";
    //     }
    //     else 
    //     {
    //         Happiness = "Withered";
    //     }

    // }
  


  }
}

