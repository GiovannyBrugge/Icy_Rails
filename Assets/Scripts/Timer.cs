using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
  
    private float timerValue = 20;
    public Text timeText;

    void Update()
    {
        if (timerValue > 0)
        {
            timerValue -= Time.deltaTime;
        }
        else
        {
            timerValue = 0;
        }

        DisplayTime(timerValue);
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float milliseconds = timeToDisplay % 1 * 1000;

        if (timerValue <= 10 && timerValue>= 3) {
            timeText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
            timeText.color = Color.yellow;

        }
        else if (timerValue <= 3){
            timeText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
            timeText.color = Color.red;
        }
        else
        {
            timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            timeText.color = Color.white;
        }
    }
}
