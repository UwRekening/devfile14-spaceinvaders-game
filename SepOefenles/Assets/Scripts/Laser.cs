using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] Rigidbody2D rb;

    private void Start()
    {
        rb.velocity = transform.right * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Level")
        {
            Destroy(gameObject);
        }
    }
}
