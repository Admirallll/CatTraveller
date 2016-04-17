using UnityEngine;
using System.Collections;
using System;

public class GorillaController : MonoBehaviour {

    public int currentStep = 0;
    public GameObject BananaBoss;
    float stepTimer = 10;
    public GameObject verevka;
    public GameObject verevka2;
    public float moveSpeed = 10;
    public Vector3 moveResult = Vector3.zero;
    public float moveTime = 2.5f;
    public float moveTimer;
    Animator anim;
    bool CheckRope = false;
    bool BananaCreated;

    void Start()
    {
        moveTimer = moveTime;
        moveSpeed *= -1;
        anim = GetComponent<Animator>();
        anim.SetBool("isTrowing", true);
    }
	
	void Update () {
        stepTimer -= Time.deltaTime;
        if (stepTimer <= 0)
        { 
            if (currentStep == 0)
            {
                Instantiate(verevka, new Vector3(-5.53f, 5.79f, 0), new Quaternion());
                currentStep++;
            }
        }
        if (currentStep >= 3)
        {
            var obj = FindObjectOfType<PullRope2>();
            if (obj != null)
                obj.gameObject.GetComponent<PullRope2>().DestroySelf();
            moveSpeed = Math.Abs(moveSpeed);
            if (Math.Abs(transform.position.x - 12.3) > 0.5)
            {
                if (transform.rotation.y == 0)
                    transform.rotation = new Quaternion(0, 1, 0, 0);
                moveResult.x = moveSpeed * Time.deltaTime;
                transform.position += moveResult;
            }
            else
            {
                anim.SetBool("isMoving", false);
                transform.rotation = new Quaternion(0, 0, 0, 0);
                currentStep++;
            }
        }
        if (currentStep >= 4 && Math.Abs(transform.position.x - 12.3) <= 0.5)
        {
            if (!BananaCreated)
            {
                BananaCreated = true;
                Instantiate(BananaBoss, new Vector3(11.6f, 11f, 0), new Quaternion());
            }
             
            
        }

        if (currentStep == 2)
        {
            if (!CheckRope)
            {
                CheckRope = true;
                Instantiate(verevka2, new Vector3(((float)new System.Random().NextDouble() * 100 % 36) - 18, 5.79f, 0), new Quaternion());
            }
            if (anim.GetBool("isTrowing"))
            {
                anim.SetBool("isTrowing", false);
                anim.SetBool("isMoving", true);
            }
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
            moveResult.x = moveSpeed * Time.deltaTime;
            transform.position += moveResult;
        }

    }
}
