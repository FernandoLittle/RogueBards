using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SoulPray : MonoBehaviour
{
    public List<Tales> TalesL;
    public int indexTale;
    public Text Pray;
    public int indexWord;
    public string PrayT;
    public InputField Pray2;
    public int score;
    public Text scoreT;
    public int Gap1;
    public int Gap2;
    public GameObject Fade1;
    public GameObject Fade2;
    public Sprite PrayI1;
    public Sprite PrayI2;
    public Image BackGround;
    public int language;
    public GameObject Pray1GO;
    public int Timer;
    public int EndTimer;
    public int Idle;
    public GodCube GodCube;//x
    public bool endbool;
    public GameObject WrongAnswerGO;
    public GameObject CorrectAnswerGO;
    public GameObject UltraCorrectAnswerGO;
    public GameObject DarkEnd;
    public ParticleSystem ps;
    private void Start()
    {
        PlayerPrefs.SetInt("IntCena", 5);
        language = PlayerPrefs.GetInt("Language");
        NextTale();
        Timer = 0;


    }
    private void FixedUpdate()
    {
        Timer += 1;
        //if (Timer > EndTimer && endbool==false)
        //{
          //  EndPray();
           // endbool = true;
       // }
    }
    private void Update()
    {
        if (Pray2.text.Length == Pray.text.Length)
        {
            ResultPray();
        }
    }
    public void Cubinho()
    {
        GodCube.TakeScreenshot("Tales");
    }
    public void EndPray()
    {
        DarkEnd.SetActive(true);
        Idle = PlayerPrefs.GetInt("Idle");
        if (Idle == 1)
        {
            int buda;

            if (score >= Gap2)
            {
                PlayerPrefs.SetInt("Tale", 2);
            }
            else if (score >= Gap1)
            {
                PlayerPrefs.SetInt("Tale", 1);
            }
            else
            {
                PlayerPrefs.SetInt("Tale", 0);
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
            PlayerPrefs.SetInt("IdList", 8);
           
            
            if (score >= Gap2)
            {
                UltraCorrectAnswer();
                PlayerPrefs.SetInt("Tale", 2);
            }
            else if (score >= Gap1)
            {
                CorrectAnswer();
                PlayerPrefs.SetInt("Tale", 1);
            }
            else
            {
                WrongAnswer();
                PlayerPrefs.SetInt("Tale", 0);
            }


           
            //SceneManager.LoadScene("Tales");
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
    public void ResultPray()
    {
        if(Pray2.text== Pray.text)
        {
            ps.Play();
            score += 1;
            scoreT.text = score.ToString();
           // UpPray();
            NextWord();
        }
        else
        {
            NextWord();
        }
    }
    public void NextTale()
    {
        Pray2.ActivateInputField();
        SelectTale();
        indexWord = 0;
        if (indexTale >= TalesL.Count)
        {
            PlayerPrefs.SetInt("TaleI", 0);
            indexTale = 0;
        }
        if (language == 0)
        {
            Pray.text = TalesL[indexTale].Dialogue[indexWord];
            PrayT = TalesL[indexTale].Dialogue[indexWord];
        }
        if (language == 1)
        {
            Pray.text = TalesL[indexTale].DialogueBR[indexWord];
            PrayT = TalesL[indexTale].DialogueBR[indexWord];
        }
        if (language == 2)
        {
            Pray.text = TalesL[indexTale].DialogueES[indexWord];
            PrayT = TalesL[indexTale].DialogueES[indexWord];
        }

    }
    public void SelectTale()
    {
        try
        {
            indexTale = PlayerPrefs.GetInt("TaleI");
        }
        catch
        {
            PlayerPrefs.SetInt("TaleI", 0);
            indexTale = 0;
        }
    }
    public void NextWord()
    {
        Pray1GO.SetActive(false);
        Pray1GO.SetActive(true);
        indexWord += 1;
        Pray2.text = "";
        Pray2.ActivateInputField();
        if (language == 0)
        {


            if (indexWord >= TalesL[indexTale].Dialogue.Count)
            {
                indexTale += 1;
                PlayerPrefs.SetInt("TaleI", indexTale);
                NextTale();
            }
            else
            {

                    Pray.text = TalesL[indexTale].Dialogue[indexWord];
                    PrayT = TalesL[indexTale].Dialogue[indexWord];
                

            }
        }
        if (language == 1)
        {

            if (indexWord >= TalesL[indexTale].DialogueBR.Count)
            {
                indexTale += 1;
                PlayerPrefs.SetInt("TaleI", indexTale);
                NextTale();
            }
            else
            {


                    Pray.text = TalesL[indexTale].DialogueBR[indexWord];
                    PrayT = TalesL[indexTale].DialogueBR[indexWord];
                
            }


        }
        if (language == 2)
        {

            if (indexWord >= TalesL[indexTale].DialogueES.Count)
            {
                indexTale += 1;
                PlayerPrefs.SetInt("TaleI", indexTale);
                NextTale();
            }
            else
            {


                Pray.text = TalesL[indexTale].DialogueES[indexWord];
                PrayT = TalesL[indexTale].DialogueES[indexWord];

            }


        }

    }
    public void UpPray()
    {
        if (score >= Gap2)
        {
            Fade2.SetActive(true);
        }
        else if(score >= Gap1)
        {
            Fade1.SetActive(true);
        }
    }
    public void Background1()
    {
        BackGround.sprite = PrayI1;
    }
    public void Background2()
    {
        BackGround.sprite = PrayI2;
    }
}
