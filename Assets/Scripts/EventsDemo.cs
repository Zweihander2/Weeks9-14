using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventsDemo : MonoBehaviour
{
    public RectTransform banana;

    public UnityEvent TimerHasFinished;
    public float timerLength = 2;
    public float t;

    void Update()
    {
        t += Time.deltaTime;
        if (t > timerLength)
        {
            t = 0;
            TimerHasFinished.Invoke();
        }
    }

    public void IJustPushedAButton()
    {
        Debug.Log("I just pushed the button!");
    }

    public void IAlsoPushedAButton()
    {
        Debug.Log("Me too!");
    }

    public void MouseIsNowInside()
    {
        Debug.Log("Mouse has entered the sprite!");
        banana.localScale = Vector3.one * 1.2f;
    }

    public void MouseIsNowOutside()
    {
        Debug.Log("Mouse has left the sprite!");
        banana.localScale = Vector3.one;
    }
}