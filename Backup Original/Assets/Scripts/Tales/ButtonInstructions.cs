using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonInstructions : MonoBehaviour
{
    public TalesVariables TalesVariables;
    public SkillA SkillA;
    public List<int> Idbuttons;
    public GodCube GodCube;//x
    // Start is called before the first frame update
    public void EffectsButton(int a)
    {
        switch (a)
        {

            case -5:

                break;
            case -6:

                break;



            //-100 Special Instruction.
            case -101:
                PlayerPrefs.SetInt("Anne", 0);
                TalesVariables.SetTale(13);
                TalesVariables.Index += 1;
                break;
            case -102:
                PlayerPrefs.SetInt("Anne", 1);
                TalesVariables.SetTale(12);
                TalesVariables.Index += 1;
                break;


            //Warrior
            case 1:
             
                PlayerPrefs.SetInt("Batalha", 0);
                //temporario
                PlayerPrefs.SetInt("Tale", 1);
                //temporario, mudar com sistema de load

                StaticPlayer.Adventure = true;
                StaticPlayer.Fight = 1;
                StaticPlayer.PlayerId[0] = 28;
                StaticPlayer.Day = 1;
                StaticPlayer.PlayerLife[0] = 3;
                StaticPlayer.ManaRegen[0] = 0;
                StaticPlayer.Mana[0] = 0;
                StaticPlayer.Defense[0] = 0;
                StaticPlayer.PlayerMaxLife[0] = 0;
                StaticPlayer.Attack[0] = 0;



                TalesVariables.Index = 0;
                TalesVariables.SelectTale.NextTale();
                break;
                //Assassin
            case 2:
                TalesVariables.Day.RandomIntroAS();
                break;
            //Set Tale 1000
            //Eu acho que tem que aumentar o index manualmente,
            case 1000:
                TalesVariables.SetTale(a - 1000);
                TalesVariables.Index += 1;
                break;
            case 1001:
                TalesVariables.SetTale(a - 1000);
                TalesVariables.Index += 1;
                break;
            case 1002:
                TalesVariables.SetTale(a - 1000);
                TalesVariables.Index += 1;
                break;
            case 1003:
                TalesVariables.SetTale(a - 1000);
                TalesVariables.Index += 1;
                break;
            case 1004:
                TalesVariables.SetTale(a - 1000);
                TalesVariables.Index += 1;
                break;
            case 1005:
                TalesVariables.SetTale(a - 1000);
                TalesVariables.Index += 1;
                break;
            case 1006:
                TalesVariables.SetTale(a - 1000);
                TalesVariables.Index += 1;
                break;
            case 1007:
                TalesVariables.SetTale(a - 1000);
                TalesVariables.Index += 1;
                break;
            case 1008:
                TalesVariables.SetTale(a - 1000);
                TalesVariables.Index += 1;
                break;
            case 1009:
                TalesVariables.SetTale(a - 1000);
                TalesVariables.Index += 1;
                break;
            case 1010:
                TalesVariables.SetTale(a - 1000);
                TalesVariables.Index += 1;
                break;
            case 1011:
                TalesVariables.SetTale(a - 1000);
                TalesVariables.Index += 1;
                break;
            case 1012:
                TalesVariables.SetTale(a - 1000);
                TalesVariables.Index += 1;
                break;
            case 1013:
                TalesVariables.SetTale(a - 1000);
                TalesVariables.Index += 1;
                break;
            case 1014:
                TalesVariables.SetTale(a - 1000);
                TalesVariables.Index += 1;
                break;
            case 1015:
                TalesVariables.SetTale(a - 1000);
                TalesVariables.Index += 1;
                break;
            case 1016:
                TalesVariables.SetTale(a - 1000);
                TalesVariables.Index += 1;
                break;
            case 1017:
                TalesVariables.SetTale(a - 1000);
                TalesVariables.Index += 1;
                break;
            case 1018:
                TalesVariables.SetTale(a - 1000);
                TalesVariables.Index += 1;
                break;
            case 1019:
                TalesVariables.SetTale(a - 1000);
                TalesVariables.Index += 1;
                break;
            case 1020:
                TalesVariables.SetTale(a - 1000);
                TalesVariables.Index += 1;
                break;
            case 1021:
                TalesVariables.SetTale(a - 1000);
                TalesVariables.Index += 1;
                break;
            case 1022:
                TalesVariables.SetTale(a - 1000);
                TalesVariables.Index += 1;
                break;
            case 1023:
                TalesVariables.SetTale(a - 1000);
                TalesVariables.Index += 1;
                break;
            case 1024:
                TalesVariables.SetTale(a - 1000);
                TalesVariables.Index += 1;
                break;
            //1300 Set MiniGame
            case 1301:
                PlayerPrefs.SetInt("God", 1);//Shuá
                GodCube.TakeScreenshot("Song");
                //SceneManager.LoadScene("Song");

                break;
            case 1302:
                PlayerPrefs.SetInt("God", 2);//Lyoko
                GodCube.TakeScreenshot("Song");
                //SceneManager.LoadScene("Song");

                break;
            case 1303:
                PlayerPrefs.SetInt("God", 3);//Akasha
                GodCube.TakeScreenshot("Song");
                //SceneManager.LoadScene("Song");

                break;
            case 1304:
                PlayerPrefs.SetInt("God", 4);//Maná
                GodCube.TakeScreenshot("Song");
                //SceneManager.LoadScene("Song");
                break;
            case 1305:
                PlayerPrefs.SetInt("God", Random.Range(1, 5));//RandomGod
                GodCube.TakeScreenshot("Song");
                //SceneManager.LoadScene("Song");
                break;
            case 1306:
                PlayerPrefs.SetInt("God", Random.Range(1, 5));//RandomGod
                GodCube.TakeScreenshot("BookGame");
                //SceneManager.LoadScene("BookGame");
                break;

            //1400 Set Tale for other List
            case 1401:
                PlayerPrefs.SetInt("OldFight", 0);
                TalesVariables.Tales = TalesVariables.TalesWilliamWFight;
               
                TalesVariables.SetTale(0);
                TalesVariables.Index += 1;

                break;
            case 1402:
                PlayerPrefs.SetInt("OldFight", 1);
                TalesVariables.Tales = TalesVariables.TalesWilliamWFight;
                TalesVariables.SetTale(1);
                TalesVariables.Index += 1;
                break;
            case 1403:
                PlayerPrefs.SetInt("OldFight", 2);
                TalesVariables.Tales = TalesVariables.TalesWilliamWFight;
                TalesVariables.SetTale(2);
                TalesVariables.Index += 1;
                break;
            case 1404:
                PlayerPrefs.SetInt("OldFight", 3);
                TalesVariables.Tales = TalesVariables.TalesWilliamWFight;
                TalesVariables.SetTale(3);
                TalesVariables.Index += 1;
                break;
            case 1405:
                PlayerPrefs.SetInt("OldFight", 4);
                TalesVariables.Tales = TalesVariables.TalesWilliamWFight;
                TalesVariables.SetTale(4);
                TalesVariables.Index += 1;
                break;
            case 1406:
                PlayerPrefs.SetInt("OldFight", 5);
                TalesVariables.Tales = TalesVariables.TalesWilliamWFight;
                TalesVariables.SetTale(5);
                TalesVariables.Index += 1;
                break;
            case 1407:
                PlayerPrefs.SetInt("OldFight", 6);
                TalesVariables.Tales = TalesVariables.TalesWilliamWFight;
                TalesVariables.SetTale(6);
                TalesVariables.Index += 1;
                break;

            //1500 Set Tale for CustonRoute

            case 1501:
                TalesVariables.Tales = TalesVariables.TalesCustonRoute;
                TalesVariables.SetTale(0);
                TalesVariables.Index += 1;
                break;
            case 1502:
                TalesVariables.Tales = TalesVariables.TalesCustonRoute;
                TalesVariables.SetTale(1);
                TalesVariables.Index += 1;
                break;
            case 1503:
                TalesVariables.Tales = TalesVariables.TalesCustonRoute;
                TalesVariables.SetTale(2);
                TalesVariables.Index += 1;
                break;
            case 1504:
                TalesVariables.Tales = TalesVariables.TalesCustonRoute;
                TalesVariables.SetTale(3);
                TalesVariables.Index += 1;
                break;
            case 1505:
                TalesVariables.Tales = TalesVariables.TalesCustonRoute;
                TalesVariables.SetTale(25);
                TalesVariables.Index += 1;
                break;

            //1600 Set Tale for other List Assassin
            case 1601:
                TalesVariables.Tales = TalesVariables.TalesCustonRouteAS;
                TalesVariables.SetTale(0);
                TalesVariables.Index += 1;
                break;
            case 1602:
                TalesVariables.Tales = TalesVariables.TalesCustonRouteAS;
                TalesVariables.SetTale(12);
                TalesVariables.Index += 1;
                break;
            case 1603:
                TalesVariables.Tales = TalesVariables.TalesCustonRouteAS;
                TalesVariables.SetTale(19);
                TalesVariables.Index += 1;
                break;

            case 1701:
                PlayerPrefs.SetInt("OldFight", 0);
                TalesVariables.Tales = TalesVariables.TalesWilliamWFightAS;
                TalesVariables.SetTale(0);
                TalesVariables.Index += 1;
                break;
            case 1702:
                PlayerPrefs.SetInt("OldFight", 1);
                TalesVariables.Tales = TalesVariables.TalesWilliamWFightAS;
                TalesVariables.SetTale(1);
                TalesVariables.Index += 1;
                break;
            case 1703:
                PlayerPrefs.SetInt("OldFight", 2);
                TalesVariables.Tales = TalesVariables.TalesWilliamWFightAS;
                TalesVariables.SetTale(2);
                TalesVariables.Index += 1;
                break;
            case 1704:
                PlayerPrefs.SetInt("OldFight", 3);
                TalesVariables.Tales = TalesVariables.TalesWilliamWFightAS;
                TalesVariables.SetTale(4);
                TalesVariables.Index += 1;
                break;
            case 1705:
                PlayerPrefs.SetInt("OldFight", 4);
                TalesVariables.Tales = TalesVariables.TalesWilliamWFightAS;
                TalesVariables.SetTale(3);
                TalesVariables.Index += 1;
                break;
        
























            case 101:
                SetTaleSkillAF1(a);
                break;

            case 102:
                SetTaleSkillAF1(a);
                break;

            case 103:
                SetTaleSkillAF1(a);
                break;

            case 104:
                SetTaleSkillAF1(a);
                break;

            case 105:
                SetTaleSkillAF1(a);
                break;

            case 201:
                SetTaleSkillAF2(a);
                break;
            case 301:
                SetTaleSkillAR1(a);
                break;
            case 401:
                SetTaleSkillAR2(a);
                break;
            case 501:
                SetTaleSkillB1(a);
                break;
            case 502:
                SetTaleSkillB1(a);
                break;
            case 601:
                SetTaleSkillB2(a);
                break;
            case 701:
                SetTaleSkillD1(a);
                break;
            case 703:
                SetTaleSkillD1(a);
                break;
            case 801:
                SetTaleSkillD2(a);
                break;





        }
    }
    //Only Work Index<11
    public void SetTale(int b)
    {
        TalesVariables.Index = b - 1000;
        TalesVariables.ShowText();
        TalesVariables.Index += 1;
    }
    public void SetTaleSkillAF1(int b)
    {
        SkillA.SelecTSkill(1);
        TalesVariables.Index = b - 100;
        TalesVariables.ShowText();
        TalesVariables.Index += 1;
    }
    public void SetTaleSkillAF2(int b)
    {
        SkillA.SelecTSkill(5);
        TalesVariables.Index = b - 200;
        TalesVariables.ShowText();
        TalesVariables.Index += 1;
    }
    public void SetTaleSkillAR1(int b)
    {
        SkillA.SelecTSkill(2);
        TalesVariables.Index = b - 300;
        TalesVariables.ShowText();
        TalesVariables.Index += 1;
    }
    public void SetTaleSkillAR2(int b)
    {
        SkillA.SelecTSkill(6);
        TalesVariables.Index = b - 400;
        TalesVariables.ShowText();
        TalesVariables.Index += 1;
    }
    public void SetTaleSkillB1(int b)
    {
        SkillA.SelecTSkill(3);
        TalesVariables.Index = b - 500;
        TalesVariables.ShowText();
        TalesVariables.Index += 1;
    }
    public void SetTaleSkillB2(int b)
    {
        SkillA.SelecTSkill(7);
        TalesVariables.Index = b - 600;
        TalesVariables.ShowText();
        TalesVariables.Index += 1;
    }
    public void SetTaleSkillD1(int b)
    {
        SkillA.SelecTSkill(4);
        TalesVariables.Index = b - 700;
        TalesVariables.ShowText();
        TalesVariables.Index += 1;
    }
    public void SetTaleSkillD2(int b)
    {
        SkillA.SelecTSkill(8);
        TalesVariables.Index = b - 800;
        TalesVariables.ShowText();
        TalesVariables.Index += 1;
    }
    public void TranslateButton(int id1, int id2, int id3, int id4, int id5)
    {
        int language;
        language = PlayerPrefs.GetInt("Language");
        Idbuttons.Clear();
        if (id1 != 0)
        {
            Idbuttons.Add(id1);
        }
        if (id2 != 0)
        {
            Idbuttons.Add(id2);
        }
        if (id3 != 0)
        {
            Idbuttons.Add(id3);
        }
        if (id4 != 0)
        {
            Idbuttons.Add(id4);
        }
        if (id5 != 0)
        {
            Idbuttons.Add(id5);
        }

        for (int x = 0; x < Idbuttons.Count; x = x + 1)
        {

            if (language == 0)
            {
                TranslateButtonEN(Idbuttons[x], x);
            }
            if (language == 1)
            {
                TranslateButtonBR(Idbuttons[x], x);
            }

        }

    }

    public void TranslateButtonEN(int idbutton, int nextbutton)
    {
        Debug.Log("PIMBA");
        string ButtonText = "";
        switch (idbutton)
        {
            case 1:
                ButtonText = "I can";
                break;
            case 2:
                ButtonText = "I can't";
                break;
            case 3:
                ButtonText = "Decline offer";
                break;
            case 4:
                ButtonText = "It's not up to me to make this decision";
                break;
            case 5:
                ButtonText = "Accept the bad luck";
                break;
            case 6:
                ButtonText = "Flip the coin againZ";
                break;
            case 7:
                ButtonText = "Play a religious song";
                break;
            case 8:
                ButtonText = "Play a love song";
                break;
            case 9:
                ButtonText = "Play a patriotic song";
                break;
            case 10:
                ButtonText = "Play an instrumental song";
                break;
            case 11:
                ButtonText = "Play a song";
                break;
            case 12:
                ButtonText = "Read a book";
                break;
            case 13:
                ButtonText = "Follow your heart";
                break;
            case 14:
                ButtonText = "Follow Shuá";
                break;
            case 15:
                ButtonText = "Join the prayer";
                break;
            case 16:
                ButtonText = "Doubt the existence of Shuá";
                break;
            case 17:
                ButtonText = "Follow the Path of Shuá";
                break;
            case 18:
                ButtonText = "Follow the Path of Warrior";
                break;
            case 19:
                ButtonText = "Question the monk";
                break;
            case 20:
                ButtonText = "Ask for the monk's forgiveness";
                break;
            case 21:
                ButtonText = "Accept the bribe";
                break;
            case 22:
                ButtonText = "Refuse the bribe";
                break;
            case 23:
                ButtonText = "Kill him";
                break;
            case 24:
                ButtonText = "Spare him";
                break;
            case 25:
                ButtonText = "Accept the offer";
                break;
            case 26:
                ButtonText = "Decline the offer";
                break;
            case 27:
                ButtonText = "Congratulations!";
                break;
            case 28:
                ButtonText = "Screw this";
                break;
            case 29:
                ButtonText = "Follow the Path of Warrior";
                break;
            case 30:
                ButtonText = "Follow the Path of Assassin";
                break;

        }
        TalesVariables.OptionsText1[nextbutton].text = ButtonText;
    }
    public void TranslateButtonBR(int idbutton, int nextbutton)
    {
        Debug.Log("Foi");
        string ButtonText = "";
        Debug.Log(idbutton);
        Debug.Log(nextbutton);
        switch (idbutton)
        {
          
            case 1:
                ButtonText = "Eu consigo";
                break;
            case 2:
                ButtonText = "Eu não consigo";
                break;
            case 3:
                ButtonText = "Recusar a oferta";
                break;
            case 4:
                ButtonText = "Não cabe a mim tomar essa decisão";
                break;
            case 5:
                Debug.Log("AAAAAAAA");
                ButtonText = "Aceite o azar";
                break;
            case 6:
                Debug.Log("BBBBBBBBBBBBBBBB");
                ButtonText = "Jogue a moeda novamente";
                break;
            case 7:
                ButtonText = "Toque uma música religiosa";
                break;
            case 8:
                ButtonText = "Toque uma música de amor";
                break;
            case 9:
                ButtonText = "Toque uma música patriótica";
                break;
            case 10:
                ButtonText = "Toque uma música instrumental";
                break;
            case 11:
                ButtonText = "Toque uma música";
                break;
            case 12:
                ButtonText = "Leia um livro";
                break;
            case 13:
                ButtonText = "Siga seus coração";
                break;
            case 14:
                ButtonText = "Siga Shuá";
                break;
            case 15:
                ButtonText = "Junte-se à oração";
                break;
            case 16:
                ButtonText = "Duvidar da existência de Shuá";
                break;
            case 17:
                ButtonText = "Siga o Caminho de Shuá";
                break;
            case 18:
                ButtonText = "Siga o Caminho do Guerreiro";
                break;
            case 19:
                ButtonText = "Questione o monge";
                break;
            case 20:
                ButtonText = "Peça o perdão do monge";
                break;
            case 21:
                ButtonText = "Aceite o suborno";
                break;
            case 22:
                ButtonText = "Recuse o suborno";
                break;
            case 23:
                ButtonText = "Mate Joshua";
                break;
            case 24:
                ButtonText = "Poupe Joshua";
                break;
            case 25:
                ButtonText = "Aceite a oferta";
                break;
            case 26:
                ButtonText = "Recuse a oferta";
                break;
            case 27:
                ButtonText = "Parabéns!";
                break;
            case 28:
                ButtonText = "Foda-se";
                break;
            case 29:
                ButtonText = "Seguir o Caminho do Guerreiro";
                break;
            case 30:
                ButtonText = "Seguir o Caminho do Assassino";
                break;
        }
        Debug.Log(ButtonText);
        TalesVariables.OptionsText[nextbutton] = ButtonText;
        TalesVariables.OptionsText1[nextbutton].text = ButtonText;
    }
}
