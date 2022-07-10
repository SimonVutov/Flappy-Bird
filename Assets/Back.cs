using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    public float speed = 4;
    float length = 35.63519f;

    void Start()
    {
        transform.position = new Vector2(length / 4, transform.position.y);
    }

    void Update()
    {
        if (transform.position.x < -length / 4)
        {
            transform.position = new Vector2(length / 4, transform.position.y);
        }

        transform.position -= Vector3.right * speed * Time.deltaTime;
    }
}
