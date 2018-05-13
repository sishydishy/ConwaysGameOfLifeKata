using System.Collections.Generic;
using ConwaysGameOfLifeKata.Kata;

namespace ConwaysGameOfLifeKata.Kata



{
    // ways to comment when you hover over class
    /// <summary>
    /// 
    /// </summary>
    public class LiveEvolutionRules : EvolutionRules
    {
        

        public LiveEvolutionRules() : base(new Dictionary<int, bool>{{2,true},{3,true}})
        {
           
        }
    }
}