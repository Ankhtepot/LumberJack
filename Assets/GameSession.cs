﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    // configuration parameters
    [Range(0, 2)] [SerializeField] float gameSpeed = 1f;
    //[SerializeField] int pointsPerBlockDestoryed = 10;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] bool isAutoplayEnabled;


    // state variable
    [SerializeField]  int currentScore = 0;

    private static GameSession gameStatus = null;

    private void Awake()
    {
        if (gameStatus == null)
        {
            gameStatus = this;
        }
        else if (gameStatus != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start()
    {
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;            // 1f - regular time scale
    }

    public void AddPointsToScore(int pointsPerBlockDestoryed)
    {
        currentScore += pointsPerBlockDestoryed;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + currentScore.ToString();
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }

    public bool IsAutoPlayEnabled()
    {
        return isAutoplayEnabled;
    }

    public int GetCurrentScore()
    {
        return currentScore;
    }
}
