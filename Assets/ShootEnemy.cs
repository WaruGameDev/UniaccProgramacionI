using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemy : MonoBehaviour
{
    public GameObject bullet;
    public Transform[] canons;    
    public float fireRate = 0.3f;

    private void Start()
    {
        StartCoroutine(Shooting());
    }
    public void Shoot()
    {
        foreach (Transform canon in canons)
        {
            Instantiate(bullet, canon.position, Quaternion.Euler(0, 0, 180));

        }
        
    }
    IEnumerator Shooting()
    {       
        while(true)
        {
            yield return new WaitForSeconds(fireRate);
            Shoot();
        }        
    }
}
