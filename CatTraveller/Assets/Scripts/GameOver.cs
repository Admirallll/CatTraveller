using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class GameOver : MonoBehaviour
{
    void Start()
    {
        var text = GetComponent<Text>();
        var diesCount = 0;
        var currentLevel = 3;
        var SceneNames = new string[]{ "Stage 1 - Forest", "Stage 2 - Another Forest", "Stage 3 - Castle", "Stage 4 - Final Boss", "The End" };
        if (PlayerPrefs.HasKey("DiesCount"))
            diesCount = PlayerPrefs.GetInt("DiesCount");
        if (PlayerPrefs.HasKey("CurrentLevel"))
            currentLevel = PlayerPrefs.GetInt("CurrentLevel");
        text.text = SceneNames[currentLevel-3] + "\r\nx " + diesCount;
        if (currentLevel != 7)
            StartCoroutine(Wait(2, currentLevel));
        else
            StartCoroutine(Wait(5, 0));
    }

    IEnumerator Wait(float time, int scene)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(scene);
    }

}
