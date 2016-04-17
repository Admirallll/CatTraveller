using UnityEngine;
using System.Collections;

public class BananaCreator : MonoBehaviour {

    public float loopTime = 1f;
    public float startWaitTime = 0.5f;
    float loopTimer = 0.5f;
    public GameObject Fruit;

    void Start()
    {
        loopTimer = startWaitTime;
    }

    void ThrowFruit(Vector2 pos, GameObject fruit)
    {
        var gj = (GameObject) Instantiate(fruit, transform.position, new Quaternion());
        Destroy(gj, 5);
    }

    void Update()
    {
        if (GetComponentInParent<GorillaController>().currentStep < 2)
        {
            loopTimer -= Time.deltaTime;
            if (loopTimer <= 0)
            {
                loopTimer = loopTime;
                ThrowFruit(transform.position, Fruit);
            }
        }
    }
}
