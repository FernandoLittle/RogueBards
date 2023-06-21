using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dio : MonoBehaviour
{
    public Money Money;
    public Image BackgroundI;
    public Sprite BackgroundS1;
    public List<Sprite> BackgroundS;
    public List<GameObject> BuyButtons;
    public List<int> Upgrades;
    public List<int> PricesUpgrade1;
    public List<int> PricesUpgrade2;
    public List<int> PricesUpgrade3;
    public List<int> PricesUpgrade4;
    public GameObject DiscordButton;
    public List<AudioClip> Musiquinhas;
    public AudioSource Hihi;
    public List<int> DialogueInstruction;
    public GameObject DialogueO;

    //1, 2, 3, 4== BackGrounds
    public int money;
    public Text DialogueText;
    public MonsterDialogue MonsterDialogue;
    public List<bool> OldDialogues;
    public GameObject BackgroundO;
    public GameObject MusicO;
    public GameObject YoutubeO;
    public GameObject UpgradeO;
    public GameObject MiniGameO;
    public GameObject FeaturesO;
    public int language;
    public Animator DialogueAnime;
    public int test;
    public Generic Generic;
    public List<Comprar> ComprarList;
    public int test1;
    public GameObject ResultDialogue;
    public Text ResultDialogueT;
    public GameObject ExitButton;
    public Animator AnimeExit;
    public GameObject EscolhaO;
    public GodCube GodCube;//x
    private void Start()
    {
        language = PlayerPrefs.GetInt("Language");
        AudioControler();
        test = PlayerPrefs.GetInt("Animalia");

        LoadCoisas();
        LoadCoisas2();
        ResultGame();
    }
    public void ResultGame()
    {
        int a;
        int b;
        int reward;
        a = PlayerPrefs.GetInt("Idle");
        if (a == 1)
        {
            b = PlayerPrefs.GetInt("Tale");
            reward = (b + 1) * (Upgrades[9] + 3) * (Upgrades[10] + 3) * (Upgrades[11] + 3) * (Upgrades[12] + 3);
            money += reward;
            PlayerPrefs.SetInt("Idle", 0);
            ResultDialogue.SetActive(true);
            if (language == 0)
            {
                ResultDialogueT.text = "Congratulations, you've earned " + reward + " bucks.";
            }
            if (language == 1)
            {
                ResultDialogueT.text = "Parabéns, você ganhou "+ reward+ " conto.";
            }
            
        }

    }
    public void TraduçãoLoad()
    {
        for (int x = 1; x < Upgrades.Count; x = x + 1)
        {
            if (Upgrades[x] > 0)
            {
                ComprarList[x].Tradução();
            }
        }

    }
    public void SetTest()
    {
        test1 = PlayerPrefs.GetInt("Money");
    }
    public void LoadCoisas2()
    {
        int idBackground;
        idBackground = PlayerPrefs.GetInt("Background");
        Background(idBackground);
        money = PlayerPrefs.GetInt("Money");
        if (OldDialogues[2] == true)
        {
            BackgroundO.SetActive(true);
        }
        if (OldDialogues[4] == true)
        {
            MusicO.SetActive(true);
        }
        if (OldDialogues[7] == true)
        {
            YoutubeO.SetActive(true);
        }
        if (OldDialogues[8] == true)
        {
            UpgradeO.SetActive(true);
        }
        if (OldDialogues[12] == true)
        {
            MiniGameO.SetActive(true);
            FeaturesO.SetActive(true);
        }
    }
    public void ResetSave()
    {

        money = 0;
        PlayerPrefs.SetInt("Buda", 0);
        PlayerPrefs.SetInt("Intro0", 0);

        PlayerPrefs.SetInt("Background", 0);

        PlayerPrefs.SetInt("Money", 0);

        PlayerPrefs.SetInt("Dialogue0", 0);
        PlayerPrefs.SetInt("Dialogue1", 0);
        PlayerPrefs.SetInt("Dialogue2", 0);
        PlayerPrefs.SetInt("Dialogue3", 0);
        PlayerPrefs.SetInt("Dialogue4", 0);
        PlayerPrefs.SetInt("Dialogue5", 0);
        PlayerPrefs.SetInt("Dialogue6", 0);
        PlayerPrefs.SetInt("Dialogue7", 0);
        PlayerPrefs.SetInt("Dialogue8", 0);
        PlayerPrefs.SetInt("Dialogue9", 0);
        PlayerPrefs.SetInt("Dialogue10", 0);
        PlayerPrefs.SetInt("Dialogue11", 0);
        PlayerPrefs.SetInt("Dialogue12", 0);
        PlayerPrefs.SetInt("Dialogue13", 0);
        PlayerPrefs.SetInt("Dialogue14", 0);
        PlayerPrefs.SetInt("Dialogue15", 0);
        PlayerPrefs.SetInt("Dialogue16", 0);
        PlayerPrefs.SetInt("Dialogue17", 0);
        PlayerPrefs.SetInt("Dialogue18", 0);
        PlayerPrefs.SetInt("Dialogue19", 0);
        PlayerPrefs.SetInt("Dialogue20", 0);
        PlayerPrefs.SetInt("Dialogue21", 0);
        PlayerPrefs.SetInt("Dialogue22", 0);
        PlayerPrefs.SetInt("Dialogue24", 0);
        PlayerPrefs.SetInt("Dialogue25", 0);
        PlayerPrefs.SetInt("Dialogue26", 0);
        PlayerPrefs.SetInt("Dialogue27", 0);
        PlayerPrefs.SetInt("Dialogue28", 0);
        PlayerPrefs.SetInt("Dialogue29", 0);
        PlayerPrefs.SetInt("Dialogue30", 0);
        PlayerPrefs.SetInt("Dialogue31", 0);
        PlayerPrefs.SetInt("Dialogue32", 0);






        PlayerPrefs.SetInt("Upgrade0", 0);
        PlayerPrefs.SetInt("Upgrade1", 0);
        PlayerPrefs.SetInt("Upgrade2", 0);
        PlayerPrefs.SetInt("Upgrade3", 0);
        PlayerPrefs.SetInt("Upgrade4", 0);
        PlayerPrefs.SetInt("Upgrade5", 0);
        PlayerPrefs.SetInt("Upgrade6", 0);
        PlayerPrefs.SetInt("Upgrade7", 0);
        PlayerPrefs.SetInt("Upgrade8", 0);
        PlayerPrefs.SetInt("Upgrade9", 0);
        PlayerPrefs.SetInt("Upgrade10", 0);
        PlayerPrefs.SetInt("Upgrade11", 0);
        PlayerPrefs.SetInt("Upgrade12", 0);
        PlayerPrefs.SetInt("Upgrade13", 0);
        PlayerPrefs.SetInt("Upgrade14", 0);
        PlayerPrefs.SetInt("Upgrade15", 0);
        PlayerPrefs.SetInt("Upgrade16", 0);
        PlayerPrefs.SetInt("Upgrade17", 0);
        PlayerPrefs.SetInt("Upgrade18", 0);
        PlayerPrefs.SetInt("Upgrade19", 0);
        PlayerPrefs.SetInt("Upgrade20", 0);

    }

    public void Volume()
    {

    }
    public void AudioControler()
    {
        if (Hihi.isPlaying == false)
        {
            Hihi.clip = Musiquinhas[0];
            if (Upgrades[16] > 0)
            {
                Hihi.Play();
            }
        }
    }
    public void RoyDialogo()
    {

        Hihi.clip = Musiquinhas[1];

        Hihi.Play();


    }
    public void WillDialogo()
    {

        Hihi.clip = Musiquinhas[2];

        Hihi.Play();


    }
    public void LinkDiscord()
    {
        Application.OpenURL("https://discord.gg/CkNfEPDNhA");
    }
    public void LinkYoutube()
    {
        Application.OpenURL("https://www.youtube.com/");
    }

    public void Discord()
    {
        DiscordButton.SetActive(true);
        Dialogue(13, 0, 0);
    }
    public void ExitB()
    {
        ExitButton.SetActive(true);
    }
    public void ExitB1()
    {
        Dialogue(26, 27, 28);
    }
    public void ActiveBuy(int a)
    {
        DisableAll();
        BuyButtons[a].SetActive(true);
        if (a == 16 || a == 17 || a == 18 || a == 19)
        {
            Dialogue(5, 6, 7);
        }
        if (a == 9 || a == 11)
        {
            Dialogue(10, 25, 0);
        }

    }
    //move to script comprar
    public void Background(int a)
    {
        BackgroundI.sprite = BackgroundS[a];
    }
    public void Intro()
    {
        PlayerPrefs.SetInt("Intro0", 1);
        GodCube.TakeScreenshot("Cubo");
        //SceneManager.LoadScene("Cubo");

    }
    public void MusicGame()
    {
        PlayerPrefs.SetInt("Idle", 1);
        GodCube.TakeScreenshot("Song");
        //SceneManager.LoadScene("Song");

    }
    public void PrayGame()
    {
        PlayerPrefs.SetInt("Idle", 1);
        GodCube.TakeScreenshot("Pray");
        //SceneManager.LoadScene("Pray");

    }
    public void BookGame()
    {
        PlayerPrefs.SetInt("Idle", 1);
        GodCube.TakeScreenshot("BookGame");
        //SceneManager.LoadScene("BookGame");

    }
    public void PathOfHappiness()
    {
        PlayerPrefs.SetInt("Aventura", 1);
        GodCube.TakeScreenshot("Adventure");
        //SceneManager.LoadScene("Adventure");
    }
    public void DisableAll()
    {
        for (int x = 0; x < BuyButtons.Count; x = x + 1)
        {
            BuyButtons[x].SetActive(false);
        }

    }
    public void DialoguePower(int a)
    {
        if (a == 0)
        {

        }
        if (a == 2)
        {
            BackgroundO.SetActive(true);
        }
        if (a == 4)
        {
            MusicO.SetActive(true);
        }
        if (a == 7)
        {
            YoutubeO.SetActive(true);
        }
        if (a == 8)
        {
            UpgradeO.SetActive(true);
        }
        if (a == 12)
        {
            MiniGameO.SetActive(true);
            FeaturesO.SetActive(true);
        }
        if (a == 28)
        {
            AnimeExit.Play("rodaroda");
        }
        if (a == 31)
        {
            Definitivo();
        }

    }
    public void Dialogue(int id1, int id2, int id3)
    {
        if (OldDialogues[id1] == false)
        {
            if (DialogueInstruction.Count == 0)
            {
                DialogueO.SetActive(true);
                DialogueAnime.Play("DialogueIntro");
            }
            // DialogueInstruction.Clear();
            if (id1 != 0)
            {
                DialogueInstruction.Add(id1);
            }
            if (id2 != 0)
            {
                DialogueInstruction.Add(id2);
            }
            if (id3 != 0)
            {
                DialogueInstruction.Add(id3);
            }

            if (language == 0)
            {
                DialogueText.text = MonsterDialogue.Dialogue[DialogueInstruction[0]];
            }
            if (language == 1)
            {
                DialogueText.text = MonsterDialogue.DialogueBR[DialogueInstruction[0]];
            }
            OldDialogues[id1] = true;
            OldDialogues[id2] = true;
            OldDialogues[id3] = true;
            SaveDialogue(id1);
            SaveDialogue(id2);
            SaveDialogue(id3);
        }

    }
    public void AnimeExecution()
    {
        //DialoguePower(DialogueInstruction[0]);
        DialogueInstruction.RemoveAt(0);
        //indexDialogue += 1;
        if (DialogueInstruction.Count == 0)
        {

            DialogueAnime.Play("DialogueEnd");
        }
        else
        {
            if (language == 0)
            {
                DialogueText.text = MonsterDialogue.Dialogue[DialogueInstruction[0]];
            }
            if (language == 1)
            {
                DialogueText.text = MonsterDialogue.DialogueBR[DialogueInstruction[0]];
            }

        }
    }
    public void LoadCoisas()
    {
        Upgrades[0] = PlayerPrefs.GetInt("Upgrade0");
        Upgrades[1] = PlayerPrefs.GetInt("Upgrade1");
        Upgrades[2] = PlayerPrefs.GetInt("Upgrade2");
        Upgrades[3] = PlayerPrefs.GetInt("Upgrade3");
        Upgrades[4] = PlayerPrefs.GetInt("Upgrade4");
        Upgrades[5] = PlayerPrefs.GetInt("Upgrade5");
        Upgrades[6] = PlayerPrefs.GetInt("Upgrade6");
        Upgrades[7] = PlayerPrefs.GetInt("Upgrade7");
        Upgrades[8] = PlayerPrefs.GetInt("Upgrade8");
        Upgrades[9] = PlayerPrefs.GetInt("Upgrade9");
        Upgrades[10] = PlayerPrefs.GetInt("Upgrade10");
        Upgrades[11] = PlayerPrefs.GetInt("Upgrade11");
        Upgrades[12] = PlayerPrefs.GetInt("Upgrade12");
        Upgrades[13] = PlayerPrefs.GetInt("Upgrade13");
        Upgrades[14] = PlayerPrefs.GetInt("Upgrade14");
        Upgrades[15] = PlayerPrefs.GetInt("Upgrade15");
        Upgrades[16] = PlayerPrefs.GetInt("Upgrade16");
        Upgrades[17] = PlayerPrefs.GetInt("Upgrade17");
        Upgrades[18] = PlayerPrefs.GetInt("Upgrade18");
        Upgrades[19] = PlayerPrefs.GetInt("Upgrade19");

        //.................................................
        OldDialogues[0] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue0"));
        OldDialogues[1] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue1"));
        OldDialogues[2] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue2"));
        OldDialogues[3] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue3"));
        OldDialogues[4] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue4"));
        OldDialogues[5] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue5"));
        OldDialogues[6] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue6"));
        OldDialogues[7] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue7"));
        OldDialogues[8] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue8"));
        OldDialogues[9] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue9"));
        OldDialogues[10] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue10"));
        OldDialogues[11] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue11"));
        OldDialogues[12] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue12"));
        OldDialogues[13] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue13"));
        OldDialogues[14] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue14"));
        OldDialogues[15] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue15"));
        OldDialogues[16] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue16"));
        OldDialogues[17] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue17"));
        OldDialogues[18] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue18"));
        OldDialogues[19] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue19"));
        OldDialogues[20] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue20"));
        OldDialogues[21] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue21"));
        OldDialogues[22] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue22"));
        OldDialogues[23] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue23"));
        OldDialogues[24] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue24"));
        OldDialogues[25] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue25"));
        OldDialogues[26] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue26"));
        OldDialogues[27] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue27"));
        OldDialogues[28] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue28"));
        OldDialogues[29] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue29"));
        OldDialogues[30] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue30"));
        OldDialogues[31] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue31"));
        OldDialogues[32] = Generic.Boolinha(PlayerPrefs.GetInt("Dialogue32"));
        //.................................................
        money = PlayerPrefs.GetInt("Money");

        TraduçãoLoad();
        if (Upgrades[14] > 0)
        {
            Discord();
        }
    }
    public void SaveMoney(int a)
    {
        PlayerPrefs.SetInt("Money", a);
    }
    public void SaveDialogue(int id)
    {
        if (id == 0)
        {
            PlayerPrefs.SetInt("Dialogue0", 1);
        }
        if (id == 1)
        {
            PlayerPrefs.SetInt("Dialogue1", 1);
        }
        if (id == 2)
        {
            PlayerPrefs.SetInt("Dialogue2", 1);
        }
        if (id == 3)
        {
            PlayerPrefs.SetInt("Dialogue3", 1);
        }
        if (id == 4)
        {
            PlayerPrefs.SetInt("Dialogue4", 1);
        }
        if (id == 5)
        {
            PlayerPrefs.SetInt("Dialogue5", 1);
        }
        if (id == 6)
        {
            PlayerPrefs.SetInt("Dialogue6", 1);
        }
        if (id == 7)
        {
            PlayerPrefs.SetInt("Dialogue7", 1);
        }
        if (id == 8)
        {
            PlayerPrefs.SetInt("Dialogue8", 1);
        }
        if (id == 9)
        {
            PlayerPrefs.SetInt("Dialogue9", 1);
        }
        if (id == 10)
        {
            PlayerPrefs.SetInt("Dialogue10", 1);
        }
        if (id == 11)
        {
            PlayerPrefs.SetInt("Dialogue11", 1);
        }
        if (id == 12)
        {
            PlayerPrefs.SetInt("Dialogue12", 1);
        }
        if (id == 13)
        {
            PlayerPrefs.SetInt("Dialogue13", 1);
        }
        if (id == 14)
        {
            PlayerPrefs.SetInt("Dialogue14", 1);
        }
        if (id == 15)
        {
            PlayerPrefs.SetInt("Dialogue15", 1);
        }
        if (id == 16)
        {
            PlayerPrefs.SetInt("Dialogue16", 1);
        }
        if (id == 17)
        {
            PlayerPrefs.SetInt("Dialogue17", 1);
        }
        if (id == 18)
        {
            PlayerPrefs.SetInt("Dialogue18", 1);
        }
        if (id == 19)
        {
            PlayerPrefs.SetInt("Dialogue19", 1);
        }
        if (id == 20)
        {
            PlayerPrefs.SetInt("Dialogue20", 1);
        }
        if (id == 21)
        {
            PlayerPrefs.SetInt("Dialogue21", 1);
        }
        if (id == 22)
        {
            PlayerPrefs.SetInt("Dialogue22", 1);
        }
        if (id == 23)
        {
            PlayerPrefs.SetInt("Dialogue23", 1);
        }
        if (id == 24)
        {
            PlayerPrefs.SetInt("Dialogue24", 1);
        }
        if (id == 25)
        {
            PlayerPrefs.SetInt("Dialogue25", 1);
        }
        if (id == 26)
        {
            PlayerPrefs.SetInt("Dialogue26", 1);
        }
        if (id == 27)
        {
            PlayerPrefs.SetInt("Dialogue27", 1);
        }
        if (id == 28)
        {
            PlayerPrefs.SetInt("Dialogue28", 1);
        }
        if (id == 29)
        {
            PlayerPrefs.SetInt("Dialogue29", 1);
        }
        if (id == 30)
        {
            PlayerPrefs.SetInt("Dialogue30", 30);
        }
        if (id == 31)
        {
            PlayerPrefs.SetInt("Dialogue31", 31);
        }
        if (id == 32)
        {
            PlayerPrefs.SetInt("Dialogue32", 32);
        }
    }
    public void SaveUpgrade(int id, int value)
    {
        if (id == 0)
        {
            PlayerPrefs.SetInt("Upgrade0", value);
        }
        if (id == 1)
        {
            PlayerPrefs.SetInt("Upgrade1", value);
        }
        if (id == 2)
        {
            PlayerPrefs.SetInt("Upgrade2", value);
        }
        if (id == 3)
        {
            PlayerPrefs.SetInt("Upgrade3", value);
        }
        if (id == 4)
        {
            PlayerPrefs.SetInt("Upgrade4", value);
        }
        if (id == 5)
        {
            PlayerPrefs.SetInt("Upgrade5", value);
        }
        if (id == 6)
        {
            PlayerPrefs.SetInt("Upgrade6", value);
        }
        if (id == 7)
        {
            PlayerPrefs.SetInt("Upgrade7", value);
        }
        if (id == 8)
        {
            PlayerPrefs.SetInt("Upgrade8", value);
        }
        if (id == 9)
        {
            PlayerPrefs.SetInt("Upgrade9", value);
        }
        if (id == 10)
        {
            PlayerPrefs.SetInt("Upgrade10", value);
        }
        if (id == 11)
        {
            PlayerPrefs.SetInt("Upgrade11", value);
        }
        if (id == 12)
        {
            PlayerPrefs.SetInt("Upgrade12", value);
        }
        if (id == 13)
        {
            PlayerPrefs.SetInt("Upgrade13", value);
        }
        if (id == 14)
        {
            PlayerPrefs.SetInt("Upgrade14", value);
        }
        if (id == 15)
        {
            PlayerPrefs.SetInt("Upgrade15", value);
        }
        if (id == 16)
        {
            PlayerPrefs.SetInt("Upgrade16", value);
        }
        if (id == 17)
        {
            PlayerPrefs.SetInt("Upgrade17", value);
        }
        if (id == 18)
        {
            PlayerPrefs.SetInt("Upgrade18", value);
        }
        if (id == 19)
        {
            PlayerPrefs.SetInt("Upgrade19", value);
        }
        if (id == 20)
        {
            PlayerPrefs.SetInt("Upgrade20", value);
        }

    }
    public void Definitivo()
    {
        EscolhaO.SetActive(true);
    }
    public void PathOfMoney()
    {
        EscolhaO.SetActive(false);
    }
    public void PathOfFelicidade()
    {
        EscolhaO.SetActive(false);
        PlayerPrefs.SetInt("Buda",1);
        PathOfHappiness();

    }

}
