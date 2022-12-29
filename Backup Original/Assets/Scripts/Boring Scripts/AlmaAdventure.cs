﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlmaAdventure : MonoBehaviour
{
    public List<GameObject> Play;
    public List<GameObject> Adventure;
    public static int IntroCount = 0;
   


    private void Start()
    {
        int a;
        a= PlayerPrefs.GetInt("Aventura");
        //Debug.Log(IntroCount);
        // if (IntroCount == 0)
        //{
        if (a == 1)
        {
            AdventureActive();
            PlayerPrefs.SetInt("Aventura", 0);
        }
        else
        {
            PlayActive();
        }
        
      //  }
      //  if (IntroCount > 0)
       // {
          //  AdventureActive();
      //  }
       // IntroCount += 1;
    }
    public void PlayActive()
    {
        for (int x = 0; x < Adventure.Count; x = x + 1)
        {
            Adventure[x].SetActive(false);
        }
        for (int x = 0; x < Play.Count; x = x + 1)
        {
            Play[x].SetActive(true);
        }
    }
    public void AdventureActive()
    {
        for (int x = 0; x < Play.Count; x = x + 1)
        {
            Play[x].SetActive(false);
        }

        for (int x = 0; x < Adventure.Count; x = x + 1)
        {
            Adventure[x].SetActive(true);
        }
    }
    public void PlayGo()
    {
        int b;
        b= PlayerPrefs.GetInt("Intro0");
        if (b == 1)
        {
            SceneManager.LoadScene("Cubo");
        }
        else
        {
            SceneManager.LoadScene("Money");
        }
  
    }

}
