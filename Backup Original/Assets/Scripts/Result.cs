using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    public int AllyLife;
    public int EnemyLife;
    public GameObject VictoryG;
    public GameObject DefeatG;
    public Text AllyLifeT;
    public Text EnemyLifeT;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetResult()
    {
        AllyLife = PlayerPrefs.GetInt("AllyLife");
        EnemyLife = PlayerPrefs.GetInt("EnemyLife");
        AllyLifeT.text = AllyLife.ToString();
        EnemyLifeT.text = EnemyLife.ToString();
        if(AllyLife>= EnemyLife)
        {
            Victory();
        }
        else
        {
            Defeat();
        }
    }
    public void Victory()
    {
        VictoryG.SetActive(true);
    }
    public void Defeat()
    {
        DefeatG.SetActive(true);
    }
}
