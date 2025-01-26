using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySharkRotation : MonoBehaviour
{
    Vector3 look;
    private SpriteRenderer SpriteRenderer;
    private float timer;
    public float RotateTime = 2;
    private EnemyEyes eyes;
    void Start()
    {
        timer = RotateTime;
        SpriteRenderer = GetComponent<SpriteRenderer>();
        eyes = GetComponentInChildren<EnemyEyes>();
    }
    void Update()
    {
        if (eyes.target = null)
        {

            timer -= Time.deltaTime;
            Vector3 look = transform.right;
            if (timer <= 0)
            {
                look = Random.insideUnitCircle;
                look.z = 0;
                transform.right = look;
                timer = RotateTime;
            }
        }
        else 
        {
            Vector3 targetPos = eyes.target.transform.position;
            Vector3 enemy = transform.position;
            Vector3 look = targetPos - enemy;
            look.z = 0;
            transform.right = look;
        }
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
