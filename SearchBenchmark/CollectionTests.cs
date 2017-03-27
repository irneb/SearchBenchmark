using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;
using ParallelSearch;

namespace SearchBenchmark
{
    [LegacyJitX86Job, LegacyJitX64Job, RyuJitX64Job]
    [AsciiDocExporter]
    [CsvExporter]
    [CsvMeasurementsExporter]
    [HtmlExporter]
    [MarkdownExporter]
    [PlainExporter]
    public class CollectionTests
    {
        public int LastValue { get { return array[Length - 1]; } }

        int[] array = new int[1];

        List<int> list = new List<int>();

        LinkedList<int> lList = new LinkedList<int>();

        Dictionary<int, int> dict = new Dictionary<int, int>();

        SortedDictionary<int, int> sDict = new SortedDictionary<int, int>();

        [Params(100, 1000, 10000, 100000, 1000000)]
        public int Length
        {
            get
            {
                return array.Length;
            }
            set
            {
                array = new int[value];
                list.Clear();
                lList.Clear();
                dict.Clear();
                sDict.Clear();
                for (int i = 0; i < value; ++i)
                {
                    array[i] = i;
                    list.Add(i);
                    lList.AddLast(i);
                    dict[i] = i;
                    sDict[i] = i;
                }
            }
        }

        [Benchmark]
        public int ArrayFind()
        {
            var val = LastValue;
            return Array.IndexOf<int>(array, val);
        }

        [Benchmark]
        public int ArrayParallelFind()
        {
            var val = LastValue;
            return array.PIndexOf<int>(val);
        }

        [Benchmark]
        public int ArrayBinarySearch()
        {
            var val = LastValue;
            return Array.BinarySearch<int>(array, val);
        }

        [Benchmark]
        public int ListFind()
        {
            var val = LastValue;
            return list.FindIndex(item => item.Equals(val));
        }

        [Benchmark]
        public int ListParallelFind()
        {
            var val = LastValue;
            return list.PIndexOf<int>(val);
        }

        [Benchmark]
        public int ListForEachSearch()
        {
            var val = LastValue;
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
            var val = LastValue;
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
            var val = LastValue;
            return list.BinarySearch(val);
        }

        [Benchmark]
        public LinkedListNode<int> LinkedListFind()
        {
            var val = LastValue;
            return lList.Find(val);
        }

        [Benchmark]
        public bool DictionaryContainsKey()
        {
            var val = LastValue;
            return dict.ContainsKey(val);
        }

        [Benchmark]
        public bool DictionaryContainsValue()
        {
            var val = LastValue;
            return dict.ContainsValue(val);
        }

        [Benchmark]
        public int DictionaryTryGetValue()
        {
            var val = LastValue;
            int found;
            return dict.TryGetValue(val, out found) ? found : -1;
        }

        [Benchmark]
        public bool SortedDictionaryContainsKey()
        {
            var val = LastValue;
            return sDict.ContainsKey(val);
        }

        [Benchmark]
        public bool SortedDictionaryContainsValue()
        {
            var val = LastValue;
            return sDict.ContainsValue(val);
        }

        [Benchmark]
        public int SortedDictionaryTryGetValue()
        {
            var val = LastValue;
            int found;
            return sDict.TryGetValue(val, out found) ? found : -1;
        }
    }
}