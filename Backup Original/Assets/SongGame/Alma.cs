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
        PlayerPrefs.SetInt("Batalha", 1);
        PlayerPrefs.SetInt("Tale", 2);
        if (ScoreJudge.RealScore > 3000)
        {
            PlayerPrefs.SetInt("IdList", 3);
        }
        else if (ScoreJudge.RealScore > 2000)
        {
            PlayerPrefs.SetInt("IdList", 2);
        }
        else
        {
            PlayerPrefs.SetInt("IdList", 1);
        }




        SceneManager.LoadScene("Tales");
    }
}
