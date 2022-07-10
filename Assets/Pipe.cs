using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    void Update()
    {
        transform.position -= Vector3.right * 4 * Time.deltaTime;
        if (transform.position.x < -20) Destroy(gameObject);
    }
}
