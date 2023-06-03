
Queue<string> pedagio = new();

static void ImprimirFila(Queue<string> pedagio)
{
    Console.WriteLine("FILA:");

    foreach (var v in pedagio)
    {
        Console.WriteLine(v);
    }
}

Enfileirar(pedagio, "van");
Enfileirar(pedagio, "kombi");
Enfileirar(pedagio, "guincho");
Enfileirar(pedagio, "pickup");

Desenfileirar(pedagio);
Desenfileirar(pedagio);
Desenfileirar(pedagio);
Desenfileirar(pedagio);

static void Enfileirar(Queue<string> pedagio, string veiculo)
{
    Console.WriteLine($"Entrou na fila: {veiculo}");
    pedagio.Enqueue(veiculo);
    ImprimirFila(pedagio);
}

static void Desenfileirar(Queue<string> pedagio)
{
    if (pedagio.Any())
    {
        if (pedagio.Peek() == "guincho")
        {
            Console.WriteLine("guincho está fazendo o pagamento.");
        }
        string veiculo = pedagio.Dequeue();
        Console.WriteLine($"Saiu da fila: {veiculo}");
        ImprimirFila(pedagio);
    }
}