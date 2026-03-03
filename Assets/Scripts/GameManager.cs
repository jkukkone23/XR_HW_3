using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score = 0;
    public int maxScore = 10;  // kun t‰h‰n p‰‰st‰‰n, peli loppuu
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText; // Canvasilla n‰kyv‰ Game Over -teksti

    private void Awake()
    {
        instance = this;
        gameOverText.gameObject.SetActive(false); // piilota aluksi
        UpdateScoreUI();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreUI();

        if (score >= maxScore)
        {
            EndGame();
        }
    }

    private void UpdateScoreUI()
    {
        if(scoreText != null)
            scoreText.text = "Score: " + score;
    }

    private void EndGame()
    {
    Debug.Log("Game Over!");

    if (gameOverText != null)
    {
        scoreText.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(true);
    }

    Time.timeScale = 0; // pys‰ytt‰‰ pelin ajon
    }
}