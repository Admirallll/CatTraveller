using UnityEngine;
using System.Collections;

public class FruitsMover : MonoBehaviour
{
    public Vector3 moveSpeed = new Vector2(20, 0);

	void Update () {
        transform.position = transform.position + moveSpeed * Time.deltaTime;
        var rot = transform.rotation;
        rot.z = (rot.z + 3 * Time.deltaTime) % 1;
        transform.rotation = rot;
	}
}
