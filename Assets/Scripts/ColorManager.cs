using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public Material colorNegro;
    public int index;
    public List<Renderer> cubos;

    private void Start()
    {
        //foreach(Transform t in transform)
        //{
        //    cubos.Add(t.GetComponent<Renderer>());
        //}
        //for (int i = 0; i < cubos.Count; i++)
        //{
        //    cubos[i].material = colorNegro;
        //}
        while(index < cubos.Count)
        {
            cubos[index].material = colorNegro;
            index++;
        }
    }
}
