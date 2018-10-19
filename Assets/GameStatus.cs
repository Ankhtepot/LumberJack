﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    // configuration parameters
    [Range(0,2)][SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlockDestoryed = 10;


    // state variable
    [SerializeField] int currentScore = 0;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;            // 1f - regular time scale
    }

    public void AddPointsToScore()
    {
        currentScore += pointsPerBlockDestoryed;
    }
}
