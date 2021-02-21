using ToHModels;
using System.Collections.Generic;
namespace ToHDL
{
    public interface IHeroRepo
    {
        List<Hero> GetHeroes();
        Hero AddHero(Hero newHero);
    }
}