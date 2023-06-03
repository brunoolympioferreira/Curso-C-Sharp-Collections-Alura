using _07_SetNoModelo;

Curso csharpColecoes = new("C# Colecoes", "Marcelo Oliveira");
csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
csharpColecoes.Adiciona(new Aula("Criando uma aula", 20));
csharpColecoes.Adiciona(new Aula("Modelando com colecoes", 24));

Aluno a1 = new("Vanessa Tonini", 34672);
Aluno a2 = new("Ana Losnak", 5617);
Aluno a3 = new("Rafael Nercessian", 17465);
//Matricular alunos no curso
csharpColecoes.Matricula(a1);
csharpColecoes.Matricula(a2);
csharpColecoes.Matricula(a3);
//Imprimindo alunos matriculados
Console.WriteLine("Imprimindo os alunos matriculados");
foreach (var aluno in csharpColecoes.Alunos)
{
    Console.WriteLine(aluno);
}

Console.WriteLine($"O aluno a1 {a1.NumeroMatricula} está matriculado?");
Console.WriteLine(csharpColecoes.EstaMatriculado(a1));

Aluno tonini = new("Vanessa Tonini", 34672);
Console.WriteLine("Tonini está matriculada? " + csharpColecoes.EstaMatriculado(tonini));

//mas a1 == a Tonini?
Console.WriteLine("a1 == a tonini?");
Console.WriteLine(a1 == tonini);

Console.WriteLine("a1 é equals a Tonini?");
Console.WriteLine(a1.Equals(tonini));
//Sao diferentes! Precisamos então implementar Equals()

//limpando o console
Console.Clear();
Console.WriteLine("Quem é o aluno com matrícula 5617?");
Aluno aluno5617 = csharpColecoes.BuscaMatriculado(5617);
Console.WriteLine("aluno5617:" + aluno5617);

Console.WriteLine("Quem é o aluno 5618?");
Console.WriteLine(csharpColecoes.BuscaMatriculado(5618));

Aluno fabio = new Aluno("Fabio", 5617);
//csharpColecoes.Matricula(fabio);
csharpColecoes.SubstituiAluno(fabio);
Console.WriteLine("Quem é o aluno 5617 agora?");
Console.WriteLine(csharpColecoes.BuscaMatriculado(5617));

