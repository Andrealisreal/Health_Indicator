using System;
using UnityEngine;
using UnityEngine.UI;

public class Attacker : MonoBehaviour
{
    [SerializeField] private float _damage;
    
    public event Action<float> Attacked;
    
    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(Attack);
    }
    
    private void OnDisable()
    {
        _button.onClick.RemoveListener(Attack);
    }

    private void Attack()
    {
        Attacked?.Invoke(_damage);
    }
}
