using UnityEngine;

[RequireComponent(typeof(TMPro.TextMeshProUGUI))]
public class TextBar : HeartBar
{
    private TMPro.TextMeshProUGUI _text;

    private void Awake()
    {
        _text = GetComponent<TMPro.TextMeshProUGUI>();
    }
    
    protected override void OnValueChanged(float current, float max)
    {
        _text.text = $"{current}/{max}";
    }
}
