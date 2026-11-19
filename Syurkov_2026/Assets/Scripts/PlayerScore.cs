using TMPro;
using UnityEngine;
public class PlayerScore : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    private int _score = 0;
    private int _totalCoins = 0;

    private void Start()
    {
        _totalCoins = FindObjectsByType<CoinPickup>().Length;
        RefreshText();
    }

    public void AddScore()
    {
        _score++;
        
        if (_score == _totalCoins) 
        {
            _scoreText.text = "Победа!";
        }
        else 
        {
            RefreshText();
        }


    }

    private void RefreshText()
    {
        _scoreText.text = "Счет: " + _score;

    }

}
