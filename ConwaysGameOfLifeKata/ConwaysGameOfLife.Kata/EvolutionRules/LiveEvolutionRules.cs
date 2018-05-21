using System.Collections.Generic;
using ConwaysGameOfLifeKata.Kata;

namespace ConwaysGameOfLifeKata.Kata
{
    public class LiveEvolutionRules : EvolutionRules
    {
        public LiveEvolutionRules() : base(new Dictionary<int, bool>{{2,true},{3,true}})
        {
           
        }
    }
}