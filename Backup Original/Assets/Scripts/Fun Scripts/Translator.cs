using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Translator : MonoBehaviour
{
    public List<Image> Fundinhos;
    public int a;
    public List<Text> AdventuresT;
    public List<Text> LanguagesT;
    public List<Text> TextMenu;
    // Start is called before the first frame update
    void Start()
    {

        try
        {
            a = PlayerPrefs.GetInt("Language");
            if (a == 0)
            {
                English();
            }
            if (a == 1)
            {
                Portuguese();
            }
        }
        catch
        {
            English();
        }
    }
    public void English()
    {
        PlayerPrefs.SetInt("Language", 0);
        Fantasminha();
        Fundinhos[0].color = new Color(1, 0, 0, 1);
        AdventuresT[0].text = "Adventure of Roy (Tutorial)";
        AdventuresT[1].text = "Adventure of William";
        LanguagesT[0].text = "Language:";
        LanguagesT[1].text = "Play New Game";
        LanguagesT[2].text = "Continue";


        TextMenu[0].text = "Volume";
        TextMenu[1].text = "Language";
        TextMenu[2].text = "Continue Game";
        TextMenu[3].text = "Exit Game";
    }
    public void Portuguese()
    {
        PlayerPrefs.SetInt("Language", 1);
        Fantasminha();
        Fundinhos[1].color = new Color(1, 0, 0, 1);
        AdventuresT[0].text = "Aventura de Roy (Tutorial)";
        AdventuresT[1].text = "Aventura de William";
        LanguagesT[0].text = "Idioma:";
        LanguagesT[1].text = "Jogar Nova Partida";
        LanguagesT[2].text = "Continuar";

        TextMenu[0].text = "Volume";
        TextMenu[1].text = "Idioma";
        TextMenu[2].text = "Continuar o jogo";
        TextMenu[3].text = "Sair do jogo";


    }
    public void Fantasminha()
    {
        for (int x = 0; x < Fundinhos.Count; x = x + 1)
        {
            Fundinhos[x].color = new Color(1,0,0,0.4f);
        }
    }
}
