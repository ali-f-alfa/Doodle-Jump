using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public Sprite PlatformSprite;
    public DoodlerScript Doodler;

    private int lastH = 0;

    void Start()
    {
        CreatePlatform(new Vector2(0, -3));
        CreatePlatform(new Vector2(2, 0));
        CreatePlatform(new Vector2(1, 3));
        CreatePlatform(new Vector2(-3, 0));
    }

    void Update()
    {
        if (Doodler.H > lastH)
        {
            AddRandomPlatforms();
            lastH = Doodler.H;
        }
    }

    public void AddRandomPlatforms()
    {
        CreatePlatform(Doodler.gameObject.transform.position + new Vector3(UnityEngine.Random.Range(-6, 6) - Doodler.gameObject.transform.position.x, 4, 0));
    }


    public GameObject CreatePlatform(Vector3 position)
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
        Script.Doodler = this.Doodler;

        return Platform;
    }
}
