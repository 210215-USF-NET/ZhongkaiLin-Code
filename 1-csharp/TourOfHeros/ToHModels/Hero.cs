using System;

namespace ToHModels
{
    public class Hero
    {
      private string heroName;

      public string HeroName 
      { 
        
        get{return heroName;}
        set
        { 
          if (value.Equals(null))
          {}//Throw Exeception
            heroName = value;
        }
      } 
          public int HP { get; set; }
          
          public element ElemetnType { get; set; }

          public SuperPowers SuperPower { get; set; }
          
          public override string ToString() => $"Hero Details: \n\t name:{this.HeroName} \n\t hp:{this.HP} \n\t element:{this.ElemetnType} \n\t superpower: {this.SuperPower.ToString()}";
    }
    
}
