using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class TreeMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float treespeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = (Vector2.left * treespeed );
    }

 public void OnTriggerEnter2D(Collider2D collision)
 {
    if (collision.gameObject.tag=="DeletePipe")
    {
        Destroy(gameObject);
    }
 }

}
