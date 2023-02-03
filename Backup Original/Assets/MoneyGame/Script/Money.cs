using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{

    public int Powerclick;
    public int PowerIdle;
    public Text MoneyText;
    public Animator MoneyAnime;
    public Dio Dio;
    public int timer;
    public void click()
    {
        Powerclick = (Dio.Upgrades[9] + 1) * (Dio.Upgrades[11]*2 + 1);
        MoneyAnime.Play("Dinherin");
        Dio.money += Powerclick;
        TextMoney();
        Dio.Dialogue(21, 1, 2);
        if (Dio.money > 50)
        {
            Dio.Dialogue(8, 0, 0);
        }
        if (Dio.money > 500)
        {
            Dio.Dialogue(29, 30, 31);
        }
    }
    public void TextMoney()
    {
        if (Dio.money < 1000)
        {
            MoneyText.text = "$" + Dio.money.ToString();
        }
        else if (Dio.money < 1000000)
        {
            MoneyText.text = "$" + (Dio.money/1000).ToString() + " K";
        }
        else if (Dio.money < 1000000000)
        {
            MoneyText.text = "$" + (Dio.money / 1000000).ToString() + " MI";
        }
        else
        {
            Dio.money = 1000000000;
            MoneyText.text = "MAX";
        }
    }
    public void IdlePower()
    {
        PowerIdle = (Dio.Upgrades[10]) * (Dio.Upgrades[12] * 2 + 1);
        Dio.money += PowerIdle;
        TextMoney();
    }
    private void FixedUpdate()
    {
        timer += 1;
        if (timer > 10000)
        {
            timer = 0;
        }
        if (timer % 10==0)
        {
            IdlePower();
            Dio.SaveMoney(Dio.money);
        }

        if (Dio.Hihi.isPlaying== false)
            {
                if (Dio.Upgrades[16] > 0)
                {

                        Dio.AudioControler();
                    
                }
               
            }
        
    }
}
