using hejgame;
using System;


refresh_objects_positions();

settings.apply_settings();
Thread game_player = new(movement);
game_player.Start();

while (player.score != 5)
{

    game();
    Thread.Sleep(10);

    Console.Clear();
}
Console.Clear();
Console.WriteLine("You Win!");

void game()
{

    game_manager();

    for (int y = -settings.map_size; y < settings.map_size; y++)
    {

        for (int x = -settings.map_size; x < settings.map_size; x++)
        {

            if(OnTrigger(y, x, player.position_y, player.position_x))
            {

                write(player.mark, false);
            }
            else if(OnTrigger(y, x, coin.position_y, coin.position_x))
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
    write("score:" + player.score, true);
    write("collect 5 points ", true);
    write("inventory: " + player.inventory, true);
}

void movement()
{

    while (true)
    {

        switch (Console.ReadKey(true).Key)
        {

            case ConsoleKey.W:
                refresh_objects_positions();
                player.position_y -= 1;
                break;
            case ConsoleKey.S:
                refresh_objects_positions();
                player.position_y += 1;
                break;
            case ConsoleKey.D:
                refresh_objects_positions();
                player.position_x += 1;
                break;
            case ConsoleKey.A:
                refresh_objects_positions();
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

bool OnTrigger(int y1, int x1, int y2, int x2) 
{

    if (y1 == y2 && x1 == x2)
    {

        return true;
    }
    else
    {

        return false;
    }
}

void refresh_objects_positions()
{

    @object.position_y = player.position_y; @object.position_x = player.position_x;
    @object.position_y1 = @object.position_y; @object.position_x1 = @object.position_x;
    @object.position_y2 = @object.position_y1; @object.position_x2 = @object.position_x1;
    @object.position_y3 = @object.position_y2; @object.position_x3 = @object.position_x2;
    @object.position_y4 = @object.position_y3; @object.position_x4 = @object.position_x3;
}

void game_manager()
{

    if(OnTrigger(player.position_y, player.position_x, coin.position_y, coin.position_x) && coin.is_active) 
    {

        player.score += 1;
        coin.is_active = false;
    }

    if (!coin.is_active)
    {

        coin.position_refresh();
    }
}