using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUSTOM_CounterChecker : MonoBehaviour
{
    [SerializeField] UP_Counter counter = null;

    [SerializeField] float value = 0f;

    [SerializeField] UP_NoArgsUnityEvent IsValueEqual = new UP_NoArgsUnityEvent();

    public void UP_CheckValueLessOrEqual ()
    {
        if (counter.Counter <= value)
        { IsValueEqual.Invoke();}
    }

    public void UP_CheckValueGreaterOrEqual ()
    {
        if (counter.Counter >= value)
        { IsValueEqual.Invoke();}
    }

    public void UP_CheckValueEqual ()
    {
        if (counter.Counter == value)
        { IsValueEqual.Invoke();}
    }

    public void UP_CheckValueNotEqual ()
    {
        if (counter.Counter != value)
        { IsValueEqual.Invoke();}
    }
    
}
