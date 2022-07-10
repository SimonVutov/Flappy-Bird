using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    public GameObject GameOverScreen;
    bool isDead = false;
    Rigidbody2D rb;

    private void Start()
    {
        GameOverScreen.SetActive(false);
        isDead = false;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isDead)
        {
            rb.AddForce(new Vector3(0, 7 - rb.velocity.y, 0), ForceMode2D.Impulse);
        }

        Vector2 lookDir = rb.velocity + Vector2.right * 4;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg + 0;
        rb.rotation = angle;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOverScreen.SetActive(true);
        isDead = true;
    }
}
