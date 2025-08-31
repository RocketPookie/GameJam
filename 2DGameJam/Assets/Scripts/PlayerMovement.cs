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

    public Animator animator;

    void Update()
    {
        verticalMovement = Input.GetAxisRaw("Vertical");

        //animacion
        if (verticalMovement >= 1)
        {
            animator.SetBool("SeMueveHaciaArriba", true);
        }
        if (verticalMovement <= -1)
        {
            animator.SetBool("SeMueveHaciaAbajo", true);
        }
        if (verticalMovement == 0)
        {
            animator.SetBool("SeMueveHaciaArriba", false);
            animator.SetBool("SeMueveHaciaAbajo", false);
        }


    }

    private void FixedUpdate()
    {
        rb.AddForce(pushSpeed * Time.deltaTime, 0); //fuerza de empuje Horizontal


        if (verticalMovement >= 1)
        {
            rb.AddForce(pushSpeedVertical * Time.deltaTime, 0);
        }
        if (verticalMovement <= -1)
        {
            rb.AddForce(-pushSpeedVertical * Time.deltaTime, 0);
        }
      
    }
}
