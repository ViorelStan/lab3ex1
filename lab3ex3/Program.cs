/*
 * 
*/

using System.ComponentModel;

Console.WriteLine("Introduceti lungimea vectorului");
int lungime = int.Parse(Console.ReadLine());
var vector = CitireVector(lungime);

Console.WriteLine("Cel mai mare numar din vector este: " + MaxValoare(vector));
Console.WriteLine("Cel mai mic numar din vector este: " + MinValoare(vector));
Console.WriteLine("Numerele divizibile cu 3 sunt: " + Divizibil3(vector));


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
int MaxValoare(int[] vector)
{
    int max = vector[0];
    for (int i = 1; i < vector.Length; i++)
    { 
    if (vector[i] > max) 
        {
        max = vector[i];
        }
    }
    return max;
}
int MinValoare(int[] vector)
{
    int min = vector[0];
    for (int i = 1; i < vector.Length; i++)
    {
        if (vector[i] < min)
        {
            min = vector[i];
        }
    }
    return min;
}

//Nu am reusit sa afisez toate valorile din vector...nu mi-am dat seama cum(problema de la int la string, am modificat in tot ce mi-a venit in minte)
int[] Divizibil3(int[] vector)
{
    int[] divizibil = vector;
    for (int i = 1; i < vector.Length; i++)
    {
           if (vector[i] % 3 == 0)
        {
            divizibil = vector;
        }
       
    }
    return divizibil;
}