using System.Collections.Generic;

namespace tests.utilities
{
    public static class CollectionUtilities
    {
        public static void Add<item>(this IList<item> items ,params item[] parameters ) where item: new() 
        {
            foreach (var parameter in parameters)
            {
                items.Add(parameter);
            } 
        }
    }
}