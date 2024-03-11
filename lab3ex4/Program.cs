/*
 * Scrieti un program care va inversa elementele unui vector
 * 1. Lungimea vectorului va fi citita de la tastatura
 * 2. Inversarea elementelor va fi facuta in functia Main(fara o functie dedicata)
 * 3. Afisarea vectorului se va face printr-o functie de afisare dedicata
*/

Console.WriteLine("Introduceti lungimea vectorului");
int lungime = int.Parse(Console.ReadLine());
var vector = CitireVector(lungime);

int[] CitireVector(int n)
{
    int[] vector = new int[n];
    for (int i = 0; i < vector.Length; i++)
    {
        Console.WriteLine("Introduceti elementul " + i);
        vector[i] = int.Parse(Console.ReadLine());
    }
    return vector;
}