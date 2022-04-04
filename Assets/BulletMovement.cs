using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float Bulletspeed;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(Vector2.up* Bulletspeed*Time.deltaTime);
      //  rb.velocity = new Vector3(0, transform.position.y * Bulletspeed * Time.deltaTime,0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Enemy")
        {
            Destroy(collision.gameObject);
        }
    }
}
