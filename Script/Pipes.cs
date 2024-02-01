using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
    rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = (Vector2.left * speed);
    }
    private void OnTriggerEnter2D(Collider2D collison )
    {if (collison.gameObject.tag == "DeletePipe")
    {
        Destroy(gameObject);
    }
    }
}
