using System;

namespace Euclidscmmdc
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine(cmmdc(6, 9));
		}

		public static int cmmdc(int a, int b)
		{
			if (b == 0)
				return a;
			else
				return cmmdc(b, a % b);
		}
	}
}
