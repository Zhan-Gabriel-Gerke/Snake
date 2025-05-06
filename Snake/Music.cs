using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media; // for music
namespace Snake
{
        class Music
        {
            public static void PlayEatSound()
            {
                using (SoundPlayer player = new SoundPlayer(@"C:\Users\zange\source\repos\Snake\Snake\Sounds\eat.wav"))
                {
                    
                player.Play();
                }
            }

            public static void PlayGameOverSound()
            {
                using (SoundPlayer player = new SoundPlayer(@"C:\Users\zange\source\repos\Snake\Snake\Sounds\gameover.wav"))
                {
                    player.Play();
                }
            }
            public static void PlayStartSound()
            {
                using (SoundPlayer player = new SoundPlayer(@"C:\Users\zange\source\repos\Snake\Snake\Sounds\main.wav"))
                {
                    player.Play();
                }
            }
        }
}
