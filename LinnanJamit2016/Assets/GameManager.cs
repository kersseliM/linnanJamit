﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{

    public int Score;

    GameManager Instance;
    // Use this for initialization
    void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddScore(int _score)
    {
        Score+=_score;
    }


}
