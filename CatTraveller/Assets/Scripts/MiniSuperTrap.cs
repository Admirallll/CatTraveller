using UnityEngine;
using System.Collections;

public class MiniSuperTrap : MonoBehaviour {

    public int trapNumber;

    void OnTriggerEnter2D(Collider2D collision)
    {
        var trapCounter = GetComponentInParent<SuperTrap>().TrapCounter;
        if (Utils.IsHero(collision.gameObject))
            if (trapCounter >= trapNumber)
            {
                if (Utils.IsEntity(collision.gameObject))
                    foreach (Transform apple in transform)
                    {
                        apple.GetComponent<Rigidbody2D>().isKinematic = false;
                    }
                if (trapCounter == trapNumber)
                    GetComponentInParent<SuperTrap>().TrapCounter++;
            }
        
    }
}
