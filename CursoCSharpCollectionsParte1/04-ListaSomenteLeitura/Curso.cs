using System.Collections.ObjectModel;

namespace _04_ListaSomenteLeitura;
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
        this.aulas = new List<Aula>();
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
        this.aulas.Add(aula);
    }
}
