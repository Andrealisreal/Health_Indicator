using UnityEngine;
using UnityEngine.UI;

public class SmoothSliderBar : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;

    private Slider _slider;
    private float _targetValue;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _targetValue = _slider.maxValue;
    }

    private void LateUpdate()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _targetValue, _speed * Time.deltaTime);
    }

    public void OnSmoothValueChanged(float current, float max)
    {
        _targetValue = current / max;
    }
}