using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EscalarCubo : MonoBehaviour
{
    public bool preventEscalar;
    public void Escalar()
    {
        if (!preventEscalar)
        {
            transform.DOShakeScale(1);
            StartCoroutine(WaitToEscalar());
        }

    }
    IEnumerator WaitToEscalar()
    {
        preventEscalar = true;
        yield return new WaitForSeconds(1.1f);
        preventEscalar = false;
        yield break;
    }
}
