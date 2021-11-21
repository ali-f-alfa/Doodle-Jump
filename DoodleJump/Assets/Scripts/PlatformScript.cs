using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public DoodlerScript Doodler;

    void Start()
    {

    }

    void Update()
    {
        
        //transform.position += new Vector3(0, -0.02f, 0);

    }

    //private void OnCollisionEnter2D(Collision2D collision)
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y < 0)
        {

            collision.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
            //gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

        }

    }

    //private void OnTriggerStay2D(Collider2D collision)
    //{
    //    collision.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
    //}

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;

        //if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y < 0)
        //{
        //    Debug.Log("az bala");

        //    //gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        //    collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0.5f);

        //}
        //else
        //{
        //    Debug.Log("az paiin");

        //}

    }
}