using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer : MonoBehaviour
{
    public GameObject bullet;
    public Transform[] canons;
    public bool canFire = true;
    public float fireRate = 0.3f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Jump") && canFire)
        {
            Shoot();
        } 
        
    }
    public void Shoot()
    {
        foreach(Transform canon in canons)
        {
            Instantiate(bullet, canon.position, Quaternion.Euler(0, 0, 0));            
            
        }
        StartCoroutine(Firerate());
    }
    IEnumerator Firerate()
    {
        canFire = false;
        yield return new WaitForSeconds(fireRate);
        canFire = true;
        yield break;
    }    
}
