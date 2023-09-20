using System;

class Program
{
    static void Main()
    {
        Console.Write("What is your grade percentage? ");
        double porcentajeCalificacion = Convert.ToDouble(Console.ReadLine());

        char calificacion;

        if (porcentajeCalificacion >= 90)
        {
            calificacion = 'A';
        }
        else if (porcentajeCalificacion >= 80)
        {
            calificacion = 'B';
        }
        else if (porcentajeCalificacion >= 70)
        {
            calificacion = 'C';
        }
        else if (porcentajeCalificacion >= 60)
        {
            calificacion = 'D';
        }
        else
        {
            calificacion = 'F';
        }

        Console.WriteLine("your grade is: " + calificacion);

        if (porcentajeCalificacion >= 70)
        {
            Console.WriteLine("¡Felicidades! Has aprobado el curso.");
        }
        else
        {
            Console.WriteLine("Ánimo, puedes intentarlo de nuevo la próxima vez.");
        }
    }
}