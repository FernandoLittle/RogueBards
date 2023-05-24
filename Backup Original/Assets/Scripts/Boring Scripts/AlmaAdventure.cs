using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlmaAdventure : MonoBehaviour
{
    public List<GameObject> Play;
    public List<GameObject> Adventure;
    public static int IntroCount = 0;
    public GodCube GodCube;//x
    public GameObject IntroPlay;
    public GameObject IntroAdventure;
    public GameObject Continue;
    private void Start()
    {  
        int a;

        a = PlayerPrefs.GetInt("Aventura");
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
        int day;
        for (int x = 0; x < Adventure.Count; x = x + 1)
        {
            Adventure[x].SetActive(false);
        }
        for (int x = 0; x < Play.Count; x = x + 1)
        {
            Play[x].SetActive(true);
        }
        IntroPlay.SetActive(true);
        day = PlayerPrefs.GetInt("Day");
        if (day > 1)
        {
            Continue.SetActive(true);
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
        IntroAdventure.SetActive(true);
    }
    public void PlayGo()
    {
        PlayerPrefs.SetInt("Aventura", 1);
        int buda;
        int b;
        b= PlayerPrefs.GetInt("Intro0");
        if (b == 1)
        {
            GodCube.TakeScreenshot("Cubo");
            //SceneManager.LoadScene("Cubo");
        }
        else
        {
            buda = PlayerPrefs.GetInt("Buda");
            if (buda == 1)
            {
                GodCube.TakeScreenshot("Cubo");
                //SceneManager.LoadScene("Adventure");
            }
            else
            {

                GodCube.TakeScreenshot("Cubo");
                //SceneManager.LoadScene("Money");
            }
        }
        IntroPlay.SetActive(false);
        IntroAdventure.SetActive(false);
  
    }
    public void ContinueGo()
    {
        LoadDay();
        PlayerPrefs.SetInt("Aventura", 1);
        int buda;
        int b;
        b = PlayerPrefs.GetInt("Intro0");
        if (b == 1)
        {
            GodCube.TakeScreenshot("Tales");
            //SceneManager.LoadScene("Cubo");
        }
        else
        {
            buda = PlayerPrefs.GetInt("Buda");
            if (buda == 1)
            {
                GodCube.TakeScreenshot("Tales");
                //SceneManager.LoadScene("Adventure");
            }
            else
            {

                GodCube.TakeScreenshot("Tales");
                //SceneManager.LoadScene("Money");
            }
        }
        IntroPlay.SetActive(false);
        IntroAdventure.SetActive(false);

    }
    public void LoadDay()
    {
        int a;
        PlayerPrefs.SetInt("Batalha", 0);
        StaticPlayer.PlayerId[0]=PlayerPrefs.GetInt("PlayerId");

        StaticPlayer.Day = PlayerPrefs.GetInt("Day");

        StaticPlayer.TrueAttack[0] = PlayerPrefs.GetInt("Skill1");
        StaticPlayer.FakeAttack[0] = PlayerPrefs.GetInt("Skill2");
        StaticPlayer.Block[0] = PlayerPrefs.GetInt("Skill3");
        StaticPlayer.CounterAttack[0] = PlayerPrefs.GetInt("Skill4");


        StaticPlayer.RelicsAlly.Clear();

        a = PlayerPrefs.GetInt("Relic1");
        if (a != 0)
        {
            StaticPlayer.RelicsAlly.Add(a);
        }
        a = PlayerPrefs.GetInt("Relic2");
        if (a != 0)
        {
            StaticPlayer.RelicsAlly.Add(a);
        }
        a = PlayerPrefs.GetInt("Relic3");
        if (a != 0)
        {
            StaticPlayer.RelicsAlly.Add(a);
        }
        a = PlayerPrefs.GetInt("Relic4");
        if (a != 0)
        {
            StaticPlayer.RelicsAlly.Add(a);

        }
        a = PlayerPrefs.GetInt("Relic5");
        if (a != 0)
        {
            StaticPlayer.RelicsAlly.Add(a);
        }
    }
   

}
