using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamageable
{
    [SerializeField] private Defeat _defeat;

    public void TakeDamage(int damage)
    {
        _defeat.Restart();
    }
}
