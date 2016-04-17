using UnityEngine;
using System.Collections;
using System;

public class JumpingObject : MonoBehaviour {

    public GameObject hero;

	void Update () {
        if (Math.Abs(hero.transform.position.x - transform.position.x) < 2 && Utils.IsGrounded(GetComponent<Rigidbody2D>()))
                GetComponent<Jumper>().Jump(true, false);
	}
}
