using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapturarFruta : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Fruit"))
        {
            Fruits f = other.GetComponent<Fruits>();            
            f.TakeDamage(1);           
        }
    }
}
