using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EjemploValueUI : MonoBehaviour
{
    
    public Slider slider;
    public Image circle;    

    // Update is called once per frame
    void Update()
    {
        circle.fillAmount = slider.value;
    }

    public void ClickButton()
    {
        StartCoroutine(TimerToChangeSlide());
    }

    IEnumerator TimerToChangeSlide()
    {
        while(slider.value <1)
        {
            slider.value += 0.1f;
            yield return new WaitForSeconds(1);
        }
        
        print("Termine ");
        yield break;
    }
}
