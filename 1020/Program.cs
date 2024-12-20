int ano, mes, dia, diasUsuario;

diasUsuario = int.Parse(Console.ReadLine());

ano = diasUsuario / 365;
diasUsuario = diasUsuario % 365;

mes = diasUsuario / 30;
diasUsuario = diasUsuario % 30;

dia = diasUsuario;

Console.WriteLine($"{ano} ano(s)\n{mes} mes(es)\n{dia} dia(s)");