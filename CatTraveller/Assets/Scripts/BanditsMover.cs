using UnityEngine;
using System.Collections;
using System;

public class BanditsMover : MonoBehaviour {

    public float moveSpeed = 4;
    public Vector2 moveResult = Vector2.zero;
    Rigidbody2D rigidbody;
    public float moveTime = 2f;
    public float moveTimer;    

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        moveTimer = moveTime;
        moveSpeed *= -1;
    }

	void Update ()
    {
        moveResult.y = rigidbody.velocity.y;
        if (Math.Abs(rigidbody.velocity.y) <= 0.5)
        {
            moveTimer -= Time.deltaTime;
            if (moveTimer <= 0)
            {
                moveTimer = moveTime;
                moveSpeed *= -1;
                if (transform.rotation.y == 1)
                    transform.rotation = new Quaternion(0, 0, 0, 0);
                else
                    transform.rotation = new Quaternion(0, 1, 0, 0);
            }
            moveResult.x = moveSpeed;
        }
        else
            moveResult.x = 0;
        rigidbody.velocity = moveResult;
    }
}
