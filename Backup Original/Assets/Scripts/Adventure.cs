using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Adventure : MonoBehaviour
{
    public int FightID;
    public GameObject Loading;
    public GodCube GodCube;//x
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Roy()
    {
        ResetGame();
        PlayerPrefs.SetInt("Batalha", 0);
        //temporario
        PlayerPrefs.SetInt("Tale", 0);
        //temporario, mudar com sistema de load
        StaticPlayer.Adventure = true;
        StaticPlayer.Fight = 1;
        StaticPlayer.PlayerId[0] = 27;
        StaticPlayer.PlayerLife[0] = 3;
        StaticPlayer.ManaRegen[0] = 0;
        StaticPlayer.Mana[0] = 0;
        StaticPlayer.Defense[0] = 0;
        StaticPlayer.PlayerMaxLife[0] = 0;
        StaticPlayer.Attack[0] = 0;
        Loading.SetActive(true);
        GodCube.TakeScreenshot("Tales");
        //SceneManager.LoadScene("Tales");
    }
    public void WilliamW()
    {
        PlayerPrefs.SetInt("Batalha", 0);
        //temporario
        PlayerPrefs.SetInt("Tale", FightID);
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
        Loading.SetActive(true);
        GodCube.TakeScreenshot("Tales");
        //SceneManager.LoadScene("Tales");
    }
    public void WilliamAS()
    {
        ResetGame();
        PlayerPrefs.SetInt("Batalha", 0);
        //temporario
        PlayerPrefs.SetInt("Tale", FightID);//Eu acho que isso é do mal e eu deveria ter apagado, mas como o jogo tá funcionando vou deixar quieto
        //temporario, mudar com sistema de load
        StaticPlayer.Adventure = true;
        StaticPlayer.Fight = 1;
        StaticPlayer.PlayerId[0] = 29;
        StaticPlayer.Day = 1;
        StaticPlayer.PlayerLife[0] = 3;
        StaticPlayer.ManaRegen[0] = 0;
        StaticPlayer.Mana[0] = 0;
        StaticPlayer.Defense[0] = 0;
        StaticPlayer.PlayerMaxLife[0] = 0;
        StaticPlayer.Attack[0] = 0;
        Loading.SetActive(true);
        GodCube.TakeScreenshot("Tales");
        //SceneManager.LoadScene("Tales");
    }
    public void Discord()
    {
        Application.OpenURL("https://discord.gg/CkNfEPDNhA");
    }
    public void ResetGame()
    {

        //mover para adventure


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
