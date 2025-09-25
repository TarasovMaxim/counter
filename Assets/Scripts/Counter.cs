using System;
using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _delay = 0.5f;
    [SerializeField] private CounterInput _counterInput;
    public event Action CounterChanged;
    private int _counter = 0;
    private Coroutine _counterCoroutine;
    private bool _isRunning = false;

    public int CounterValue => _counter;

    private void Work()
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

    private void OnEnable()
    {
        _counterInput.ButtonPressed += Work;
    }   

    private void OnDisable()
    {
        _counterInput.ButtonPressed -= Work;
    }

    private IEnumerator CountUp()
    {
        WaitForSeconds waitForSecond = new WaitForSeconds(_delay);

        while (enabled)
        {
            _counter++;
            CounterChanged?.Invoke();
            yield return waitForSecond;
        }
    }
}