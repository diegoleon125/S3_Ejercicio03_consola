Console.Write("Inserte edad: ");
int edad = int.Parse(Console.ReadLine());
Console.Write("Inserte adivinanzas acertadas: ");
int adiv = int.Parse(Console.ReadLine());
float mont=0f;
if (edad < 18) {
    if (adiv < 3)
    {
        mont = 50.00f;
    }
    else
    {
        mont = 80.00f;
    }
} else {
    if (adiv < 3)
    {
        mont = 30.00f;
    }
    else
    {
        mont = 50.00f;
    }
}
mont += 5*edad + 2*adiv;
Console.WriteLine("el premio es: " + mont);