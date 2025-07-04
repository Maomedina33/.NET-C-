int edad = 18;

Console.WriteLine("Introduce tu edad");
edad = Convert.ToInt32(Console.ReadLine());

if (edad >= 18){
    Console.WriteLine("Eres mayor de edad");
    Console.WriteLine("ya puedes votar");
}
else{
    Console.WriteLine("Eres menor de edad");
    Console.WriteLine("no puedes votar");
}
