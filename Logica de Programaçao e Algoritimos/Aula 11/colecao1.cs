int [] numeros = new int [5];
string [] nomes = {"João", "Maria", "Pedro", "Ana", "Lucas"};

numeros [0] = 10;
numeros [1] = 10;
System.Console.WriteLine(numeros[1]);
numeros [2] = 0;
numeros [3] = 5;
numeros [4] = 7;
numeros [1] = 9;
System.Console.WriteLine(numeros[1]);
int tamanho = numeros.Length;
System.Console.WriteLine("O tamanho do vetor é: " + tamanho);
numeros.GetType();
