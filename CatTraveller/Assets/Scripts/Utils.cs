using UnityEngine;
using System.Collections;
using System;

public class Utils : MonoBehaviour
{
    public static bool IsEntity(GameObject gj)
    {
        var layers = new[] { 9, 12 };

        foreach (var lay in layers)
            if (lay == gj.layer)
                return true;
        return false;
    }

    public static bool IsHero(GameObject gj)
    {
        return gj.layer == 9;
    }

    public static bool FirstUnderSecond(GameObject one, GameObject second)
    {
        var oneSize = one.GetComponent<Collider2D>().bounds;
        var secSize = second.GetComponent<Collider2D>().bounds;
        Debug.Log(oneSize.min.x + " " + oneSize.max.x + " " + secSize.min.x + " " + secSize.max.x);
        return oneSize.max.y <= secSize.min.y + 0.5f && 
            ((oneSize.max.x - 0.05 > secSize.min.x && oneSize.max.x < secSize.max.x) 
            || (oneSize.min.x - 0.05 > secSize.min.x && oneSize.min.x < secSize.max.x));
    }

    public static bool SecondUnderFirst(GameObject one, GameObject second)
    {
        var oneSize = one.GetComponent<Collider2D>().bounds;
        var secSize = second.GetComponent<Collider2D>().bounds;
        Debug.Log(oneSize.min.x + " " + oneSize.max.x + " " + secSize.min.x + " " + secSize.max.x);
        return oneSize.min.y + 0.5f >= secSize.max.y &&
            ((oneSize.max.x - 0.05 > secSize.min.x && oneSize.max.x < secSize.max.x)
            || (oneSize.min.x - 0.05 > secSize.min.x && oneSize.min.x < secSize.max.x));
    }
}
