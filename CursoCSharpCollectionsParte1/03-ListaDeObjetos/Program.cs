﻿var aulaIntro = new Aula("Introdução às coleções", 20);
var aulaModelando = new Aula("Modelando a Classe Aula", 18);
var aulaSets = new Aula ("Trabalhando com Conjuntos", 16);

List<Aula> aulas = new List<Aula>();
aulas.Add(aulaIntro);
aulas.Add(aulaModelando);
aulas.Add(aulaSets);

Imprimir(aulas);

aulas.Sort();
Imprimir(aulas);

aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
Imprimir(aulas);

void Imprimir(List<Aula> aulas)
{
    Console.Clear();
    foreach (var aula in aulas)
    {
        Console.WriteLine(aula);
    }
}

class Aula : IComparable
{
    private string titulo;
    private int tempo;

    public Aula(string titulo, int tempo)
    {
        this.titulo = titulo;
        this.tempo = tempo;
    }

    public string Titulo { get => titulo; set => titulo = value; }
    public int Tempo { get => tempo; set => tempo = value; }

    public int CompareTo(object? obj)
    {
        Aula that = obj as Aula;
        return this.titulo.CompareTo(that.titulo);
    }

    public override string ToString()
    {
        return $"[título: {titulo}, tempo: {tempo} minutos]";
    }
}