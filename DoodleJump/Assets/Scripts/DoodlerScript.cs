using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoodlerScript : MonoBehaviour
{
    public float HorizontalMoveSpeed;
    public float VerticalMoveSpeed;

    private Vector3 HorizontalMoveVector;
    private Vector3 VerticalMoveVector;
    private Rigidbody2D rb;

    void Start()
    {
        HorizontalMoveVector = new Vector3(1 * HorizontalMoveSpeed, 0, 0);
        VerticalMoveVector = new Vector3(0, 1, 0);

        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D) && (transform.position.x <= 9))
        {
            transform.position += HorizontalMoveVector;
        }

        if (Input.GetKey(KeyCode.A) && (transform.position.x >= -9.1))
        {
            transform.position -= HorizontalMoveVector;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * 5, ForceMode2D.Impulse);
        }
    }
}
