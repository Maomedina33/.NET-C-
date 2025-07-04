namespace Operaciones
{
  private class Calculadora
  {
    public string Suma(int numero1, int numero2)
    {
      int resultado = numero1 + numero2;
      return ResultadoOperacion(resultado);
    }
    public string Diferencia(int numero1, int numero2)
    {
      int resultado = numero1 - numero2;
      return ResultadoOperacion(resultado);
    }
    public string Multiply(int numero1, int numero2)
    {
      int resultado = numero1 * numero2;
      return ResultadoOperacion(resultado);
    }
    public string Division(int numero1, int numero2)
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
     private string ResultadoOperacion(int resultado)
    {
      return $"El resultado de la operacion es: {resultado}";
    }
  }   
}    



