﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        gameManager.PlayTheGame();
    }
}
