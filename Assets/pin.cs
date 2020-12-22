using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pin : MonoBehaviour
{

    public float speed = 10f;
    public Rigidbody2D rb;
    private bool _isPinned = false;


    // Update is called once per frame
    void Update()
    {
        if (!_isPinned)
        {
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
            
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.CompareTag("Rotator"))
        {
            transform.SetParent(col.transform);
            ScoreCounter.PinScore++;
            _isPinned = true;
        }else if (col.CompareTag("pin"))
        {
            FindObjectOfType<GameManager>().EngGame();
        }
    }
}