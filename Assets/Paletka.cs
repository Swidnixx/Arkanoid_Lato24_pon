using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paletka : MonoBehaviour
{
    public float speed = 1;

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        inputX *= speed * Time.deltaTime;
        transform.position += new Vector3(inputX, 0, 0);
    }
}
