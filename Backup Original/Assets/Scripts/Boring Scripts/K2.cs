using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class K2 : MonoBehaviour
{
    public A A;
    public Dialogues Dialogues;
    public int darktime;
    public int idDark;
    public Text DarkText;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void SetTextDark()
    {
        if (darktime == 0)
        {
            idDark = Random.Range(0, Dialogues.DarkText.Count);
        }

        int language;
        language = PlayerPrefs.GetInt("Language");
        if (language == 0)
        {
            DarkText.text = Dialogues.DarkText[idDark].Speak[darktime];
        }
        if (language == 1)
        {
            DarkText.text = Dialogues.DarkTextBR[idDark].Speak[darktime];
        }
        if (language == 2)
        {
            DarkText.text = Dialogues.DarkTextES[idDark].Speak[darktime];
        }
        if (darktime == 0)
        {
            Dialogues.DarkText2.text = "Round 1";
        }
        if (darktime == 1)
        {
            Dialogues.DarkText2.text = "Round 2";
        }
        if (darktime == 2)
        {
            Dialogues.DarkText2.text = "Round 3";
        }
        if (darktime == 3)
        {
            Dialogues.DarkText2.text = "Round 4";
        }
        darktime += 1;
    }
}
