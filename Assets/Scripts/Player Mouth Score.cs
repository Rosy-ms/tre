using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMouthScore : MonoBehaviour
{
    private int Score = 0;
    public TextMeshProUGUI scoreText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Fish"))
        {
            Destroy(collision.gameObject);
            Score++;
            scoreText.text = Score + "";

        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
