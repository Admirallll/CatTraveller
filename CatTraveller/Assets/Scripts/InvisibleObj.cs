using UnityEngine;
using System.Collections;

public class InvisibleObj : MonoBehaviour {

    void Start()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;
        GetComponent<SpriteRenderer>().enabled = false;
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (Utils.FirstUnderSecond(collision.gameObject, gameObject))
        {
            GetComponent<BoxCollider2D>().isTrigger = false;
            GetComponent<SpriteRenderer>().enabled = true;
        }

    }
}
