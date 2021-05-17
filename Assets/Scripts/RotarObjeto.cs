using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarObjeto : MonoBehaviour
{
    public float speed = 5;
    public List<Transform> theTransfroms;
    public bool puedeGirar = true;
    public int index;
    

    // Update is called once per frame
    void Update()
    {
        if(puedeGirar)
        {
            Girar(SpeedCalculate(), Vector3.up);
        }
        else 
        {
            Girar(SpeedCalculate(), Vector3.right);
        }
       
    }
    public void Girar(float speedGirar, Vector3 dir)
    {
        foreach(Transform t in theTransfroms)
        {
            t.Rotate(dir * speedGirar * Time.deltaTime);
        }
        
    }
    public float SpeedCalculate()
    {
        float c = speed * 100;
        return c;
    }
}
