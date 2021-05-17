using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFruit : MonoBehaviour
{
    public string toDestroy = "Fruit";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag(toDestroy))
        {
            if(other.GetComponent<Fruits>().scoreToAdd > 0)
            {
                GameManager.instance.fruitMissed++;
            }
           
            Destroy(other.gameObject);
        }
    }
}
