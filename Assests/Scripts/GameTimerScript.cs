using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameTimerScript : MonoBehaviour
{
    public Text GameTimerText;
    private float startTime;
    public bool finished=false;
 void Start()
    {
       startTime= Time.time; 
    }




    // Update is called once per frame
    void Update()
    {
        if(finished)
        return;

       float t=Time.time-startTime;
       int minutes = (int) t / 60000 ;
       int seconds = (int) t / 1000 - 60 * minutes;
       int milliseconds = (int) t - minutes * 60000 - 1000 * seconds;
        GameTimerText.text=string. Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds );
    }

    public void finnish(){
        finished=true;
        GameTimerText.color=Color.yellow;
        
    }
}
