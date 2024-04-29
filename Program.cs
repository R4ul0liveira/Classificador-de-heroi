using System;

// menssagem para inserir o nome do Heroi
Console.WriteLine("defina o nome do Heroi");

// recebe o nome do heroi
string name = Console.ReadLine();

//exibe uma menssagem para receber a experiencia do heroi
Console.WriteLine("defina uma quantidade de experiencia para seu heroi");

//recebe os dados de experiencia do heroi
int experiencia = Convert.ToInt32(Console.ReadLine());

// verifica qual o nivel do heroi baseado na quantidade de experiencia inserida e mostra no console
if (experiencia < 1000)
{
    Console.WriteLine("O Heroi de nome: "+ name +" está no Nivel: Ferro");
}
else if (experiencia > 1001 && experiencia < 2000)
{
    Console.WriteLine("O Heroi de nome: " + name +" está no Nivel: bronze");
}
else if (experiencia > 2001 && experiencia < 5000)
{
    Console.WriteLine("O Heroi de nome: " + name +" está no Nivel: prata");
}
else if (experiencia > 5001 && experiencia < 7000)
{
    Console.WriteLine("O Heroi de nome: " + name +" está no Nivel: ouro");
}
else if (experiencia > 7001 && experiencia < 8000)
{
    Console.WriteLine("O Heroi de nome: " + name +" está no Nivel: platina");
}
else if (experiencia > 8001 && experiencia < 9000)
{
    Console.WriteLine("O Heroi de nome: " + name +" está no Nivel: ascendente");
}
else if (experiencia > 9001 && experiencia < 10000)
{
    Console.WriteLine("O Heroi de nome: " + name +" está no Nivel: imortal");
}
else if (experiencia > 10001)
{
    Console.WriteLine("O Heroi de nome: " + name +" está no Nivel: Radiante");
};
Console.Write("fim");