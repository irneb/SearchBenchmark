using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace SearchBenchmark
{
    public class CollectionTests
    {
        List<int> list = new List<int>();

        LinkedList<int> lList = new LinkedList<int>();

        Dictionary<int, int> dict = new Dictionary<int, int>();

        SortedDictionary<int, int> sDict = new SortedDictionary<int, int>();

        [Params(100, 1000, 10000, 100000, 1000000)]
        public int Length
        {
            get
            {
                return list.Count;
            }
            set
            {
                list.Clear();
                lList.Clear();
                dict.Clear();
                sDict.Clear();
                for (int i = 0; i < value; ++i)
                {
                    list.Add(i);
                    lList.AddLast(i);
                    dict[i] = i;
                    sDict[i] = i;
                }
            }
        }

        [Benchmark]
        public int ListFind()
        {
            var val = list[list.Count - 1];
            return list.FindIndex(item => item.Equals(val));
        }

        [Benchmark]
        public int ListForEachSearch()
        {
            var val = list[list.Count - 1];
            var idx = 0;
            foreach (var item in list)
            {
                if (val.Equals(item))
                {
                    return idx;
                }
                ++idx;
            }
            return -1;
        }

        [Benchmark]
        public int ListForSearch()
        {
            var val = list[list.Count - 1];
            for (int i = 0; i < Length; ++i)
            {
                if (val.Equals(list[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        [Benchmark]
        public int ListBinarySearch()
        {
            var val = list[list.Count - 1];
            //seq.Next;
            return list.BinarySearch(val);
        }

        [Benchmark]
        public LinkedListNode<int> LinkedListFind()
        {
            var val = lList.Last.Value;
            return lList.Find(val);
        }

        [Benchmark]
        public bool DictionaryContainsKey()
        {
            var val = list[Length - 1];
            return dict.ContainsKey(val);
        }

        [Benchmark]
        public bool DictionaryContainsValue()
        {
            var val = list[Length - 1];
            return dict.ContainsValue(val);
        }

        [Benchmark]
        public int DictionaryTryGetValue()
        {
            var val = list[Length - 1];
            int found;
            return dict.TryGetValue(val, out found) ? found : -1;
        }

        [Benchmark]
        public bool SortedDictionaryContainsKey()
        {
            var val = list[Length - 1];
            return sDict.ContainsKey(val);
        }

        [Benchmark]
        public bool SortedDictionaryContainsValue()
        {
            var val = list[Length - 1];
            return sDict.ContainsValue(val);
        }

        [Benchmark]
        public int SortedDictionaryTryGetValue()
        {
            var val = list[Length - 1];
            int found;
            return sDict.TryGetValue(val, out found) ? found : -1;
        }
    }
}