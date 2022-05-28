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
        DarkText.text = Dialogues.DarkText[idDark].Speak[darktime];
        darktime += 1;
    }
}
