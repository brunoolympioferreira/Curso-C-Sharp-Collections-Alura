using System.Collections.ObjectModel;

namespace _05_OrdenandoESomando;
class Curso
{
    private List<Aula> aulas;

    public IList<Aula> Aulas
    {
        get { return new ReadOnlyCollection<Aula>(aulas); }
    }

    private string nome;
    private string instrutor;

    public Curso(string nome, string instrutor)
    {
        this.nome = nome;
        this.instrutor = instrutor;
        aulas = new List<Aula>();
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string Instrutor
    {
        get { return instrutor; }
        set { instrutor = value; }
    }

    internal void Adiciona(Aula aula)
    {
        aulas.Add(aula);
    }

    public int TempoTotal
    {
        get
        {
            //int total = 0;
            //foreach (var aula in aulas)
            //{
            //    total += aula.Tempo;
            //}
            //return total;

            // Implementar via LINQ
            return aulas.Sum(aula => aula.Tempo);
        }
    }

    public override string ToString()
    {
        return $"Curso: {nome}, Tempo: {TempoTotal}, Aulas: {string.Join(",", aulas)}";
    }
}
