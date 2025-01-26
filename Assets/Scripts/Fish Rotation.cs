using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishRotation : MonoBehaviour
{
    private SpriteRenderer SpriteRenderer;
    private float timer;
    public float RotateTime = 2;
    void Start()
    {
        timer = RotateTime;
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        timer -= Time.deltaTime;
        Vector3 look = transform.right;
        if (timer <= 0)
        {
            look = Random.insideUnitCircle;
            look.z = 0;
            transform.right = look;
            timer = RotateTime;
            float x = look.x;
            if (x < 0)
            {
                SpriteRenderer.flipY = true;
            }
            else
            {
                SpriteRenderer.flipY = false;
            }
        }
    }
}
