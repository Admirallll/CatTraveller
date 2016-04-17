using UnityEngine;
using System.Collections;

public class ObjectFromGround : MonoBehaviour {

    public float moveTime = 0.1f;
    private float moveTimer;
    private bool isTriggered;

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (!isTriggered && Utils.IsEntity(collision.gameObject))
        {
            foreach (Transform apple in transform)
            {
                apple.GetComponent<Rigidbody2D>().isKinematic = false;
            }
            moveTimer = moveTime;
            isTriggered = true;
        }
            
    }

    void Update()
    {
        if (isTriggered)
        {
            moveTimer -= Time.deltaTime;
            if (moveTimer <= 0)
            {
                foreach (Transform apple in transform)
                {
                    apple.GetComponent<Rigidbody2D>().isKinematic = true;
                }
            }    
        }
    }
}
