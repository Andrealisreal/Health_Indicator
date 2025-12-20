using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Attacker _attacker;
    [SerializeField] private Healer _healer;
    [SerializeField] private HealthView[] _heartBars;
    [SerializeField] private float _maxHealth;
    
    private Health _health;

    private void Awake()
    {
        _health = new Health(_maxHealth);
        
        foreach (var bar in _heartBars)
            bar.Initialize(_health);
    }

    private void OnEnable()
    {
        _attacker.Triggered += _health.TakeDamage;
        _healer.Triggered += _health.Heal;
    }
    
    private void OnDisable()
    {
        _attacker.Triggered -= _health.TakeDamage;
        _healer.Triggered -= _health.Heal;
    }
}
