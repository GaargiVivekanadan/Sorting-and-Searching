using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSamples
{
    public class BinarySort
    {
        public int[] BubbleSortData(int[] _inputArray)
        {
            int temp = 0;
            for(int _outerCount = 0; _outerCount < _inputArray.Length; _outerCount++)
            {
                for(int i=0; i< _inputArray.Length-1; i++)
                {
                    if(_inputArray[i] > _inputArray[i+1])
                    {
                        temp = _inputArray[i];
                        _inputArray[i] = _inputArray[i + 1];
                        _inputArray[i + 1] = temp;
                    }
                }
            }
            return _inputArray;
        }
    
        public static object BinarySearch(int[] _inputArray, int _searchValue, int _min, int _max)
        {
            if(_min>_max)
            {
                return "Not a valid scenario";
            }

            else
            {
                int _mid = (_min + _max) / 2;
                if(_searchValue == _inputArray[_mid])
                {
                    return ++_mid;
                }
                else if (_searchValue < _inputArray[_mid])
                {
                    return BinarySearch(_inputArray, _searchValue, _min, _mid);
                }
                else
                {
                    return BinarySearch(_inputArray, _searchValue, _mid+1, _max);
                }
            }
            
        }
    }
}
