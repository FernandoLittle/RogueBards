﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneT : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TBattle()
    {
        SceneManager.LoadScene("Select");
    }
    public void AhShitHereWeGoAgain()
    {
        SceneManager.LoadScene("Adventure");
    }
}
