#define FACTORIAL
namespace Ex6
{
	internal class Program
	{
		public static int factorial(int num, ref int r)
		{

			if (num == 1)
			{
				return 1;
			}

			r = num * factorial(num - 1, ref r);

			return r;
		}

		public static bool facts(int num, ref int r)
		{
			if (num < 0 || num > 10)
			{
				return false;
			}
			else
			{
				factorial(num, ref r);
				return true;
			}
		}

		public static void drawStars(int quantity = 10)
		{

			for (int i = 0; i < quantity; i++)
			{
				Console.SetCursorPosition(new Random().Next(0, 21), new Random().Next(0, 11));
				Console.Write("*");
			}
			Console.SetCursorPosition(21, 11);
			Console.Write("#");
			Console.SetCursorPosition(0, 12);
		}

		static void Main(string[] args)
		{

#if FACTORIAL
			int r = 0;
			bool fact = facts(3, ref r);
			Console.WriteLine(fact);
#else
			drawStars(5);
			drawStars();
#endif

		}
	}
}