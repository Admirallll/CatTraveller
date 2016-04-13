using UnityEngine;
using System.Collections;

public class TouchToKill : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (Utils.IsHero(collision.gameObject))
        { 
            if (Utils.SecondUnderFirst(gameObject, collision.gameObject))
                SceneMan.Die();  
        }
        else
        {
            if (Utils.IsEntity(collision.gameObject))
                Destroy(collision.gameObject);
        }
    }
}
