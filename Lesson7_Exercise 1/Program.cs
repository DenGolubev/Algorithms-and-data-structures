using System;

namespace Lesson7_Exercise_1
{
	class Program
	{
		static Field field = new Field();
		public static int a = 3;
		public static int b = 3;
		static void Main(string[] args)
		{
			Console.WriteLine(string.Format("Колличество путей = {0}", field.myField(a, b)));
			Console.ReadKey();
		}
	}
}
