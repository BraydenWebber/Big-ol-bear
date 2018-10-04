﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int Score;

    Text ScoreText;

    //Use this for initialization
    private void Start()
    {
        ScoreText = GetComponent<Text>();

        Score = 0;

    }

    //This update is called once per frame
    void Update()
    {
        if (Score < 0)
            Score = 0;

        ScoreText.text = " " + Score;

    }

    public static void AddPoints(int PointsToAdd)
    {
        Score += PointsToAdd;



    }
}