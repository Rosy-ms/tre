using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class f1 : MonoBehaviour
{

    Vector3 mouse;
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
        mouse = Input.mousePosition;
        mouseInUnity = Camera.main.ScreenToWorldPoint(mouse);
        player = transform.position;
        look = mouseInUnity - player;
        transform.right = look;
        look.z = 0;
        transform.right = look;
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
