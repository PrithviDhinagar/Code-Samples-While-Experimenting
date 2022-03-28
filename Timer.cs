/* This was part of my internship project where I worked on In-game HUD where timer was required. 
 * The timer starts based on the number assigned in the startingTime variable and decreases as time passes and until it reaches 0. 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //Timer which displays the exact time of each round in decrements.
    float currentTime;
    public float startingTime = 90f; //the starting time is 90. 

    [SerializeField] Text countdownText;
    void Start()
    {
        currentTime = startingTime;
    }
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}