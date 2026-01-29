using Sprint_0_Group_4.Models;
using System;
using System.Collections.Generic;
using Xunit;
using Sprint_0_Group_4.Models;

namespace Sprint_0_Group_4.Tests
{
    public class NumberSorterTests
    {
        [Fact]
        public void SortAscending_SortsCorrectly()
        {
            var input = new List<int> { 5, 1, 3, 3, -2 };
            var result = NumberSorter.SortAscending(input);

            Assert.Equal(new List<int> { -2, 1, 3, 3, 5 }, result);
        }

        [Fact]
        public void SortDescending_SortsCorrectly()
        {
            var input = new List<int> { 5, 1, 3, 3, -2 };
            var result = NumberSorter.SortDescending(input);

            Assert.Equal(new List<int> { 5, 3, 3, 1, -2 }, result);
        }

        [Fact]
        public void SortAscending_ThrowsOnNull()
        {
            Assert.Throws<ArgumentNullException>(() => NumberSorter.SortAscending(null!));
        }

        [Fact]
        public void SortDescending_ThrowsOnNull()
        {
            Assert.Throws<ArgumentNullException>(() => NumberSorter.SortDescending(null!));
        }
    }
}
