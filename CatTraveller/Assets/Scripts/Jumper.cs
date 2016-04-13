using UnityEngine;
using System.Collections;

public class Jumper : MonoBehaviour {

    public float jumpSpeed = 32f;
    public float jumpTime = 0.7f;
    float currJump = 0;
    Vector2 moveDirection;
    Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }


    public void Jump(bool isTop)
    {
        if (isTop)
            currJump = jumpSpeed;
        else
            currJump = -jumpSpeed;
    }

    void Update()
    {
        moveDirection = rigidbody.position;
        if (currJump > 0)
        {
            currJump -= 50 * Time.deltaTime;
            moveDirection.y += currJump * Time.deltaTime;

        }
        rigidbody.position = moveDirection;
    }
}
