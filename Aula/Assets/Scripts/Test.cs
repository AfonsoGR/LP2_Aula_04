using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private float secHello;
    [SerializeField] private float secUp;
    [SerializeField] private float stopCount;
    private Coroutine printHello;

    private IEnumerator HelloSpam(float seconds)
    {
        WaitForSeconds wts = new WaitForSeconds(seconds);

        while (true)
        {
            Debug.Log("Hello");
            yield return wts;
        }
    }

    private IEnumerator CountUp(float seconds, float stopCount)
    {
        int count = 0;
        WaitForSeconds wts = new WaitForSeconds(seconds);

        while (true)
        {
            Debug.Log($"{count}");
            count++;

            if (count == stopCount)
                StopCoroutine(printHello);

            yield return wts;
        }
    }

    void Start()
    {
        printHello = StartCoroutine(HelloSpam(secHello));
        StartCoroutine(CountUp(secUp, stopCount));
    }
}