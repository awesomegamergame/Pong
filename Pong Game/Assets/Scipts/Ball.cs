using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    Vector2 direction;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = Vector2.one.normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = direction * speed;
    }


}
