using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneMan : MonoBehaviour {
    
    public static int currentCheckPoint;
    public Vector2[] Positions;
	
	void Start () {
        if (PlayerPrefs.HasKey("current_checkpoint"))
            currentCheckPoint = PlayerPrefs.GetInt("current_checkpoint");
        transform.position = Positions[currentCheckPoint];
	}

    public static void Die()
    {
        var playerDies = 0;
        var currentLevel = SceneManager.GetActiveScene().buildIndex;
        if (PlayerPrefs.HasKey("DiesCount"))
            playerDies = PlayerPrefs.GetInt("DiesCount");
        if (PlayerPrefs.HasKey("CurrentLevel"))
            currentLevel = PlayerPrefs.GetInt("CurrentLevel");
        playerDies++;
        PlayerPrefs.SetInt("DiesCount", playerDies);
        PlayerPrefs.SetInt("CurrentLevel", currentLevel);
        SceneManager.LoadScene("RestartGameScene");
    }
}
