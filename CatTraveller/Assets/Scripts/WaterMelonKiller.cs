using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WaterMelonKiller : MonoBehaviour {

    public AudioClip HitSound;

    void Start()
    {
        Destroy(gameObject, 3);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (Utils.IsHero(collision.gameObject))
        {
            collision.gameObject.GetComponent<SceneMan>().Die();
        }
        else if (Utils.IsEntity(collision.gameObject))
        {
            //AudioSource.PlayClipAtPoint(HitSound, transform.position);
            collision.gameObject.GetComponent<GorillaController>().currentStep++;

        }
        else if (collision.gameObject.layer == 11)
        {
            PlayerPrefs.SetInt("current_checkpoint", 0);
            PlayerPrefs.SetInt("CurrentLevel", 7);
            SceneManager.LoadScene("RestartGameScene");
        }
        if (collision.gameObject.layer != 13)
            Destroy(gameObject);
    }
}
