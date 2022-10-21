// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


//Cast - Casting de Tipos de Dados

/*
Diferença entre a classe Convert e Parse

- A classe Convert consegue lidar com valores nulos
- o Parse não lida com valores nulo
*/

int a = Convert.ToInt32("5");//Convert -> Classe para cast de dados

Console.WriteLine(a);

int b = int.Parse("5");

Console.WriteLine(b);

//Cast para string

/*
- O método ToString esta presente em todas a classes do C Sharp pois é herdado da classe Object
*/

int z = 10;
string c = z.ToString();

Console.WriteLine(c);

//Cast implicito
/*
- Cast implicito é a conversão automática de diferentes tipos
- O cast implicito é possivel desde que o tamanho de um tipo seja comportado em outro
*/

int d = 15;
double e = d;

int f = int.MaxValue;
long g = f;


Console.WriteLine(d);
Console.WriteLine(g);

//Conversão segura de tipos

string h = "15-";
int.TryParse(h, out int i);//TryParse -> espera que possa ocorrer um erro durante a conversão

Console.WriteLine(i);
