using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalesVariables : MonoBehaviour
{
    public List<Tales> Tales;
    public List<Tales> TalesIntro;
    public List<Tales> TalesRoy;
    public List<Tales> TalesWilliamWFight;
    public List<Tales> TalesWilliamWFight2;
    public List<Tales> TalesAction;
    public int instruction;
    public int TaleSelect;
    public int Index;
    public Instructions Instructions;
    public Text TaleText;
    public List<GameObject> OptionsObjects;
    public List<string> OptionsText;
    public List<Text> OptionsText1;
    public List<int> IdButton;
    public GameObject DisableNext;
    public ButtonInstructions ButtonInstructions;
    public SelectTale SelectTale;
    public Day Day;
    public List<int> FightL;
    public List<int> FightL1;
    public int IdList;
    // Start is called before the first frame update
    public void Start()
    {
        //select Day
        
        Index = 0;
        SelectTale.NextTale();
    }
    public void MasterAction()
    {


        Instructions.TaleSwitch(Tales[TaleSelect].instruction[Index]);

        Index += 1;

    }
    public void SetTale(int TaleS)
    {
        Index = 0;

        TaleSelect = TaleS;

        MasterAction();
        Index = 0;
    }
    public void ShowText()
    {

        TaleText.text = Tales[TaleSelect].Dialogue[Index];
    }
    public void ShowButtons(int NumberOptions)
    {
        DisableNext.SetActive(true);
        for (int x = 0; x < 5; x = x + 1)
        {
            OptionsObjects[x].SetActive(false);
        }
        for (int x = 0; x < NumberOptions; x = x + 1)
        {
            OptionsObjects[x].SetActive(true);
            OptionsText1[x].text = OptionsText[x];
        }
    }
    public void ButtonEffect(int idbutton)
    {
        OptionsObjects[0].SetActive(false);
        OptionsObjects[1].SetActive(false);
        OptionsObjects[2].SetActive(false);
        OptionsObjects[3].SetActive(false);
        OptionsObjects[4].SetActive(false);
        DisableNext.SetActive(false);
        ButtonInstructions.EffectsButton(IdButton[idbutton]);
    }
    public void SelectListTale()
    {
        IdList = PlayerPrefs.GetInt("IdList");
        if (IdList == 0)
        {
            Tales = TalesRoy;
        }
        if (IdList == 1)
        {
            Tales = TalesWilliamWFight2;
        }
    }

}
