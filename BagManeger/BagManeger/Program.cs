using BagManeger;
using System.Collections.Generic;
using System.Media;

Dictionary<item, string> desc = new Dictionary<item, string>
{
            {new Potion(), "A spray-type wound medicine. It restores the HP of one Pokémon by 20 points."},
            {new Superpotion(), "A spray-type wound medicine. It restores the HP of one Pokémon by 50 points."},
            {new Revive(), "A medicine that revives a fainted Pokémon, restoring HP by half the maximum amount."},
            {new Parlyzeheal(), "A spray-type medicine. It heals one Pokémon from paralysis."},
            {new Antidote(), "A spray-type medicine. It heals one Pokémon from a poisoning."}
};

List<item> itens = new List<item>();
List<Pokemon> pokemons = new List<Pokemon>();
pokemons.Add(new Pokemon("Pika", "Pikachu", "Eletrico", 10, 0, 30, false, false));

SoundPlayer player = new SoundPlayer("C:\\Users\\GATEWAY\\source\\repos\\BagManeger\\BagManeger\\media\\plink.wav");


while (true)
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
                player.Play();
                break;

        case ConsoleKey.UpArrow:
            option = (option == 1 ? option : option - 1);
                player.Play();
                break;

        case ConsoleKey.Enter:
            selecionado = true;
                player.Play();
                break;
    }
}

switch (option)
{
    case 1:
            menuPokemons();
        break;
    case 2:
        menuItens();
        break;
    case 3:
        return;
}
}

void menuPokemons()
{
    while (true)
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

            for (int i = 0; i < pokemons.Count; i++)
            {
                Console.WriteLine($"  {pokemons[i]}");
            }
            Console.WriteLine($"{(option == 0 ? sel : "  ")}Adicionar");
            Console.WriteLine($"{(option == 1 ? sel : "  ")}Remover");
            Console.WriteLine($"{(option == 2 ? sel : "  ")}Sair");

            key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.DownArrow:
                    option = (option == 2 ? option : option + 1);
                    break;

                case ConsoleKey.UpArrow:
                    option = (option == 0 ? option : option - 1);
                    break;

                case ConsoleKey.Enter:
                    selecionado = true;
                    player.Play();
                    break;
            }
        }

        if (option == 0)
        {
            adicionarPokemon();
        }
        else if (option == 1)
        {
            removerPokemon();
        } else if (option == 2)
        {
            break;
        }
    }
}

void adicionarPokemon() {
    Console.Clear();
    Console.Write("Digite o nome: ");
    string name = Console.ReadLine();
    Console.Clear();
    Console.Write("Digite a especie: ");
    string especie = Console.ReadLine();
    Console.Clear();
    Console.Write("Digite o tipo: ");
    string tipo = Console.ReadLine();
    Console.Clear();
    Console.Write("Selecione o nivel: ");
    int nivel = selectQuantPoke();
    Console.Clear();
    Console.Write("Selecione o HP Atual: ");
    int hp = selectQuantPoke();
    Console.Clear();
    Console.Write("Selecione o HP Maximo: ");
    int hpmax = selectQuantPoke();
    Console.Clear();
    Console.Write("Envenenado:");
    bool envenenado = falseOrTrue();
    Console.Clear();
    Console.Write("Paralisado:");
    bool paralisado = falseOrTrue();

    pokemons.Add(new Pokemon(name, especie, tipo, nivel, hp, hpmax, paralisado, envenenado));
}

void removerPokemon()
{
    while (true)
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

            for (int i = 0; i < pokemons.Count; i++)
            {
                Console.WriteLine($"{(option == i ? sel : "  ")}{pokemons[i]}");
            }
            Console.WriteLine($"{(option == pokemons.Count ? sel : "  ")}Sair");

            key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.DownArrow:
                    option = (option == pokemons.Count ? option : option + 1);
                    break;

                case ConsoleKey.UpArrow:
                    option = (option == 0 ? option : option - 1);
                    break;

                case ConsoleKey.Enter:
                    selecionado = true;
                    player.Play();
                    break;
            }
        }

        if (option == pokemons.Count)
        {
            break;
        }
        else
        {
            pokemons.RemoveAt(option);
            break;
        }
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
                    player.Play();
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
            usabilidadeItem(option);
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
                    player.Play();
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

void usabilidadeItem(int pos)
{
    Console.Clear();
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

        Console.WriteLine($"  {itens[pos]}");
        Console.WriteLine($"{(option == 1 ? sel : "  ")}Usar");
        Console.WriteLine($"{(option == 2 ? sel : "  ")}Largar");
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
                player.Play();
                break;
        }
    }
    switch (option)
    {
        case 1:
            usarItem(pos);
            break;
        case 2:
            int quant = selectQuantLimit(itens[pos].quant);
            if (quant < itens[pos].quant)
            {
                itens[pos].quant -= quant;
            }
            else
            {
                itens.RemoveAt(pos);
            }
            break;
        case 3:
            break;
    }
}

void usarItem(int pos) {
    while (true)
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

            for (int i = 0; i < pokemons.Count; i++)
            {
                Console.WriteLine($"{(option == i ? sel : "  ")}{pokemons[i]}");
            }
            Console.WriteLine($"{(option == pokemons.Count ? sel : "  ")}Cancelar");

            key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.DownArrow:
                    option = (option == pokemons.Count ? option : option + 1);
                    break;

                case ConsoleKey.UpArrow:
                    option = (option == 0 ? option : option - 1);
                    break;

                case ConsoleKey.Enter:
                    selecionado = true;
                    player.Play();
                    break;
            }
        }

        if (option == pokemons.Count)
        {
            break;
        }
        else
        {
            bool usar = itens[pos].Usar(pokemons[option]);
            if (usar)
            {
                if (itens[pos].name == "Potion")
                {
                    SoundPlayer play = new SoundPlayer(Potion.audio);
                    play.Play();
                }
                    
                if (itens[pos].quant == 1)
                {
                    itens.RemoveAt(pos);
                }
                else
                {
                    itens[pos].quant -= 1;
                }
            } 
            break;
        }
    }
}

int selectQuantLimit(int limit)
{
    while (true)
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

            Console.Write($"  Quantidade {option} ");
            Console.Write($"{(exit == true ? sel : "  ")}Cancelar");

            key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.DownArrow:
                    option = (option == 0 ? option : option - 1);
                    break;

                case ConsoleKey.UpArrow:
                    option = (option == limit ? option : option + 1); ;
                    break;

                case ConsoleKey.Enter:
                    selecionado = true;
                    player.Play();
                    break;
                case ConsoleKey.RightArrow:
                    exit = true;
                    break;
                case ConsoleKey.LeftArrow:
                    exit = false;
                    break;
            }
        }
        return option;
    }
}
int selectQuant()
{
    Console.Clear();
    while(true)
    { 
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

            Console.Write($"  Quantidade {option} ");
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
                    player.Play();
                    break;
                case ConsoleKey.RightArrow:
                    exit = true;
                    break;
                case ConsoleKey.LeftArrow:
                    exit = false;
                    break;
            }
        }
        return option;
    }
}

int selectQuantPoke()
{
    while (true)
    {
        ConsoleKeyInfo key;
        int option = 1;
        bool exit = false;
        bool selecionado = false;
        (int left, int top) = Console.GetCursorPosition();
        string sel = "> ";

        Console.CursorVisible = false;

        while (!selecionado)
        {
            Console.SetCursorPosition(left, top);

            Console.Write($"{option}");

            key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.DownArrow:
                    option = (option == 1 ? option : option - 1);
                    break;

                case ConsoleKey.UpArrow:
                    option++;
                    break;

                case ConsoleKey.Enter:
                    selecionado = true;
                    player.Play();
                    break;
            }
        }
        return option;
    }
}

bool falseOrTrue()
{
    while (true)
    {
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

            Console.Write($" {(option == 1 ? "SIM" : "NÃO")}");

            key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.DownArrow:
                    option = (option == 0 ? option : option - 1);
                    break;

                case ConsoleKey.UpArrow:
                    option = (option == 1 ? option : option + 1); ;
                    break;

                case ConsoleKey.Enter:
                    selecionado = true;
                    player.Play();
                    break;
            }
        }
        switch (option)
        {
            case 0:
                return false;
            case 1:
                return true;
        }
    }
}
