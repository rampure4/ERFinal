using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class NewBehaviourScript : MonoBehaviour
{

    public TMP_Text displayTimeText;

    public UnityEvent gameOver;

    private float curTime = 120;
    private float displayTime;

    // Update is called once per frame
    void Update()
    {
        curTime -= Time.deltaTime;
        displayTime = Mathf.Round(curTime);
        displayTimeText.text = displayTime.ToString() + "s";

        if (curTime < 0)
        {
            Time.timeScale = 0;
            Debug.Log("GAME OVER");
            gameOver.Invoke();
            displayTimeText.text = "GAME OVER";
        }
    }
}
