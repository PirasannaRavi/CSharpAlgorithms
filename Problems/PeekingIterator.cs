using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    // C# IEnumerator interface reference:
    // https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerator?view=netframework-4.8

    // C# IEnumerator interface reference:
    // https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerator?view=netframework-4.8

    public class PeekingIterator
    {
        private readonly IEnumerator<int> _iterator;
        private bool _hasNext;
        private int _previousElement;

        // iterators refers to the first element of the array.
        public PeekingIterator(IEnumerator<int> iterator)
        {
            this._iterator = iterator;
            this._previousElement = _iterator.Current;
            this._hasNext = this._iterator.MoveNext();
        }

        // Returns the next element in the iteration without advancing the iterator.
        public int Peek()
        {
            return _iterator.Current;
        }

        // Returns the next element in the iteration and advances the iterator.
        public int Next()
        {
            this._previousElement = _iterator.Current;
            this._hasNext = this._iterator.MoveNext();
            return _previousElement;
        }

        // Returns false if the iterator is refering to the end of the array of true otherwise.
        public bool HasNext()
        {
            return _hasNext;
        }
        public int Current()
        {
            return _previousElement;
        }
    }
}
