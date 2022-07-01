using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelicEffects : MonoBehaviour
{
    public A A;
    public D D;
    public F F;
    public Generic Generic;

    public void StartEffectRelic()
    {
        for (int x = 2; x < 6; x = x + 3)
        {

            for (int w = 1; w < A.Zone[w].Relics.Count; w = w + 1)
            {
                if (A.Zone[x].Relics[w] == 11)//Colar Shuá
                {

                    A.Zone[x].Lyoko[0] += 3;
                }
                if (A.Zone[x].Relics[w] == 10)//ManaPotion
                {

                    AddStatusRelic(2, x);
                }
                if (A.Zone[x].Relics[w] == 6)//LyokoTower
                {

                    AddStatusRelic(4, x);
                }
                if (A.Zone[x].Relics[w] == 7)//Óculos Akashicos
                {

                    AddStatusRelic(3, x);
                }
            }
        }
    }
    public void EndTurnEffectRelic(int ally)
    {



        for (int w = 1; w < A.Zone[w].Relics.Count; w = w + 1)
        {
            if (A.Zone[ally].Relics[w] == 3)//Flor Shuá
            {

                if (A.Zone[ally].Lyoko[0] >= 15)
                {
                    F.UpAttributeRelic(3, 0, true, 3);
                }
            }
            if (A.Zone[ally].Relics[w] == 5)//Code Lyoko
            {

                if (Generic.HaveInt(A.Zone[ally].status, 4))
                {
                    F.UpAttributeRelic(2, 0, true, 5);
                }
            }
        }

    }
    public void DoubleFeeling(int ally)//Mana Drugs
    {
        if (Generic.HaveInt(F.Zone[ally].Relics, 9))
        {
            A.RelicSystem.RelicSentimento(ally);
        }
    }
    public void ChangeFellingRelic(int ally)
    {
        if(Generic.HaveInt(F.Zone[ally].Relics, 4))//Shuá Coração
        {

            A.Zone[ally].sentimento = 4;
        }

    }
    public void ChangeWisdonRelic()
    {

    }
    public void SentimentalBonus(int ally)
    {
        if (Generic.HaveInt(F.Zone[ally].Relics, 1))//WillianSword
        {
            F.UpAttributeRelic(1, 1, true, 1);
        }
        if (Generic.HaveInt(F.Zone[ally].Relics, 4))//Shua Heart
        {
            F.AltruismRelic(4, 4);
        }
    }
    public void AddStatusRelic(int IdStatus, int idzone)
    {
        int indexo = 0;

        if (A.Zone[idzone].status[0] == 0)
        {
            indexo = 0;
        }
        else if (A.Zone[idzone].status[1] == 0)
        {
            indexo = 1;
        }
        else if (A.Zone[idzone].status[2] == 0)
        {
            indexo = 2;
        }
        else if (A.Zone[idzone].status[3] == 0)
        {
            indexo = 3;
        }

        A.Zone[idzone].status[indexo] = IdStatus;
        A.Zone[idzone].statos[indexo].id = IdStatus;
        A.Zone[idzone].statos[indexo].self.sprite = D.Status[IdStatus].Icon;
        A.Zone[idzone].statos[indexo].selfG.SetActive(true);

    }
}
