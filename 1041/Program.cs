using System.Globalization;

string [] coordenadas = Console.ReadLine().Split(' ');

float X = float.Parse(coordenadas[0],CultureInfo.InvariantCulture);
float Y = float.Parse(coordenadas[1],CultureInfo.InvariantCulture);

if(X == 0 && Y == 0)
{
    Console.WriteLine("Origem");
}
else if(X == 0 && Y != 0)
{
    Console.WriteLine("Eixo Y");
}
else if(X != 0 && Y == 0)
{
    Console.WriteLine("Eixo X");
}
else if(X > 0 && Y > 0)
{
    Console.WriteLine("Q1");
}
else if(X < 0 && Y > 0)
{
    Console.WriteLine("Q2");
}
else if(X < 0 && Y < 0)
{
    Console.WriteLine("Q3");
}
else
{
    Console.WriteLine("Q4");
}