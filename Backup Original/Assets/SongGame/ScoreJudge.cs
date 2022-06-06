using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreJudge : MonoBehaviour
{
    public Alma Alma;
    public int oldscore;
    public int newscore;
    public int score;
    public int scoregreat;
    public int scoregood;
    public GameObject Great;
    public GameObject Good;
    public GameObject Bad;
    public int RealScore;
    public Text ScoreText;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        oldscore = Alma.Pontuation;
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        newscore = Alma.Pontuation;
        Judgement();
    }
    public void Judgement()
    {
        Great.SetActive(false);
        Good.SetActive(false);
        Bad.SetActive(false);
        score = newscore - oldscore;
        if (score > scoregreat)
        {
            Great.SetActive(true);
            SetScore(200);
        }
        else
        {
            if (score > scoregood)
            {
                Good.SetActive(true);
                SetScore(100);
            }
            else
            {
                Bad.SetActive(true);
            }
        }

    }
    public void SetScore(int scor)
    {
        RealScore += scor;
        ScoreText.text = "Score: " + (RealScore).ToString();
    }
}
