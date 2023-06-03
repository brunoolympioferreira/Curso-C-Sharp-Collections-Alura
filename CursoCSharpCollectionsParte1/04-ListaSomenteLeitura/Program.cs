using _04_ListaSomenteLeitura;

Curso csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");
csharpColecoes.Adiciona(new Aula("Trabalhando com listas", 21));

Imprimir(csharpColecoes.Aulas);

void Imprimir(IList<Aula> aulas)
{
    Console.Clear();
    foreach (var aula in aulas)
    {
        Console.WriteLine(aula);
    }
}
