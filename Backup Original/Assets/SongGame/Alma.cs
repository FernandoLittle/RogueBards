using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Alma : MonoBehaviour
{
    public int Triger;
    public int Pontuation;
    public GameObject Nota;
    public int timer;
    public int period;
    public int positionX;
    public float positionY;
    public float MaxY;
    public float MinY;
    public bool Starto;
    public ScoreJudge ScoreJudge;
    public int Idle;
    public GodCube GodCube;//x
    public bool end;
    public Transform ParentTransform;
    public GameObject ParentTransformObject;
    public GameObject WrongAnswerGO;
    public GameObject CorrectAnswerGO;
    public GameObject UltraCorrectAnswerGO;
    public GameObject DarkEnd;


    // Start is called before the first frame update

    private void Start()
    {
        PlayerPrefs.SetInt("IntCena", 3);
    }
    private void FixedUpdate()
    {
        
        timer += 1;
        if (timer > 100 && Starto==false)
        {
            Starto = true;
        }
        if (timer > 2000)
        {
            END();
            timer = 0;
            end = true;

        }
        if (period != 0 && Starto == true && end==false)
        {
            if (timer % period == 0)
            {
                Spawn();
            }
        }

        if (Triger >= 1)
        {
            ScoreJudge.SetScore(1);
            Pontuation += 1;
        }
    }
    public void CorrectAnswer()
    {
        CorrectAnswerGO.SetActive(true);
    }
    public void UltraCorrectAnswer()
    {
        UltraCorrectAnswerGO.SetActive(true);
    }
    public void WrongAnswer()
    {
        WrongAnswerGO.SetActive(true);
    }
    public void Spawn()
    {
      
        GameObject Notinha = Instantiate(Nota,ParentTransform) as GameObject;
        positionY = Random.Range(MinY, MaxY);
        Notinha.transform.localPosition = new Vector2(positionX, positionY);
       
    }
    public void TrigerYes()
    {
        Triger += 1;
    }
    public void TrigerNo()
    {
        Triger -= 1;
    }
    public void Cubinho() 
    {

        GodCube.TakeScreenshot("Tales"); ;
    }

    public void END()
    {
        DarkEnd.SetActive(true);
        int buda;
        Idle = PlayerPrefs.GetInt("Idle");
        if (Idle == 1)
        {
      
            if (ScoreJudge.RealScore > 3000)
            {
                UltraCorrectAnswer();
                PlayerPrefs.SetInt("Tale", 2);
            }
            else if (ScoreJudge.RealScore > 2000)
            {
                PlayerPrefs.SetInt("Tale", 1);
                CorrectAnswer();
            }
            else
            {
                PlayerPrefs.SetInt("Tale", 0);
                WrongAnswer();
            }
            buda = PlayerPrefs.GetInt("Buda");
            if (buda == 1)
            {
                GodCube.TakeScreenshot("Adventure");
                //SceneManager.LoadScene("Adventure");
            }
            else
            {
                GodCube.TakeScreenshot("Adventure");
                //SceneManager.LoadScene("Money");
            }
        }
        else
        {
            PlayerPrefs.SetInt("Batalha", 1);
            PlayerPrefs.SetInt("IdList", 2);
            if (ScoreJudge.RealScore > 3000)
            {
                PlayerPrefs.SetInt("Tale", 2);
                UltraCorrectAnswer();
            }
            else if (ScoreJudge.RealScore > 2000)
            {
             
                PlayerPrefs.SetInt("Tale", 1);
                CorrectAnswer();
            }
            else
            {
                PlayerPrefs.SetInt("Tale", 0);
                WrongAnswer();
            }



            
            ParentTransformObject.SetActive(false);
            //SceneManager.LoadScene("Tales");
        }

       
    }
}
