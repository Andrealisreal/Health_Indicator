using UnityEngine;

public abstract class HealthView : MonoBehaviour
{
    private Health _health;

    private void OnDisable()
    {
        _health.Changed -= OnValueChanged;
    }
    
    public void Initialize(Health health)
    {
        if (_health != null)
            _health.Changed -= OnValueChanged;

        _health = health;
        _health.Changed += OnValueChanged;
        OnValueChanged(_health.Current, _health.Max);
    }

    protected abstract void OnValueChanged(float current, float max);
}
