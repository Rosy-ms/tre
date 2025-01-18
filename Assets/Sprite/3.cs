using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;



public class f3 : MonoBehaviour
{

    public float rotateTime = 2;
    private float timer = 0;
    Vector3 mouseInUnity;
    Vector3 player;
    Vector3 look;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        timer -= Time.deltaTime;
        look = transform.right;
        if (timer <= 0)
        {

            look = Random.insideUnitCircle;
            look.z = 0;
            transform.right = look;

            timer = rotateTime;
        }
        float x = look .x;
        if (x<0)
        {
            spriteRenderer.flipY = true;
        }
        else
        {
            spriteRenderer.flipY = false;
        }




    }
}
