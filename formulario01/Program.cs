//Resposta exercício 2 - letra B

Console.WriteLine("Digite um número: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite outro número");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine("O resultado é " + (n1+ n2));


//Resposta do exercício 3 - letra D

List<string> nomes = new List<string>();
nomes.Add("Jorge");
nomes.Add("Mario");
nomes.Add("Paula");
nomes.Remove("Mario");
nomes[0] = "Pedro";
nomes.Add("Maria");
nomes.RemoveAt(2);
Console.WriteLine(nomes[0]);
Console.WriteLine(nomes[1]);


//Resposta do exercício 4 - C

//Console.WriteLine("Digite o ano em que você nasceu: ");
int idade = 2024 - int.Parse(Console.ReadLine());

Console.WriteLine("Sua idade é de " + idade + " anos");


//Resposta do exercício 5 - Letra C

string nome = "Pedro";



//Resposta do exercício 6 - letra C
int capacidadeTanque = 100;
while (capacidadeTanque > 0)
{
    Console.WriteLine("Quantidade de água restante: " + capacidadeTanque + "litros");
    capacidadeTanque -=  3;
}

//Resposta do exercício 7
string[] listaDeCompras = { "Pão", "Leite", "Ovos", "Queijo", "Café" };
string terceiroItem = listaDeCompras[2];
Console.WriteLine("O terceiro item da lista de compras é: " + terceiroItem);

//Resposta do exercício 8
bool logado = true;

//Resposta do exercício 9 - Letra A
string nome = "Eduardo";
string sobrenome = "da Silva";
string nome_completo = nome + " " + sobrenome;
Console.WriteLine(nome_completo);

//Resposta do exercício 10 
int a = 15;
int b = 5;
int resultado = 0;

while(a > 0)
{
    a -= b;
    resultado++;
}

Console.WriteLine("o resultado é: " + resultado);