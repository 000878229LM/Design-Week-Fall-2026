using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    [SerializeField] private float startingTime = 60f;
    [SerializeField] private TMP_Text timerText;

    private float currentTime;

    private void Start()
    {
        currentTime = startingTime;
        UpdateTimerDisplay();
    }

    private void Update()
    {
        if (currentTime <= 0f)
        {
            currentTime = 0f;
            UpdateTimerDisplay();
            return;
        }

        currentTime -= Time.deltaTime;
        UpdateTimerDisplay();
    }

    private void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime - minutes * 60);
        int milliseconds = (int)((currentTime - (int)currentTime) * 1000);

        string gameTimeString = string.Format(
            "{0:00}:{1:00}.{2:000}",
            minutes,
            seconds,
            milliseconds
        );

        timerText.text = gameTimeString;
    }

    public void AddTime(float timeToAdd)
    {
        currentTime += timeToAdd;
    }

    public float GetCurrentTime()
    {
        Debug.Log(currentTime);
        return currentTime;
    }
}