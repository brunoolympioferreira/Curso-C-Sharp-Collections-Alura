//declarando set de alunos
using System.Security.Cryptography;

ISet<string> alunos = new HashSet<string>();

// adicionando: vanessa, ana, rafael
alunos.Add("Vanessa Tonini");
alunos.Add("Ana Losnak");
alunos.Add("Rafael Necessian");


Console.WriteLine(string.Join(",", alunos));

// qual a diferença para uma lista?
alunos.Add("Priscila Stuani");
alunos.Add("Rafael Rollo");
alunos.Add("Fabio Gushiken");
Console.WriteLine(string.Join(",", alunos));

//e a ordem?

//removendo ana, add marcelo
alunos.Remove("Ana Losnak");
alunos.Add("Marcelo Oliveira");
Console.WriteLine(string.Join(",", alunos));

//add gishiken novamente
alunos.Add("Fabio Gushiken");
Console.WriteLine(string.Join(",", alunos));

//ordenando
List<string> alunosEmLista = new(alunos);
alunosEmLista.Sort();
Console.WriteLine(string.Join(",", alunosEmLista));


