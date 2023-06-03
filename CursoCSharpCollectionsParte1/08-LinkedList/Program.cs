List<string> frutas = new()
{
    "abacate", "banana", "caqui", "damasco", "figo"
};

foreach (var fruta in frutas)
{
    Console.WriteLine(fruta);
}

Console.Clear();

// Apresentando LISTA LIGADA (LINKED LIST):
LinkedList<string> dias = new();

var d4 = dias.AddFirst("Quarta");
Console.WriteLine("d4.value: " + d4.Value);

var d2 = dias.AddBefore(d4, "Segunda");

var d3 = dias.AddAfter(d2, "Terça");

var d6 = dias.AddAfter(d4, "Sexta");

var d7 = dias.AddAfter(d6, "Sabado");

var d5 = dias.AddBefore(d6, "Quinta");

var d1 = dias.AddBefore(d2, "Domingo");

foreach (var dia in dias)
{
    Console.WriteLine(dia);
}
