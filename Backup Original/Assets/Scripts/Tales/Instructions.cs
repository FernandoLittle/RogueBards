using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instructions : MonoBehaviour
{
    public TalesVariables TalesVariables;
    public List<int> Caos;
    public List<int> Inteiro;
    public List<string> Caracter;
    public SkillA SkillA;
    public List<int> Routes;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TaleSwitch(int a)
    {
        switch (a)
        {
            case 0:

                TalesVariables.ShowText();
                break;

            //SetFight
            case 1:

                StaticPlayer.Fight = 1;
                TalesVariables.Loading.SetActive(true);
                SceneManager.LoadScene("Battle");
                break;
            case 2:
                StaticPlayer.Fight = 2;
                TalesVariables.Loading.SetActive(true);
                SceneManager.LoadScene("Battle");
                break;
            case 3:
                StaticPlayer.Fight = 3;
                TalesVariables.Loading.SetActive(true);
                SceneManager.LoadScene("Battle");
                break;
            case 4:
                StaticPlayer.Fight = 4;
                TalesVariables.Loading.SetActive(true);
                SceneManager.LoadScene("Battle");
                break;
            case 5:
                StaticPlayer.Fight = 5;
                TalesVariables.Loading.SetActive(true);
                SceneManager.LoadScene("Battle");
                break;
            case 6:
                StaticPlayer.Fight = 6;
                TalesVariables.Loading.SetActive(true);
                SceneManager.LoadScene("Battle");
                break;
            case 7:
                StaticPlayer.Fight = 7;
                TalesVariables.Loading.SetActive(true);
                SceneManager.LoadScene("Battle");
                break;
            case 8:
                StaticPlayer.Fight = 8;
                TalesVariables.Loading.SetActive(true);
                SceneManager.LoadScene("Battle");
                break;
            case 9:
                StaticPlayer.Fight = 9;
                TalesVariables.Loading.SetActive(true);
                SceneManager.LoadScene("Battle");
                break;
            case 10:
                StaticPlayer.Fight = 10;
                TalesVariables.Loading.SetActive(true);
                SceneManager.LoadScene("Battle");
                break;
            case 11:
                StaticPlayer.Fight = 11;
                TalesVariables.Loading.SetActive(true);
                SceneManager.LoadScene("Battle");
                break;
            case 12:
                StaticPlayer.Fight = 12;
                TalesVariables.Loading.SetActive(true);
                SceneManager.LoadScene("Battle");
                break;
            case 13:
                StaticPlayer.Fight = 13;
                TalesVariables.Loading.SetActive(true);
                SceneManager.LoadScene("Battle");
                break;
            case 14:
                StaticPlayer.Fight = 14;
                TalesVariables.Loading.SetActive(true);
                SceneManager.LoadScene("Battle");
                break;
            case 15:
                StaticPlayer.Fight = 15;
                TalesVariables.Loading.SetActive(true);
                SceneManager.LoadScene("Battle");
                break;
            case 16:
                StaticPlayer.Fight = 16;
                TalesVariables.Loading.SetActive(true);
                SceneManager.LoadScene("Battle");
                break;







            //100 Set Tale
            case 100:
                TalesVariables.SetTale(a - 100);
                break;
            case 101:
                TalesVariables.SetTale(a - 100);
                break;
            case 102:
                TalesVariables.SetTale(a - 100);
                break;
            case 105:
                TalesVariables.SetTale(a - 100);
                break;
            case 106:
                TalesVariables.SetTale(a - 100);
                break;
            case 107:
                TalesVariables.SetTale(a - 100);
                break;
            case 108:
                TalesVariables.SetTale(a - 100);
                break;
            case 109:
                TalesVariables.SetTale(a - 100);
                break;
            case 110:
                TalesVariables.SetTale(a - 100);
                break;
            case 111:
                TalesVariables.SetTale(a - 100);
                break;
            case 112:
                TalesVariables.SetTale(a - 100);
                break;
            case 113:
                TalesVariables.SetTale(a - 100);
                break;
            case 114:
                TalesVariables.SetTale(a - 100);
                break;
            case 115:
                TalesVariables.SetTale(a - 100);
                break;
            case 116:
                TalesVariables.SetTale(a - 100);
                break;
            case 117:
                TalesVariables.SetTale(a - 100);
                break;
            case 118:
                TalesVariables.SetTale(a - 100);
                break;
            case 119:
                TalesVariables.SetTale(a - 100);
                break;
            case 120:
                TalesVariables.SetTale(a - 100);
                break;
            case 121:
                TalesVariables.SetTale(a - 100);
                break;
            case 122:
                TalesVariables.SetTale(a - 100);
                break;
            case 123:
                TalesVariables.SetTale(a - 100);
                break;
            case 124:
                TalesVariables.SetTale(a - 100);
                break;


            //200 SetDialogue
            case 201:
                TalesVariables.Index = 1;
                TalesVariables.ShowText();
                break;
            case 202:
                TalesVariables.Index = 2;
                TalesVariables.ShowText();
                break;
            case 203:
                TalesVariables.Index = 3;
                TalesVariables.ShowText();
                break;
            case 204:
                TalesVariables.Index = 4;
                TalesVariables.ShowText();
                break;
            case 205:
                TalesVariables.Index = 5;
                TalesVariables.ShowText();
                break;
            case 206:
                TalesVariables.Index = 6;
                TalesVariables.ShowText();
                break;

            //300 Set Buttons

            case 312:
                SetButtonST("I can", "I can't", "", "", "");
                SetButton(1008, 1009, 0, 0, 0);
                TalesVariables.ShowText();
                break;

            case 313:
                SetButtonST("Decline offer", "It's not up to me to make this decision", "", "", "");
                SetButton(1011, 1010, 0, 0, 0);
                TalesVariables.ShowText();
                break;
            case 314:
                StaticPlayer.PlayerId[1] = 11;
                StaticPlayer.PlayerLife[0] = 3;
                SceneManager.LoadScene("Battle");
                break;
            case 315:
                SetButtonST("Accept the bad luck", "Flip the coin again", "", "", "");
                SetButton(-101, -102, 0, 0, 0);
                TalesVariables.ShowText();
                break;
            case 316:
                SetButtonST("Play a religious song.", "Play a love song.", "Play a patriotic song.", "Play an instrumental song.", "");
                SetButton(1301, 1302, 1303, 1304, 0);
                TalesVariables.ShowText();
                break;
            case 317:
                SetButtonST("Play a song.", "Read a book.", "", "", "");
                SetButton(1305, 1306, 0, 0, 0);
                TalesVariables.ShowText();
                break;
            case 318:
                SetButtonST("Follow your heart.", "Follow Shuá.", "", "", "");
                SetButton(1019, 1020, 0, 0, 0);
                TalesVariables.ShowText();
                break;
            case 319:
                SetButtonST("Join the prayer.", "Doubt the existence of Shuá.", "", "", "");
                SetButton(1016, 1017, 0, 0, 0);
                TalesVariables.ShowText();
                break;
            case 320:
                SetButtonST("Follow the Path of Shuá.", "Follow the Path of Warrior.", "", "", "");
                SetButton(1014, 1013, 0, 0, 0);
                TalesVariables.ShowText();
                break;
            case 321:
                SetButtonST("Question the monk.", "Ask for the monk's forgiveness.", "", "", "");
                SetButton(1022, 1023, 0, 0, 0);
                TalesVariables.ShowText();
                break;
            case 322:
                SetButtonST("Accept the bribe.", "Refuse the bribe.", "", "", "");
                SetButton(1009, 1024, 0, 0, 0);
                TalesVariables.ShowText();
                break;
            //500 Genecric

            case 500:
                TalesVariables.Day.FightCrime(0);
                break;


            case 666:
                TalesVariables.Obrigado.SetActive(true);
                break;
            //1000 Special Instructions
            //*****************************************************
            case 1000: //GreatReward
                SkillA.RelicReward();
                SkillA.GodReward1();
                TalesVariables.ShowText();
                break;
            case 1001: //Reward
                SkillA.GodReward1();
                TalesVariables.ShowText();
                break;
            case 1002: //NextDay
                TalesVariables.Day.SelectDay();
                break;
            case 1003: //Minigame
                TalesVariables.Day.Minigame();
                break;



            //*****************************************************
            case -1:
                RandomActions();
                break;
            case -2:
                RandomCustomRoute();
                break;
        }
    }



    public void SetButton(int id1, int id2, int id3, int id4, int id5)
    {
        int NumberButtons;
        NumberButtons = 0;
        if (id1 != 0)
        {
            NumberButtons += 1;
        }
        if (id2 != 0)
        {
            NumberButtons += 1;
        }
        if (id3 != 0)
        {
            NumberButtons += 1;
        }
        if (id4 != 0)
        {
            NumberButtons += 1;
        }
        if (id5 != 0)
        {
            NumberButtons += 1;
        }
        TalesVariables.IdButton[0] = id1;
        TalesVariables.IdButton[1] = id2;
        TalesVariables.IdButton[2] = id3;
        TalesVariables.IdButton[3] = id4;
        TalesVariables.IdButton[4] = id5;
        TalesVariables.ShowButtons(NumberButtons);
    }

    //This void must come after void SetButton
    public void SetButtonST(string st1, string st2, string st3, string st4, string st5)
    {
        TalesVariables.OptionsText[0] = st1;
        TalesVariables.OptionsText[1] = st2;
        TalesVariables.OptionsText[2] = st3;
        TalesVariables.OptionsText[3] = st4;
        TalesVariables.OptionsText[4] = st5;
    }
    public void RandomCustomRoute()
    {
        
        int Route1;
        int Route2;
        int Route3;
        int chaos;

        for (int x = 0; x < TalesVariables.TalesCustonRouteTrue.Count; x = x + 1)
        {
            TalesVariables.CustonRoute.Add(x);
        }
        Debug.Log("O_O");
        Debug.Log(TalesVariables.CustonRoute.Count);
        chaos = Random.Range(0, TalesVariables.CustonRoute.Count);
        Route1 = TalesVariables.CustonRoute[chaos];
        TalesVariables.CustonRoute.RemoveAt(chaos);
        Debug.Log(TalesVariables.CustonRoute.Count);
        chaos = Random.Range(0, TalesVariables.CustonRoute.Count);
        Route2 = TalesVariables.CustonRoute[chaos];
        TalesVariables.CustonRoute.RemoveAt(chaos);
        Debug.Log(TalesVariables.CustonRoute.Count);
        chaos = Random.Range(0, TalesVariables.CustonRoute.Count);
        Route3 = TalesVariables.CustonRoute[chaos];
        TalesVariables.CustonRoute.RemoveAt(chaos);
        Debug.Log(TalesVariables.CustonRoute.Count);
        Routes.Add(Route1);
        Routes.Add(Route2);
        Routes.Add(Route3);

        for (int x = 0; x < 3; x = x + 1)
        {
            if (Routes[x] == 0)
            {
                Inteiro[x] = 1501;
                Caracter[x] = "Drink in a bar";
            }
            if (Routes[x] == 1)
            {
                Inteiro[x] = 1502;
                Caracter[x] = "Visit a cemetery";
            }
            if (Routes[x] == 2)
            {
                Inteiro[x] = 1503;
                Caracter[x] = "Pray";
            }
            if (Routes[x] == 3)
            {
                Inteiro[x] = 1504;
                Caracter[x] = "Take a bribe";
            }
          //Gay Kiss
          //Eat Corn
        }
        SetButtonST(Caracter[0], Caracter[1], Caracter[2], "", "");
        SetButton(Inteiro[0], Inteiro[1], Inteiro[2], 0, 0);
        TalesVariables.ShowText();
    }
    public void RandomActions()
    {
        int CountFightL1;
        int RandomRemove;
        TalesVariables.FightL.Clear();
        TalesVariables.FightL1.Clear();
        for (int x = 0; x < TalesVariables.TalesWilliamWFight.Count; x = x + 1)
        {
            TalesVariables.FightL.Add(x);
        }
        for (int x = 0; x < TalesVariables.FightL.Count; x = x + 1)
        {
            TalesVariables.FightL1.Add(TalesVariables.FightL[x]);
        }
        CountFightL1 = TalesVariables.FightL1.Count - 3;
        for (int x = 0; x < CountFightL1; x = x + 1)
        {
            RandomRemove = Random.Range(0, TalesVariables.FightL1.Count);
            TalesVariables.FightL1.Remove(RandomRemove);
        }


        for (int x = 0; x < 3; x = x + 1)
        {
            if (TalesVariables.FightL1[x] == 0)
            {
                Inteiro[x] = 1401;
                Caracter[x] = "Apology for Crime";
            }
            if (TalesVariables.FightL1[x] == 1)
            {
                Inteiro[x] = 1402;
                Caracter[x] = "Theft";
            }
            if (TalesVariables.FightL1[x] == 2)
            {
                Inteiro[x] = 1403;
                Caracter[x] = "Drug Trafficking";
            }
            if (TalesVariables.FightL1[x] == 3)
            {
                Inteiro[x] = 1404;
                Caracter[x] = "Illegal Immigration";
            }
            if (TalesVariables.FightL1[x] == 4)
            {
                Inteiro[x] = 1405;
                Caracter[x] = "Organ Trafficking";
            }
            if (TalesVariables.FightL1[x] == 5)
            {
                Inteiro[x] = 1406;
                Caracter[x] = "Tax Evasion";
            }
       
        }

        SetButtonST(Caracter[0], Caracter[1], Caracter[2], "", "");
        SetButton(Inteiro[0], Inteiro[1], Inteiro[2], 0, 0);
        TalesVariables.ShowText();

    }

}
