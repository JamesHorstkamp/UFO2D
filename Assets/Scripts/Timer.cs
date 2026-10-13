using UnityEngine;
using TMPro;
using UnityEngine.Rendering;
using System;
using UnityEngine.SocialPlatforms.Impl;
public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI winText;
    [SerializeField] float maxScore;
    int score = 0;


    void Update()
    {
        if (maxScore > 0)
        { 
            maxScore -= Time.deltaTime;

            
        }
        else if (maxScore < 0)
        {
            maxScore = 0;
        }

        int score = Mathf.RoundToInt(maxScore);

        winText.text = string.Format("CONGRADULATIONS, YOU WON!!! YOUR SCORE IS {0}", score);

    }
}
