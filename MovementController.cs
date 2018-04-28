using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {
    public bool IsGrounded;
    public float JumpHeight;
    public float RotSpeed;
    private float speed;
    private float w_speed = 0.5f;
    private float rot_speed = 1.0f;

    Rigidbody rb;
    Animator anim;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        IsGrounded = true;
    }

    void MovementControl(string state)
    {
        switch (state)
        {
            case "WalkingForward":
                anim.SetBool("isWalkingForward", true);
                anim.SetBool("isIdle", false);
                anim.SetBool("isWalkingBackward", false);
                break;
            case "WalkingBackward":
                anim.SetBool("isWalkingBackward", true);
                anim.SetBool("isIdle", false);
                anim.SetBool("isWalkingForward", false);
                break;
            case "Idle":
                anim.SetBool("isIdle", true);
                anim.SetBool("isWalkingForward", false);
                anim.SetBool("isWalkingBackward", false);
                break;

        }
    }

        // Update is called once per frame
        void Update ()
    {
        if (IsGrounded)
        {
            if (Input.GetKey(KeyCode.W))
            {
                speed = w_speed;
                MovementControl("WalkingForward");
            }
            else if (Input.GetKey(KeyCode.S))
            {
                speed = w_speed;
                MovementControl("WalkingBackward");
            }
            else
            {
                MovementControl("Idle");
            }
            if(Input.GetKey(KeyCode.D))
            {
                RotSpeed = rot_speed;
            }
            else if(Input.GetKey(KeyCode.A))
            {
                RotSpeed = rot_speed;
            }
            else
            {
                RotSpeed = 0;
            }
        }

        var z = Input.GetAxis("Vertical") * speed;
        var y = Input.GetAxis("Horizontal") * RotSpeed;
        transform.Translate(0, 0, z);
        transform.Rotate(0, y, 0);

        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded==true)
        {
            anim.SetTrigger("isJumping");
            rb.AddForce(0,JumpHeight * Time.deltaTime, 0);
            IsGrounded = false;
        }
    }

    void OnCollisionEnter()
    {
        IsGrounded = true;
    }
}


