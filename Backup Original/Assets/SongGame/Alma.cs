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
    // Start is called before the first frame update

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
        }
        if (period != 0 && Starto == true)
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
    public void Spawn()
    {

        GameObject Notinha = Instantiate(Nota) as GameObject;
        positionY = Random.Range(MinY, MaxY);
        Notinha.transform.position = new Vector2(positionX, positionY);
    }
    public void TrigerYes()
    {
        Triger += 1;
    }
    public void TrigerNo()
    {
        Triger -= 1;
    }
    public void END()
    {
        int buda;
        Idle = PlayerPrefs.GetInt("Idle");
        if (Idle == 1)
        {
      
            if (ScoreJudge.RealScore > 3000)
            {
                PlayerPrefs.SetInt("Tale", 2);
            }
            else if (ScoreJudge.RealScore > 2000)
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
                GodCube.TakeScreenshot("Money");
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
            }
            else if (ScoreJudge.RealScore > 2000)
            {
                PlayerPrefs.SetInt("Tale", 1);
            }
            else
            {
                PlayerPrefs.SetInt("Tale", 0);
            }



            GodCube.TakeScreenshot("Tales");
            //SceneManager.LoadScene("Tales");
        }

       
    }
}
