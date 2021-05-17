using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerFruits : MonoBehaviour
{
    public List<GameObject> frutas;
    public float rate = 1;
    public float randomX = 5;
    
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateFruit", 0, rate);
    }

    public void GenerateFruit()
    {
        Vector2 randomPos = new Vector2(Random.Range(transform.position.x - randomX, transform.position.x + randomX), transform.position.y);
        GameObject fruit = Instantiate(frutas[Random.Range(0, frutas.Count)], randomPos, Quaternion.identity);
        fruit.GetComponent<Rigidbody2D>().AddForce(Vector2.up * (Random.Range(150, 300)));
        fruit.GetComponent<Rigidbody2D>().AddForce(Vector2.right * (Random.Range(-200f, 200)));
    }

    
}
