using UnityEngine;
using System.Collections;

public class FakeObject : MonoBehaviour
{ 
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 9)
            Destroy(gameObject.transform.parent.gameObject);
    }
}