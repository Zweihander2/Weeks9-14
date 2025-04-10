using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBasedBattler : MonoBehaviour
{
    public AnimationCurve curve;

    Coroutine size;
    IEnumerator sizeTwo;

    public float t = 0;
    void Start()
    {
        size = StartCoroutine(GrowSquareTwoElectricBoogaloo());
    }

    private IEnumerator GrowSquareTwoElectricBoogaloo()
    {
        while (true)
        {
            sizeTwo = GrowSquare();
            yield return StartCoroutine(sizeTwo);
        }

    }


    void Update()
    {
        
    }

    private IEnumerator GrowSquare()
    {
        t += Time.deltaTime;
        transform.localScale = Vector2.one * curve.Evaluate(t);
        yield return null;
    }
}
