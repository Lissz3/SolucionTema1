namespace ConsoleApp1
{
	internal class Program
	{

		public static void drawMenu(string[] options, int option, bool flag)
		{
			if (flag)
			{
				Console.Clear();
			}
			Console.WriteLine("Seleccione opción:");

			for (int i = 0; i < options.Length; i++)
			{
				if (i == option)
				{
					Console.BackgroundColor = ConsoleColor.DarkMagenta;
					Console.ForegroundColor = ConsoleColor.DarkBlue;
				}

				Console.WriteLine(options[i]);
				Console.BackgroundColor = ConsoleColor.Black;
				Console.ForegroundColor = ConsoleColor.DarkMagenta;
			}
		}

		public static void mainMenu()
		{
			int option = 0;
			int selected = -1;
			string[] options = { "1.- Tirar dado", "2.- Adivina el número", "3.- Quiniela", "4.- Jugar a todos", "5.- Salir" };
			Console.CursorVisible = false;

			Console.WriteLine("");


			drawMenu(options, option, true);

			do
			{
				ConsoleKeyInfo key = Console.ReadKey();
				switch (key.Key)
				{
					case ConsoleKey.DownArrow:
						option = option < options.Length - 1 ? option + 1 : option;
						break;

					case ConsoleKey.UpArrow:
						option = option > 0 ? option - 1 : option;
						break;

					case ConsoleKey.Enter:
						selected = option;
						break;

					case ConsoleKey.Escape:
						selected = options.Length - 1;
						break;
				}
				drawMenu(options, option, true);

				Console.WriteLine();

				switch (selected)
				{
					case 0:
						dice();
						if (selected == 3)
						{
							goto case 1;
						}
						option = 0;
						selected = -1;
						drawMenu(options, option, false);

						break;

					case 1:
						guess();
						if (selected == 3)
						{
							goto case 2;
						}
						option = 0;
						selected = -1;
						drawMenu(options, option, false);

						break;

					case 2:
						quiniela();
						option = 0;
						selected = -1;
						drawMenu(options, option, false);
						break;

					case 3:
						goto case 0;
						
				}

			} while (selected != options.Length - 1);

		}


		public static void dice()
		{

			int faces = 0;
			int userNum = 0;
			int[] consolenums = new int[10];
			int a = 0;

			Random random = new Random();

			while (faces < 1)
			{
				Console.WriteLine("Cuantas caras tiene el dado?");
				faces = Convert.ToInt32(Console.ReadLine());

				if (faces < 1)
				{
					Console.WriteLine("El numero tiene que ser mayor que 1.");
				}
			}

			do
			{
				Console.WriteLine("Qué número cree que saldrá?");
				userNum = Convert.ToInt32(Console.ReadLine());

				if (userNum < 1 || userNum > faces)
				{
					Console.WriteLine("El numero tiene que estar dentro del rango 1-{0}.", faces);
				}

			} while (userNum < 1 || userNum > faces);


			for (int i = 0; i < consolenums.Length; i++)
			{
				consolenums[i] = random.Next(1, userNum + 1);
				Console.WriteLine("¡Ha salido el {0}!", consolenums[i]);
				if (consolenums[i] == userNum)
				{
					a++;
				}
			}


			if (a != 0)
			{
				Console.WriteLine("¡Felicidades, has acertado {0} veces!", a);

			}
			else
			{
				Console.WriteLine("No has acertado ninguna vez. ¡Otra vez será!");
			}

		}
		public static void guess()
		{
			Random r = new Random();

			int num = r.Next(1, 101);

			int usernum = 0;

			int tries = 5;

			while (usernum != num && tries != 0)
			{
				Console.WriteLine("#Número de intentos: {0}#", tries);

				do
				{
					Console.WriteLine("Inserte un número entre 1-100: ");
					usernum = Convert.ToInt32(Console.ReadLine());
				} while (usernum < 1 || usernum > 100);


				if (usernum < num)
				{
					Console.WriteLine("El número que busca es mayor");
				}
				else if (usernum > num)
				{
					Console.WriteLine("El número que busca es menor");
				}

				tries--;
			}

			if (usernum == num)
			{
				Console.WriteLine("¡Felicidades, has acertado!");
			}
			else
			{
				Console.WriteLine("Se han agotado sus intentos. El número a adivinar era el {0}", num);
			}

		}

		public static string balanced()
		{
			Random r = new Random();

			int balanced = r.Next(1, 101);

			switch (balanced)
			{
				case int when (balanced > 60 && balanced < 86):
					return "X";

				case int when (balanced > 85):
					return "2";

				default:
					return "1";
			}

		}

		public static void quiniela()
		{
			int rep = 0;
			Console.WriteLine("#QUINIELA#");
			Console.Write("# ");
			for (int i = 0; i < 14; i++)
			{

				Console.Write(balanced() + " # ");
				rep++;
				if (rep == 3)
				{
					Console.WriteLine("");
					Console.Write("# ");
					rep = 0;
				}

			}

			Console.WriteLine("");

		}


		static void Main(string[] args)
		{
			mainMenu();
		}
	}
}