using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public int miNumeroEntero;
    public float miNumeroDecimal = 3.5f;
    public string miTexto = "Holas";
    public bool miVerdaderoOFalse = true;
    public Transform theTransform;
    public float ahorro = 100;

    [SerializeField]
    private int ejemploSerializado;

    // Update is called once per frame
    void Update()
    {
        if (miVerdaderoOFalse || miNumeroEntero == 0)
        {
            theTransform.Rotate(new Vector3(0, 1, 0) * ejemploSerializado * Time.deltaTime);
        }
        //else
        //{
        //    theTransform.Rotate(new Vector3(0, -1, 0) * ejemploSerializado * Time.deltaTime);
        //}
        else if (miNumeroEntero > 0)
        {
            theTransform.Rotate(new Vector3(0, -1, 0) * ejemploSerializado * Time.deltaTime);
        }
        else if (miNumeroEntero == 0)
        {

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Sumar(SumarRetorno(miNumeroDecimal, ahorro), miNumeroEntero);
        }


    }

    public void Sumar(float a, float b)
    {
        float c = a + b;
        print(c);

    }
    public float SumarRetorno(float a, float b)
    {
        float c = a + b;
        return c;
    }
}