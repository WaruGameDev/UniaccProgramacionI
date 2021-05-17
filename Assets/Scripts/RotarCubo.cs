using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RotarCubo : MonoBehaviour
{
    public bool preventRotar;
    public void Rotar()
    {
        if(!preventRotar)
        {
            transform.DORotate(new Vector3(0, 0, 90), 1).SetRelative(true);
            StartCoroutine(WaitToRotar());
        }
        
    }
    IEnumerator WaitToRotar()
    {
        preventRotar = true;
        yield return new WaitForSeconds(1.1f);
        preventRotar = false;
        yield break;
    }
}
