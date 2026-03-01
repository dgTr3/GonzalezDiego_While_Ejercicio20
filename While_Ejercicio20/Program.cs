Console.WriteLine("Contar cuántos dígitos tiene un número.");
Console.WriteLine("Ingrese número");
int numero = int.Parse(Console.ReadLine());
int contador = 0;
while (numero > 0)
{
    numero /= 10;
    contador++;
}
Console.WriteLine("cantidad de digitos " + contador);