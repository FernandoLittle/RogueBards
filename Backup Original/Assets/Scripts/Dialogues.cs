using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogues : MonoBehaviour
{
    public List<Tales> Dialogo;
    public int DialogueSelect;
    public int Index;
    public Text DiagolgueText;
    public A A;
    public GameObject DialogueObject;
    public Tutorial Tutorial;
    public GameObject TutoIlustration;
    public List<ListString> DarkText;
    public List<ListString> DarkTextBR;
    public Image Face;
    public Stuff Stuff;
    public Text DarkText2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
    public void ShowText()
    {
        int language;
        language = PlayerPrefs.GetInt("Language");
        if (language == 0)
        {
            DiagolgueText.text = Dialogo[DialogueSelect].Dialogue[Index];
        }
        if (language == 1)
        {
            DiagolgueText.text = Dialogo[DialogueSelect].DialogueBR[Index];
        }

    }
    public void MasterDialogue()
    {

        if (StaticPlayer.Fight == 1)
        {
            if (A.turn == 0)
            {
                SetDialogue(0);
            }
            if (A.turn == 1)
            {
                SetDialogue(1);
            }
            
        }
        if (StaticPlayer.Fight == 2)
        {
            if (A.turn == 0)
            {
                SetDialogue(3);
            }

        }
        if (StaticPlayer.Fight == 3)
        {
            if (A.turn == 0)
            {
                SetDialogue(2);
            }
            if (A.turn == 1)
            {
                SetDialogue(4);
            }
        }
        if (StaticPlayer.Fight == 4)
        {

        }
        if (StaticPlayer.Fight == 5)
        {

        }
        if (StaticPlayer.Fight == 6)
        {

        }
        if (StaticPlayer.Fight == 7)
        {

        }
        if (StaticPlayer.Fight == 8)
        {

        }
        if (StaticPlayer.Fight == 9)
        {

        }
        if (StaticPlayer.Fight == 10)
        {

        }
        if (StaticPlayer.Fight == 11)
        {

        }
        if (StaticPlayer.Fight == 12)
        {

        }
        if (StaticPlayer.Fight == 13)
        {

        }
        if (StaticPlayer.Fight == 14)
        {

        }


    }
    public void SetDialogue(int dialogueselect)
    {
        Index = 0;
        DialogueSelect = dialogueselect;

        GetInstruction();
    }
    public void PlayNext()
    {
        Index += 1;
        GetInstruction();
    }
    public void GetInstruction()
    {
        DialogueObject.SetActive(true);
        if (Dialogo[DialogueSelect].instruction[Index] == 0)
        {
            ShowText();
            SetFace();
        }
        if (Dialogo[DialogueSelect].instruction[Index] == 1)
        {
            DialogueObject.SetActive(false);
            TutoIlustration.SetActive(false);
        }
        if (Dialogo[DialogueSelect].instruction[Index] >=11 && Dialogo[DialogueSelect].instruction[Index]<=21)
        {
            ShowText();
            Tutorial.Tuto(Dialogo[DialogueSelect].instruction[Index]);
        }
    }
    public void SetFace()
    {
        Face.sprite = Stuff.Cards[Dialogo[DialogueSelect].idchara[Index]].sprite;
    }
}
