using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    // C# IEnumerator interface reference:
    // https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerator?view=netframework-4.8

    // C# IEnumerator interface reference:
    // https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerator?view=netframework-4.8

    class PeekingIterator
    {
        private readonly IEnumerator<int> _iterator;
        private bool _hasPeeked;
        private bool _hasNext;
        private int? _peekedElement;

        // iterators refers to the first element of the array.
        public PeekingIterator(IEnumerator<int> iterator)
        {
            this._iterator = iterator;
            // initialize any member here.
        }

        // Returns the next element in the iteration without advancing the iterator.
        public int Peek()
        {
            if (!_hasPeeked)
            {
                _hasNext = _iterator.MoveNext();
                _peekedElement = _iterator.Current;
                _hasPeeked = true;
            }

            return _peekedElement ?? 0;
        }

        // Returns the next element in the iteration and advances the iterator.
        public int Next()
        {
            if (!_hasPeeked)
            {
                _iterator.MoveNext();
                return _iterator.Current;
            }

            int result = _peekedElement ?? 0;
            _peekedElement = null;
            _hasPeeked = false;
            return result;
        }

        // Returns false if the iterator is refering to the end of the array of true otherwise.
        public bool HasNext()
        {
            return _hasNext;
        }
    }
}
