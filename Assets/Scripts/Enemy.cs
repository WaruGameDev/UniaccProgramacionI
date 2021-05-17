using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int puntajeADar;
    public int rng;
    public float speed = 3;
    public float speedDown = 1;
    public float limit = 2.35f;

    private void Start()
    {
        rng = Random.Range(-1, 2);
        if(rng ==0)
        {
            rng = 1;
        }
    }
    public void SumarPuntaje()
    {
        GameManagerNave.instance.puntaje += puntajeADar;
    }


    public void Update()
    {
        
        transform.Translate(transform.right * rng * speed * Time.deltaTime);
        if(transform.position.x < -limit)
        {
            rng = 1;
        }
        if(transform.position.x > limit)
        {
            rng = -1;
        }



        transform.Translate(-transform.up * speedDown * Time.deltaTime);

    }
}
