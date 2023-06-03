using _05_OrdenandoESomando;

Curso csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");
csharpColecoes.Adiciona(new Aula("Trabalhando com listas", 21));
Imprimir(csharpColecoes.Aulas);

//adicionar 2 aulas
csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 19));
Imprimir(csharpColecoes.Aulas);

//ordenar a lista de aulas
List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);
//ordenar a copia
aulasCopiadas.Sort();
Imprimir(aulasCopiadas);

//totalizar o tempo do curso
Console.WriteLine(csharpColecoes.TempoTotal);

//imprimir detalhes do curso
Console.WriteLine(csharpColecoes);

void Imprimir(IList<Aula> aulas)
{
    Console.Clear();
    foreach (var aula in aulas)
    {
        Console.WriteLine(aula);
    }
}
