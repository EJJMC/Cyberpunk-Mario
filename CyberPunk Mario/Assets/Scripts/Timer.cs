using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [Header("Count Down Timer")]
    public float cdRemainingTime = 30;
    public bool cdTimeRunning = false;
    public TextMeshProUGUI cdTimeText;

    //[Header("Count Up Timer")]
   //// public bool countUpTimeRunning = false;
   // public float countUpTime = 0;
   // public TextMeshProUGUI countUpTimeText;

    private void Start()
    {  
        cdTimeRunning = true;//Count Down Timer
        cdTimeText.text = cdRemainingTime.ToString();//Count Down Timer


        
       // countUpTimeRunning = true;// Count Up Timer
       // countUpTimeText.text = countUpTime.ToString();// Count Up Timer
    }

    void Update()
    {

        if (cdTimeRunning)// Count Down Timer
        {
            if (cdRemainingTime > 0)
            {
                cdRemainingTime -= Time.deltaTime;
                DisplayCountDownTimer(cdRemainingTime);
            }
            else
            {
                cdRemainingTime = 0;
                cdTimeRunning = false;
            }
        }


        /*if (countUpTimeRunning)// Count Up Timer
        {
                countUpTime += Time.deltaTime;
                DisplayCountUpTimer(countUpTime);
        }
        */
    }

    void DisplayCountDownTimer(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        cdTimeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    /*void DisplayCountUpTimer(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        countUpTimeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    */
}
