using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private Slider _healthBarOne;
        [SerializeField] private Slider _healthBarTwo;
        [SerializeField] private Button _attack;
        [SerializeField] private Button _heal;
        [SerializeField] private TextMesh _healthValue;
        
        [SerializeField] private float _damage = 10f;
        [SerializeField] private float _currentHealth = 100f;
        [SerializeField] private float _amountHealth = 20f;
        
        private Health _health;

        private void Awake()
        {
            _health = new Health(_currentHealth);
        }

        private void OnEnable()
        {
            _attack.onClick.AddListener(() => { _health.TakeDamage(_damage); });
            _heal.onClick.AddListener(() => { _health.Heal(_amountHealth); });
        }

        private void OnDisable()
        {
            _attack.onClick.RemoveListener(() => { _health.TakeDamage(_damage); });
            _heal.onClick.RemoveListener(() => { _health.Heal(_amountHealth); });
        }
    }
}
