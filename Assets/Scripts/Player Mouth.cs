using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMouth : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Fish"))
        {
            Destroy(collision.gameObject);
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
