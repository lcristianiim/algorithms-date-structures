using System;

namespace BinarySearch
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] a = new int[100];
			for (int i = 0; i < 100; i++) {
				a [i] = i;
			}

			Console.WriteLine(rank (77, a));
		}

		/// <summary>
		/// Cautare binara implementare nerecursiva
		/// </summary>
		/// <param name="key">Cheia care se cauta</param>
		/// <param name="a">Vectorul in care se cauta</param>
		/// <returns>Pozitia pe care apare cheia in vector sau -1 daca cheia nu e in vector</returns>
		public static int rank(int key, int[] a)
		{
			int lo, hi, mid;
			lo = 0;
			hi = a.Length - 1;
			while (lo <= hi)
			{
				mid = lo + (hi - lo) / 2;
				if (key < a[mid])
					hi = mid - 1;
				else if (key > a[mid])
					lo = mid + 1;
				else
					return mid;
			}
			return -1;
		}
	}
}
