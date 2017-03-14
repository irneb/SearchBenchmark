``` ini

BenchmarkDotNet=v0.10.3.0, OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i7-5930K CPU 3.50GHz, ProcessorCount=12
Frequency=3417972 Hz, Resolution=292.5712 ns, Timer=TSC
  [Host]     : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.81.0
  DefaultJob : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.81.0


```
 |                        Method |  Length |               Mean |         StdDev |
 |------------------------------ |-------- |------------------- |--------------- |
 |                      **ListFind** |     **100** |        **210.8728 ns** |      **0.2828 ns** |
 |             ListForEachSearch |     100 |        263.5013 ns |      0.6537 ns |
 |                 ListForSearch |     100 |        132.0602 ns |      3.1448 ns |
 |              ListBinarySearch |     100 |         29.5608 ns |      0.0235 ns |
 |                LinkedListFind |     100 |        253.4067 ns |      2.2634 ns |
 |         DictionaryContainsKey |     100 |         10.8739 ns |      0.0174 ns |
 |       DictionaryContainsValue |     100 |        401.3303 ns |      0.1154 ns |
 |         DictionaryTryGetValue |     100 |         13.4186 ns |      0.0104 ns |
 |   SortedDictionaryContainsKey |     100 |         51.1954 ns |      0.0582 ns |
 | SortedDictionaryContainsValue |     100 |      1,564.6841 ns |      1.9752 ns |
 |   SortedDictionaryTryGetValue |     100 |         51.6454 ns |      0.0913 ns |
 |                      **ListFind** |    **1000** |      **1,926.5068 ns** |      **3.6660 ns** |
 |             ListForEachSearch |    1000 |      2,402.0682 ns |      1.3194 ns |
 |                 ListForSearch |    1000 |      1,269.8392 ns |     15.5053 ns |
 |              ListBinarySearch |    1000 |         36.2189 ns |      0.0286 ns |
 |                LinkedListFind |    1000 |      2,415.2781 ns |      5.7607 ns |
 |         DictionaryContainsKey |    1000 |         10.8713 ns |      0.0125 ns |
 |       DictionaryContainsValue |    1000 |      3,840.8775 ns |      2.5489 ns |
 |         DictionaryTryGetValue |    1000 |         13.4448 ns |      0.0199 ns |
 |   SortedDictionaryContainsKey |    1000 |        101.6691 ns |      0.0553 ns |
 | SortedDictionaryContainsValue |    1000 |     15,773.1005 ns |     17.8597 ns |
 |   SortedDictionaryTryGetValue |    1000 |        102.0352 ns |      0.1102 ns |
 |                      **ListFind** |   **10000** |     **19,156.8934 ns** |      **8.6780 ns** |
 |             ListForEachSearch |   10000 |     23,925.7998 ns |      7.8927 ns |
 |                 ListForSearch |   10000 |     12,064.5665 ns |    276.3725 ns |
 |              ListBinarySearch |   10000 |         44.6416 ns |      0.0549 ns |
 |                LinkedListFind |   10000 |     24,400.1280 ns |     23.9741 ns |
 |         DictionaryContainsKey |   10000 |         10.8717 ns |      0.0049 ns |
 |       DictionaryContainsValue |   10000 |     38,497.8015 ns |     12.0532 ns |
 |         DictionaryTryGetValue |   10000 |         13.3727 ns |      0.0182 ns |
 |   SortedDictionaryContainsKey |   10000 |        123.9992 ns |      0.5270 ns |
 | SortedDictionaryContainsValue |   10000 |    170,634.9806 ns |    165.3908 ns |
 |   SortedDictionaryTryGetValue |   10000 |        125.1158 ns |      1.7314 ns |
 |                      **ListFind** |  **100000** |    **192,384.2266 ns** |    **278.4124 ns** |
 |             ListForEachSearch |  100000 |    239,289.7963 ns |    115.2376 ns |
 |                 ListForSearch |  100000 |    107,086.0887 ns |    306.9392 ns |
 |              ListBinarySearch |  100000 |         51.5410 ns |      0.7844 ns |
 |                LinkedListFind |  100000 |    250,084.8588 ns |  4,401.0654 ns |
 |         DictionaryContainsKey |  100000 |         10.8875 ns |      0.0101 ns |
 |       DictionaryContainsValue |  100000 |    385,293.9692 ns |    286.8841 ns |
 |         DictionaryTryGetValue |  100000 |         13.4074 ns |      0.0036 ns |
 |   SortedDictionaryContainsKey |  100000 |        152.7852 ns |      0.6526 ns |
 | SortedDictionaryContainsValue |  100000 |  1,705,311.7587 ns |  8,666.0117 ns |
 |   SortedDictionaryTryGetValue |  100000 |        152.0239 ns |      0.0484 ns |
 |                      **ListFind** | **1000000** |  **2,079,932.8314 ns** | **31,990.4845 ns** |
 |             ListForEachSearch | 1000000 |  2,386,364.9104 ns |    253.9154 ns |
 |                 ListForSearch | 1000000 |  1,068,988.2407 ns |  1,576.1544 ns |
 |              ListBinarySearch | 1000000 |         57.3881 ns |      0.0421 ns |
 |                LinkedListFind | 1000000 |  4,461,480.2765 ns |  1,592.8922 ns |
 |         DictionaryContainsKey | 1000000 |         10.8584 ns |      0.0025 ns |
 |       DictionaryContainsValue | 1000000 |  3,887,899.9984 ns |  1,120.7314 ns |
 |         DictionaryTryGetValue | 1000000 |         13.4597 ns |      0.0020 ns |
 |   SortedDictionaryContainsKey | 1000000 |        179.3557 ns |      0.4993 ns |
 | SortedDictionaryContainsValue | 1000000 | 25,406,147.1839 ns | 43,220.3619 ns |
 |   SortedDictionaryTryGetValue | 1000000 |        178.4695 ns |      0.3371 ns |
