// Mais um programico para calcular a formula resolvente...

using System;
using System.Collections;

public class formularesol
{
    static int a, b, c;

    static double FR1(int a, int b, int c)
    {
        double valor_raiz = (b * b) - (4 * a * c);      // b2 - 4ac
        double raiz = Math.Sqrt(valor_raiz);        // Raiz(b2 - 4ac)
        double numerador = -b + raiz;               // -b + Raiz(b2 - 4ac)
        double resultado = numerador / (2 * a);     // -b + Raiz(b2 - 4ac) / (2*a)
        return resultado;
    }

    static double FR2(int a, int b, int c)
    {
        double valor_raiz = (b * b) - (4 * a * c);      // b2 - 4ac
        double raiz = Math.Sqrt(valor_raiz);        // Raiz(b2 - 4ac)
        double numerador = -b - raiz;               // -b - Raiz(b2 - 4ac)
        double resultado = numerador / (2 * a);     // -b - Raiz(b2 - 4ac) / (2*a)
        return resultado;
    }

    public static void Main()
    {

        Console.WriteLine("\n\t\tPROGRAMA PARA CALCULAR UMA RAÍZ QUADRADA\n\n");

        Console.WriteLine("\t-b+Raiz(b2 - 4ac)");
        Console.WriteLine("x=_______________________");
        Console.WriteLine("\t2*a");

        Console.WriteLine("\n\nIntroduza o valor de a ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduza o valor de b ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduza o valor de c ");
        c = int.Parse(Console.ReadLine());
        Console.WriteLine("\nO resultado e de {0:0.0000} e {1:0.0000}", FR1(a, b, c), FR2(a, b, c));
        Console.WriteLine("\n\n\t\tProduced by wiLL , Mess with the best .. Die Like the Rest");
        Console.ReadLine();
    }
}