using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    private Vector3 Mouse;
    private Vector3 MouseinUnity;
    private Vector3 Player;
    private Vector3 Look;
    private SpriteRenderer SpriteRenderer;
    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        Mouse = Input.mousePosition;
        MouseinUnity = Camera.main.ScreenToWorldPoint(Mouse);
        Player = transform.position;
        Look = MouseinUnity - Player;
        Look.z = 0;
        transform.right = Look;
        float x = Look.x;
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
