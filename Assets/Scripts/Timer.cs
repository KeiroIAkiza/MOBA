using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    private float countDownTime;
    public Text timerText = null;
    int stage = 0;

    public void Start()
    {
        countDownTime = 5;//30;//this is ban phase
        timerText.text = countDownTime.ToString();
        Debug.Log("Entering champ select");
    }

    public void Update()
    {
        switch (stage)
        {
            case 0://Ban phase
                countDownTime -= Time.deltaTime;
                timerText.text = countDownTime.ToString("0.");
                //Debug.Log(countDownTime.ToString("0."));
                if (countDownTime < 0)
                {
                    stage = 1;
                    countDownTime = 10;//60;
                    Debug.Log("End Ban Phase");
                }
                
                break;
            case 1://Pick phase
                countDownTime -= Time.deltaTime;
                timerText.text = countDownTime.ToString("0.");
                //Debug.Log(countDownTime.ToString("0."));
                if (countDownTime < 0)
                {
                    stage = 2;
                    countDownTime = 10;
                    Debug.Log("End Picks");
                }
                
                break;
            case 2://End phase
                countDownTime -= Time.deltaTime;
                timerText.text = countDownTime.ToString("0.");
                //Debug.Log(countDownTime.ToString("0."));
                if (countDownTime < 0)
                {
                    LoadMatch();
                    Debug.Log("End Champion selection");
                    stage = 3;
                }
                break;
            default:
                Debug.Log("Champion selection Completed or Failed");
                break;
        }


    }

    private void LoadMatch()
    {
        SceneManager.LoadScene("Game");
    }
}
