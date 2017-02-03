using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using StringFilter;

namespace StringFilter.Tests
{
    [TestFixture]
    public class StringFilterTests
    {
        private IList<string> _listToFilter;
        private IList<string> _listFiltered;

        [OneTimeSetUp]
        public void CreateStringList()
        {
            _listToFilter = new List<string>
            {
                "al", "albums", "aver", "bar", "barely", "be", "befoul", "bums", "by", "cat", "con",
                "convex", "ely", "foul", "here", "hereby", "jig", "jigsaw", "or", "saw", "tail", "tailor",
                "vex", "we", "weaver"
            };

            _listFiltered = new List<string>
            {
                "albums", "barely", "befoul", "convex", "hereby", "jigsaw", "tailor", "weaver"
            };
        }

        [Test]
        public void EmptyList_FilterShouldReturnEmptyList()
        {
            var listToFilter = new List<string>();

            var result = StringFilter.FilterStringList(listToFilter);

            Assert.IsEmpty(result);
        }

        [Test]
        public void NullList_FilterShouldReturnEmptyList()
        {
            var result = StringFilter.FilterStringList(null);

            Assert.IsEmpty(result);
        }

        [Test]
        public void ValidList_FilterShouldReturnListWithCorrectCharacterAmount()
        {
            var result = StringFilter.FilterStringList(_listToFilter);

            var isCountIncorrect = result.Any(str => str.Length != StringFilter.NrCharsToPass);
            Assert.False(isCountIncorrect);
        }

        [Test]
        public void ValidList_FilterShouldReturnSubSetOfInputList()
        {
            var result = StringFilter.FilterStringList(_listToFilter);

            CollectionAssert.IsSubsetOf(result, _listToFilter);
        }

        [Test]
        public void ValidList_FilterShouldReturnCorrectValues()
        {
            var result = StringFilter.FilterStringList(_listToFilter);

            CollectionAssert.AreEquivalent(_listFiltered, result);
        }
    }
}
