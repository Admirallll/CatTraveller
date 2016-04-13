using UnityEngine;
using System.Collections;

public class HeroAttack : MonoBehaviour {

    public Transform attackPoint;
    public int attackDamage = 10;
    public float cooldown = 0.5f;
    float currCd;

    void Start () {
        currCd = cooldown;
	}
	
	// Update is called once per frame
	void Update () {
        currCd -= Time.deltaTime;
        if (Input.GetKeyDown("f") && currCd <= 0)
        {
            currCd = cooldown;
            Attack.Action(gameObject, attackPoint.position, 0.5f, 11, 10);
        }
    }
}
