using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFight : MonoBehaviour
{
    public A A;
    public Stuff Stuff; 
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

    }
    public void CardData(int id, int zone)
    {
        A.zone[zone].sprite = Stuff.Cards[id].sprite;
        A.zoneid[zone].idcard1 = Stuff.Cards[id].id;
        A.zoneid[zone].Lyoko[0] = Stuff.Cards[id].Vida;
        A.zoneid[zone].Lyoko[1] = Stuff.Cards[id].Ataque;
        A.zoneid[zone].Lyoko[2] = Stuff.Cards[id].Defesa;
        A.zoneid[zone].Lyoko2.Add(Stuff.Cards[id].Vida);
        A.zoneid[zone].Lyoko2.Add(Stuff.Cards[id].Ataque);
        A.zoneid[zone].Lyoko2.Add(Stuff.Cards[id].Defesa);
        A.zoneid[zone].idPersonagem = Stuff.Cards[id].idPersonagem;


        A.zoneid[zone].Mana = Stuff.Cards[id].Level;
        A.zoneid[zone].Mana1 = Stuff.Cards[id].Level;

        A.zoneid[zone].Lyoko1.Add(0);
        A.zoneid[zone].Lyoko1.Add(0);
        A.zoneid[zone].Lyoko1.Add(0);
        if(zone==3 || zone == 4 || zone == 5)
        {
            A.zoneid[zone].side = 1;
        }
        if (zone == 0 || zone == 1 || zone == 2)
        {
            A.zoneid[zone].side = -1;
        }

    }

}
