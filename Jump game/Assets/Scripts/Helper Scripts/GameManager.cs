﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    void Awake() {
        if (instance == null)
            instance = this;
    }//awake

    public void RestartGame() {
        SceneManager.LoadScene("EndGame");
    }//restart




} // class




