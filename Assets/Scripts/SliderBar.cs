using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SliderBar : HealthView
{
    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }
    
    protected override void OnValueChanged(float current, float max)
    {
        _slider.value = current / max;
    }
}
