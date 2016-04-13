using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RestartWholeGame : MonoBehaviour {

    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(() => {
            PlayerPrefs.DeleteAll();
        });
    }
}
