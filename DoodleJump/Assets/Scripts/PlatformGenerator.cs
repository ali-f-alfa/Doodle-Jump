using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public Sprite PlatformSprite;


    void Start()
    {
        CreatePlatform(new Vector2(0, 0));
    }

    void Update()
    {
        
    }

    public GameObject CreatePlatform(Vector2 position)
    {
        GameObject Platform = new GameObject();
        Platform.name = "generated platform" ;

        Platform.transform.position = position;
        Platform.transform.localScale = new Vector3(10f, 3.5f, 0);

        SpriteRenderer spriteRenderer = Platform.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = PlatformSprite;
        spriteRenderer.color = new Color(0, 1, 0, 1);

        Platform.tag = TagNames.Platform.ToString();

        PolygonCollider2D bc = Platform.AddComponent<PolygonCollider2D>() as PolygonCollider2D;
        bc.isTrigger = true;

        //Rigidbody2D Rb = Platform.AddComponent<Rigidbody2D>();

        PlatformScript Script = Platform.AddComponent<PlatformScript>();


        return Platform;
    }
}
