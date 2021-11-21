using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Doodler;
    private Vector3 offset;
    public GameObject deathZone;

    void Start()
    {
        offset = transform.position - Doodler.transform.position;
        //Debug.Log(offset.x);
        Debug.Log(transform.position);

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y - Doodler.transform.position.y < offset.y)
        {
            Debug.Log(transform.position);

            transform.position = new Vector3(0, Doodler.transform.position.y + offset.y, offset.z);
            deathZone.transform.position = new Vector3(0, Doodler.transform.position.y + offset.y - 7.5f, offset.z);
        }

        //else if (transform.position.y - Doodler.transform.position.y < -2)
        //{
        //    transform.position = Doodler.transform.position + offset;
        //}

    }
}
