using UnityEngine;

public class CoinPickup : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {

        PlayerScore score = other.GetComponent<PlayerScore>();

        if (score != null )
        {
            score.AddScore();
            Destroy(gameObject);
        }
    }


}
