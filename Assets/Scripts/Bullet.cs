using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector2 direction;
    public float speed = 5;
    public float timeToDestroy = 3;
    public float damage = 1;
    public string targetDamage = "Enemy";

    private void Start()
    {
        Destroy(gameObject, timeToDestroy);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag(targetDamage))
        {
            Health health = other.GetComponent<Health>();
            health.TakeDamage(damage);
            Destroy(gameObject);

            GetComponent<Health>().TakeDamage(1);
        }
    }
}
