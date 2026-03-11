using static System.Console;

//Declaração de um dicionario
Dictionary<string, int> pessoas = new Dictionary<string, int>()
{
    {"João", 20},
    {"Maria", 30},
    {"Pedro", 40}
};
//Adicionando dados ao dicionário 
pessoas.Add("Clodoaldo", 54);
WriteLine($"Tamanho = {pessoas.Count()}");
WriteLine(pessoas["Clodoaldo"]);
WriteLine($"Tamanho = {pessoas.Count()}");
pessoas.Remove("Clodoaldo");
WriteLine($"Tamanho = {pessoas.Count()}");

