namespace Operaciones
{
  public static class Calculadora
  {
    public static string Suma(int numero1, int numero2)
    {
      int resultado = numero1 + numero2;
      return ResultadoOperacion(resultado);
    }
    public static string Diferencia(int numero1, int numero2)
    {
      int resultado = numero1 - numero2;
      return ResultadoOperacion(resultado);
    }
    public static string Multiply(int numero1, int numero2)
    {
      int resultado = numero1 * numero2;
      return ResultadoOperacion(resultado);
    }
    public static string Division(int numero1, int numero2)
    {
      if (numero2 != 0)
      {
        int resultado = numero1 / numero2;
        return ResultadoOperacion(resultado);
      }
      else
      {
        return "Error: División por cero no permitida.";
      }
    }
     private static string ResultadoOperacion(int resultado)
    {
      return $"El resultado de la operacion es: {resultado}";
    }
  }   
}    



