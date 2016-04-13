using UnityEngine;
using System.Collections;

public class GetUpFlag : MonoBehaviour {

    public int flagNumber;
    
    void Start()
    {
        var currentFlag = 0;
        if (PlayerPrefs.HasKey("current_checkpoint"))
            currentFlag = PlayerPrefs.GetInt("current_checkpoint");
        if (currentFlag < flagNumber)
            GetComponent<Animator>().SetBool("isNotUpped", true);
    }

    void OnTriggerEnter2D(Collider2D myTrigger)
    {
        
        if (flagNumber != -1)
        {
            var currentFlag = 0;
            if (PlayerPrefs.HasKey("current_checkpoint"))
                currentFlag = PlayerPrefs.GetInt("current_checkpoint");
            if (currentFlag < flagNumber)
            {
                currentFlag = flagNumber;
                GetComponent<Animator>().SetBool("isUpFlag", true);
            }
            PlayerPrefs.SetInt("current_checkpoint", currentFlag);
            Debug.Log(currentFlag);
        }
        else
        {
            myTrigger.GetComponent<Mover>().enabled = false;
            Camera.allCameras[0].GetComponent<CameraMover>().enabled = false;
            myTrigger.GetComponent<Animator>().SetBool("isMoving", true);
            for (int i = 0; i < 10; i++)
            {
                StartCoroutine(Wait(0.5f));
                myTrigger.GetComponent<Rigidbody2D>().velocity = new Vector2(10, 0);
            }
            
        }


    }
    IEnumerator Wait(float time)
    {
        yield return new WaitForSeconds(time);
    }
}
