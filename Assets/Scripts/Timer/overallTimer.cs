using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class overallTimer : MonoBehaviour
{
    private Text TimerText;
    private int time;
    // Start is called before the first frame update
    void Start()
    {
        TimerText = gameObject.GetComponent<Text>();
        StartCoroutine("Timer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Timer()
    {
        for (int time = 179; time >= 0; time--) 
        {
            yield return new WaitForSeconds(1);
        
            if(time>=120)
            {
                if((time-120)<10)
                {
                    TimerText.text = "Time left: 2:0" + (time-120).ToString();
                }
                else{
                    TimerText.text = "Time left: 2:" + (time-120).ToString();
                }
            }
            else if(time>=60)
            {
                if((time-60)<10)
                {
                    TimerText.text = "Time left: 1:0" + (time-60).ToString();
                }
                else{
                    TimerText.text = "Time left: 1:" + (time-60).ToString();
                }
                
            }
            else
            {
                   if(time<10)
                {
                    TimerText.text = "Time left: 0:0" + (time).ToString();
                }
                else{
                    TimerText.text = "Time left: 0:" + (time).ToString();
                }
            }
        }
        
    }
}
