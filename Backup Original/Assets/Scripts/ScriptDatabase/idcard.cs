using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idcard : MonoBehaviour
{
    public BuyCard Controler;
    public int id;
    public int cost;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Buy()
    {
        if (Controler.score >= cost)
        {
            Controler.CardsOw[id] = true;
            Controler.score -= cost;
            Controler.scoreT.text = Controler.score.ToString();
            Controler.idcard = id;
            Controler.Buy();
        }


    }
}
