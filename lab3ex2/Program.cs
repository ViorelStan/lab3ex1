/*
 * Scrieti o functie care va determina daca un numar este sau nu patrat perfect. Apelati-o si afisati rezultatul.
*/

using System.ComponentModel.Design;

Console.WriteLine("Introduceti numarul pe care doriti sa il verificam");
int numar = int.Parse(Console.ReadLine());

int numar2 = (int)Math.Sqrt(numar);
int numar3 = numar2 * numar2;

if (numar == numar3)
{
    Console.WriteLine("Numarul este patrat perfect");
}
else
{
    Console.WriteLine("Numarul nu este patrat perfect");
}