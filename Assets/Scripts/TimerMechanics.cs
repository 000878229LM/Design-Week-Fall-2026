using UnityEngine;
using TMPro;
using Unity.Mathematics;

public class TimerMechanics : MonoBehaviour
{
    public static bool temp = false; // temp
    bool timer = false;
    public static bool start = false;
    float timerDuration = 10;

    public TMP_Text gameTimer;

    void Start()
    {
        temp = true;
        timer = true;
    }

    void Update()
    {
        Timer();
    }

    void Timer()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    temp = true;
        //    timer = true;
        //}

        if (timer)
        {
            timerDuration -= Time.deltaTime;
        }

        if (timerDuration <= 0)
        {
            timer = false;
            timerDuration = 0;
            start = true;
        }

        
        gameTimer.text = (math.round(timerDuration * 10) / 10).ToString();
    }
}
