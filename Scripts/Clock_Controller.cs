using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock_Controller : MonoBehaviour
{
    [SerializeField] Transform Hour_Hand, Minute_Hand, Second_Hand;

    private const float Hourse_To_Degrees = 30f;
    private const float Minute_To_Degrees = 6f;
    private const float Secont_To_Degrees = 6f;

    private void Update()
    {
        var time = DateTime.Now;

        Hour_Hand.localRotation = Quaternion.Euler(0, Hourse_To_Degrees * time.Hour, 0);
        Minute_Hand.localRotation = Quaternion.Euler(0, Minute_To_Degrees * time.Minute, 0);
        Second_Hand.localRotation = Quaternion.Euler(0, Secont_To_Degrees * time.Second, 0);
    }
}
