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
            //Não precisa de animação, só programar na mão

            for (int w = 0; w < A.Zone[x].Relics.Count; w = w + 1)
            {
                if (A.Zone[x].Relics[w] == 11)//Coelho de Shuá
                {

                    A.Zone[x].Lyoko[0] += 3;
                }
                if (A.Zone[x].Relics[w] == 7)//Corvo Akashico
                {
                    Debug.Log("Corvo Akashico, perde a defesa e causa 4 de dano");
                    A.Zone[x].Lyoko[2] = 0;
                    A.Zone[Generic.Enemy(x)].Lyoko[0] -= 4;
                }
                if (A.Zone[x].Relics[w] == 8)//Registros Akashicos
                {
                    Debug.Log("Registros Akashicos, perde o ataque e causa 6 de dano");
                    A.Zone[x].Lyoko[1] = 0;
                    A.Zone[Generic.Enemy(x)].Lyoko[0] -= 6;
                }
                if (A.Zone[x].Relics[w] == 14)//Lyoko Wolf
                {
                    Debug.Log("Lyoko Wolf, Receba 4 de dano verdadeiro no início da partida, ganhe 2 de vida no fim de cada turno.");
                    A.Zone[x].Lyoko[0] -= 4;
                }
                if (A.Zone[x].Relics[w] == 22)//Bard Relic
                {
                    Debug.Log("Eu não vou programar, fodace");
                }
                if (A.Zone[x].Relics[w] == 23)//Maduin Relic
                {
                   // Debug.Log("Maduin Relic: Ataque=0");
                   // A.Zone[x].Lyoko[1] =0;
                }
                if (A.Zone[x].Relics[w] == 25)//Chaos 2
                {

                    Debug.Log("Chaos 2: Ganhe 4 ataque");
                    A.Zone[x].Lyoko[1] +=4;
                }
                if (A.Zone[x].Relics[w] == 26)//Chaos 3
                {

                    Debug.Log("Chaos 3: Ganhe 10 defesa");
                    A.Zone[x].Lyoko[2] += 10;
                }
                if (A.Zone[x].Relics[w] == 32)//Caixão
                {

                    Debug.Log("Caixão: Ganhe 1 de defesa");
                    A.Zone[x].Lyoko[2] += 1;
                }
                if (A.Zone[x].Relics[w] == 33)//Garrafa
                {

                    Debug.Log("Garrafa: Ganhe 1 de ataque");
                    A.Zone[x].Lyoko[1] += 1;
                }
            }
        }
    }
    public void EndTurnEffectRelic(int ally)
    {
        Debug.Log("End Turn Relic Effects "+ ally.ToString());



        for (int w = 0; w < A.Zone[ally].Relics.Count; w = w + 1)
        {
            if (A.Zone[ally].Relics[w] == 3)//Flor Shuá
            {

                if (A.Zone[ally].Lyoko[0] >= 15)
                {
                    Debug.Log("FlorShuá Relic");
                    F.UpAttributeRelic(3, 0, true, 3);
                }
            }
            if (A.Zone[ally].Relics[w] == 6)//Lyoko Tower
            {

                if (A.Zone[ally].Mana < A.Zone[Generic.Enemy(ally)].Mana)
                {
                    Debug.Log("LyokoTower Relic");
                    F.UpAttributeRelic(3, 1, true, 6);
                }
            }
            if (A.Zone[ally].Relics[w] == 12)//Árvore de Shuá
            {
                Debug.Log("árvore Akashica");

                F.AltruismRelic(3, 12);
                
            }
            if (A.Zone[ally].Relics[w] == 13)//Lyoko Warrior
            {


                if (A.Zone[ally].Lyoko[0] < 5)
                {
                    F.UpAttributeRelic(3, 0, true, 13);
                }

            }
            if (A.Zone[ally].Relics[w] == 14)//Lyoko Wolf
            {


                    F.UpAttributeRelic(2, 0, true, 14);
                Debug.Log("LyokoWolf Relic");

            }
            if (A.Zone[ally].Relics[w] == 15)//Concha Akashica
            {
               

                if (A.Zone[ally].Lyoko[2] < A.Zone[Generic.Enemy(ally)].Lyoko[2])
                {
                    int a;
                    a = A.Zone[Generic.Enemy(ally)].Lyoko[2]-A.Zone[ally].Lyoko[2];

                    F.TrueDamageRelic(a,15);
                    F.UpAttributeRelic(a, 2, true, 15);
                    Debug.Log("Akashic Conha Relic");
                }


            }
            if (A.Zone[ally].Relics[w] == 16)//Brinquedo Akashica
            {


                if (A.Zone[ally].Lyoko[1] < A.Zone[Generic.Enemy(ally)].Lyoko[1])
                {
                    int a;
                    a = A.Zone[Generic.Enemy(ally)].Lyoko[1] - A.Zone[ally].Lyoko[1];

                    F.TrueDamageRelic(a, 16);
                    F.UpAttributeRelic(a, 2, true, 16);
                    Debug.Log("Brinquedo akashico Relic");
                }


            }
            if (A.Zone[ally].Relics[w] == 17)//Mana Mind
            {

                if(A.turn== 3)
                {
                    Debug.Log("Mana Mind: Causa dano igual a quantidade de mana no último turno");
                    F.TrueDamageRelic(A.Zone[ally].Mana, 17);
                }


            }
            if (A.Zone[ally].Relics[w] == 18)//Mana Potion
            {
                Debug.Log("Mana Potion");
                F.TrueDamageAllyRelic(1, 18);
                F.UpManaRelic(2, 18);

            }
            if (A.Zone[ally].Relics[w] == 21)//Corn
            {
                if (A.Zone[ally].Mana==0)
                {
                    Debug.Log("Corn Relic");
                    F.UpManaRelic(2, 21);
                }

                

            }
            if (A.Zone[ally].Relics[w] == 24)//Chaos 1
            {
                //No fim da luta, ganhe 6 de vida
                if (A.turn == 3)
                {
                    if (A.Zone[ally].Lyoko[0] > 0)
                    {

                        F.UpAttributeRelic(6, 0, true, 24);
                    }
                    
                }



            }
            if (A.Zone[ally].Relics[w] == 25)//Chaos 2
            {
                //Perde 1 de ataque no fim do turno
                F.SacrificeAttributeRelic(1, 1, true, 25);
            }
            if (A.Zone[ally].Relics[w] == 26)//Chaos 3
            {

                //Defesa =0, ataque =20
                F.SacrificeAttributeRelic(A.Zone[ally].Lyoko[2], 2, true, 26);
                F.UpAttributeRelic((20- A.Zone[ally].Lyoko[1]),1,true,26);
            }
            if (A.Zone[ally].Relics[w] == 27)//Chaos 4
            {

                //Se você tiver mais vida que seu adversário, ganha 2 de mana no fim do turno.

                if (A.Zone[ally].Lyoko[0]> A.Zone[Generic.Enemy(ally)].Lyoko[0])
                {
                    F.UpManaRelic(2, 27);
                }

            }
            if (A.Zone[ally].Relics[w] == 28)//Chaos 5
            {

                //Se você tiver menos vida que seu adversário, ganha 2 de vida no fim do turno.

                if (A.Zone[ally].Lyoko[0] < A.Zone[Generic.Enemy(ally)].Lyoko[0])
                {
                    F.UpAttributeRelic(2,0,true,28);
                }

            }
            if (A.Zone[ally].Relics[w] == 29)//Chaos 6
            {

                //Se você tiver menos mana que seu adversário, ganha 2 de defesa no fim do turno.

                if (A.Zone[ally].Mana < A.Zone[Generic.Enemy(ally)].Mana)
                {
                    F.UpAttributeRelic(2, 2, true, 29);
                }

            }
            if (A.Zone[ally].Relics[w] == 30)//Chaos 7
            {

                //Se você tiver mais mana que seu adversário, ganha 2 de ataque no fim do turno.

                if (A.Zone[ally].Mana > A.Zone[Generic.Enemy(ally)].Mana)
                {
                    F.UpAttributeRelic(2, 1, true, 30);
                }

            }
            if (A.Zone[ally].Relics[w] == 31)//Chaos 8
            {

                //Se você você tiver mais que 7 de vida, ganhe 2 de vida no fim do turno.

                if (A.Zone[ally].Lyoko[0] > 7)
                {
                    F.UpAttributeRelic(2, 0, true, 31);
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
        if (Generic.HaveInt(F.Zone[ally].Relics, 23))//Maduin Relic
        {
            Debug.Log("Compaixão de Maduin");
            A.Zone[ally].sentimento = 4;
        }

        for (int x = 0; x < A.Zone[ally].status.Count; x = x + 1)//if status compaixão: Sentimento=Compaixão
        {
            if (A.Zone[ally].status[x] == 7)
            {
                A.Zone[ally].sentimento = 4;
            }
        }

        
    }
    public void ChangeWisdonRelic()
    {

    }
    public void SentimentalBonus(int ally)
    {
        Debug.Log("SentimentosBBB");
        if (Generic.HaveInt(F.Zone[ally].Relics, 1))//WillianSword
        {
            F.UpAttributeRelic(1, 1, true, 1);
        }
        if (Generic.HaveInt(F.Zone[ally].Relics, 2))//Dinheiro
        {
            F.UpManaRelic(2,2);
        }
        if (Generic.HaveInt(F.Zone[ally].Relics, 4))//Shua Heart
        {
            F.UpAttributeRelic(3, 0, true, 4);
        }
        if (Generic.HaveInt(F.Zone[ally].Relics, 5))//Code Lyoko
        {
            
            F.UpAttributeRelic(1, 2, true, 5);
        }
        if (Generic.HaveInt(F.Zone[ally].Relics, 10))//Mana Lion
        {
            F.UpManaRelic(2, 10);
        }
        if (Generic.HaveInt(F.Zone[ally].Relics, 19))//William Dagger
        {
            F.UpAttributeRelic(2, 1, true, 19);
            F.TrueDamageAllyRelic(2, 19);
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
