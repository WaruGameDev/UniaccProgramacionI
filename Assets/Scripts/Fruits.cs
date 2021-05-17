using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour
{
    public float scoreToAdd = 10;
    public int hp = 1;

    public void TakeDamage(int amount)
    {
        hp -= amount;
        if(hp <= 0)
        {
            GameManager.instance.puntaje += scoreToAdd;
            Destroy(gameObject);
        }
    }
}
