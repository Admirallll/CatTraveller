using UnityEngine;
using System.Collections;

public class KillFromJump : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 pos = transform.position;
        if (Utils.IsHero(collision.gameObject))
        {
            if (Utils.SecondUnderFirst(collision.gameObject, gameObject))
            {
                collision.gameObject.GetComponent<Jumper>().Jump(true, false);
                Destroy(gameObject, 0.1f);
            }
            else
            {
                collision.gameObject.GetComponent<SceneMan>().Die();
            }
        }
        else if (Utils.IsEntity(collision.gameObject))
            Destroy(collision.gameObject);
    }

}
