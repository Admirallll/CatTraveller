using UnityEngine;
using System.Collections;

public class CameraMover : MonoBehaviour {

    public GameObject hero;

	void LateUpdate () {
        transform.position = new Vector3(hero.transform.position.x + 7, transform.position.y, transform.position.z);
	}

    void Update()
    {
        if (Input.GetKeyDown("escape"))
            Time.timeScale = 0;
    }
}
