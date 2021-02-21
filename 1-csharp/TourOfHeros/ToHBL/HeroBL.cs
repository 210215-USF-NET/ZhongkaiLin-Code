using System;
using System.Collections.Generic;
using ToHDL;
using ToHModels;

namespace ToHBL
{
    public class HeroBL : IHeroBL
    {
        private IHeroRepo _repo;
        public HeroBL(IHeroRepo repo)
        {
            _repo = repo;
        }
        public void AddHero(Hero newHero)
        {
            _repo.AddHero(newHero);
        }

        public List<Hero> GetHeroes()
        {
            return _repo.GetHeroes();
        }
    }
}
