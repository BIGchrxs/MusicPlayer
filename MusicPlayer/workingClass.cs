using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;
using System.Media;

namespace MusicPlayer
{
    class workingClass
    {
        private SoundPlayer _Player;

        public workingClass()
            {
            _Player = new System.Media.SoundPlayer();
        }


        public void musicPlayer()
        {
            Console.WriteLine("Welcome to Music Player! \n" +
                "Please select a song:");

            var songs = AnsiConsole.Prompt(
              new SelectionPrompt<string>()
        .Title("What's your [blue]favorite Song[/]?")
        .PageSize(10)
        .AddChoices(new[] {
            "[red]Be quite and drive[/]", "[red]Animal I've become[/]" , "[red]TV off[/]",
        }));
            if (songs == "Be quite and drive")
            {
                musicPlayer("dft.wav");
            }
            else if (songs == "Animal I've become")
            {
                musicPlayer("tdg.wav");
            }
            else if (songs == "TV off")
            {
                musicPlayer("tvo.wav");
            }

        }
        //----------------------------------------------------------//

        public void musicPlayer(string song)
        {
            Console.WriteLine("Playing " + song);
            _Player.SoundLocation = Path.Combine(Directory.GetCurrentDirectory(), "Music", song);
            _Player.Load();
            _Player.PlaySync();

        }
        //----------------------------------------------------------//
    }
}
//==========================END OF FILE==========================================//