using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetFight : MonoBehaviour
{
    public A A;
    public Stuff Stuff;
    public D D;
    public int id;
    public List<Image> Chara1;
    public List<Image> Chara2;
    public List<Image> Chara3;
    public List<Image> Chara4;
    public List<Image> Chara5;
    public List<Image> Chara6;
    public Skin Skin;
    public Interface Interface;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SetFighto()
    {
        A.Attacking(true);

        PlayerPrefs.SetInt("1", 0);
        PlayerPrefs.SetInt("0", 1);
        A.player1 = PlayerPrefs.GetInt("0");
        A.player2 = PlayerPrefs.GetInt("1");






        //...................
        id = A.StaticData.Fight;
        //D.FightParameters[id];
        for (int x = 1; x < 7; x = x + 1)
        {
            if (D.FightParameters[id].IdChara[x] == 0)
            {
                A.ZoneObject[x].SetActive(false);
                A.CharaObject[x].SetActive(false);
            }
            else
            {
                CardData(D.FightParameters[id].IdChara[x], x);
            }
        }
        SetDataChara();
        A.RelicSystem.SetRelicX();
        A.RelicSystem.SetRelicSprite();



        A.ActiveBlue(4, true);
        A.ActiveBlue(5, true);
        A.ActiveBlue(6, true);










        /*
                    Debug.Log(StaticPlayer.PlayerId[0]);
                if (StaticPlayer.PlayerId[0] == 27)
                {
                    A.j[4].enabled = true;
                    CardData(27,4);
                    Debug.Log(StaticPlayer.Fight);
                    if (StaticPlayer.Fight == 1)
                    {
                        CardData(StaticPlayer.PlayerId[1], 1);
                    }
                }

        */
    }
    public void CardData(int id, int zone)
    {
        A.zone[zone].sprite = Stuff.Cards[id].sprite;
        A.Zone[zone].idcard1 = Stuff.Cards[id].id;
        A.Zone[zone].Lyoko[0] = Stuff.Cards[id].Vida;
        A.Zone[zone].Lyoko[1] = Stuff.Cards[id].Ataque;
        A.Zone[zone].Lyoko[2] = Stuff.Cards[id].Defesa;
        A.Zone[zone].Lyoko2.Add(Stuff.Cards[id].Vida);
        A.Zone[zone].Lyoko2.Add(Stuff.Cards[id].Ataque);
        A.Zone[zone].Lyoko2.Add(Stuff.Cards[id].Defesa);
        A.Zone[zone].idPersonagem = Stuff.Cards[id].idPersonagem;


        A.Zone[zone].Mana = Stuff.Cards[id].Level;
        A.Zone[zone].Mana1 = Stuff.Cards[id].Level;

        A.Zone[zone].Lyoko1.Add(0);
        A.Zone[zone].Lyoko1.Add(0);
        A.Zone[zone].Lyoko1.Add(0);
        SetSkin(id,zone);
        if(zone==4 || zone == 5 || zone == 6)
        {
            A.Zone[zone].side = 1;
        }
        if (zone == 1 || zone == 2 || zone == 3)
        {
            A.Zone[zone].side = -1;
        }

        if (zone == 5)
        {
            Interface.BarAllyLife.OldInt = A.Zone[5].Lyoko[0]*10;
            Interface.BarAllyMana.OldInt = A.Zone[5].Mana*10;
            Interface.LifeAllyT.text = "Life " + A.Zone[5].Lyoko[0].ToString();
            Interface.AttackAllyT.text= A.Zone[5].Lyoko[1].ToString();
            Interface.DefenseAllyT.text = A.Zone[5].Lyoko[2].ToString();
            Interface.ManaAllyT.text = "Mana " + A.Zone[5].Mana.ToString();

            Interface.BarAllyLife.Slider.value = A.Zone[5].Lyoko[0] * 10;
            Interface.BarAllyMana.Slider.value = A.Zone[5].Mana * 10;



            Interface.LifeAlly = A.Zone[5].Lyoko[0];
            Interface.AttackAlly = A.Zone[5].Lyoko[1];
            Interface.DefenseAlly = A.Zone[5].Lyoko[2];
            Interface.ManaAlly = A.Zone[5].Mana;

            Interface.SetStatosOld();
        }
        if (zone == 2)
        {
            Interface.BarEnemyLife.OldInt = A.Zone[2].Lyoko[0]*10;
            Interface.BarEnemyMana.OldInt = A.Zone[2].Mana*10;
            Interface.LifeEnemyT.text = "Life " + A.Zone[2].Lyoko[0].ToString();
            Interface.AttackEnemyT.text = A.Zone[2].Lyoko[1].ToString();
            Interface.DefenseEnemyT.text = A.Zone[2].Lyoko[2].ToString();
            Interface.ManaEnemyT.text = "Mana " + A.Zone[2].Mana.ToString();


            Interface.BarEnemyLife.Slider.value = A.Zone[2].Lyoko[0] * 10;
            Interface.BarEnemyMana.Slider.value= A.Zone[2].Mana * 10;

            Interface.LifeEnemy= A.Zone[2].Lyoko[0];
            Interface.AttackEnemy = A.Zone[2].Lyoko[1];
            Interface.DefenseEnemy = A.Zone[2].Lyoko[2];
            Interface.ManaEnemy = A.Zone[2].Mana;

            Interface.SetStatosOld();
        }


    }
    public void SetSkin(int id, int zone)
    {
        if (zone == 1)
        {
            Chara1[0].sprite = Skin.Head[Stuff.Cards[id].skin[0]];
            Chara1[1].sprite = Skin.Body[Stuff.Cards[id].skin[1]];
            Chara1[2].sprite = Skin.Arm1[Stuff.Cards[id].skin[2]];
            Chara1[3].sprite = Skin.Arm2[Stuff.Cards[id].skin[3]];
            Chara1[4].sprite = Skin.Arm3[Stuff.Cards[id].skin[4]];
            Chara1[5].sprite = Skin.Arm4[Stuff.Cards[id].skin[5]];
            Chara1[6].sprite = Skin.Hand1[Stuff.Cards[id].skin[6]];
            Chara1[7].sprite = Skin.Hand2[Stuff.Cards[id].skin[7]];
            Chara1[8].sprite = Skin.Leg1[Stuff.Cards[id].skin[8]];
            Chara1[9].sprite = Skin.Leg2[Stuff.Cards[id].skin[9]];
            Chara1[10].sprite = Skin.Leg3[Stuff.Cards[id].skin[10]];
            Chara1[11].sprite = Skin.Leg4[Stuff.Cards[id].skin[11]];
            Chara1[12].sprite = Skin.Foot1[Stuff.Cards[id].skin[12]];
            Chara1[13].sprite = Skin.Foot2[Stuff.Cards[id].skin[13]];
        }
        if (zone == 2)
        {
            Chara2[0].sprite = Skin.Head[Stuff.Cards[id].skin[0]];
            Chara2[1].sprite = Skin.Body[Stuff.Cards[id].skin[1]];
            Chara2[2].sprite = Skin.Arm1[Stuff.Cards[id].skin[2]];
            Chara2[3].sprite = Skin.Arm2[Stuff.Cards[id].skin[3]];
            Chara2[4].sprite = Skin.Arm3[Stuff.Cards[id].skin[4]];
            Chara2[5].sprite = Skin.Arm4[Stuff.Cards[id].skin[5]];
            Chara2[6].sprite = Skin.Hand1[Stuff.Cards[id].skin[6]];
            Chara2[7].sprite = Skin.Hand2[Stuff.Cards[id].skin[7]];
            Chara2[8].sprite = Skin.Leg1[Stuff.Cards[id].skin[8]];
            Chara2[9].sprite = Skin.Leg2[Stuff.Cards[id].skin[9]];
            Chara2[10].sprite = Skin.Leg3[Stuff.Cards[id].skin[10]];
            Chara2[11].sprite = Skin.Leg4[Stuff.Cards[id].skin[11]];
            Chara2[12].sprite = Skin.Foot1[Stuff.Cards[id].skin[12]];
            Chara2[13].sprite = Skin.Foot2[Stuff.Cards[id].skin[13]];
        }
        if (zone == 3)
        {
            Chara3[0].sprite = Skin.Head[Stuff.Cards[id].skin[0]];
            Chara3[1].sprite = Skin.Body[Stuff.Cards[id].skin[1]];
            Chara3[2].sprite = Skin.Arm1[Stuff.Cards[id].skin[2]];
            Chara3[3].sprite = Skin.Arm2[Stuff.Cards[id].skin[3]];
            Chara3[4].sprite = Skin.Arm3[Stuff.Cards[id].skin[4]];
            Chara3[5].sprite = Skin.Arm4[Stuff.Cards[id].skin[5]];
            Chara3[6].sprite = Skin.Hand1[Stuff.Cards[id].skin[6]];
            Chara3[7].sprite = Skin.Hand2[Stuff.Cards[id].skin[7]];
            Chara3[8].sprite = Skin.Leg1[Stuff.Cards[id].skin[8]];
            Chara3[9].sprite = Skin.Leg2[Stuff.Cards[id].skin[9]];
            Chara3[10].sprite = Skin.Leg3[Stuff.Cards[id].skin[10]];
            Chara3[11].sprite = Skin.Leg4[Stuff.Cards[id].skin[11]];
            Chara3[12].sprite = Skin.Foot1[Stuff.Cards[id].skin[12]];
            Chara3[13].sprite = Skin.Foot2[Stuff.Cards[id].skin[13]];
        }
        if (zone == 4)
        {
            Chara4[0].sprite = Skin.Head[Stuff.Cards[id].skin[0]];
            Chara4[1].sprite = Skin.Body[Stuff.Cards[id].skin[1]];
            Chara4[2].sprite = Skin.Arm1[Stuff.Cards[id].skin[2]];
            Chara4[3].sprite = Skin.Arm2[Stuff.Cards[id].skin[3]];
            Chara4[4].sprite = Skin.Arm3[Stuff.Cards[id].skin[4]];
            Chara4[5].sprite = Skin.Arm4[Stuff.Cards[id].skin[5]];
            Chara4[6].sprite = Skin.Hand1[Stuff.Cards[id].skin[6]];
            Chara4[7].sprite = Skin.Hand2[Stuff.Cards[id].skin[7]];
            Chara4[8].sprite = Skin.Leg1[Stuff.Cards[id].skin[8]];
            Chara4[9].sprite = Skin.Leg2[Stuff.Cards[id].skin[9]];
            Chara4[10].sprite = Skin.Leg3[Stuff.Cards[id].skin[10]];
            Chara4[11].sprite = Skin.Leg4[Stuff.Cards[id].skin[11]];
            Chara4[12].sprite = Skin.Foot1[Stuff.Cards[id].skin[12]];
            Chara4[13].sprite = Skin.Foot2[Stuff.Cards[id].skin[13]];
        }
        if (zone == 5)
        {
            Chara5[0].sprite = Skin.Head[Stuff.Cards[id].skin[0]];
            Chara5[1].sprite = Skin.Body[Stuff.Cards[id].skin[1]];
            Chara5[2].sprite = Skin.Arm1[Stuff.Cards[id].skin[2]];
            Chara5[3].sprite = Skin.Arm2[Stuff.Cards[id].skin[3]];
            Chara5[4].sprite = Skin.Arm3[Stuff.Cards[id].skin[4]];
            Chara5[5].sprite = Skin.Arm4[Stuff.Cards[id].skin[5]];
            Chara5[6].sprite = Skin.Hand1[Stuff.Cards[id].skin[6]];
            Chara5[7].sprite = Skin.Hand2[Stuff.Cards[id].skin[7]];
            Chara5[8].sprite = Skin.Leg1[Stuff.Cards[id].skin[8]];
            Chara5[9].sprite = Skin.Leg2[Stuff.Cards[id].skin[9]];
            Chara5[10].sprite = Skin.Leg3[Stuff.Cards[id].skin[10]];
            Chara5[11].sprite = Skin.Leg4[Stuff.Cards[id].skin[11]];
            Chara5[12].sprite = Skin.Foot1[Stuff.Cards[id].skin[12]];
            Chara5[13].sprite = Skin.Foot2[Stuff.Cards[id].skin[13]];
        }
        if (zone == 6)
        {
            Chara6[0].sprite = Skin.Head[Stuff.Cards[id].skin[0]];
            Chara6[1].sprite = Skin.Body[Stuff.Cards[id].skin[1]];
            Chara6[2].sprite = Skin.Arm1[Stuff.Cards[id].skin[2]];
            Chara6[3].sprite = Skin.Arm2[Stuff.Cards[id].skin[3]];
            Chara6[4].sprite = Skin.Arm3[Stuff.Cards[id].skin[4]];
            Chara6[5].sprite = Skin.Arm4[Stuff.Cards[id].skin[5]];
            Chara6[6].sprite = Skin.Hand1[Stuff.Cards[id].skin[6]];
            Chara6[7].sprite = Skin.Hand2[Stuff.Cards[id].skin[7]];
            Chara6[8].sprite = Skin.Leg1[Stuff.Cards[id].skin[8]];
            Chara6[9].sprite = Skin.Leg2[Stuff.Cards[id].skin[9]];
            Chara6[10].sprite = Skin.Leg3[Stuff.Cards[id].skin[10]];
            Chara6[11].sprite = Skin.Leg4[Stuff.Cards[id].skin[11]];
            Chara6[12].sprite = Skin.Foot1[Stuff.Cards[id].skin[12]];
            Chara6[13].sprite = Skin.Foot2[Stuff.Cards[id].skin[13]];
        }
    }
    public void SetDataChara()
    {
        if (A.X1Lixo == true)
        {
            A.DD.SetInfo();
            A.F.z = 2;
            A.F.y = 5;

            PlayerPrefs.SetInt("A1", A.Zone[2].idcard1);
            PlayerPrefs.SetInt("A", A.Zone[5].idcard1);
            if (A.X1Lixo == true)
            {
                A.ActiveSkills();
            }
        }


    }
}
