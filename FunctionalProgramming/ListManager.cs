using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    internal class ListManager
    {
        List<string> Names {  get; set; } = new List<string>();

        public ListManager(List<string> names)
        {
            Names = names;
        }

        public List<string> Filter(Predicate<string> filter)
        {
            List<string> filteredPeople = new List<string>();
            foreach (string name in Names)
            {
                if (filter(name))
                {
                    filteredPeople.Add(name);
                }
                
            }
            return filteredPeople;
        }


    }
}
