using System;
using System.IO;
using System.Media;
using System.Reflection;

public class SoundManager
{
    private static SoundManager instance;
    private SoundPlayer player;
    private bool isPlaying = false;

    // Tên tệp âm thanh
    private string audioFileName = "Chill.wav";

    // Private constructor để ngăn việc khởi tạo từ bên ngoài
    private SoundManager()
    {
        // Lấy đường dẫn thư mục của ứng dụng
        string directoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        // Kết hợp đường dẫn của thư mục với tên tệp âm thanh
        string filePath = Path.Combine(directoryPath, "Resources", audioFileName);

        // Kiểm tra xem tệp âm thanh có tồn tại không
        if (File.Exists(filePath))
        {
            // Khởi tạo SoundPlayer với đường dẫn tệp âm thanh
            player = new SoundPlayer(filePath);
        }
        else
        {
            throw new FileNotFoundException($"File {audioFileName} not found in the Resources directory.");
        }
    }

    // Phương thức để lấy instance của SoundManager (singleton pattern)
    public static SoundManager GetInstance()
    {
        if (instance == null)
        {
            instance = new SoundManager();
        }
        return instance;
    }

    // Phương thức để phát âm thanh
    public void Play()
    {
        player.PlayLooping();
        isPlaying = true;
    }

    // Phương thức để tạm dừng âm thanh
    public void Pause()
    {
        player.Stop();
        isPlaying = false;
    }

    // Phương thức để dừng âm thanh
    public void Stop()
    {
        player.Stop();
        isPlaying = false;
    }

    // Phương thức để kiểm tra trạng thái phát của âm thanh
    public bool IsPlaying()
    {
        return isPlaying;
    }

    // Phương thức để bật/tắt âm thanh
    public void ToggleSound()
    {
        if (IsPlaying())
        {
            Pause();
        }
        else
        {
            Play();
        }
    }
}
