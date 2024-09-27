using BagManeger;
using System.Collections.Generic;

Dictionary<item, string> desc = new Dictionary<item, string>
{
            {new Potion(), "A spray-type wound medicine. It restores the HP of one Pokémon by 20 points."},
            {new Superpotion(), "A spray-type wound medicine. It restores the HP of one Pokémon by 50 points."},
            {new Revive(), "A medicine that revives a fainted Pokémon, restoring HP by half the maximum amount."},
            {new Parlyzeheal(), "A spray-type medicine. It heals one Pokémon from paralysis."},
            {new Antidote(), "A spray-type medicine. It heals one Pokémon from a poisoning."}
};

List<item> itens = new List<item>();


while(true)
{
Console.Clear();
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

switch (option)
{
    case 1:
        break;
    case 2:
        menuItens();
        break;
    case 3:
        return;
}
}

void menuItens()
{
    while (true) { 
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

    if (option == itens.Count)
    {
        adicionarItem();
    } else if (option == itens.Count+1)
    {
        break;
    } else
    {

    }
    }
}

void adicionarItem() 
{
    while (true) { 
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

        int i = 0;
        foreach (var pair in desc)
        {
            Console.WriteLine($"{(option == i ? sel : "  ")}{pair.Key.name} -> {pair.Value}");
            i++;
        }

        Console.WriteLine($"{(option == desc.Count ? sel : "  ")}Sair");

        key = Console.ReadKey(true);

        switch (key.Key)
        {
            case ConsoleKey.DownArrow:
                option = (option == desc.Count ? option : option + 1);
                break;

            case ConsoleKey.UpArrow:
                option = (option == 0 ? option : option - 1);
                break;

            case ConsoleKey.Enter:
                selecionado = true;
                break;
        }
    }
    if (option == desc.Count)
    {
        break;
    } else
    {
            int quant = selectQuant();
            if (quant > 0)
            {
                var enu = desc.GetEnumerator();
                for (int i = 0; i <= option; i++)
                    enu.MoveNext();
                item esp = enu.Current.Key;
                esp.quant = quant;

                int pos = -1;
                for(int i = 0; i < itens.Count; i++)
                {
                    if (itens[i].name == esp.name)
                    {
                        pos = i;
                    }
                }

                if(pos < 0)
                {
                    itens.Add(esp.DeepCopy());
         
                }
                else
                {
                    itens[pos].quant += esp.quant;
                }
            }
        break;
    }
    }
}

int selectQuant()
{
    while(true)
    {
        Console.Clear();
        Console.WriteLine("\nUse up e down e > para navegar e \u001b[32mEnter/Return\u001b[0m para selecionar");

        ConsoleKeyInfo key;
        int option = 0;
        bool exit = false;
        bool selecionado = false;
        (int left, int top) = Console.GetCursorPosition();
        string sel = "> ";

        Console.CursorVisible = false;

        while (!selecionado)
        {
            Console.SetCursorPosition(left, top);

            Console.WriteLine($"  Quantidade {option}");
            Console.Write($"{(exit == true ? sel : "  ")}Cancelar");

            key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.DownArrow:
                    option = (option == 0 ? option : option - 1);
                    break;

                case ConsoleKey.UpArrow:
                    option++;
                    break;

                case ConsoleKey.Enter:
                    selecionado = true;
                    break;
                case ConsoleKey.RightArrow:
                    exit = true;
                    break;
            }
        }
        return option;
    }
}