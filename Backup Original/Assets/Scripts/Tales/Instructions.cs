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
    public GodCube GodCube;//x

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
        int chaos;
        switch (a)
        {
            case 0:

                TalesVariables.ShowText();
                break;

            //SetFight
            case 1:

                StaticPlayer.Fight = 1;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 2:
                StaticPlayer.Fight = 2;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 3:
                StaticPlayer.Fight = 3;
                TalesVariables.Loading.SetActive(true);
                //SceneManager.LoadScene("Battle");
                GodCube.TakeScreenshot("Battle");
                break;
            case 4:
                StaticPlayer.Fight = 4;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 5:
                StaticPlayer.Fight = 5;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 6:
                StaticPlayer.Fight = 6;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 7:
                StaticPlayer.Fight = 7;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 8:
                StaticPlayer.Fight = 8;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 9:
                StaticPlayer.Fight = 9;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 10:
                StaticPlayer.Fight = 10;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 11:
                StaticPlayer.Fight = 11;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 12:
                StaticPlayer.Fight = 12;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 13:
                StaticPlayer.Fight = 13;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 14:
                StaticPlayer.Fight = 14;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 15:
                StaticPlayer.Fight = 15;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 16:
                StaticPlayer.Fight = 16;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;

            case 17:

                StaticPlayer.Fight = 17;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 18:
                StaticPlayer.Fight = 18;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 19:
                StaticPlayer.Fight = 19;
                TalesVariables.Loading.SetActive(true);
                //SceneManager.LoadScene("Battle");
                GodCube.TakeScreenshot("Battle");
                break;
            case 20:
                StaticPlayer.Fight = 20;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 21:
                StaticPlayer.Fight = 21;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 22:
                StaticPlayer.Fight = 22;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 23:
                StaticPlayer.Fight = 23;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 24:
                StaticPlayer.Fight = 24;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 25:
                StaticPlayer.Fight = 25;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 26:
                StaticPlayer.Fight = 26;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 27:
                StaticPlayer.Fight = 27;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 28:
                StaticPlayer.Fight = 28;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 29:
                StaticPlayer.Fight = 29;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 30:
                StaticPlayer.Fight = 30;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 31:
                StaticPlayer.Fight = 31;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 32:
                StaticPlayer.Fight = 32;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 33:
                StaticPlayer.Fight = 33;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 34:
                StaticPlayer.Fight = 34;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 35:
                StaticPlayer.Fight = 35;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 36:
                StaticPlayer.Fight = 36;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 37:
                StaticPlayer.Fight = 37;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 38:
                StaticPlayer.Fight = 38;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 39:
                StaticPlayer.Fight = 39;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 40:
                StaticPlayer.Fight = 40;
                TalesVariables.Loading.SetActive(true);
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
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
            case 103:
                TalesVariables.SetTale(a - 100);
                break;
            case 104:
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
            case 125:
                TalesVariables.SetTale(a - 100);
                break;
            case 126:
                TalesVariables.SetTale(a - 100);
                break;
            case 127:
                TalesVariables.SetTale(a - 100);
                break;
            case 128:
                TalesVariables.SetTale(a - 100);
                break;
            case 129:
                TalesVariables.SetTale(a - 100);
                break;
            case 130:
                TalesVariables.SetTale(a - 100);
                break;
            case 131:
                TalesVariables.SetTale(a - 100);
                break;
            case 132:
                TalesVariables.SetTale(a - 100);
                break;
            case 133:
                TalesVariables.SetTale(a - 100);
                break;
            case 134:
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
                SetButtonST("I can.", "I can't.", "", "", "");
                SetButton(1008, 1009, 0, 0, 0);
                TalesVariables.ButtonInstructions.TranslateButton(1, 2, 0, 0, 0);
                TalesVariables.ShowText();
                break;

            case 313:
                SetButtonST("Decline offer.", "It's not up to me to make this decision.", "", "", "");
                SetButton(1011, 1010, 0, 0, 0);
                TalesVariables.ButtonInstructions.TranslateButton(3, 4, 0, 0, 0);
                TalesVariables.ShowText();
                break;
            case 314:
                StaticPlayer.PlayerId[1] = 11;
                StaticPlayer.PlayerLife[0] = 3;
                GodCube.TakeScreenshot("Battle");
                //SceneManager.LoadScene("Battle");
                break;
            case 315:
                SetButtonST("Accept the bad luck", "Flip the coin again", "", "", "");
                TalesVariables.ButtonInstructions.TranslateButton(5, 6, 0, 0, 0);
                SetButton(-101, -102, 0, 0, 0);
                TalesVariables.ShowText();
                break;
            case 316:
                SetButtonST("Play a religious song", "Play a love song", "Play a patriotic song", "Play an instrumental song", "");
                SetButton(1301, 1302, 1303, 1304, 0);
                TalesVariables.ButtonInstructions.TranslateButton(7, 8, 9, 10, 0);
                TalesVariables.ShowText();
                break;
            case 317:
                SetButtonST("Play a song", "Read a book", "", "", "");
                SetButton(1305, 1306, 0, 0, 0);
                TalesVariables.ButtonInstructions.TranslateButton(11, 12, 0, 0, 0);
                TalesVariables.ShowText();
                break;
            case 318:
                SetButtonST("Follow your heart", "Follow Shuá", "", "", "");
                SetButton(1019, 1020, 0, 0, 0);
                TalesVariables.ButtonInstructions.TranslateButton(13, 14, 0, 0, 0);
                TalesVariables.ShowText();
                break;
            case 319:
                SetButtonST("Join the prayer", "Doubt the existence of Shuá", "", "", "");
                SetButton(1016, 1017, 0, 0, 0);
                TalesVariables.ButtonInstructions.TranslateButton(15, 16, 0, 0, 0);
                TalesVariables.ShowText();
                break;
            case 320:
                SetButtonST("Follow the Path of Shuá", "Follow the Path of Warrior", "", "", "");
                SetButton(1014, 1013, 0, 0, 0);
                TalesVariables.ButtonInstructions.TranslateButton(17, 18, 0, 0, 0);
                TalesVariables.ShowText();
                break;
            case 321:
                SetButtonST("Question the monk", "Ask for the monk's forgiveness", "", "", "");
                SetButton(1022, 1023, 0, 0, 0);
                TalesVariables.ButtonInstructions.TranslateButton(19, 20, 0, 0, 0);
                TalesVariables.ShowText();
                break;
            case 322:
                SetButtonST("Accept the bribe", "Refuse the bribe", "", "", "");
                SetButton(1009, 1024, 0, 0, 0);
                TalesVariables.ButtonInstructions.TranslateButton(21, 22, 0, 0, 0);
                TalesVariables.ShowText();
                break;
            case 323:
                SetButtonST("Kill him", "Spare him", "", "", "");
                SetButton(1017, 1016, 0, 0, 0);
                TalesVariables.ButtonInstructions.TranslateButton(23, 24, 0, 0, 0);
                TalesVariables.ShowText();
                break;
            case 324:
                SetButtonST("Accept the offer", "Decline the offer", "", "", "");
                SetButton(1002, 1001, 0, 0, 0);
                TalesVariables.ButtonInstructions.TranslateButton(25, 26, 0, 0, 0);
                TalesVariables.ShowText();
                break;
            case 325:
                SetButtonST("Congratulations!", "Screw this", "", "", "");
                SetButton(1005, 1006, 0, 0, 0);
                TalesVariables.ButtonInstructions.TranslateButton(27, 28, 0, 0, 0);
                TalesVariables.ShowText();
                break;
            case 326:
                SetButtonST("Follow the Path of Warrior", "Follow the Path of Assassin", "", "", "");
                SetButton(1, 2, 0, 0, 0);
                TalesVariables.ButtonInstructions.TranslateButton(29, 30, 0, 0, 0);
                TalesVariables.ShowText();
                break;
            //500 Genecric

            case 500:
                TalesVariables.Day.FightCrime(0);
                break;
            case 501:
                TalesVariables.Day.FightCrimeAS(1);
                break;
            case 502:
                TalesVariables.SetPrayTale();
                break;





            case 666:
                TalesVariables.Obrigado.SetActive(true);
                ResetGame();
                break;




            //700 Pray Tales SType= Set List Tale  SIndex= Set Index
            //Stype1= CustonRouteAs
            case 700:
                PlayerPrefs.SetInt("SType", 1);
                PlayerPrefs.SetInt("SIndex", 8);
                GodCube.TakeScreenshot("Pray");
                break;
            case 701:
                PlayerPrefs.SetInt("SType", 1);
                PlayerPrefs.SetInt("SIndex", 9);
                GodCube.TakeScreenshot("Pray");
                break;
            case 702:
            
                PlayerPrefs.SetInt("SType", 1);
                chaos = Random.Range(0, 2);
                if (chaos == 0)
                {
                    PlayerPrefs.SetInt("SIndex", 10);
                }
                else
                {
                    PlayerPrefs.SetInt("SIndex", 11);
                }
                GodCube.TakeScreenshot("Pray");
                break;
            case 703:
                PlayerPrefs.SetInt("SType", 2);
                PlayerPrefs.SetInt("SIndex", 18);
                GodCube.TakeScreenshot("Pray");
                break;


            //800 Relic Reward
            case 821: //Milho
                SkillA.SpecificRelicReward(a - 800);
                TalesVariables.ShowText();
                break;
            case 832: //Garrafa
                SkillA.SpecificRelicReward(a - 800);
                TalesVariables.ShowText();
                break;
            case 833: //Caixão
                SkillA.SpecificRelicReward(a-800);
                TalesVariables.ShowText();
                break;

            //900 END
            case 901:
                TalesVariables.Obrigado.SetActive(true);
                TalesVariables.EndScene(a-900);
                ResetGame();
                break;
            case 902:
                TalesVariables.Obrigado.SetActive(true);
                TalesVariables.EndScene(a - 900);
                ResetGame();
                break;
            case 903:
                TalesVariables.Obrigado.SetActive(true);
                TalesVariables.EndScene(a - 900);
                ResetGame();
                break;
            case 904:
                TalesVariables.Obrigado.SetActive(true);
                TalesVariables.EndScene(a - 900); 
                ResetGame();
                break;
            case 905:
                TalesVariables.Obrigado.SetActive(true);
                TalesVariables.EndScene(a - 900);
                ResetGame();
                break;
            case 906:
                TalesVariables.Obrigado.SetActive(true);
                TalesVariables.EndScene(a - 900);
                ResetGame();
                break;
            case 907:
                TalesVariables.Obrigado.SetActive(true);
                TalesVariables.EndScene(a - 900);
                ResetGame();
                break;
            case 908:
                TalesVariables.Obrigado.SetActive(true);
                TalesVariables.EndScene(a - 900);
                ResetGame();
                break;
            case 909:
                TalesVariables.Obrigado.SetActive(true);
                TalesVariables.EndScene(a - 900);
                ResetGame();
                break;
            case 910:
                TalesVariables.Obrigado.SetActive(true);
                TalesVariables.EndScene(a - 900);
                ResetGame();
                break;
            case 911:
                TalesVariables.Obrigado.SetActive(true);
                TalesVariables.EndScene(a - 900);
                ResetGame();
                break;
            case 912:
                TalesVariables.Obrigado.SetActive(true);
                TalesVariables.EndScene(a - 900);
                ResetGame();
                break;


            //1000 Special Instructions
            //*****************************************************
            case 1000: //GreatReward
                SkillA.RelicReward();
                SkillA.TrueTrueGodReward();
                TalesVariables.ShowText();
                break;
            case 1001: //Reward
                SkillA.TrueTrueGodReward();
                TalesVariables.ShowText();
                break;
            case 1002: //NextDay
                if (StaticPlayer.PlayerId[0] == 28)
                {
                    TalesVariables.Day.SelectDay();
                }
                if (StaticPlayer.PlayerId[0] == 29)
                {
                    TalesVariables.Day.SelectDayAssassin();
                }

                break;
            case 1003: //Minigame
                TalesVariables.Day.Minigame();
                break;
            case 1004: //Relic Reward
                SkillA.RelicReward();
                TalesVariables.ShowText();
                break;
            case 1005: //Old Fight Reset
                PlayerPrefs.SetInt("OldFight", -1);
                TalesVariables.ShowText();
                break;
            case 1006: //Relic Sword
                SkillA.RelicRewardSword();
                TalesVariables.ShowText();
                break;
            case 1007: //Relic Dagger
                SkillA.RelicRewardDagger();
                TalesVariables.ShowText();
                break;
            case 1008: //Anne Laura
                int Anne;
                Anne = PlayerPrefs.GetInt("Anne");
                if (Anne == 0)
                {
                    Debug.Log("Laura");
                    StaticPlayer.Fight = 15 ;
                    TalesVariables.Loading.SetActive(true);
                    GodCube.TakeScreenshot("Battle");

                }
                if (Anne == 1)
                {
                    Debug.Log("Anne1");
                    StaticPlayer.Fight = 11;
                    TalesVariables.Loading.SetActive(true);
                    GodCube.TakeScreenshot("Battle");

                }
                break;
            case 1009: //song
                PlayerPrefs.SetInt("God", 4);//Maná
                GodCube.TakeScreenshot("Song");
                break;


            //*****************************************************
            //2000 RewardTale
            //*****************************************************

            case 2150:
                SkillA.RewardTale(a-2100, 1);
                TalesVariables.ShowText();
                break;
            case 2151:
                SkillA.RewardTale(a - 2100, 1);
                TalesVariables.ShowText();
                break;
            case 2152:
                SkillA.RewardTale(a - 2100, 1);
                TalesVariables.ShowText();
                break;
            case 2153:
                SkillA.RewardTale(a - 2100, 1);
                TalesVariables.ShowText();
                break;
            case 2154:
                SkillA.RewardTale(a - 2100, 1);
                TalesVariables.ShowText();
                break;
            case 2155:
                SkillA.RewardTale(a - 2100, 1);
                TalesVariables.ShowText();
                break;
            case 2156:
                SkillA.RewardTale(a - 2100, 1);
                TalesVariables.ShowText();
                break;
            case 2157:
                SkillA.RewardTale(a - 2100, 1);
                TalesVariables.ShowText();
                break;
            case 2158:
                SkillA.RewardTale(a - 2100, 1);
                TalesVariables.ShowText();
                break;
            case 2159:
                SkillA.RewardTale(a - 2100, 1);
                TalesVariables.ShowText();
                break;
            case 2160:
                SkillA.RewardTale(a - 2100, 1);
                TalesVariables.ShowText();
                break;
            case 2161:
                SkillA.RewardTale(a - 2100, 1);
                TalesVariables.ShowText();
                break;

            case 2250:
                SkillA.RewardTale(a - 2200, 2);
                TalesVariables.ShowText();
                break;
            case 2251:
                SkillA.RewardTale(a - 2200, 2);
                TalesVariables.ShowText();
                break;
            case 2252:
                SkillA.RewardTale(a - 2200, 2);
                TalesVariables.ShowText();
                break;
            case 2253:
                SkillA.RewardTale(a - 2200, 2);
                TalesVariables.ShowText();
                break;
            case 2254:
                SkillA.RewardTale(a - 2200, 2);
                TalesVariables.ShowText();
                break;
            case 2255:
                SkillA.RewardTale(a - 2200, 2);
                TalesVariables.ShowText();
                break;
            case 2256:
                SkillA.RewardTale(a - 2200, 2);
                TalesVariables.ShowText();
                break;
            case 2257:
                SkillA.RewardTale(a - 2200, 2);
                TalesVariables.ShowText();
                break;
            case 2258:
                SkillA.RewardTale(a - 2200, 2);
                TalesVariables.ShowText();
                break;
            case 2259:
                SkillA.RewardTale(a - 2200, 2);
                TalesVariables.ShowText();
                break;
            case 2260:
                SkillA.RewardTale(a - 2200, 2);
                TalesVariables.ShowText();
                break;
            case 2261:
                SkillA.RewardTale(a - 2200, 2);
                TalesVariables.ShowText();
                break;
            case 2350:
                SkillA.RewardTale(a - 2300, 3);
                TalesVariables.ShowText();
                break;
            case 2351:
                SkillA.RewardTale(a - 2300, 3);
                TalesVariables.ShowText();
                break;
            case 2352:
                SkillA.RewardTale(a - 2300, 3);
                TalesVariables.ShowText();
                break;
            case 2353:
                SkillA.RewardTale(a - 2300, 3);
                TalesVariables.ShowText();
                break;
            case 2354:
                SkillA.RewardTale(a - 2300, 3);
                TalesVariables.ShowText();
                break;
            case 2355:
                SkillA.RewardTale(a - 2300, 3);
                TalesVariables.ShowText();
                break;
            case 2356:
                SkillA.RewardTale(a - 2300, 3);
                TalesVariables.ShowText();
                break;
            case 2357:
                SkillA.RewardTale(a - 2300, 3);
                TalesVariables.ShowText();
                break;
            case 2358:
                SkillA.RewardTale(a - 2300, 3);
                TalesVariables.ShowText();
                break;
            case 2359:
                SkillA.RewardTale(a - 2300, 3);
                TalesVariables.ShowText();
                break;
            case 2360:
                SkillA.RewardTale(a - 2300, 3);
                TalesVariables.ShowText();
                break;
            case 2361:
                SkillA.RewardTale(a - 2300, 3);
                TalesVariables.ShowText();
                break;
            case 2450:
                SkillA.RewardTale(a - 2400, 4);
                TalesVariables.ShowText();
                break;
            case 2451:
                SkillA.RewardTale(a - 2400, 4);
                TalesVariables.ShowText();
                break;
            case 2452:
                SkillA.RewardTale(a - 2400, 4);
                TalesVariables.ShowText();
                break;
            case 2453:
                SkillA.RewardTale(a - 2400, 4);
                TalesVariables.ShowText();
                break;
            case 2454:
                SkillA.RewardTale(a - 2400, 4);
                TalesVariables.ShowText();
                break;
            case 2455:
                SkillA.RewardTale(a - 2400, 4);
                TalesVariables.ShowText();
                break;
            case 2456:
                SkillA.RewardTale(a - 2400, 4);
                TalesVariables.ShowText();
                break;
            case 2457:
                SkillA.RewardTale(a - 2400, 4);
                TalesVariables.ShowText();
                break;
            case 2458:
                SkillA.RewardTale(a - 2400, 4);
                TalesVariables.ShowText();
                break;
            case 2459:
                SkillA.RewardTale(a - 2400, 4);
                TalesVariables.ShowText();
                break;
            case 2460:
                SkillA.RewardTale(a - 2400, 4);
                TalesVariables.ShowText();
                break;
            case 2461:
                SkillA.RewardTale(a - 2400, 4);
                TalesVariables.ShowText();
                break;

            case -1:
                RandomActions();
                break;
            case -2:
                if (StaticPlayer.PlayerId[0] == 28)
                {
                    RandomCustomRoute();
                }
                if (StaticPlayer.PlayerId[0] == 29)
                {
                    RandomCustomRouteAS();
                }

                break;
            case -3:
                RandomActionsAS();
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
        //translate button
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
    public void RandomCustomRouteAS()
    {

        int Route1;
        int Route2;
        int Route3;
        int chaos;

        for (int x = 0; x < TalesVariables.TalesCustonRouteTrueAs.Count; x = x + 1)
        {
            TalesVariables.CustonRoute.Add(x);
        }

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


        int language;
        language = PlayerPrefs.GetInt("Language");

        for (int x = 0; x < 3; x = x + 1)
        {
            if (language == 0)
            {
                if (Routes[x] == 0)
                {
                    Inteiro[x] = 1601;
                    Caracter[x] = "Sell Drugs";
                }
                if (Routes[x] == 1)
                {
                    Inteiro[x] = 1602;
                    Caracter[x] = "Kill a Rapist";
                }
                if (Routes[x] == 2)
                {
                    Inteiro[x] = 1603;
                    Caracter[x] = "Look to the Sky";
                }
            }
            if (language == 1)
            {
                if (Routes[x] == 0)
                {
                    Inteiro[x] = 1601;
                    Caracter[x] = "Venda Drogas.";
                }
                if (Routes[x] == 1)
                {
                    Inteiro[x] = 1602;
                    Caracter[x] = "Mate um Estuprador.";
                }
                if (Routes[x] == 2)
                {
                    Inteiro[x] = 1603;
                    Caracter[x] = "Olhe para o Céu.";
                }
            }
            //Gay Kiss
            //Eat Corn
        }
        SetButtonST(Caracter[0], Caracter[1], Caracter[2], "", "");
        SetButton(Inteiro[0], Inteiro[1], Inteiro[2], 0, 0);
        TalesVariables.ShowText();
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


        int language;
        language = PlayerPrefs.GetInt("Language");

        for (int x = 0; x < 3; x = x + 1)
        {
            if (language == 0)
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
                if (Routes[x] == 4)
                {
                    Inteiro[x] = 1505;
                    Caracter[x] = "Eat corn";
                }
            }
            if (language == 1)
            {
                if (Routes[x] == 0)
                {
                    Inteiro[x] = 1501;
                    Caracter[x] = "Beba no bar.";
                }
                if (Routes[x] == 1)
                {
                    Inteiro[x] = 1502;
                    Caracter[x] = "Visite um cemitério.";
                }
                if (Routes[x] == 2)
                {
                    Inteiro[x] = 1503;
                    Caracter[x] = "Reze.";
                }
                if (Routes[x] == 3)
                {
                    Inteiro[x] = 1504;
                    Caracter[x] = "Cobre um suborno.";
                }
                if (Routes[x] == 4)
                {
                    Inteiro[x] = 1505;
                    Caracter[x] = "Coma milho.";
                }
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
        int OldFight;
        OldFight = PlayerPrefs.GetInt("OldFight");
        TalesVariables.FightL.Clear();
        TalesVariables.FightL1.Clear();
        for (int x = 0; x < TalesVariables.TalesWilliamWFight.Count; x = x + 1)
        {
            if (x != OldFight)
            {
                TalesVariables.FightL.Add(x);
            }
           
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

        int language;
        language = PlayerPrefs.GetInt("Language");

        for (int x = 0; x < 3; x = x + 1)
        {
            if (language == 0)
            {
                if (TalesVariables.FightL1[x] == 0)
                {
                    Inteiro[x] = 1401;
                    Caracter[x] = "Apology for Crime.";
                }
                if (TalesVariables.FightL1[x] == 1)
                {
                    Inteiro[x] = 1402;
                    Caracter[x] = "Theft.";
                }
                if (TalesVariables.FightL1[x] == 2)
                {
                    Inteiro[x] = 1403;
                    Caracter[x] = "Drug Trafficking.";
                }
                if (TalesVariables.FightL1[x] == 3)
                {
                    Inteiro[x] = 1404;
                    Caracter[x] = "Illegal Emigration.";
                }
                if (TalesVariables.FightL1[x] == 4)
                {
                    Inteiro[x] = 1405;
                    Caracter[x] = "Organ Trafficking.";
                }
                if (TalesVariables.FightL1[x] == 5)
                {
                    Inteiro[x] = 1406;
                    Caracter[x] = "Tax Evasion.";
                }
            }

            if (language == 1)
            {
                if (TalesVariables.FightL1[x] == 0)
                {
                    Inteiro[x] = 1401;
                    Caracter[x] = "Apologia ao Crime.";
                }
                if (TalesVariables.FightL1[x] == 1)
                {
                    Inteiro[x] = 1402;
                    Caracter[x] = "Roubo.";
                }
                if (TalesVariables.FightL1[x] == 2)
                {
                    Inteiro[x] = 1403;
                    Caracter[x] = "Tráfico de Drogas.";
                }
                if (TalesVariables.FightL1[x] == 3)
                {
                    Inteiro[x] = 1404;
                    Caracter[x] = "Emigração Ilegal.";
                }
                if (TalesVariables.FightL1[x] == 4)
                {
                    Inteiro[x] = 1405;
                    Caracter[x] = "Tráfico de Órgãos.";
                }
                if (TalesVariables.FightL1[x] == 5)
                {
                    Inteiro[x] = 1406;
                    Caracter[x] = "Sonegação.";
                }
            }

        }

        SetButtonST(Caracter[0], Caracter[1], Caracter[2], "", "");
        SetButton(Inteiro[0], Inteiro[1], Inteiro[2], 0, 0);
        TalesVariables.ShowText();

    }
    public void RandomActionsAS()
    {
        int CountFightL1;
        int RandomRemove;
        int OldFight;
        OldFight = PlayerPrefs.GetInt("OldFight");
        TalesVariables.FightL.Clear();
        TalesVariables.FightL1.Clear();
        for (int x = 0; x < TalesVariables.TalesWilliamWFightAS.Count; x = x + 1)
        {
            if (x != OldFight)
            {
                TalesVariables.FightL.Add(x);
            }
            
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

        int language;
        language = PlayerPrefs.GetInt("Language");

        for (int x = 0; x < 3; x = x + 1)
        {
            if (language == 0)
            {
                if (TalesVariables.FightL1[x] == 0)
                {
                    Inteiro[x] = 1701;
                    Caracter[x] = "Apology for Crime.";
                }
                if (TalesVariables.FightL1[x] == 1)
                {
                    Inteiro[x] = 1702;
                    Caracter[x] = "Drug Trafficking.";
                }
                if (TalesVariables.FightL1[x] == 2)
                {
                    Inteiro[x] = 1703;
                    Caracter[x] = "Illegal Immigration.";
                }
                if (TalesVariables.FightL1[x] == 3)
                {
                    Inteiro[x] = 1704;
                    Caracter[x] = "Organ Trafficking.";
                }
                if (TalesVariables.FightL1[x] == 4)
                {
                    Inteiro[x] = 1705;
                    Caracter[x] = "Tax Evasion.";
                }
            }

            if (language == 1)
            {
                if (TalesVariables.FightL1[x] == 0)
                {
                    Inteiro[x] = 1701;
                    Caracter[x] = "Apologia ao Crime.";
                }
                if (TalesVariables.FightL1[x] == 1)
                {
                    Inteiro[x] = 1702;
                    Caracter[x] = "Tráfico de Drogas.";
                }
                if (TalesVariables.FightL1[x] == 2)
                {
                    Inteiro[x] = 1703;
                    Caracter[x] = "Imigração Ilegal.";
                }
                if (TalesVariables.FightL1[x] == 3)
                {
                    Inteiro[x] = 1704;
                    Caracter[x] = "Tráfico de Órgãos.";
                }
                if (TalesVariables.FightL1[x] == 4)
                {
                    Inteiro[x] = 1705;
                    Caracter[x] = "Sonegação.";
                }
            }

        }

        SetButtonST(Caracter[0], Caracter[1], Caracter[2], "", "");
        SetButton(Inteiro[0], Inteiro[1], Inteiro[2], 0, 0);
        TalesVariables.ShowText();

    }
    public void ResetGame()
    {

        //mover para adventure
        PlayerPrefs.SetInt("Day", 0);


        PlayerPrefs.SetInt("Skill1", 0);
        PlayerPrefs.SetInt("Skill2", 0);
        PlayerPrefs.SetInt("Skill3", 0);
        PlayerPrefs.SetInt("Skill4", 0);

        PlayerPrefs.SetInt("Relic1", 0);
        PlayerPrefs.SetInt("Relic2", 0);
        PlayerPrefs.SetInt("Relic3", 0);
        PlayerPrefs.SetInt("Relic4", 0);
        PlayerPrefs.SetInt("Relic5", 0);

        StaticPlayer.RelicsAlly.Clear();
    }
}
