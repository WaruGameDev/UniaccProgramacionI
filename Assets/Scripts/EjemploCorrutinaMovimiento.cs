using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploCorrutinaMovimiento : MonoBehaviour
{
    public bool signal;
    public void Start()
    {
        StartCoroutine(Mover());
    }
    IEnumerator Mover()
    {
        yield return new WaitForSeconds(3);
        transform.position = new Vector3(0, 3, 0);
        yield return new WaitForSeconds(2);
        transform.position = new Vector3(0, -3, 0);
        yield return new WaitUntil(() => signal);
        transform.position = Vector3.zero;

        yield return new WaitWhile(() => signal);
        transform.position = new Vector3(3, 3, 0);
        yield break;
    }
    public void SetSignal(bool sig)
    {
        signal = sig;
    }
}
