﻿//Determinar si un número es par u impar//


Console.WriteLine("ingrese un numero:");

int number;
if (!Int32.TryParse(Console.ReadLine(), out number)) ;
{
    Console.Write("Error, numero invalido");
}
else
{
    if ((number % 2) == 0) ;
    {
        Console.WriteLine("Es par.");
    }
    else
    {
        Console.WriteLine("Es impar.");
    }

}



