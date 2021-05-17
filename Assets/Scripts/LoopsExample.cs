using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsExample : MonoBehaviour
{
    public int cantidadDeNumeros = 100;
    public List<GameObject> objetos;
    public int count;
    //for yay!
    //foreach
    //while

    // repetir tarea de manera automatica

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Contador());
       
        for (int i = 0; i < cantidadDeNumeros; i++)
        {
            if(i%2 == 0)
            {
                Debug.Log(i + " es un numero par");
            }
            else
            {
                Debug.Log( i + " es un numero impar");
            }
        }
        foreach(GameObject objeto in objetos)
        {
            Debug.Log(objeto.transform.name);
        }
        //while(count < 10)
        //{
        //    Debug.Log(count);
        //    count++;
        //}
    }

    IEnumerator Contador()
    {
        while(count <10)
        {
            Debug.Log(count);
            
            yield return new WaitForSeconds(1);
            count++;
        }
        Debug.Log("Termine la cuenta");
        yield break;
    }

}
