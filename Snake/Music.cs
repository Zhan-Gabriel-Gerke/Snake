using System;
using System.Media;
using System.Threading.Tasks;

namespace Snake
{
    class Music
    {
        public static void PlayEatSound()
        {
            // Запуск воспроизведения звука в отдельном потоке
            Task.Run(() =>
            {
                using (SoundPlayer player = new SoundPlayer(@"C:\Users\zange\source\repos\Snake\Snake\Sounds\eat.wav"))
                {
                    player.Play();
                }
            });
        }

        public static void PlayGameOverSound()
        {
            Task.Run(() =>
            {
                using (SoundPlayer player = new SoundPlayer(@"C:\Users\zange\source\repos\Snake\Snake\Sounds\gameover.wav"))
                {
                    player.Play();
                }
            });
        }

        public static void PlayStartSound()
        {
            Task.Run(() =>
            {
                using (SoundPlayer player = new SoundPlayer(@"C:\Users\zange\source\repos\Snake\Snake\Sounds\main.wav"))
                {
                    player.Play();
                }
            });
        }
    }
}
