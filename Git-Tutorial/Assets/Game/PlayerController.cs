using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float verticalVelocity = 10;
    public float horizontalVelocity = 10;
    // Update is called once per frame
    void Update()
    {
        var rb = GetComponent<Rigidbody2D>();
        var velocity = rb.velocity;

        if (Input.GetKey(KeyCode.D))
        {
            velocity.x = horizontalVelocity;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            velocity.x = -horizontalVelocity;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            velocity.y = verticalVelocity;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            velocity.y = -verticalVelocity;
        }
        else
        {
            velocity.x = 0;
            velocity.y = 0;
        }
        rb.velocity = velocity;
    }
}
