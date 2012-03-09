using System.Collections.Generic;

namespace tests.utilities
{
    public static class CreateInstances
    {
        public static IList<item> instance<item>(IEnumerable<item> items) where item : new()
        {
            return new List<item>();
        }
    }
}