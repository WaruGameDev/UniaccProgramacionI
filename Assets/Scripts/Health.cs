using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 5;
    public SpriteRenderer sprite;
    bool receivingDamage;
    public bool isEnemy;
    public bool dead;
    public GameObject visualDamage;
    public GameObject deadVisual;

    public void TakeDamage(float damage)
    {
        health -= damage;
        
        
        if (!receivingDamage)
        {
            StartCoroutine(DamageFX());
        }
        if (health <= 0 && !dead)
        {
            dead = true;
            Destroy(gameObject);
            if (isEnemy)
            {
                GetComponent<Enemy>().SumarPuntaje();
            }
            if(deadVisual != null)
            {
                Instantiate(deadVisual, transform.position, Quaternion.identity);
            }           
        }
        else
        {
            if (visualDamage != null)
            {
                Instantiate(visualDamage, transform.position, Quaternion.identity);

            }
        }
        
    }
    IEnumerator DamageFX()
    {
        receivingDamage = true;
        sprite.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        sprite.color = Color.white;
        receivingDamage = false; 
        yield break;
    }

}
