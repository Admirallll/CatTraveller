﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerPrefs.SetInt("current_checkpoint", 0);
        PlayerPrefs.SetInt("CurrentLevel", PlayerPrefs.GetInt("CurrentLevel") + 1);
        SceneManager.LoadScene("RestartGameScene");
    }
}
