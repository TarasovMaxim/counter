using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _delay = 0.5f;
    private int _counter = 0;
    private Coroutine _counterCoroutine;
    private bool _isRunning = false;
    private int _startCountCommand = 0;

    public int CounterValue => _counter;

    private void Update()
    {
        if (Input.GetMouseButtonDown(_startCountCommand))
        {
            if (_isRunning && _counterCoroutine != null)
            {
                StopCoroutine(_counterCoroutine);
            }
            else
            {
                _counterCoroutine = StartCoroutine(CountUp());
            }

            _isRunning = !_isRunning;
        }
    }

    private IEnumerator CountUp()
    {
        WaitForSeconds waitForSecond = new WaitForSeconds(_delay);

        while (enabled)
        {
            _counter++;
            yield return waitForSecond;
        }
    }
}