using UnityEngine;
using System;
using System.Collections;

public class Mover : MonoBehaviour
{
    public float groundPosition = -8f;
    public float moveSpeed = 10.0F;
    public float gravity = 5;
    
    Rigidbody2D rigidbody;
    Vector2 moveDirection;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.freezeRotation = true;
    }

    void Update()
    {
        if (transform.position.y < groundPosition)
            SceneMan.Die();

        moveDirection = rigidbody.position;
        if (Input.GetKey("a"))
        {
            anim.SetBool("isMoving", true);
            moveDirection.x -= moveSpeed * Time.deltaTime;
            transform.rotation = new Quaternion(0, 1, 0, 0);
        }
        else if (Input.GetKey("d"))
        {
            anim.SetBool("isMoving", true);
            moveDirection.x += moveSpeed * Time.deltaTime;
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
        else
            anim.SetBool("isMoving", false);


        if (Input.GetKeyDown("space"))
        {
            if (rigidbody.velocity.y == 0)
                GetComponent<Jumper>().Jump(true);
        }
        if (rigidbody.velocity.y != 0)
            moveDirection.y -= gravity * Time.deltaTime;
        rigidbody.position = moveDirection;
    }
}