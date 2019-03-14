using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;
using SortSamples;

namespace TestSortingAndSearching
{
    [TestFixture]
    public class TestSortSearch
    {
        [Test]
        public void TestSorting()
        {
            int[] _testData = {10,0,67,44,23,5,77};
            BinarySort sortData = new BinarySort();
            int[] _sortedData = sortData.BubbleSortData(_testData);
            int[] _expectedData = { 0, 5, 10, 23, 44, 67, 77 };
            Assert.AreEqual(_expectedData, _sortedData);
        }

        [Test]
        public void TestSearching()
        {

        }

    }
}
