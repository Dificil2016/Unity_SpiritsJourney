using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UP_MovementAnimator : MonoBehaviour
{

    public Rigidbody2D rb2D;

    public Animator animator;
    public SpriteRenderer spriteRenderer;

    public float velocity;

    public UP_Counter inGroundCounter;
    public bool inGroundInverted;

    public bool flipImageWhenGoingLeft;
    public bool flipImageWhenGoingDown;

    public string rightKey;
    public string leftKey;
    public string jumpKey;
    public string crouchKey;


    void Update()
    {
        velocity = rb2D.velocity.x;

        animator.SetFloat("X_Speed", rb2D.velocity.x);
        animator.SetFloat("Y_Speed", rb2D.velocity.y);

        if(inGroundCounter)
        {
            if(inGroundInverted == true)
            {
                if (inGroundCounter.Counter == 0)   {animator.SetBool("InGround", true);}
                else                                {animator.SetBool("InGround", false);}
            }
            else
            {
                if (inGroundCounter.Counter == 0)   {animator.SetBool("InGround", false);}
                else                                {animator.SetBool("InGround", true);}
            }
        }

        if(flipImageWhenGoingLeft)
        {
            if(rb2D.velocity.x < 0)         {spriteRenderer.flipX = true;}
            else if(rb2D.velocity.x > 0)    {spriteRenderer.flipX = false;}
        }
        if(flipImageWhenGoingDown)
        {
            if(rb2D.velocity.y < 0)         {spriteRenderer.flipY = true;}
            else if(rb2D.velocity.y > 0)    {spriteRenderer.flipY = false;}
        }

        if(Input.GetKey(rightKey))      {animator.SetBool("PressingKey", true);}
        else if(Input.GetKey(leftKey)) {animator.SetBool("PressingKey", true);}
        else                                {animator.SetBool("PressingKey", false);}

        if(Input.GetKeyDown(jumpKey)) {animator.SetBool("JumpPressed", true);}
        else                      {animator.SetBool("JumpPressed", false);}

        if(Input.GetKey(crouchKey)) {animator.SetBool("PressingCrouch", true);}
        else                        {animator.SetBool("PressingCrouch", false);}
    }
}
