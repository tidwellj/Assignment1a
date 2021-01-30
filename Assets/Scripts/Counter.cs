using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Counter : MonoBehaviour
{
    public float timeLeft = 3.0f;
    public Text startText; // used for showing countdown from 3, 2, 1 


    void Update()
    {
        timeLeft -= Time.deltaTime;
        startText.text = (timeLeft).ToString("0");
        if (timeLeft < 0)
        {
            startText.text = ("");
            
        }
    }
}