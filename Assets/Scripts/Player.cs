using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Attacker _attacker;
    [SerializeField] private Healer _healer;
    [SerializeField] private SliderBar _sliderBar;
    [SerializeField] private SmoothSliderBar _smoothSliderBar;
    [SerializeField] private TextBar _textBar;
    [SerializeField] private float _maxHealth;
    
    private Health _health;

    private void Awake()
    {
        _health = new Health(_maxHealth);
        _textBar.SetText(_maxHealth);
    }

    private void OnEnable()
    {
        _attacker.Attacked += _health.TakeDamage;
        _healer.Healed += _health.Heal;
        _health.Changed += UpdateUI;
    }
    
    private void OnDisable()
    {
        _attacker.Attacked -= _health.TakeDamage;
        _healer.Healed -= _health.Heal;
        _health.Changed -= UpdateUI;
    }

    private void UpdateUI()
    {
        _sliderBar.OnValueChanged(_health.CurrentHealth, _health.MaxHealth);
        _smoothSliderBar.OnSmoothValueChanged(_health.CurrentHealth, _health.MaxHealth);
        _textBar.OnTextChanged(_health.CurrentHealth, _health.MaxHealth);
    }
}
