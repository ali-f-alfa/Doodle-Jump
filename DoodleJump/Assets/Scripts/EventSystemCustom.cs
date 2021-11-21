using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventSystemCustom : MonoBehaviour
{
    public UnityEvent OnUpdateScore;
    public UnityEvent OnEnd;

    void Awake()
    {
        OnUpdateScore = new UnityEvent();
        OnEnd = new UnityEvent();
    }
}
