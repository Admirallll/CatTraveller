using UnityEngine;
using System.Collections;

public class InvisibleObj : MonoBehaviour {

    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<SpriteRenderer>().enabled = true;
    }
}
