Double DivideByZeroException(double numero1, double numero2)
{
    if (numero2 != 0)
    {
        Double resultado = numero1 / numero2;
        Console.WriteLine($"si a {numero1} lo divido en {numero2}, me da: {resultado}");
        return resultado;
    }
    else
    {
        Console.WriteLine("No se puede dividir por cero.");
        return double.NaN;
    }
}
double numeroResultado = DivideByZeroException(10, 4);
Console.WriteLine($"El resultado de la división es :{numeroResultado}");

//Cambios clave:
//Se valida numero2 antes de dividir para evitar la excepción.
//Se imprime mensaje de error cuando numero2 es 0.
//La función devuelve double.NaN en caso de error, que es una forma estándar de indicar que la operación no es válida.
//El bloque if que estaba fuera de la función lo moví dentro para mayor coherencia.