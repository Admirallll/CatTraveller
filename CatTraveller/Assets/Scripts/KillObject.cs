using UnityEngine;
using System.Collections;

public class KillObject : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (Utils.IsHero(collision.gameObject))
            SceneMan.Die();
            
    }
	
}
