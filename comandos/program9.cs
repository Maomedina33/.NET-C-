using Operaciones;

Operaciones.Calculadora calculadora = new Operaciones.Calculadora();

string resultadoSuma = calculadora.Suma(5,3);
Console.WriteLine($"La suma de 5 y 3 es: {resultadoSuma}");

string resultadoDiferencia = calculadora.ResultadoOperacion(5);
