public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Addition.Add(1, 2));
        Console.WriteLine(Resta.Restar(3, 4));
        Console.WriteLine(Multiplicacion.Multiplicar(5, 6));
        Console.WriteLine(Division.Divide(7, 8));
    }
}


// Esta clase implementa la operación Resta
public class Resta
{
   public static int Restar(int a, int b)
   {
       return a - b;
   }
}

// Esta clase implementa la operación "suma"
public class Addition
{
   public static int Add(int a, int b)
   {
       return a + b;
   }
}

// Esta clase implementa la operación división
public class Division
{
   public static double Divide(int a, int b)
   {
       return (double)a / b;
   }
}

// Esta clase implementa la operación multiplicacion
public class Multiplicacion
{
   public static int Multiplicar(int a, int b)
   {
       return a * b;
   }
}
