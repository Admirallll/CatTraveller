using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour
{
    static GameObject NearTarget(Vector3 position, Collider2D[] array)
    {
        Collider2D current = null;
        float dist = Mathf.Infinity;

        foreach (Collider2D coll in array)
        {
            float curDist = Vector3.Distance(position, coll.transform.position);

            if (curDist < dist)
            {
                current = coll;
                dist = curDist;
            }
        }

        return current.gameObject;
    }

    public static void Action(GameObject attacker, Vector2 point, float radius, int layerMask, int damage)
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(point, radius, 1 << layerMask);
        if (colliders.Length > 0)
        {
            GameObject obj = NearTarget(point, colliders);
            obj.GetComponent<UnitsHP>().HPUpdate(-damage);
            if (obj.GetComponent<Rigidbody2D>())
                obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1, 3), ForceMode2D.Force);
        }
        
    }
}