using UnityEngine;
using System.Collections;

public class PullRope : MonoBehaviour {

    public GameObject DropObj;
    bool onTrigger;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!onTrigger && Utils.IsHero(collision.gameObject))
        {
            onTrigger = true;
            Instantiate(DropObj, new Vector3(13.12945f, 11f, 0), new Quaternion());
            Destroy(gameObject);
        }
            
    }
}
