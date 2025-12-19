using System;
using UnityEngine;
using UnityEngine.UI;

public class Healer : MonoBehaviour
{
    [SerializeField] private float _amount;
    
    public event Action<float> Healed;
    
    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(Heal);
    }
    
    private void OnDisable()
    {
        _button.onClick.RemoveListener(Heal);
    }

    private void Heal()
    {
        Healed?.Invoke(_amount);
    }
}
