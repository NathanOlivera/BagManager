using BagManeger;

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Bem vindo ao gerenciador de mochila!");
Console.ResetColor();

Console.WriteLine("\nUse up e down para navegar e \u001b[32mEnter/Return\u001b[0m para selecionar");

ConsoleKeyInfo key;
int option = 1;
bool selecionado = false;
(int left, int top) = Console.GetCursorPosition();
string sel = "> ";

Console.CursorVisible = false;

while (!selecionado)
{
    Console.SetCursorPosition(left, top);

    Console.WriteLine($"{(option == 1 ? sel : "  ")}Pokémons");
    Console.WriteLine($"{(option == 2 ? sel : "  ")}Itens");
    Console.WriteLine($"{(option == 3 ? sel : "  ")}Sair");

    key = Console.ReadKey(true);

    switch (key.Key)
    {
        case ConsoleKey.DownArrow:
            option = (option == 3 ? option : option + 1);
            break;

        case ConsoleKey.UpArrow:
            option = (option == 1 ? option : option - 1);
            break;

        case ConsoleKey.Enter:
            selecionado = true;
            break;
    }
}

Dictionary<string, string> desc = new Dictionary<string, string>
{
            {"Potion", "A spray-type wound medicine. It restores the HP of one Pokémon by 20 points."},
            {"Super Potion", "A spray-type wound medicine. It restores the HP of one Pokémon by 50 points."}, 
            {"Revive", "A medicine that revives a fainted Pokémon, restoring HP by half the maximum amount."},
            {"Parlyze Heal", "A spray-type medicine. It heals one Pokémon from paralysis."},
            {"Antidote", "A spray-type medicine. It heals one Pokémon from a poisoning."}
}; 
List<item> itens = new List<item>();

switch (option)
{
    case 1:
        break;
    case 2:
        menuItens();
        break;
    case 3:
        break;
}


void menuItens()
{
    Console.Clear();
    Console.WriteLine("\nUse up e down para navegar e \u001b[32mEnter/Return\u001b[0m para selecionar");

    ConsoleKeyInfo key;
    int option = 0;
    bool selecionado = false;
    (int left, int top) = Console.GetCursorPosition();
    string sel = "> ";

    Console.CursorVisible = false;

    while (!selecionado)
    {
        Console.SetCursorPosition(left, top);

        for (int i = 0; i < itens.Count; i++)
        {
            Console.WriteLine($"{(option == i ? sel : "  ")}{itens[i]}");
        }
        Console.WriteLine($"{(option == itens.Count ? sel : "  ")}Adicionar");
        Console.WriteLine($"{(option == itens.Count+1 ? sel : "  ")}Sair");

        key = Console.ReadKey(true);

        switch (key.Key)
        {
            case ConsoleKey.DownArrow:
                option = (option == itens.Count+1 ? option : option + 1);
                break;

            case ConsoleKey.UpArrow:
                option = (option == 0 ? option : option - 1);
                break;

            case ConsoleKey.Enter:
                selecionado = true;
                break;
        }
    }
}