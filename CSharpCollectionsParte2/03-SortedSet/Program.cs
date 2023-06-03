//Conjunto de alunos:
ISet<string> alunos = new SortedSet<string>(new ComparadorMinusculo()) 
{
    "Vanessa Tonini",
    "Ana Losnak",
    "Rafael Nercessian",
    "Priscila Stuani"
};

alunos.Add("Rafael Rollo");
alunos.Add("Fabio Gushiken");
alunos.Add("Fabio Gushiken");
alunos.Add("FABIO GUSHIKEN");

foreach (var aluno in alunos)
{
    Console.WriteLine(aluno);
}

//este conjunto é subconjunto do outro? IssubsetOf
ISet<string> outroConjunto = new HashSet<string>();
alunos.IsSubsetOf(outroConjunto);

//este conjunto é superconjunto do outro? IsSupersetOf
alunos.IsSupersetOf(outroConjunto);

//os conjuntos contem os mesmos elementos? SetEquals
alunos.SetEquals(outroConjunto);

class ComparadorMinusculo : IComparer<string>
{
    public int Compare(string? x, string? y)
    {
        return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
    }
}





