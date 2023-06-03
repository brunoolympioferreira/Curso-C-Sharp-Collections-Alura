using System.Collections.ObjectModel;

namespace _07_SetNoModelo;
class Curso
{
    private IDictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();

    private ISet<Aluno> alunos = new HashSet<Aluno>();
    public IList<Aluno> Alunos
    {
        get
        {
            return new ReadOnlyCollection<Aluno>(alunos.ToList());
        }
    }

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

    internal void Matricula(Aluno aluno)
    {
        alunos.Add(aluno);
        this.dicionarioAlunos.Add(aluno.NumeroMatricula, aluno);
    }

    public bool EstaMatriculado(Aluno aluno)
    {
        return alunos.Contains(aluno);
    }

    internal Aluno BuscaMatriculado(int numeroMatricula)
    {
        Aluno aluno = null;
        this.dicionarioAlunos.TryGetValue(numeroMatricula, out aluno);
        return aluno;
    }

    internal void SubstituiAluno(Aluno aluno)
    {
        dicionarioAlunos[aluno.NumeroMatricula] = aluno;
    }
}
