using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaitToSetActive : MonoBehaviour
{
    public float timeToSetActive;
    public Button button;

    public void IniciarCorrutina()
    {
        StartCoroutine(WaitToActive());
    }
    IEnumerator WaitToActive()
    {
        button.interactable = false;
        yield return new WaitForSeconds(timeToSetActive);
        button.interactable = true;
        yield break;
    }
}
