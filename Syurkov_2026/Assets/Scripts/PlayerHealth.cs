using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamageable
{
    [SerializeField] private Defeat _defeat;
    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private int _startHealth = 100;
    private int _health;
    private bool _isDead; // если флаг isDead = true - значит игрок умер, если false - то игрок жив

    private void Start()
    {
        _health = _startHealth;
        RefreshText();
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;

        if (_health < 0)
        {
            _health = 0;
        }

        if (_health == 0 && !_isDead)
        {
            _isDead = true;
            _defeat.Restart();
        }

        RefreshText();
    }

    private void RefreshText()
    {
        _healthText.text = _health + " HP";
    }
}
