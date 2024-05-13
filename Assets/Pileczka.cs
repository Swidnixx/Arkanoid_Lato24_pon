using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pileczka : MonoBehaviour
{
    public float speed = 5;
    Rigidbody rb;

    Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
        rb = GetComponent<Rigidbody>();
        PushBall();
    }

    void PushBall()
    {
        Vector3 dir = new Vector3((Random.value - 0.5f) * 2, 1, 0);
        dir.Normalize();
        rb.velocity = dir * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Deadly"))
        {
            Debug.Log("Dead");
            rb.velocity = Vector3.zero;
            GameManager.Instance.lives--;
            if (GameManager.Instance.lives <= 0)
            {
                //GameOver
                GetComponent<Renderer>().enabled = false; //ukrycie pi³eczki
                GameManager.Instance.GameOver(); //przegrana
            }
            else
            {
                transform.position = startPosition;
                PushBall();
            }
        }
    }
}
