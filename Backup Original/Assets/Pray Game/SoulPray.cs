using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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


    private void Start()
    {
        language = PlayerPrefs.GetInt("Language");
        NextTale();


    }
    private void Update()
    {
        if (Pray2.text.Length == Pray.text.Length)
        {
            ResultPray();
        }
    }
    public void ResultPray()
    {
        if(Pray2.text== Pray.text)
        {
            score += 1;
            scoreT.text = score.ToString();
            UpPray();
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
