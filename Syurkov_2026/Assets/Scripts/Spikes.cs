using UnityEngine;

public class Spikes : MonoBehaviour
{
    [SerializeField] private int _damage = 25;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<IDamageable>(out var target))
        {
            target.TakeDamage(_damage);
        }
    }
}
