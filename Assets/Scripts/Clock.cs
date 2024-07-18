using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.UIElements;

public class Clock : MonoBehaviour
{
    public Transform secondHand, minuteHand, hourHand;

    private int oldSeconds;
    private float targetRotation_second, targetRotation_minute, targetRotation_hour;

    void Update()
    {
        int seconds = int.Parse(System.DateTime.Now.ToString("ss"));

        if (seconds != oldSeconds)
        {
            UpdateTimer(seconds);
        }
        oldSeconds = seconds;
    }

    private void UpdateTimer(int seconds)
    {

        int minuteInt = int.Parse(System.DateTime.Now.ToString("mm"));
        int hourInt = int.Parse(System.DateTime.Now.ToString("hh"));
        Debug.Log(hourInt + ":" + minuteInt + ":" + seconds);

        targetRotation_second = 360f / 60f * seconds;
        targetRotation_minute = 360f / 60f * minuteInt;
        targetRotation_hour = 360f / 12f * hourInt + 360f / 12f / 60f * minuteInt;

        HandleHand(secondHand, targetRotation_second);
        HandleHand(minuteHand, targetRotation_minute);
        HandleHand(hourHand, targetRotation_hour);
    }

    private void HandleHand(Transform hand, float targetRotation)
    {
        if (hand == null)
        {
            return;
        }

        hand.localRotation = Quaternion.Euler(targetRotation + 90f, 0f, -90f);
    }

}
