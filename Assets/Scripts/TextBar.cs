using UnityEngine;

public class TextBar : MonoBehaviour
{
    private TMPro.TextMeshProUGUI _text;

    private void Awake()
    {
        _text = GetComponent<TMPro.TextMeshProUGUI>();
    }
    
    public void OnTextChanged(float current, float max)
    {
        _text.text = $"{current}/{max}";
    }

    public void SetText(float max)
    {
        _text.text = $"{max}/{max}";
    }
}
