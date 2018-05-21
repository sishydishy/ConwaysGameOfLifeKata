using System.Collections.Generic;

namespace ConwaysGameOfLifeKata.Kata
{
    public class EvolutionRules 
    {
        private readonly Dictionary<int, bool> _evolutionRulesDictionary;
        
        public bool CellStateBasedOnNumberOfNeighbours(int neighbours)
        {
            return _evolutionRulesDictionary.ContainsKey(neighbours) && _evolutionRulesDictionary.ContainsKey(neighbours);
        }
        
        protected EvolutionRules(Dictionary<int, bool> evolutionRulesDictionary)
        {
            _evolutionRulesDictionary = evolutionRulesDictionary;
        }  
    }
}