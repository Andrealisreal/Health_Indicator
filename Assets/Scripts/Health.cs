using System;

public class Health
{
    public event Action Changed;
    
    public Health(float currentHealth)
    {
        CurrentHealth = currentHealth;
        MaxHealth = currentHealth;
    }
    
    public float CurrentHealth { get; private set; }

    public float MaxHealth { get; }

    public void Heal(float amount)
    {
        if (CurrentHealth + amount > MaxHealth)
        {
            CurrentHealth = MaxHealth;
            
            return;
        }
        
        CurrentHealth += amount;
        Changed?.Invoke();
    }

    public void TakeDamage(float amount)
    {
        if (CurrentHealth - amount < 0)
        {
            CurrentHealth = 0;
            
            return;
        }
        
        CurrentHealth -= amount;
        Changed?.Invoke();
    }
}
