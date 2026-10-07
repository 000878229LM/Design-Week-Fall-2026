using UnityEngine;
using TMPro;

public class TimerMechanics : MonoBehaviour
{
    public static bool temp = false; // temp
    bool timer = false;
    public static bool start = false;
    float timerDuration = 10;

    public TMP_Text gameTimer;

    void Start()
    {
        
    }

    void Update()
    {
        Timer();
    }

    void Timer()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            temp = true;
            timer = true;
        }

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

        gameTimer.text = timerDuration.ToString();
    }
}
