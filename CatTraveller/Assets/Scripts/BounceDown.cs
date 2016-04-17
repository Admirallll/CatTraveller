using UnityEngine;
using System.Collections;

public class BounceDown : MonoBehaviour {

    public AudioClip HitSound;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (Utils.IsHero(collision.gameObject))
            if (Utils.FirstUnderSecond(collision.gameObject, gameObject))
            {
                AudioSource.PlayClipAtPoint(HitSound, transform.position);
                collision.gameObject.GetComponent<Jumper>().Jump(false, false);
            }
    }
}
