using System;
using System.Collections.Generic;
using System.Linq;

namespace Extensions
{
    public static class EnumerableExtensions
    {

        private static Random random = new Random();

        public static T Random<T>(this IEnumerable<T> sequence)
        {
            if (sequence == null)
            {
                throw new ArgumentNullException();
            }

            if (!sequence.Any())
            {
                throw new ArgumentException("The sequence is empty.");
            }

            //optimization for ICollection<T>
            if (sequence is ICollection<T>)
            {
                ICollection<T> col = (ICollection<T>)sequence;
                return col.ElementAt(random.Next(col.Count));
            }

            int count = 1;
            T selected = default(T);

            foreach (T element in sequence)
            {
                if (random.Next(count++) == 0)
                {
                    //Select the current element with 1/count probability
                    selected = element;
                }
            }

            return selected;
        }

    }
}
