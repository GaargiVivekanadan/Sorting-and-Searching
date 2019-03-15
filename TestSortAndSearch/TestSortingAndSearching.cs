using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;
using SortSamplesNew;

namespace TestSortingAndSearching
{
    [TestFixture]
    public class TestSortingAndSearching
    {
        [TestCase]
        public void TestSorting()
        {
            int[] _testData = { 10, 0, 67, 44, 23, 5, 77 };
            BinarySort sortData = new BinarySort();
            int[] _sortedData = sortData.BubbleSortData(_testData);
            int[] _expectedData = { 0, 5, 10, 23, 44, 67, 77 };
            Assert.AreEqual(_expectedData, _sortedData);
        }

        //[TestCase(true,0,6)]
        //[TestCase(false, 6, 6)]
        [TestCase(true, 0, 0)]
        [TestCase(true, 0, 1)]
        public void TestSearching(bool expectedResult, int _min,int _max)
        {
            //int[] _testData = { 10, 0, 67, 44, 23, 5, 77 };
            int[] _testData = { 5 };
            //int[] _testData = { 5,10 };
            BinarySort sortData = new BinarySort();
            int[] _sortedData = sortData.BubbleSortData(_testData);
            int _searchValue = 5;
            //int _min = 0;
            //int _max = _testData.Length - 1;
            object actualResult = BinarySort.BinarySearch(_sortedData, _searchValue, _min, _max);
            Assert.AreEqual(expectedResult, actualResult);


        }

    }
}

