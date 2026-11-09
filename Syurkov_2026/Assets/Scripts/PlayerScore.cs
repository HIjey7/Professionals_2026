using TMPro;
using UnityEngine;
public class PlayerScore : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    private int score = 0;
    private int totalCoins = 0;

    void Start()
    {
        totalCoins = FindObjectsByType<CoinPickup>().Length;
        RefreshText();
    }

    public void AddScore()
    {
        score++;
        
        if (score == totalCoins) 
        {
            scoreText.text = $"Победа! Все монеты в количестве {totalCoins} собраны.";
        } else 
        {
            RefreshText();
        }


    }

    private void RefreshText()
    {
        scoreText.text = "Счет: " + score;

    }

}
