using WMPLib;

namespace Game02
{
    public class SoundManager
    {
        private WindowsMediaPlayer player;
        private int volume = 50; // Giá trị mặc định cho âm lượng

        // Khởi tạo player và đặt đường dẫn tệp âm thanh
        public SoundManager(string filePath)
        {
            player = new WindowsMediaPlayer();
            player.URL = filePath;
        }

        // Phát nhạc với chế độ lặp lại
        public void PlayLoop()
        {
            // Đặt chế độ lặp lại
            player.settings.setMode("loop", true);
            // Phát nhạc
            player.controls.play();
        }

        // Dừng nhạc
        public void Stop()
        {
            player.controls.stop();
        }

        // Đặt âm lượng
        public void SetVolume(int volume)
        {
            this.volume = volume;
            player.settings.volume = volume;
        }

        // Lấy âm lượng
        public int GetVolume()
        {
            return volume;
        }
    }
}
