using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    [SerializeField] private float Speed = 2f;
    float Hor, ver;
    Vector3 move;
    Rigidbody2D rb;
    public GameObject WaterSurface;
    private bool inWater = true;
    public GameObject waterSplash;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        move = new Vector3(ver, Hor, 0);
        move.Normalize();
        if (transform.position.y > WaterSurface.transform.position.y)
        {
            rb.gravityScale = 0.2f;
            rb.drag = 2f;
            if (inWater)
            {
                Vector3 splashPos = transform.position;
                splashPos.y = WaterSurface.transform.position.y;
                GameObject splashclone = Instantiate(waterSplash, splashPos, Quaternion.identity);
                Destroy(splashclone, 0.5f);
            }
            inWater = false;
        }
        else
        {
            rb.gravityScale = 0;
            rb.drag = 1f;
            rb.AddRelativeForce(move * Speed);
            if (!inWater)
            {
                Vector3 splashPos = transform.position;
                splashPos.y = WaterSurface.transform.position.y;
                GameObject splashclone = Instantiate(waterSplash, splashPos, Quaternion.identity);
                Destroy(splashclone, 0.5f);
            }
            inWater = true;
            }
        }
     }
 
