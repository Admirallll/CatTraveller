using UnityEngine;
using System.Collections;

public class KickBrick : MonoBehaviour {

    public GameObject Drop;
    bool isDropped = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 pos = transform.position;
        pos = new Vector3(pos.x,pos.y + 1,0);
        if (collision.gameObject.layer == 9)
            if (Utils.FirstUnderSecond(collision.gameObject, gameObject))
            {
                collision.gameObject.GetComponent<Jumper>().Jump(false, false);
                Destroy(gameObject);
                if (Drop != null)
                {
                    if (!isDropped)
                        Instantiate(Drop, pos, new Quaternion(0, 0, 0, 0));
                    isDropped = true;
                }
            }
    }
}
