using UnityEngine;
using System.Collections;

public class AppleTrap : MonoBehaviour
{
    public float moveSpeed = -20;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (Utils.IsEntity(collision.gameObject))
            foreach (Transform apple in transform)
            {
                apple.GetComponent<Rigidbody2D>().isKinematic = false;
            }
    }
}