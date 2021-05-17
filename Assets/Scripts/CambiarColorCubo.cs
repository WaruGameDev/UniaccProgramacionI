using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarColorCubo : MonoBehaviour
{
    public Material[] colores;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material = colores[index];
    }

    public void CambiarColor()
    {
        index++;
        if(index >= colores.Length)
        {
            index = 0;
        }
        GetComponent<Renderer>().material = colores[index];
    }
}
