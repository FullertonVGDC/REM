﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startButtonControl : MonoBehaviour {

    public void StartButton()
    {
        SceneManager.LoadScene("gameScene",LoadSceneMode.Single);
    }
}