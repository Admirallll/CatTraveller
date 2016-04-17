using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneMan : MonoBehaviour {
    
    public static int currentCheckPoint;
    public Vector2[] Positions;
    bool isDie;
    public AudioClip DeathSound;
	
	void Start () {
        if (PlayerPrefs.HasKey("current_checkpoint"))
            currentCheckPoint = PlayerPrefs.GetInt("current_checkpoint");
        transform.position = Positions[currentCheckPoint];
	}

    public void Die()
    {
        if (!isDie)
        {
            AudioSource.PlayClipAtPoint(DeathSound, transform.position);
            isDie = true;
            var playerDies = 0;
            var currentLevel = SceneManager.GetActiveScene().buildIndex;
            if (PlayerPrefs.HasKey("DiesCount"))
                playerDies = PlayerPrefs.GetInt("DiesCount");
            if (PlayerPrefs.HasKey("CurrentLevel"))
                currentLevel = PlayerPrefs.GetInt("CurrentLevel");
            playerDies++;
            PlayerPrefs.SetInt("DiesCount", playerDies);
            PlayerPrefs.SetInt("CurrentLevel", currentLevel);
            GetComponent<Mover>().enabled = false;
            GetComponent<Jumper>().Jump(true, false);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -20);
            GetComponent<BoxCollider2D>().isTrigger = true;

            StartCoroutine(Utils.WaitAndLoad(1, "RestartGameScene"));
        }
        

    }
}
