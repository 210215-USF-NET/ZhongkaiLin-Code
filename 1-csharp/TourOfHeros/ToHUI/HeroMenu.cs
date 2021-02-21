using System;
using ToHModels;
using ToHBL;
namespace ToHUI
{
    public class HeroMenu : IMenu

    {
        private IHeroBL _heroBL;
        public HeroMenu(IHeroBL heroBL)
        {
            _heroBL = heroBL;
        }
        public void Start()
        {
            Boolean stay = true;
            do
            {
            Console.WriteLine("Welcome to my Tour of Heros app! What would you like to do?");
            Console.WriteLine("[0] Create a hero");
            Console.WriteLine("[1] Get all Heros");
            Console.WriteLine("[2] Exit");

            Console.WriteLine("Enter a number: ");
            string userInput = Console.ReadLine();

                switch (userInput)
                {
                case "0":
                    CreateHero();
                    break;
                case "1":
                    GetHeroes();
                    break;
                case "2":
                stay = false;
                ExitRemarks();
                    break;
                default:
                Console.WriteLine("Invalid Input!");
                    break;
                }
            }
            while(stay);
        }
            public void CreateHero()
        {
            Hero newHero = new Hero();
            Console.WriteLine("Enter a Hero Name: ");
            newHero.HeroName = Console.ReadLine();
            Console.WriteLine("Enter HP Value: ");
            newHero.HP = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter SuperPower details");
            SuperPowers newSupperPower = new SuperPowers();
            Console.WriteLine("Enter SuperPower Name: ");
            newHero.SuperPower.Name = Console.ReadLine();
            Console.WriteLine("Enter SuperPower Description");
            newHero.SuperPower.Description = Console.ReadLine();
            Console.WriteLine("Enter SuperPower Damage");
            newHero.SuperPower.Damage = int.Parse(Console.ReadLine());
            Console.WriteLine("Set the Element of the Hero: ");
            newHero.ElemetnType = Enum.Parse<element>(Console.ReadLine());
        
            _heroBL.AddHero(newHero);
            Console.WriteLine("Hero Successfully Created!");
        }
        public void GetHeroes()
        {
            foreach(var item in _heroBL.GetHeroes())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
        public void ExitRemarks(){
            Console.WriteLine("GoodBye!");
        }
    }
}
