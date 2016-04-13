using UnityEngine;
using System.Collections;

public class UnitsHP : MonoBehaviour {

    public int HP = 100;
	
	public void HPUpdate(int hp) {
        HP += hp;
        if (HP <= 0)
            Destroy(gameObject);
	}
}
