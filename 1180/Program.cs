int posicao, menorValor, N;
string [] valores;

Console.WriteLine("Digite a quantidade de valores:");

//Validação da quantidade
if (!int.TryParse(Console.ReadLine(), out N))
{
    Console.WriteLine("Por favor, insira um número válido.");
    return;
}
if(N < 1 || N > 1000)
{
    Console.WriteLine("Fora do intervalo aceitável.");
    return;
}


Console.WriteLine("Valores:");
int [] X = new int[N];
valores = Console.ReadLine().Split(' ');

//Validação da sequência
if(valores.Length > N || valores.Length < N)
{
    Console.WriteLine("Quantidade de valores divergentes da quantidade estipulada.\nDigite estritamente a quantidade definida.");
    return;
}


for(int i = 0; i < N; i++)
{
    X[i] = int.Parse(valores[i]);
}

menorValor = X[0];
posicao = 0;

for(int i = 1; i < N; i++)
{
    if(menorValor > X[i])
    {
        menorValor = X[i];
        posicao = i;
    }
}
Console.WriteLine($"Menor valor: {menorValor}\nPosição: {posicao}");
