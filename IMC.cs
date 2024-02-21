using System;

class imc
{
    static void Main()
    {
        double peso,altura,res_imc;

        Console.Write("Qual seu peso? (ex: 69,5) ");
        peso=double.Parse(Console.ReadLine()); //Adiciona o valor digitado anteriormente na variável peso convertendo para inteiro

        Console.Write("Qual sua altura? (ex: 1,75) ");
        altura=double.Parse(Console.ReadLine()); //Adiciona o valor digitado anteriormente na variável altura convertendo para inteiro

        res_imc = (peso/(altura*altura));

        Console.WriteLine();

        Console.Write("O seu IMC é {0}",res_imc);

        Console.ReadLine();
    }
}