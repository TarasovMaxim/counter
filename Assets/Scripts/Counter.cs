using System.Collections;
using UnityEngine;
using TMPro; 

public class CounterController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text; 
    [SerializeField] private float _delay = 0.5f;

    private int _counter = 0;
    private Coroutine _counterCoroutine;
    private bool _isRunning = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            if (_isRunning)
            {
                StopCoroutine(_counterCoroutine);
                _isRunning = false;
            }
            else
            {
                _isRunning = true;
                _counterCoroutine = StartCoroutine(CountUp());
            }
        }
    }

    private IEnumerator CountUp()
    {
        while (_isRunning)
        {
            _counter++;
            Debug.Log("Ñ÷¸ò÷èê: " + _counter);

            if (_text != null)
                _text.text = _counter.ToString();

            yield return new WaitForSeconds(_delay);
        }
    }
}