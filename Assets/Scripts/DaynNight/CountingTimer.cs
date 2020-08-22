using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountingTimer : MonoBehaviour
{
    //public function i can call to tell me how long something tool
    public static CountingTimer instace;


    [SerializeField]
    private float timerSpeed = 2f;

    private float elapsed;
    private float sec;
    private float min;
    private float hour;
    private float[] time;

    public bool startTimer;

    void Start()
    {
        instace = this;
        startTimer = true;
        elapsed = 0;
    }

    public float[] gameTimer(bool timerOn)
	{
        elapsed = 0;
        if (timerOn == true)
        {
            elapsed += Time.deltaTime;
            sec = (int)(elapsed % 60);
            min = (int)((elapsed / 60) % 60);
            hour = (int)(elapsed / 3600);

            time[0] = sec;
            time[1] = min;
            time[2] = hour;


            timerOn = false;
        }










        return time;
	}


  
}
 


