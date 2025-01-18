using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class fishMovement : MonoBehaviour
{
    public GameObject WaterSurf;
    Rigidbody2D rb;
    Vector3 Move;
    public float Speed;
    private float UseSpeed;
    // Start is called before the first frame update
    public bool inWater = true;
    public GameObject waterSplash;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        UseSpeed = Speed;
        WaterSurf = GameObject.Find("WaterSurf");
    }

    // Update is called once per frame
    void Update()
    {
        Move = Vector3.right;
        Move.Normalize();
        rb.AddRelativeForce(Move * UseSpeed);

        if (transform.position.y < WaterSurf.transform.position.y)
        {
            rb.gravityScale = 0;
            rb.drag = 1;
            UseSpeed = Speed;
            if (inWater)
            {
                Vector3 splashPos = transform.position;
                splashPos.y = WaterSurf.transform.position.y;
                GameObject splashClone = Instantiate(waterSplash, splashPos, Quaternion.identity);
                Destroy(splashClone, 0.5f);
            }
            inWater = false;
        }
        else
        {
            rb.gravityScale = 1;
            rb.drag = 0;
            UseSpeed = 0;

            if (!inWater)
            {
                Vector3 splashPos = transform.position;
                splashPos.y = WaterSurf.transform.position.y;
                GameObject splashClone = Instantiate(waterSplash, splashPos, Quaternion.identity);
                Destroy(splashClone, 3f);
            }
            inWater = true;
        }


    }
}

