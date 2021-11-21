using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoodlerScript : MonoBehaviour
{
    public float HorizontalMoveSpeed;
    public float VerticalMoveSpeed;
    public EventSystemCustom eventSystem;

    private Vector3 HorizontalMoveVector;
    private Vector3 VerticalMoveVector;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    public int H;
    public int maxH;

    void Start()
    {
        H = 0;
        maxH = 0;
        HorizontalMoveVector = new Vector3(1 * HorizontalMoveSpeed, 0, 0);
        VerticalMoveVector = new Vector3(0, VerticalMoveSpeed, 0);

        rb = gameObject.GetComponent<Rigidbody2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {

        H = (int)transform.position.y;
        if (maxH < H)
        {
            maxH = H;
            eventSystem.OnUpdateScore.Invoke();
        }
        if (Input.GetKey(KeyCode.D))
        {
            if ((transform.position.x > 8.5))
            {
                transform.position += new Vector3(-17f, 0, 0);
            }
            transform.position += HorizontalMoveVector;
            spriteRenderer.flipX = false;

        }

        if (Input.GetKey(KeyCode.A))
        {
            if ((transform.position.x < -8.5))
            {
                transform.position += new Vector3(17f, 0, 0);
            }
            transform.position -= HorizontalMoveVector;
            spriteRenderer.flipX = true;

        }


        //Debug.Log(transform.position.y);

        if (Input.GetKeyDown(KeyCode.Space) && (rb.velocity.y==0))
        {

            rb.AddForce(VerticalMoveVector, ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D Collider)
    {

        if (Collider.gameObject.CompareTag(TagNames.DeathZone.ToString()))
        {
            eventSystem.OnEnd.Invoke();
            gameObject.SetActive(false);
            //GameObject.Destroy(this.gameObject);

            //Debug.Log("collision");
        }
    }
}
