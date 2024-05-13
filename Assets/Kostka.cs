using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kostka : MonoBehaviour
{
    public int life = 1;

    private void Start()
    {
        BrickColor();
    }

    public void SetBrick(int life)
    {
        this.life = life;
        BrickColor();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Ball"))
        {
            life--;
            BrickColor();
            if(life <= 0 )
            {

                Destroy(gameObject);
            }
        }
    }

    void BrickColor()
    {
        Renderer renderer = GetComponent<Renderer>();
        Color[] colors = { Color.white, Color.blue, Color.red, Color.green };
        int colorIndex = Mathf.Clamp(life - 1, 0, colors.Length - 1);
        renderer.material.color = colors[colorIndex];
    }
}
