double nota1 = 0;
double nota2 = 0;
double nota3 = 0;
double nota4 = 0;
double media = 0;
string nome = "";
string aluno = "";

Console.WriteLine($"Olá, como você se chama?");
nome = Console.ReadLine();
Console.WriteLine(" ");

Console.WriteLine($"{nome} você poderia me dizer também como se chama este aluno?");
aluno = Console.ReadLine();
Console.WriteLine(" ");

Console.WriteLine("Digite a primeira nota deste aluno");
nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" ");

Console.WriteLine("Digite a segunda nota deste aluno");
nota2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" ");

Console.WriteLine("Digite a terceira nota deste aluno");
nota3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" ");

Console.WriteLine("Digite a Quarta nota deste aluno");
nota4 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" ");

media = (nota1 + nota2 + nota3 + nota4)/4;

if (media > 7)
{
    Console.WriteLine("============================================================");
    Console.WriteLine($"{nome}, a média do(a) {aluno} foi de {media} e ele(a) foi aprovado(a)!");
    Console.WriteLine("============================================================");
}
else
{
    Console.WriteLine("============================================================");
    Console.WriteLine($"{nome} a média do(a) {aluno} foi de {media} e ele foi reprovad(a)!");
    Console.WriteLine("============================================================");
}







