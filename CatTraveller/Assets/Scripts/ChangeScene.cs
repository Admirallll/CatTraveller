using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour {

    public string TargetScene;

    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(() => { 
            if (TargetScene != "CurrentLevel")
                SceneManager.LoadScene(TargetScene);
            else
            {
                var level = 3;
                if (PlayerPrefs.HasKey("CurrentLevel"))
                    level = PlayerPrefs.GetInt("CurrentLevel");
                PlayerPrefs.SetInt("current_checkpoint", 0);
                SceneManager.LoadScene(level);
            }
        });
    }
}