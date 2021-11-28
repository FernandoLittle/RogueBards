using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;


public class I : MonoBehaviourPunCallbacks
{
    public int id;
    public int side;
    public int life;
    public List<B> b;
    public List<Button> bu;
    public int zoneid;
    public List<I> Guild;
    public List<Button> Guildb;
    public A a;
    public GameObject Cancel;
    public GameObject Study;
    public GameObject Fight;
    public GameObject Move;
    public GameObject Damage;
    public Text DamageT;
    public Text LifeT;
    public O o;
    public GameObject Blue;
    public GameObject End;
    public GameObject End1;
    public GameObject End2;
    public GameObject End3;
    public int dmg;
    public Q Q;

    public void A()
    {
        zoneid = PlayerPrefs.GetInt("B");
        if (a.offline == false)
        {
            dmg= b[zoneid].Lyoko[1];
            a.photonView.RPC("OnlineDamage", RpcTarget.Others, dmg);
        }
        Blue.SetActive(false);

        life -= b[zoneid].Lyoko[1];
        LifeT.text = life.ToString();
        Damage.SetActive(true);
        DamageT.text = b[zoneid].Lyoko[1].ToString();
        PlayerPrefs.SetInt("A", 0);
        PlayerPrefs.SetInt("B", 0);

        for (int x = 1; x < 11; x = x + 1)
        {
            if (b[x].select == 1)
            {
                b[x].anime.Play("b");
                b[x].select = 0;

            }
        }
        a.ChangeControl();
        Q.A();
       // o.A();

        Guildb[0].enabled = false;
        Guildb[1].enabled = false;

        a.TurnUp();
        if (a.turn == a.end)
        {
            a.B();
        }



        if (life <= 0)
        {
            End.SetActive(true);
            End1.SetActive(true);
            End2.SetActive(false);
            End3.SetActive(true);
        }
        //Study.SetActive(false);
        //Fight.SetActive(false);
        //Move.SetActive(false);
        Cancel.SetActive(false);
    }
    public void OnlineDamageB(int damage) {
        Blue.SetActive(false);
        zoneid = PlayerPrefs.GetInt("B");
        life -= damage;
        LifeT.text = life.ToString();
        Damage.SetActive(true);
        DamageT.text = damage.ToString();
        PlayerPrefs.SetInt("A", 0);
        PlayerPrefs.SetInt("B", 0);

        for (int x = 1; x < 11; x = x + 1)
        {
            if (b[x].select == 1)
            {
                b[x].anime.Play("b");
                b[x].select = 0;

            }
        }
        a.ChangeControl();
        Q.A();
        // o.A();

        Guildb[0].enabled = false;
        Guildb[1].enabled = false;

        a.TurnUp();
        if (a.turn == a.end)
        {
            a.B();
        }



        if (life <= 0)
        {
            End.SetActive(true);
            End1.SetActive(true);
            End2.SetActive(false);
            End3.SetActive(true);
        }
        //Study.SetActive(false);
        //Fight.SetActive(false);
        //Move.SetActive(false);
        Cancel.SetActive(false);


    }

}
