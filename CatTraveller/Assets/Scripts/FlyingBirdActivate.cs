using UnityEngine;
using System.Collections;

public class FlyingBirdActivate : MonoBehaviour {

    public GameObject obj;
    public float moveSpeed = -50;
    public Vector3 Position;
    bool onTrigger = false;

    void FixedUpdate()
    {   
        if (obj != null)
        {
            var pos = obj.transform.position;
            if (onTrigger)
                obj.transform.position = new Vector2(pos.x + moveSpeed * Time.deltaTime, pos.y);
        }
        
    }

    void OnTriggerEnter2D(Collider2D myTrigger)
    {
        if (Utils.IsHero(myTrigger.gameObject))
        {
            if (!onTrigger)
            {
                obj = (GameObject) Instantiate(obj, Position, new Quaternion(0, 0, 0, 0));
                Destroy(obj, 2);
            }
            onTrigger = true;
        }

    }
}
