using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Day : MonoBehaviour
{
    public int day;
    public TalesVariables TalesVariables;
    public void SelectDay()
    {
        day = StaticPlayer.Day;
        //teste
        //Sincroniza 3 Controlers
        if (day == 1)
        {
           RandomIntro();
        }
        if (day == 2)
        {
            RandomBard();
        }
        if (day == 3)
        {
            FightCrime(2);
        }
        if (day == 4)
        {

            Minigame();
        }
        if (day == 5)
        {
            Happiness();
        }
        if (day == 6)
        {

        }
        if (day == 7)
        {

        }
        if (day == 8)
        {

        }
        if (day == 9)
        {

        }
        if (day == 10)
        {

        }

        SaveDay();

        day += 1;
        StaticPlayer.Day = day;
    }
    public void SelectDayAssassin()
    {
        day = StaticPlayer.Day;
        //teste
        //Sincroniza 3 Controlers
        if (day == 1)
        {
            FirstTale();
            //RandomIntroAS();
        }
        if (day == 2)
        {
            DocumentoAS();
        }
        if (day == 3)
        {
            RandomMaduin();
        }
        if (day == 4)
        {

            FightCrimeAS(3);
        }
        if (day == 5)
        {
            MinigameAS();
        }
        if (day == 6)
        {
            HappinessAS();
        }
        if (day == 7)
        {

        }
        if (day == 8)
        {

        }
        if (day == 9)
        {

        }
        if (day == 10)
        {

        }

        SaveDay();

        day += 1;
        StaticPlayer.Day = day;
    }
    public void RandomIntro()
    {
        int caos;
        caos = Random.Range(0, TalesVariables.TalesIntro.Count -2);
        TalesVariables.Tales = TalesVariables.TalesIntro;
        TalesVariables.SetTale(caos);
        TalesVariables.Index += 1;
    }
    public void RandomBard()
    {
        int caos;
        caos = Random.Range(0, 3);
        TalesVariables.Tales = TalesVariables.TalesWilliamWBard1;
        TalesVariables.SetTale(caos);
        TalesVariables.Index += 1;
    }
    public void FightCrime(int a)
    {
        TalesVariables.Tales = TalesVariables.TalesAction;
        TalesVariables.SetTale(a);
    }
    public void Minigame()
    {
        TalesVariables.Tales = TalesVariables.TalesMinigames;
        TalesVariables.SetTale(1);
    }
    public void Happiness()
    {
        TalesVariables.Tales = TalesVariables.TalesMinigames;
        TalesVariables.SetTale(2);
    }
    // Assassin
    public void RandomIntroAS()
    {
        int caos;
        caos = Random.Range(0, TalesVariables.TalesIntroAS.Count-1);
        TalesVariables.Tales = TalesVariables.TalesIntroAS;
        TalesVariables.SetTale(caos);
        TalesVariables.Index += 1;
    }
    public void FirstTale()
    {
        TalesVariables.Tales = TalesVariables.FirstTale;
        TalesVariables.SetTale(0);
        TalesVariables.Index += 1;
    }
    public void RandomMaduin()
    {
        int caos;
        TalesVariables.Tales = TalesVariables.TalesWilliamMaduin;
        caos = Random.Range(0, TalesVariables.Tales.Count);
        TalesVariables.SetTale(caos);
        TalesVariables.Index += 1;
    }
    public void FightCrimeAS(int a)
    {
        TalesVariables.Tales = TalesVariables.TalesAction;
        TalesVariables.SetTale(a);
    }
    public void MinigameAS()
    {
        int caos;
        TalesVariables.Tales = TalesVariables.TalesMinigamesAS;
        caos = Random.Range(0, TalesVariables.Tales.Count);
        TalesVariables.SetTale(caos);
        TalesVariables.Index += 1;
    }
    public void HappinessAS()
    {
        TalesVariables.Tales = TalesVariables.TalesCustonRouteAS;
        TalesVariables.SetTale(28);
    }
    public void DocumentoAS()
    {
        TalesVariables.Tales = TalesVariables.TalesCustonRouteAS;
        TalesVariables.SetTale(29);
    }
    public void SaveDay()
    {
        PlayerPrefs.SetInt("PlayerId", StaticPlayer.PlayerId[0]);


        PlayerPrefs.SetInt("Day", StaticPlayer.Day);


        PlayerPrefs.SetInt("Skill1", StaticPlayer.TrueAttack[0]);
        PlayerPrefs.SetInt("Skill2", StaticPlayer.FakeAttack[0]);
        PlayerPrefs.SetInt("Skill3", StaticPlayer.Block[0]);
        PlayerPrefs.SetInt("Skill4", StaticPlayer.CounterAttack[0]);

        PlayerPrefs.SetInt("Relic1", StaticPlayer.Day);
        PlayerPrefs.SetInt("Relic2", StaticPlayer.Day);
        PlayerPrefs.SetInt("Relic3", StaticPlayer.Day);
        PlayerPrefs.SetInt("Relic4", StaticPlayer.Day);
        PlayerPrefs.SetInt("Relic5", StaticPlayer.Day);

        PlayerPrefs.SetInt("Relic1", 0);
        PlayerPrefs.SetInt("Relic2", 0);
        PlayerPrefs.SetInt("Relic3", 0);
        PlayerPrefs.SetInt("Relic4", 0);
        PlayerPrefs.SetInt("Relic5", 0);
        for (int x = 0; x < StaticPlayer.RelicsAlly.Count; x = x + 1)
        {
            if (x==0)
            {
                PlayerPrefs.SetInt("Relic1", StaticPlayer.RelicsAlly[x]);
            }
            if (x == 1)
            {
                PlayerPrefs.SetInt("Relic2", StaticPlayer.RelicsAlly[x]);
            }
            if (x == 2)
            {
                PlayerPrefs.SetInt("Relic3", StaticPlayer.RelicsAlly[x]);
            }
            if (x == 3)
            {
                PlayerPrefs.SetInt("Relic4", StaticPlayer.RelicsAlly[x]);
            }
            if (x == 4)
            {
                PlayerPrefs.SetInt("Relic5", StaticPlayer.RelicsAlly[x]);
            }
        }
 
    }

}
