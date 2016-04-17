using UnityEngine;
using System.Collections;
using System;

public class PullRope2 : MonoBehaviour {

    public GameObject DropObj;
    bool onTrigger;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!onTrigger && Utils.IsHero(collision.gameObject))
        {
            onTrigger = true;
            Instantiate(DropObj, new Vector3(transform.position.x, 11f, 0), new Quaternion());
            var x = ((float)new System.Random().NextDouble() * 100 % 36) - 18;
            Instantiate(gameObject, new Vector3(x, 5.79f, 0), new Quaternion());
            Destroy(gameObject);
        }

    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    } 
}
