using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Counter _counter;

    private void OutputText()
    {
        Debug.Log("Ñ÷¸ò÷èê: " + _counter.CounterValue);
        _text.text = _counter.CounterValue.ToString();
    }

    private void OnEnable()
    {
        _counter.CounterChanged += OutputText;
    }

    private void OnDisable()
    {
        _counter.CounterChanged -= OutputText;
    }
}
