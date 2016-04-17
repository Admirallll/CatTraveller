using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

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
        return oneSize.max.y <= secSize.min.y + 0.5f && 
            ((oneSize.max.x - 0.05 > secSize.min.x && oneSize.max.x < secSize.max.x) 
            || (oneSize.min.x - 0.05 > secSize.min.x && oneSize.min.x < secSize.max.x));
    }

    public static bool IsGrounded(Rigidbody2D rig)
    {
        return Math.Abs(rig.velocity.y) <= 0.5;
    }

    public static bool SecondUnderFirst(GameObject one, GameObject second)
    {
        var oneSize = one.GetComponent<Collider2D>().bounds;
        var secSize = second.GetComponent<Collider2D>().bounds;
        return oneSize.min.y + 0.5f >= secSize.max.y &&
            ((oneSize.max.x - 0.05 > secSize.min.x && oneSize.max.x < secSize.max.x)
            || (oneSize.min.x - 0.05 > secSize.min.x && oneSize.min.x < secSize.max.x));
    }

    public static IEnumerator WaitAndLoad(float time, string scene)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(scene);
    }
}
