using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace ParallelSearch
{
	public static class ParallelSearch
	{
		public static int PIndexOf (this IList self, object val)
		{
			int found = -1;
			Parallel.For (0, self.Count, 
				delegate (int index, ParallelLoopState state) {
					if (val.Equals (self[index])) {
						state.Stop ();
                        found = index;
					}
				});
			return found;
		}
		
		public static int PIndexOf<T> (this IList<T> self, T val)
		{
			int found = -1;
			Parallel.For (0, self.Count, 
				delegate (int index, ParallelLoopState state) {
					if (val.Equals (self[index])) {
						state.Stop ();
                        found = index;
					}
				});
			return found;
		}
		
		public static int PIndexOf<T> (this T[] self, T val)
		{
			int found = -1;
			Parallel.For (0, self.Length, 
				delegate (int index, ParallelLoopState state) {
					if (val.Equals (self[index])) {
						state.Stop ();
                        found = index;
					}
				});
			return found;
		}
	}
}
