using System.Collections;
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
    public void AddRelic()
    {

        Debug.Log(A.Zone[5].idcard1);
        for (int x = 0; x < D.Chara[A.Zone[5].idcard1].Relics.Count; x = x + 1)
        {
            A.Zone[5].Relics.Add(D.Chara[A.Zone[5].idcard1].Relics[x]);
        }
        for (int x = 0; x < D.Chara[A.Zone[2].idcard1].Relics.Count; x = x + 1)
        {
            A.Zone[2].Relics.Add(D.Chara[A.Zone[2].idcard1].Relics[x]);
        }

        // for (int x = 0; x < A.decklist.deck[player].card[b].Relics.Count; x = x + 1)
        //{
        //    A.zoneid[a].Relics.Add(A.decklist.deck[player].card[b].Relics[x]);
        // }

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
        F.Zone[ally].SentimentalBool = false;
        if (F.Zone[ally].sentimento==0)
        {

            if (F.Zone[ally].ManaSpend < 5)
            {

                BonusSentimento1(ally);
            } 
        }
        if (F.Zone[ally].sentimento == 1)
        {

            if (F.Zone[ally].ManaSpend >= 5)
            {

                BonusSentimento1(ally);
            }
        }
        if (F.Zone[ally].sentimento == 4)
        {
            if (F.Zone[ally].ManaSpend == 0 )
            {
                BonusSentimento1(ally);
            }
        }
    }
    public void BonusSentimento1(int ally)
    {

        F.Zone[ally].SentimentalBool = true;
        F.Zone[ally].SentimentalInt += 1;
        RelicSentimento(ally);
        A.RelicEffects.DoubleFeeling(ally);
    }
    // Tipos de efeitos************************************************************************************************************
    public void RelicSentimento(int ally)
    {

        A.RelicEffects.SentimentalBonus(ally);
    }
    // Tipos de efeitos************************************************************************************************************
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
    public void SetRelicX()
    {

        if (A.StaticData.RelicsAlly.Count > 0)
        {
          //  A.Zone[5].Relics.Add(A.StaticData.RelicsAlly[0]);
        }

    }
}
