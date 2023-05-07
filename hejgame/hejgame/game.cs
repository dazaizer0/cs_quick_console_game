using hejgame;
using System;

int size = 5;

Thread reader = new(movement);
reader.Start();

while (true)
{

    game();
    Thread.Sleep(10);

    Console.Clear();
}

void game()
{

    game_manager();

    for (int y = -size; y < size; y++)
    {

        for (int x = -size; x < size; x++)
        {

            if(y == player.position_y &&  x == player.position_x)
            {

                write(player.mark, false);
            }
            else if(y == coin.position_y & x == coin.position_x)
            { 
                
                if(coin.is_active)
                {

                    write(coin.mark, false);
                }
                else
                {

                    write("*", false);
                }
            }
            else
            {

                write("*", false);
            }
        }

        write("", true);
    }
    Console.WriteLine("score: " + player.score);
}

void movement()
{

    while (true)
    {

        switch (Console.ReadKey(true).Key)
        {

            case ConsoleKey.W:
                player.position_y -= 1;
                break;
            case ConsoleKey.S:
                player.position_y += 1;
                break;
            case ConsoleKey.D:
                player.position_x += 1;
                break;
            case ConsoleKey.A:
                player.position_x -= 1;
                break;
        }
    }
}

void write(string text, bool line) 
{

    if (line) 
    {

        Console.WriteLine(" " + text);
    }
    else
    {

        Console.Write(" " + text);
    }
}

void game_manager()
{

    if(player.position_y == coin.position_y && player.position_x == coin.position_x && coin.is_active) 
    {

        player.score += 1;
        coin.is_active = false;
    }
}