string[][] familias = new string[3][];
//Declarando um array denteado(jagged array)
familias[0] = new string[] { "Fred", "Wilma", "Pedrita" };
familias[1] = new string[] { "Homer", "Marge", "Lisa", "Bart", "Maggie" };
familias[2] = new string[] { "Florinda", "Kiko" };

foreach (var familia in familias)
{
    Console.WriteLine(string.Join(",", familia));
}
