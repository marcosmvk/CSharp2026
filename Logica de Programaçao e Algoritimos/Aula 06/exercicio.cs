using static System.Console;
//Declaração de variaveis 
int a, b, c;
Write("Digite o valor A ");a = int.Parse(ReadLine());
Write("Digite o valor B ");b = int.Parse(ReadLine());
Write("Digite o valor C ");c = int.Parse(ReadLine());
bool pergunta1 = a == c;
bool pergunta2 = b != a;
bool pergunta3 = b > c;
bool pergunta4 = a <= c;
WriteLine($"O primeiro valor é igual ao terceiro valor? {pergunta1}");
WriteLine($"O segundo valor é diferente do perimeiro valor?{pergunta2}");
WriteLine($"O segundo valor é maior que o terceiro valor{pergunta3}");
WriteLine($"O primeiro valor é menor ou igual que o terceiro valo?{pergunta4}");
bool resultado1 = pergunta1 & pergunta2;
bool resultado2 = pergunta2 | pergunta4;
bool resultado3 = !pergunta1;
WriteLine($"Se a pergunta 1 e pergunta 3 são verdadeiras o resultado é: {resultado1}");
WriteLine($"Se a 2° pergunta e a 4° pergunta são verdadeiras o resultado é: {resultado2}");
WriteLine($"Se a negação da priemira pergunta é verdadeira: {resultado3}");





