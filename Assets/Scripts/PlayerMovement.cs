using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float movement;
    public float speed;
    public GameObject bulletprefab;
  public Vector3 offset;
    Rigidbody2D rb;
    public int health=10;
    public Text htext;
    public Text Gameover;
    

    
    // Start is called before the first frame update
    void Start()
    {
       
    }
       

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
       transform.Translate(movement*speed*Time.deltaTime, 0f, 0f);

        if ( transform.position.x < -8.0f)
        {
            transform.position = new Vector2(-8.0f, transform.position.y);

                
        }
        else if ( transform.position.x > 8.0f)
        {
            transform.position = new Vector2(8.0f, transform.position.y);
        }
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletprefab, transform.position + offset, Quaternion.identity);
           // rb.velocity = new Vector2(rb.velocity.x * Bulletspeed, rb.velocity.y) ;
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Finish")
        {
            health--;
            htext.text = health.ToString();
            if(health==0)

            {
                Gameover.GetComponent<Text>().enabled = true;
            }
        }
    }
}
