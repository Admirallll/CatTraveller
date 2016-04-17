using UnityEngine;
using System.Collections;

public class KillObject : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (Utils.IsHero(collision.gameObject))
            collision.gameObject.GetComponent<SceneMan>().Die();
        else if (Utils.IsEntity(collision.gameObject))
            Destroy(collision.gameObject);
            
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (Utils.IsHero(collision.gameObject))
            collision.gameObject.GetComponent<SceneMan>().Die();
    }

}
