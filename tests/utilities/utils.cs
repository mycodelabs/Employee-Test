using System.Collections.Generic;

namespace tests.utilities
{
    public static class utils
    {
        public static IList<T>  create_instance<T>(this IList<T> item) where T : new()
        {
            create_new_instance<T> items = CreateInstances.instance;
            return items(item);
        }
    }
}