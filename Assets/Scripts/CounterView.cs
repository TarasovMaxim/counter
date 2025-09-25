using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Counter _counter;

    void Update()
    {
        Debug.Log("Ñ÷¸ò÷èê: " + _counter.CounterValue);
        _text.text = _counter.CounterValue.ToString();
    }
}
