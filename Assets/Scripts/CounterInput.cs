using System;
using UnityEngine;

public class CounterInput : MonoBehaviour
{
    private int _startCountCommand = 0;
    public event Action ButtonPressed;

    private void Update()
    {
        if (Input.GetMouseButtonDown(_startCountCommand))
        {
            ButtonPressed?.Invoke();
        }
    }
}
