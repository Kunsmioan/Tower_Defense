using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static bool GameIsOver;

    public GameObject gameOverUI;
    public GameObject completeLevelUI;

    void Start()
    {
        // Reset trạng thái của chính GameManager
        GameIsOver = false;

        // --- PHẦN BỔ SUNG QUAN TRỌNG ---
        // Reset lại trạng thái của các script khác tại đây

        // Ví dụ: Reset lại mạng sống của người chơi
        // Giả sử bạn có một biến static startLives trong PlayerStats
        if (FindObjectOfType<PlayerStats>() != null) // Kiểm tra để chắc chắn
        {
            PlayerStats.Lives = PlayerStats.startLives;
        }

        // Ví dụ: Reset lại số lượng kẻ địch
        // Điều này đảm bảo WaveSpawner bắt đầu đếm lại từ đầu
        if (FindObjectOfType<WaveSpawner>() != null)
        {
            WaveSpawner.EnemiesAlive = 0;
        }

        // Tắt tất cả các UI khi bắt đầu game
        gameOverUI.SetActive(false);
        completeLevelUI.SetActive(false);
    }

    void Update()
    {
        if (GameIsOver)
            return;

        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        GameIsOver = true;
        gameOverUI.SetActive(true);
    }

    public void WinLevel()
    {
        GameIsOver = true;
        if (completeLevelUI != null)
        {
            completeLevelUI.SetActive(true);
        }
        else
        {
            Debug.LogError("Chưa gán Complete Level UI trong Inspector của GameManager!");
        }
    }
}