using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.GameCenter;

public class PlayerMovement : MonoBehaviour
{
    float verticalMovement = 0f;

    public Rigidbody2D rb;

    public Vector2 pushSpeed;
    public Vector2 pushSpeedVertical;

    void Update()
    {
        verticalMovement = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.AddForce(pushSpeed * Time.deltaTime, 0); //fuerza de empuje Horizontal


        if (verticalMovement >= 1)
        {
            rb.AddForce(pushSpeedVertical * Time.deltaTime, 0);
        }
        else if (verticalMovement <= -1)
        {
            rb.AddForce(-pushSpeedVertical * Time.deltaTime, 0);
        }
    }
}
