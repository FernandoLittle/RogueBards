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
                SceneManager.LoadScene("Battle");
                break;
            case 2:
                StaticPlayer.Fight = 2;
                SceneManager.LoadScene("Battle");
                break;
            case 3:
                StaticPlayer.Fight = 3;
                SceneManager.LoadScene("Battle");
                break;
            case 4:
                StaticPlayer.Fight = 4;
                SceneManager.LoadScene("Battle");
                break;
            case 5:
                StaticPlayer.Fight = 5;
                SceneManager.LoadScene("Battle");
                break;
            case 6:
                StaticPlayer.Fight = 6;
                SceneManager.LoadScene("Battle");
                break;
            case 7:
                StaticPlayer.Fight = 7;
                SceneManager.LoadScene("Battle");
                break;
            case 8:
                StaticPlayer.Fight = 8;
                SceneManager.LoadScene("Battle");
                break;
            case 9:
                StaticPlayer.Fight = 9;
                SceneManager.LoadScene("Battle");
                break;
            case 10:
                StaticPlayer.Fight = 10;
                SceneManager.LoadScene("Battle");
                break;
            case 11:
                StaticPlayer.Fight = 11;
                SceneManager.LoadScene("Battle");
                break;








            //100 Set Tale
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
                SetButton(502, 703, 0, 0, 0);
                TalesVariables.ShowText();
                break;

            case 313:
                SetButtonST("Decline offer", "It's not up to me to make this decision", "", "", "");
                SetButton(1001, 1002, 0, 0, 0);
                TalesVariables.ShowText();
                break;
            case 314:
                StaticPlayer.PlayerId[1] = 11;
                StaticPlayer.PlayerLife[0] = 3;
                SceneManager.LoadScene("Battle");
                break;
            case 315:
                SetButtonST("Accept the bad luck", "Flip the coin again", "", "", "");
                SetButton(1013, 1014, 0, 0, 0);
                TalesVariables.ShowText();
                break;
            case 316:
                SetButtonST("Play a religious song.", "Play a love song.", "Play a patriotic song.", "Play an instrumental song.", "");
                SetButton(1301, 1302, 1303, 1304, 0);
                TalesVariables.ShowText();
                break;

            //500 Genecric

            case 500:
                TalesVariables.Tales = TalesVariables.TalesAction;
                TalesVariables.SetTale(0);
                break;
            
            case -1:
                RandomActions();
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
    public void RandomActions()
    {
        int CountFightL1;
        int RandomRemove;
        TalesVariables.FightL1.Clear();
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
                Caracter[x] = "Gambling Games";
            }
            if (TalesVariables.FightL1[x] == 2)
            {
                Inteiro[x] = 1403;
                Caracter[x] = "Drug Trafficking";
            }
            if (TalesVariables.FightL1[x] == 3)
            {
                Inteiro[x] = 1404;
                Caracter[x] = "Imigração Ilegal";
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
            if (TalesVariables.FightL1[x] == 6)
            {
                Inteiro[x] = 1407;
                Caracter[x] = "Theft";
            }
        }

        SetButtonST(Caracter[0], Caracter[1], Caracter[2], "", "");
        SetButton(Inteiro[0], Inteiro[1], Inteiro[2], 0, 0);
        TalesVariables.ShowText();

    }

}
