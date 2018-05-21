using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    const float degreesPerHour = 30f;
    const float degreesPerMinute = 6f;
    const float degreesPerSecond = 6f;
    public Transform hoursTransform, minutesTransform, secondsTransform;
    private void Awake()
    {
        hoursTransform.localRotation = Quaternion.Euler(0f, DateTime.Now.Hour * degreesPerHour, 0f);
        minutesTransform.localRotation = Quaternion.Euler(0f, DateTime.Now.Minute * degreesPerMinute, 0f);
        secondsTransform.localRotation = Quaternion.Euler(0f, DateTime.Now.Second * degreesPerSecond, 0f);
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
