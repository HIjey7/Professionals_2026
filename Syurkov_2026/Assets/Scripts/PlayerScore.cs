using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    private int score = 0;

    public void AddScore()
    {
        score++;
        Debug.Log("Счет игрока: " + score);
    }

}
