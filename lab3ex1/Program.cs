/*
 * Scrieti o functie care va calcula suma cifrelor unui numar
*/

using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Introduceti numarul pentru care doriti sa calculati suma cifrelor");
int numar = int.Parse(Console.ReadLine());
Console.WriteLine(SumaElementelor(numar));


static int SumaElementelor(int numar)
{
    int suma = 0;
    while (numar > 0)
    {
        int r = numar % 10;
        suma = suma + r;
        numar = numar / 10;
    }
    return suma;
}

