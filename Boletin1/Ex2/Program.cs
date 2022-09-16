// See https://aka.ms/new-console-template for more information

//#define FRASE


String? frase1 = "";
String? frase2 = "";

Console.WriteLine("Primera frase:");
frase1 = Console.ReadLine();
Console.WriteLine("Segunda frase:");
frase2 = Console.ReadLine();

#if FRASE

Console.WriteLine("\"{0}\" \\{1}\\ ", frase1, frase2);

#else

Console.WriteLine("{0} \t {1} \n{0} \n{1}", frase1, frase2);

#endif