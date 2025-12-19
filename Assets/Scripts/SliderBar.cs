using UnityEngine;
using UnityEngine.UI;

public class SliderBar : MonoBehaviour
{
    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }
    
    public void OnValueChanged(float current, float max)
    {
        _slider.value = current / max;
    }
}
