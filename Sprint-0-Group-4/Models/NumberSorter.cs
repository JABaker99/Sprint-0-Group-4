using System;
using System.Collections.Generic;
using System.Linq;

namespace Sprint_0_Group_4.Models
{
    /// <summary>
    /// Provides number sorting utilities.
    /// </summary>
    public static class NumberSorter
    {
        /// <summary>
        /// Returns a new list of numbers sorted in ascending order.
        /// </summary>
        public static List<int> SortAscending(IEnumerable<int> numbers)
        {
            if (numbers is null)
                throw new ArgumentNullException(nameof(numbers));

            return numbers.OrderBy(n => n).ToList();
        }

        /// <summary>
        /// Returns a new list of numbers sorted in descending order.
        /// </summary>
        public static List<int> SortDescending(IEnumerable<int> numbers)
        {
            if (numbers is null)
                throw new ArgumentNullException(nameof(numbers));

            return numbers.OrderByDescending(n => n).ToList();
        }
    }
}
