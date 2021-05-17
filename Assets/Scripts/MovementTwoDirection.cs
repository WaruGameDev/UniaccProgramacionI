using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTwoDirection : MonoBehaviour
{
    public float speed = 5;
    public float limit = 2.3f;
    public float limitVertical = 5;
    public bool onlyX = true;
   
    private void FixedUpdate()
    {
        
        float x = Input.GetAxis("Horizontal");

        transform.Translate(transform.right * x * speed * Time.fixedDeltaTime);
        if (!onlyX)
        {
            float y = Input.GetAxis("Vertical");
            transform.Translate(transform.up * y * speed * Time.fixedDeltaTime);
        }
        Vector2 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -limit, limit);
        pos.y = Mathf.Clamp(pos.y, -limitVertical, limitVertical);
        
        transform.position = pos;

    }
}
