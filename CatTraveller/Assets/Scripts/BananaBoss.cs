using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BananaBoss : MonoBehaviour {

    public float loopTime = 1f;
    public float startWaitTime = 0.5f;
    float loopTimer = 0.5f;
    public GameObject Fruit;
    float endTime = 10f;
    public GameObject waterMelon;

    void Start()
    {
        loopTimer = startWaitTime;
    }

    void ThrowFruit(Vector2 pos, GameObject fruit)
    {
        var gj = (GameObject)Instantiate(fruit, new Vector2(8.2f, (float) (new System.Random().NextDouble() * 4 - 4)), new Quaternion());
        Destroy(gj, 5);
    }

    void Update()
    {
        endTime -= Time.deltaTime;
        if (endTime <= 0)
        {
            endTime = 10000000;
            for (int i = 0; i < 10; i++)
                Instantiate(waterMelon, new Vector3(11.6f, 11f, 0), new Quaternion());
        }
        loopTimer -= Time.deltaTime;
        if (loopTimer <= 0)
        {
            loopTimer = loopTime;
            ThrowFruit(transform.position, Fruit);
        }
    }
}
