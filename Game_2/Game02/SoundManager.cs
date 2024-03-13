using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Game02
{
    public class SoundManager
    {
        private static SoundPlayer player;

        // Khởi tạo player và chơi nhạc
        public static void Play(string filePath)
        {
            if (player != null)
            {
                player.Stop();
                player.Dispose();
            }

            player = new SoundPlayer(filePath);
            player.PlayLooping(); // Phát nhạc lặp lại
        }

        // Dừng nhạc
        public static void Stop()
        {
            player?.Stop();
        }

    }
}
