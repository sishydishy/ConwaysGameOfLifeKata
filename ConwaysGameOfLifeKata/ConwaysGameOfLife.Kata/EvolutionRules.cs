using System;
using System.Collections.Generic;

namespace ConwaysGameOfLifeKata.Kata
{


    public class EvolutionRules 
    {
        private readonly Dictionary<int, bool> _evolutionRulesDictionary;

        protected EvolutionRules(Dictionary<int, bool> evolutionRulesDictionary)
        {
            _evolutionRulesDictionary = evolutionRulesDictionary;
        }

        
        public bool CellStateBasedOnNumberOfNeighbours(int neighbours)
        {
            try
            {
                return _evolutionRulesDictionary[neighbours];
                
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        
    }
}