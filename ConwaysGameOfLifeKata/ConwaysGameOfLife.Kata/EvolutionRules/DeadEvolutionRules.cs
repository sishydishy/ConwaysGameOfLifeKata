using System.Collections.Generic;
using ConwaysGameOfLifeKata.Kata;

namespace ConwaysGameOfLife.Kata
{
    public class DeadEvolutionRules : EvolutionRules
    {
        public DeadEvolutionRules() : base(new Dictionary<int, bool>{{3,true}})
        {
        }
    }
}