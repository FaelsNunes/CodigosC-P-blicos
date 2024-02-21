/*OPERADORES LÓGICOS
> - Maior
< - Menor
>= - Maior ou igual
<= - Menor ou igual
== - Igual
!= - Diferente
&& - E - parece que só um funciona &
|| - Ou - parece que só um funciona |
*/

// No C# sempre encerramos um bloco de instrução com ";"
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//DECLARAÇÃO DE VARIÁVEIS

	//Declaração de variável sem definir valores
	int spped;
	//Declaração de variável definindo valor
	int velocidade = 30;
	//Variável float
	float s = 3.40f;
	//Variável string
	string texto = "Olá Mundo!";
	//Variável boolean
	bool isLife = true;
	//Variável composta arrey
	//int [] intArray;
	int [] intArray = new int[] {1,2,3};
	//Variável composta lista -> Lista é mais versátil, pode ser alterada ou removida valores
	//List<int> intList;
	List<int> intList = new List<int>() {1,2,3,4,5};

	int n1,n2,n3;
	n1 = 10; n2 = 20; n3 = 30;

	//int num; //Se não atribuir nada na variável automaticamente no caso de inteiro ela recebe zero, é sempre bom adicionar
	byte n1=10; //Armazena entre 0 e 255, não aceita números negativos
	int num=-10; //Aceita números negativos
	char letra='c';
	float valor=5.3f;
	string nome="Bruno"; //Utiliza-se aspas duplas, e pode ter vários char dentro dele
	var aux=10; //Não especifica o tipo da variável, recebe o tipo na atribuição
	int num1=0,num2=0,res=0; //foi declarada 3 variáveis numa linha só

	//A tupla em C# é chamada de constante, os valores não podem ser alterados, abaixo exemplos
	const string canal="CFB Cursos";
	const double pi=3.1415;




	//Cria uma função chamada Movement com retorno void
	//Funções e métodos são a mesma coisa, depende da linguagem essa nomenclatura
	//void é um retorno vazio, pode ser usado para qualquer coisa
	void Movement()
	{
		intList.Add(3); //Adiciona o número 3 na lista
		intList.Remove(1); //Remove o número 1 da lista

		if(velocidade >= 0)
		{
			//Executa algo se o if fosse verdadeiro;
		}
		else
		{
			//Executa algo se o if fosse falso;
		}

		//Estrura de laço de repetição, pegando todos os casos de uma variável
		foreach (int intNumbers in intArray)
		{

		}

		//Estrutura de repetição utilizando a contagem de valores dentro do arrey
		for (int i = 0; i < intArray.Length; i++)
		{
			int currentNumber = intArray[i] //Cria uma variável local e ela recebe o valor do item do Arrey
		}

		//Estrutura de repetição utilizando a contagem de valores dentro da lista
		for (int i = 0; i < intList.count; i++)
		{

		}

	}


//se eu não declarar nada antes do método ou variável, subentende-se que ele é privado, para público, preciso adicionar public

public class EnemyWeapon
{
	public float damage;
	public float fireRate;

	public void Shoot()
	{

	}
}

//COMANDOS
Console.ReadLine(); //Colocado na última linha do programa, faz o programa aguardar um enter para encerrar
Console.Write(); //Prita algo no console
Console.Write("Olá\nTudo bem?"); //Printa algo na tela, quebrando o texto com o \n
Console.Write("\tOlá Tudo bem?"); //Printa algo na tela, dando um tabulação com o \t
Console.WriteLine() //Prita algo no console e faz a quebra da linha
Console.WriteLine(n1 + ", " + n2 + ", " + n3); //Printando algo concatenado
Console.WriteLine("n1={0}, n2={1}, n3={2}",n1,n2,n3); //Dentro da chave, coloca-se a posição das variáveis que estão no final
Console.WriteLine("Produto........:{0,15}",produto); //Printa um texto colocando o tamanho do espaçamento de 15 caracteres
Console.WriteLine("Val.Compra.....:{0,15:c}",valorCompra); //Printa um texto com 15 caracteres em formato de moeda
Console.WriteLine("Lucro..........:{0,15:p}",valorCompra); //Printa um texto com 15 caracteres em formato percentual

//RECEBENDO VALORES DO TECLADO

int v1,v2,soma;
string nome;

Console.Write("Digite seu nome: "); //Entrada de dados do teclado
nome=Console.ReadLine(); //Adiciona o texto inserido acima para a variável nome
Console.WriteLine("Nome digitado: {0}",nome);

Console.Write("Digite o primeiro valor: "); //Entrada de dados do teclado
v1=int.Parse(Console.ReadLine()); //Adiciona o valor digitado anteriormente na variável v1 convertendo para inteiro

Console.Write("Digite o segundo valor: "); //Entrada de dados do teclado
v2=Convert.ToInt32(Console.ReadLine()); //Adiciona o valor digitado anteriormente na variável v1 convertendo para inteiro

soma=v1+v2;
Console.WriteLine("A soma de {0} mais {1} é igual a {2}",v1,v2,soma);

