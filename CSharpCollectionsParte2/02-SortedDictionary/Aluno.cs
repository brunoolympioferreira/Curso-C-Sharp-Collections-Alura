using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SortedDictionary;
internal class Aluno
{
    private string nome;
    private string Nome
    {
        get { return nome; }
    }

    private int numeroMatricula;
    public int NumeroMatricula
    {
        get { return numeroMatricula; }
    }

    public Aluno(string nome, int numeroMatricula)
    {
        this.nome = nome;
        this.numeroMatricula = numeroMatricula;
    }

    public override string ToString()
    {
        return "[Aluno: " + this.nome + ", matricula: " + this.numeroMatricula + "]";
    }
}
