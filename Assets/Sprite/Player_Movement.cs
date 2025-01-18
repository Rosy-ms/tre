using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player_Movement : MonoBehaviour
{
    public GameObject WaterSurf;
    Rigidbody2D rb;
    public float Speed;
    private float UseSpeed;
    // Start is called before the first frame update
    public bool inWater = true;
    public GameObject waterSplash;
    void Start()
    {
       rb =  GetComponent<Rigidbody2D>();
        UseSpeed = Speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < WaterSurf.transform.position.y)
        {
            rb.gravityScale = 0;
            rb.drag = 1;
            UseSpeed = Speed;
            if (inWater)
            {
                Vector3 splashPos = transform.position;
                splashPos.y = WaterSurf.transform.position.y;
                GameObject splashClone = Instantiate(waterSplash, splashPos,  Quaternion.identity);
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
             Vector3 splashPos  = transform.position;
                splashPos.y = WaterSurf.transform.position.y;
                GameObject splashClone = Instantiate(waterSplash, splashPos, Quaternion.identity );
                Destroy( splashClone, 0.5f);
            }
            inWater = true;
        }
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 move = new Vector3 (hor, ver, 0);
        move.Normalize();
       // transform.Translate (move*0.1f);
       rb.AddRelativeForce (move * UseSpeed);
      

    }
}
