//Exercicio Entrada e Saída //

/*1) a)	Imprimir a mensagem: “É preciso fazer todos os algoritmos para aprender lógica*/

/*class Program
{
    static void Main()
    {
        Console.WriteLine("É preciso fazer todos os algoritmos para aprender lógica");
    }
}*/



/*2)Criar um algoritmo que imprima o produto dos números 20 e 40.*/

/*class Program
{
    static void Main()

    {   //Calculo do produto//

        int p = 20 * 40;

        //Saída do codigo//
        Console.WriteLine("O produto de 20 e 40 é: " + p);
    }
}
*/

/*3)Criar um algoritmo que imprima a média aritmética dos números 5, 9 e 7.*/

/*class Program
{
    static void Main()
    {   
        //Entrada das variaveis dos números fornecidos//    
        int N1 = 5, N2 = 9, N3 = 7;

        //Calculo da media aritmetica//
        float m = (N1 + N2 + N3) / 3.0f;

        //Saída do código//
        Console.WriteLine("A média de {0}, {1} e {2} é: {3:F2}", N1, N2, N3, m);
    }
}*/



/*4)Ler dois números inteiros e imprimi-los.*/

/*class Program
{
    static void Main()
    {   
        //Variaveis//
        int n1, n2;

        //Leitura do 1 numero//
        Console.Write("Digite o primeiro número inteiro: ");
        n1 = int.Parse(Console.ReadLine());

        //Leitura do 2 numero//
        Console.Write("Digite o segundo número inteiro: ");
        n2 = int.Parse(Console.ReadLine());

        //Impressão do resultado//
        Console.WriteLine("Você digitou os números: {0} e {1}", n1, n2);
    }
}*/


/*5) Ler nome, endereço e telefone e imprimi-los.*/

/*class Program
{
    static void Main()
    {
        //variáveis
        string nome;
        string endereco;
        string telefone;

        // Lê o nome
        Console.Write("Digite o nome: ");
        nome = Console.ReadLine();

        // Lê o endereço
        Console.Write("Digite o endereço: ");
        endereco = Console.ReadLine();

        // Lê o telefone
        Console.Write("Digite o telefone: ");
        telefone = Console.ReadLine();

        // Imprime as informações
        Console.WriteLine("\nNome: " + nome);
        Console.WriteLine("Endereço: " + endereco);
        Console.WriteLine("Telefone: " + telefone);
    }
}*/

/*6)Ler dois números inteiros e imprimir a subtração. Antes do resultado, deverá aparecer a mensagem: o resultado da subtração é.*/


/*class Program
{
    static void Main()
    {
        // variáveis
        int numero1, numero2, resultado;

        // Pede o primeiro número
        Console.Write("Digite o primeiro número inteiro: ");
        numero1 = int.Parse(Console.ReadLine());

        // Pede o segundo número
        Console.Write("Digite o segundo número inteiro: ");
        numero2 = int.Parse(Console.ReadLine());

        // Calculo da subtração
        resultado = numero1 - numero2;

        //O resultado
        Console.WriteLine("O resultado da subtração é: " + resultado);
    }
}*/


/*7) Ler um número real e imprimir a quinta parte deste número.*/

/*
class Program
{
    static void Main()
    {
        //variável
        double numero, quintaParte;

        // pede o número real
        Console.Write("Digite um número real: ");
        numero = double.Parse(Console.ReadLine());

        // calculo da quinta parte do número
        quintaParte = numero / 5;

        // resultado
        Console.WriteLine("A quinta parte de " + numero + " é: " + quintaParte);
    }
}*/


/*8)Entrar com dois números inteiros e imprimir a seguinte saída:*/

/*

class Program
{
    static void Main()
    {
        //o primeiro número inteiro
        Console.Write("Digite o primeiro número inteiro: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        //segundo número inteiro
        Console.Write("Digite o segundo número inteiro: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        // imprime os números fornecidos
        Console.WriteLine($"Você digitou o número {numero1} e o número {numero2}.");
    }
}*/



