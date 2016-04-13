using UnityEngine;
using System.Collections;

public class MoveUpDown : MonoBehaviour {

    GameObject obj;
    public float moveSpeed = -20;
    bool onTrigger = false;

    void FixedUpdate()
    {
        if (obj != null)
        {
            var pos = obj.transform.position;
            if (onTrigger)
                obj.transform.position = new Vector2(pos.x, pos.y + moveSpeed * Time.deltaTime);
        }
 
    }

    void OnTriggerEnter2D(Collider2D myTrigger)
    {
        if (Utils.IsEntity(myTrigger.gameObject))
        {
            if (!onTrigger)
            {
                obj = transform.parent.gameObject;
                Destroy(gameObject, 2);
            }
            onTrigger = true;
        }
        
    }
}