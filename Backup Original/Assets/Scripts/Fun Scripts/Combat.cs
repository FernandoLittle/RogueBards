﻿using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class Combat : MonoBehaviourPunCallbacks
{
    public int AttackA;
    public int AttackE;
    public int ManaSpendA;
    public int ManaSpendE;
    public int ScaleA;
    public int ScaleE;
    public Text ManaSpendT;
    public Text AttackAT;
    public int ManaA;
    public int ManaE;
    public Text ManaAT;
    public Text ManaET;
    public List<Animator> FightAN;
    public List<Animator> FightANT;
    public List<Animator> Draco1;
    public List<Animator> Draco2;
    public List<GameObject> Blue;
    public List<GameObject> FantasyRivals;
    public List<GameObject> Dark;
    public Text AttackCA;
    public Text ScaleCA;
    public Text ManaCA;
    public Text AttackCE;
    public Text ScaleCE;
    public Text ManaCE;
    public Expect Expect;
    public FantasyRivalsIA FantasyRivalsIA;
    public List<Animator> anime;
    public int SkillIDA;
    public int SkillIDE;
    public int Win;
    public D D;
    public F F;
    public int Attacking;
    public O o;
    public int x10;
    public int x20;
    public int x30;
    public int x40;
    public int y0;
    public int z0;
    public List<int> ScaleAE;
    public int k;
    public int k0;
    public A A;
    public bool AllyConfirm;
    public bool EnemyConfirm;
    public bool NoRepeatKey;
    // Start is called before the first frame update
    void Start()
    {

        ManaAT.text = ManaA.ToString();
        ManaET.text = ManaE.ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void MANAUP()
    {
        if (ManaA > 0)
        {
            ManaA -= 1;
            ManaAT.text = ManaA.ToString();
            ManaSpendA += 1;
            Calculus();
            D.LevelChange(-1, true);
        }

    }
    public void MANADOWN()
    {
        if (ManaSpendA > 0)
        {
            ManaA += 1;
            ManaAT.text = ManaA.ToString();
            ManaSpendA -= 1;
            Calculus();
            D.LevelChange(1, true);
        }
    }
    public void Calculus()
    {
        ManaSpendT.text = ManaSpendA.ToString();
        AttackAT.text = (ManaSpendA * ScaleA).ToString();
    }
    public void Return()
    {
        for (int x = 0; x < FightAN.Count; x = x + 1)
        {

            FightAN[x].Play("Spectral3");
        }
        for (int x = 0; x < FightANT.Count; x = x + 1)
        {

            FightANT[x].Play("SpectralText0");
        }
        Invoke("Return2", 0.5f); 
    }
    public void Return2()
    {
        Debug.Log("Invokado");
        D.Return();
    }
    public void Fight()
    {
        A.TrueDisabler.SetActive(true);
        if (A.offline == true)
        {
            D.Zone[D.p1].ManaSpend = ManaSpendA;
            D.DisableA(true);
            for (int x = 0; x < FightAN.Count; x = x + 1)
            {

                FightAN[x].Play("Spectral3");
            }
            for (int x = 0; x < FightANT.Count; x = x + 1)
            {

                FightANT[x].Play("SpectralText0");
            }



            for (int x = 0; x < Blue.Count; x = x + 1)
            {

                Blue[x].SetActive(false);
            }
            //BIBRIRIBRI

            if (A.offline == true)
            {
                if (o.NexusE.id * o.NexusE.side < 0)
                {

                    Attacking = 1;
                }
                else
                {
                    Attacking = 0;
                }
            }
            else
            {
                if (A.Atacante == true)
                {
                    Attacking = 1;
                }
                else
                {
                    Attacking = 0;
                }
            }




            FantasyRivals[0].SetActive(true);
            FantasyRivals[1].SetActive(true);
            Dark[1].SetActive(true);
            Dark[0].SetActive(false);
            Expect.ManaSpendA = ManaSpendA;
            Expect.ManaA = ManaA;
            Expect.OriginalManaSpendA = 0;
            Expect.OriginalManaA = ManaSpendA + ManaA;
            Expect.ScaleA = ScaleA;
            Expect.ScaleE = ScaleE;
            FantasyRivalsIA.ManE = ManaE;
            FantasyRivalsIA.ManA = ManaA + ManaSpendA;
            FantasyRivalsIA.IA();



            ScaleAE[0] = ScaleA;
            ScaleAE[1] = ScaleE;

            ScaleChangeEffects();
            if (ScaleAE[0] > ScaleA)
            {
                ScaleCA.color = new Color(0, 0.9f, 0, 1);
            }
            if (ScaleAE[0] == ScaleA)
            {
                ScaleCA.color = new Color(1, 1, 1, 1);
            }
            if (ScaleAE[0] < ScaleA)
            {
                ScaleCA.color = new Color(0.9f, 0, 0, 1);
            }
            if (ScaleAE[1] > ScaleE)
            {
                ScaleCE.color = new Color(0, 0.9f, 0, 1);
            }
            if (ScaleAE[1] == ScaleE)
            {
                ScaleCE.color = new Color(1, 1, 1, 1);
            }
            if (ScaleAE[1] < ScaleE)
            {
                ScaleCE.color = new Color(0.9f, 0, 0, 1);
            }


            ScaleA = ScaleAE[0];
            ScaleE = ScaleAE[1];

            ScaleCA.text = ScaleA.ToString();
            ScaleCE.text = ScaleE.ToString();
            Expect.ScaleA = ScaleA;
            Expect.ScaleE = ScaleE;


            Anime();
            Expect.CalculusTextA();
            Expect.CalculusTextE();
            Expect.A();
        }
        else
        {

            AllyConfirm = true;
            Fight0();

            photonView.RPC("Fight2", RpcTarget.Others);

        }


    }
    public void FightOnline()
    {


        D.Zone[D.p1].ManaSpend = ManaSpendA;
        D.Zone[D.p2].ManaSpend = ManaSpendE;
        D.DisableA(true);
        for (int x = 0; x < FightAN.Count; x = x + 1)
        {

            FightAN[x].Play("Spectral3");
        }
        for (int x = 0; x < FightANT.Count; x = x + 1)
        {

            FightANT[x].Play("SpectralText0");
        }



        for (int x = 0; x < Blue.Count; x = x + 1)
        {

            Blue[x].SetActive(false);
        }
        //BIBRIRIBRI



        if (A.Atacante == true)
        {
            Attacking = 1;
        }
        else
        {
            Attacking = 0;
        }





        FantasyRivals[0].SetActive(true);
        FantasyRivals[1].SetActive(true);
        Dark[1].SetActive(true);
        Dark[0].SetActive(false);
        //BIRBIRI
        Expect.ManaSpendA = ManaSpendA;
        Expect.ManaSpendE = ManaSpendE;

        Expect.ManaA = ManaA;
        Expect.ManaE = ManaE;
        Expect.OriginalManaSpendA = 0;
        Expect.OriginalManaSpendE = 0;
        Expect.OriginalManaA = ManaSpendA + ManaA;
        Expect.OriginalManaE = ManaSpendE + ManaE;
        Expect.ScaleA = ScaleA;
        Expect.ScaleE = ScaleE;
        FantasyRivalsIA.ManE = ManaE;
        FantasyRivalsIA.ManA = ManaA + ManaSpendA;
        //FantasyRivalsIA.IA();



        ScaleAE[0] = ScaleA;
        ScaleAE[1] = ScaleE;

        ScaleChangeEffects();
        if (ScaleAE[0] > ScaleA)
        {
            ScaleCA.color = new Color(0, 0.9f, 0, 1);
        }
        if (ScaleAE[0] == ScaleA)
        {
            ScaleCA.color = new Color(1, 1, 1, 1);
        }
        if (ScaleAE[0] < ScaleA)
        {
            ScaleCA.color = new Color(0.9f, 0, 0, 1);
        }
        if (ScaleAE[1] > ScaleE)
        {
            ScaleCE.color = new Color(0, 0.9f, 0, 1);
        }
        if (ScaleAE[1] == ScaleE)
        {
            ScaleCE.color = new Color(1, 1, 1, 1);
        }
        if (ScaleAE[1] < ScaleE)
        {
            ScaleCE.color = new Color(0.9f, 0, 0, 1);
        }


        ScaleA = ScaleAE[0];
        ScaleE = ScaleAE[1];

        ScaleCA.text = ScaleA.ToString();
        ScaleCE.text = ScaleE.ToString();
        Expect.ScaleA = ScaleA;
        Expect.ScaleE = ScaleE;


        Anime();
        Expect.CalculusTextA();
        Expect.CalculusTextE();
        Expect.A();


    }
    [PunRPC]
    public void Fight2()
    {
        EnemyConfirm = true;
        Fight0();

    }
    public void Fight0()
    {
        if (AllyConfirm == true && EnemyConfirm == true)
        {
            if (NoRepeatKey == false)
            {
                NoRepeatKey = true;
                photonView.RPC("SendData", RpcTarget.Others, ManaA, SkillIDA, ManaSpendA, ScaleA,F.x1,F.x2,F.x3,F.x4);
            }
        }
    }
    [PunRPC]
    public void SendData(int ManaA, int SkillIDA, int ManaSpendA, int ScaleA, int x1, int x2, int x3, int x4 )
    {
        if (NoRepeatKey == false)
        {
            NoRepeatKey = true;
            photonView.RPC("SendData", RpcTarget.Others, this.ManaA, this.SkillIDA, this.ManaSpendA, this.ScaleA, F.x1, F.x2, F.x3, F.x4);
        }
       
        D.LevelChange(ManaSpendA * -1, false);


        F.x5 = x1;
        F.x6 = x2;
        F.x7 = x3;
        F.x8 = x4;

        if (SkillIDA == 1)
        {
            F.b5 = 1;
            F.b6 = 0;
            F.b7 = 0;
            F.b8 = 0;

        }
        if (SkillIDA == 2)
        {
            F.b6 = 1;
            F.b5 = 0;
            F.b7 = 0;
            F.b8 = 0;
        }
        if (SkillIDA == 3)
        {
            F.b7 = 1;
            F.b5 = 0;
            F.b6 = 0;
            F.b8 = 0;
        }
        if (SkillIDA == 4)
        {
            F.b8 = 1;
            F.b5 = 0;
            F.b6 = 0;
            F.b7 = 0;
        }
        ManaSpendE = ManaSpendA;
        ScaleE = ScaleA;
        ManaE = ManaA;
        D.Zone[D.p2].ManaSpend = ManaSpendA;
        Expect.ManaSpendE = ManaSpendA;
        Expect.ManaE = ManaA;
        Expect.OriginalManaE = ManaSpendA + ManaA;
        Expect.ScaleE = ScaleA;
        ScaleE = ScaleA;
        this.ManaE = ManaA;
        SkillIDE = SkillIDA;
        FightOnline();

    }
    public void Anime()
    {
        if (SkillIDA == 1)
        {
            anime[0].Play("AllyCardAnimation");
            anime[1].Play("draco0");
        }
        if (SkillIDA == 2)
        {
            anime[0].Play("draco0");
            anime[1].Play("AllyCardAnimation2");
        }
        if (SkillIDA == 3)
        {
            anime[2].Play("AllyCardAnimation");
          anime[3].Play("draco0");
        }
        if (SkillIDA == 4)
        {
            anime[2].Play("draco0");
            anime[3].Play("AllyCardAnimation2");
        }
        //anime[4].Play("draco");


        if (SkillIDE == 1)
        {
            anime[5].Play("EnemyCardAnimation");
            anime[6].Play("draco0");
        }
        if (SkillIDE == 2)
        {
            anime[5].Play("draco0");
            anime[6].Play("EnemyCardAnimation2");
        }
        if (SkillIDE == 3)
        {
            anime[7].Play("EnemyCardAnimation");
            anime[8].Play("draco0");
        }
        if (SkillIDE == 4)
        {
            anime[7].Play("draco0");
            anime[8].Play("EnemyCardAnimation2");
        }
      //  anime[9].Play("dracox");
    }
    public void Victory()
    {
        A.Interface.SetStatos();
        if (Win == 0)
        {
            F.AllyWin = 1;
            F.EnemyWin = 0;
        }
        if (Win == 1)
        {
            F.EnemyWin = 1;
            F.AllyWin = 0;
        }
        F.PassiveEffects();
        F.A();
    }
    public void Victory2()
    {
        if (Win == 0)
        {
            anime[SkillIDA - 1].Play("Victory");
            anime[SkillIDE + 4].Play("Defeat1");
        }
        else
        {
            anime[SkillIDA - 1].Play("Defeat");
            anime[SkillIDE + 4].Play("Victory1");
        }
    }
    public void Victory1()
    {
        anime[SkillIDA - 1].Play("Attack");
        anime[SkillIDE + 4].Play("Attack2");

        /*
        if (SkillIDE == 1)
        {






            anime[5].Play("A1FRx2");
            if (Win == 1)
            {
                anime[SkillIDA - 1].Play("B1FR2");
            }
            else
            {
                anime[SkillIDA - 1].Play("B2FR2");
            }

        }
        if (SkillIDE == 2)
        {
            anime[6].Play("A2FRx2");
            if (Win == 1)
            {
                anime[SkillIDA - 1].Play("B2FR2");
            }
            else
            {
                anime[SkillIDA - 1].Play("B1FR2");
            }
        }
        if (SkillIDE == 3)
        {
            anime[7].Play("B1FRx2");
            if (Win == 1)
            {
                anime[SkillIDA - 1].Play("A2FR2");
            }
            else
            {
                anime[SkillIDA - 1].Play("A1FR2");
            }
        }
        if (SkillIDE == 4)
        {
            anime[8].Play("B2FRx2");
            if (Win == 1)
            {
                anime[SkillIDA - 1].Play("A1FR2");
            }
            else
            {
                anime[SkillIDA - 1].Play("A2FR2");
            }
        }
        */
    }
    public void AttackChangeEffects()
    {
        UpAttackEffects();
        DownAttackEffects();

    }
    public void ScaleChangeEffects()
    {
        UpLevelEffects();
        DownLevelEffects();

    }
    public void ExChange(int x)
    {
        k0 = k + Attacking;
        if (k0 > 1)
        {
            k0 = 0;
        }
        if ((Attacking + x) % 2 == 0)
        {
            x10 = F.x1;
            x20 = F.x2;
            x30 = F.x3;
            x40 = F.x4;
            y0 = F.y;
            z0 = F.z;
        }
        if ((Attacking + x) % 2 == 1)
        {
            x10 = F.x5;
            x20 = F.x6;
            x30 = F.x7;
            x40 = F.x8;
            y0 = F.z;
            z0 = F.y;
        }
    }
    public void UpLevelEffects()
    {
        for (int x = 0; x < 2; x = x + 1)
        {
            k = x;
            ExChange(x);

            if (x20 == 23)
            {
                if (A.round == 1)
                {
                    UpLevel(2);
                }
            }


            if (x30 == 19)
            {
                if (A.round == 1)
                {
                    UpLevel(2);
                }
            }

            if (x10 == 27)
            {
                F.DuelistF(y0);
                if (F.duelist == true)
                {
                    UpLevel(1);
                }
            }

            if (x20 == 21)
            {
                F.PactF(y0);
                if (F.pact > 1)
                {
                    UpLevel(1);
                }

            }

        }
    }
    public void DownLevelEffects()
    {
        for (int x = 0; x < 2; x = x + 1)
        {
            k = x;
            ExChange(x);


            if (x10 == 25)
            {
                DownLevel(2, 7);
            }


            if (x20 == 20)
            {

                DownLevel(3, 6);

            }

            if (x30 == 17)
            {
                DownLevel(2, 4);
            }

            if (x20 == 22)
            {
                if (F.Zone[y0].Code[11] == true)
                {


                    DownLevel(5, 5);
                    F.Zone[y0].Code[11] = false;
                }
            }
        }
    }


    public void UpAttackEffects()
    {

        for (int x = 0; x < 2; x = x + 1)
        {
            k = x;

            ExChange(x);

            if (x10 == 26)
            {
                if (A.round == 1)
                {
                    UpAttack(4);
                }
            }


            if (x20 == 22)
            {
                UpAttack(8);
            }

            if (x40 == 20)
            {
                F.DuelistF(y0);
                if (F.duelist == true)
                {
                    UpAttack(5);
                }

            }
            if (x20 == 24)
            {
                F.DuelistF(y0);
                if (F.duelist == true)
                {
                    UpAttack(6);
                }

            }

            if (x10 == 24)
            {
                F.PactF(y0);
                if (F.pact > 1)
                {
                    UpAttack(6);
                }
            }

        }
    }
    public void DownAttackEffects()
    {
        for (int x = 0; x < 2; x = x + 1)
        {
            k = x;

            ExChange(x);

            if (x40 == 18)//VladE
            {
                DownAttack(10, 18);
            }


            if (x10 == 23)//Anivia AF
            {

                DownAttack(10, 20);

            }

            if (x40 == 16)//Anivia E
            {
                DownAttack(7, 13);
            }

            if (x10 == 22)//TeemoAF
            {
                if (F.Zone[y0].Code[11] == true)
                {
                    DownAttack(20, 23);
                    F.Zone[y0].Code[11] = false;
                }
            }

            if (x40 == 17)//KalistaE
            {
                F.PactF(y0);
                if (F.pact > 1)
                {
                    DownAttack(7, 20);
                }
            }


        }

    }




    public void CopyLevelEffects()
    {
        for (int x = 0; x < 2; x = x + 1)
        {
            k = x;

            ExChange(x);
            if (x30 == 18)
            {
                if (F.pact > 1)
                {
                    CopyLevel();
                }


            }




        }

    }









    //...............................................................................................................
    public void UpLevel(int up)
    {
        ScaleAE[k0] += up;
    }
    public void DownLevel(int down, int min)
    {
        if (k0 == 0)
        {
            ScaleAE[1] -= down;
            if (ScaleAE[1] < min)
            {
                ScaleAE[1] = min;
            }
        }
        if (k0 == 1)
        {
            ScaleAE[0] -= down;
            if (ScaleAE[0] < min)
            {
                ScaleAE[0] = min;
            }
        }
    }
    public void UpAttack(int up)
    {
        Expect.AttackAE[k0] += up;


    }
    public void DownAttack(int down, int min)
    {

        if (k0 == 0)
        {

            if (Expect.AttackAE[1] > min)
            {
                Expect.AttackAE[1] -= down;
                if (Expect.AttackAE[1] < min)
                {

                    Expect.AttackAE[1] = min;

                }
            }
        }
        if (k0 == 1)
        {

            if (Expect.AttackAE[0] > min)
            {
                Expect.AttackAE[0] -= down;
                if (Expect.AttackAE[0] < min)
                {
                    Expect.AttackAE[0] = min;
                }
            }
        }
    }
    public void CopyLevel()
    {
        if (k0 == 0)
        {
            ScaleAE[0] = ScaleAE[1];
        }
        if (k0 == 1)
        {
            ScaleAE[1] = ScaleAE[0];
        }
    }
}
