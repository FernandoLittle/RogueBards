﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RelicSystem : MonoBehaviour
{
    public A A;
    public F F;
    public D D;
    public List<int> Relics;
    public List<GameObject> RelicAllyG;
    public List<GameObject> RelicEnemyG;
    public List<Image> RelicAlly;
    public List<Image> RelicEnemy;
    public List<RelicItem> RelicItemAlly;
    public List<RelicItem> RelicItemEnemy;
    public Relic teste;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetRelic()
    {

        Relics.Clear();
        try
        {
            for (int x = 0; x < StaticPlayer.RelicsAlly.Count; x = x + 1)
            {
                Relics.Add(StaticPlayer.RelicsAlly[x]);
            }
        }
        catch
        {
            Debug.Log("SemRelíquia");
        }
        //AddRelicEnemytoo

        


    }
    public void AddRelic(int a, int player, int b)
    {
        for (int x = 0; x < A.decklist.deck[player].card[b].Relics.Count; x = x + 1)
        {
            A.zoneid[a].Relics.Add(A.decklist.deck[player].card[b].Relics[x]);
        }
    }
    public void AddRelic2()
    {
        SetRelic();
        for (int x = 0; x < Relics.Count; x = x + 1)
        {
            A.zoneid[4].Relics.Add(Relics[x]);
        }
        SetRelicSprite();

    }
    public void GeralRelic(int a)
    {
        try
        {
            StaticPlayer.RelicsAlly.Add(a);
        }
        catch
        {
            Debug.Log("Sem Relíquia");
        }

    }
    public void BonusSentimento(int ally, int enemy, int attack)
    {
        if (F.Zone[ally].sentimento==0)
        {
            Debug.Log("to calmo");
            if (F.Zone[ally].ManaSpend < 4)
            {
                Debug.Log("calminho");
                RelicSentimento(ally);
            } 
        }
        if (F.Zone[ally].sentimento == 1)
        {
            Debug.Log("TO com medo");
            if (attack == 0)
            {
                Debug.Log(F.Zone[ally].idzone1 + "atacando");
                if (F.Zone[ally].ManaSpend < 4)
                {
                    Debug.Log("medinho");
                    RelicSentimento(ally);
                }
            }
            if (attack == 1)
            {
                Debug.Log(F.Zone[ally].idzone1 + "defendendo");
                if (F.Zone[ally].ManaSpend > 6)
                {
                    Debug.Log("Medinho");
                    RelicSentimento(ally);
                }
            }
        }
        if (F.Zone[ally].sentimento == 2)
        {
            Debug.Log("To puto");
            if (attack == 0)
            {
                Debug.Log(F.Zone[ally].idzone1 + "atacando");
                if (F.Zone[ally].ManaSpend > 6)
                {
                    Debug.Log("putao");
                    RelicSentimento(ally);
                }
            }
            if (attack == 1)
            {
                Debug.Log(F.Zone[ally].idzone1 + "defendendo");
                if (F.Zone[ally].ManaSpend < 4)
                {
                    Debug.Log("putao");
                    RelicSentimento(ally);
                }
            }
        }
        if (F.Zone[ally].sentimento == 3)
        {
            Debug.Log("odio");
            if (F.Zone[ally].ManaSpend > 6)
            {
                Debug.Log("Odiador");
                RelicSentimento(ally);
            }
        }
        if (F.Zone[ally].sentimento == 4)
        {
            if (F.Zone[ally].ManaSpend == 0 )
            {
                RelicSentimento(ally);
            }
        }
    }
    public void RelicSentimento(int ally)
    {
        for (int x = 0; x < F.Zone[ally].Relics.Count; x = x + 1)
        {
            if (F.Zone[ally].Relics[x]==1)//WillianSword
            {
                F.UpAttributeRelic(1, 1, true,1);//Aumenta ataque em 1 permanentemente, idrelic==1
            }
        }
    }
    public void SetRelicSprite()
    {
        for (int x = 0; x < A.zoneid[4].Relics.Count; x = x + 1)
        {
            RelicAllyG[x].SetActive(true);

            RelicAlly[x].sprite = D.Relics[A.zoneid[4].Relics[x]].SpriteRelic;
            RelicItemAlly[x].RelicId = D.Relics[A.zoneid[4].Relics[x]].IdRelic;
        }
        for (int x = 0; x < A.zoneid[1].Relics.Count; x = x + 1)
        {
            RelicEnemyG[x].SetActive(true);
            RelicItemEnemy[x].RelicId = D.Relics[A.zoneid[1].Relics[x]].IdRelic;
            RelicEnemy[x].sprite = D.Relics[A.zoneid[1].Relics[x]].SpriteRelic;
        }
    }
}