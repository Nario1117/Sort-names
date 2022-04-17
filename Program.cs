// See https://aka.ms/new-console-template for more information
Console.Title = "Pocet deti";
Console.WriteLine("Kolik je dětí ve třídě");

int pocetDeti = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Napiš jména/o");

string[] deti = new string[pocetDeti];

for (int i = 0; i < pocetDeti; i++)
{
     deti[i] = Console.ReadLine();
}



Console.WriteLine("Tady jsou všechny jména postupne abecedně");

Array.Sort(deti);

for (int i = 0; (i) < deti.Length; i++)
{
    Console.WriteLine(deti[i]);
}

Console.ReadKey();