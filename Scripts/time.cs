using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class time : MonoBehaviour
{
    public float timeleft;
    public int timedelay = 250;
    public bool timerisrunning = false;
    public Text timetxt;
    void Start()
    {
        timerisrunning = true;
        timeleft = Keepdata.slidervalue;
    }
    void Update()
    {
        if(timedelay > 0)
        {
            timedelay--;
        }
        else
        {
            timedelay = 250;
            Time();
        }
    }
    void DisplayTime(){
        timetxt.text = timeleft + " seconds left";
    }
    void Time()
    {
        if(timerisrunning)
        {
            if(timeleft > 0){
            timeleft -= 1;
            DisplayTime();}
            else{
                timerisrunning = false;
                
            }
        }
    }
}
