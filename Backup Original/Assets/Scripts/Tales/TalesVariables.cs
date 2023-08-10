using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalesVariables : MonoBehaviour
{
    //Tales Warrior
    public List<Tales> Tales;
    public List<Tales> TalesIntro;
    public List<Tales> TalesRoy;
    public List<Tales> TalesWilliamWFight;
    public List<Tales> TalesWilliamWFight2;
    public List<Tales> TalesWilliamWBard1;
    public List<Tales> TalesWilliamWBard2;
    public List<Tales> TalesWilliamWBook;
    public List<Tales> TalesAction;
    public List<Tales> TalesMinigames;
    public List<Tales> TalesCustonRoute;
    public List<Tales> TalesCustonRouteTrue;
    public List<Tales> TalesDeath;
    public List<Tales> TalesPray;


    //Tales Assassin
    public List<Tales> FirstTale;
    public List<Tales> TalesIntroAS;
    public List<Tales> TalesWilliamWFightAS;
    public List<Tales> TalesWilliamWFight2AS;
    public List<Tales> TalesWilliamMaduin;
    public List<Tales> TalesWilliamMaduin2;
    public List<Tales> TalesActionAS;
    public List<Tales> TalesMinigamesAS;
    public List<Tales> TalesCustonRouteAS;
    public List<Tales> TalesCustonRouteTrueAs;



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
    public List<int> CustonRoute;
    public int IdList;
    public IlusControler IlusControler;
    public List<Tales> TaleGod;
    public GameObject Obrigado;
    public GameObject Loading;
    public List<Image> FinalImage;
    public List<int> FinalInt;
    public List<GameObject> FinalBlue;

    // Start is called before the first frame update
    public void Start()
    {
        Debugamento();
        PlayerPrefs.SetInt("IntCena", 1);
        //select Day

        Index = 0;
        SelectTale.NextTale();
        try
        {
            Debug.Log("IdCards:" + StaticPlayer.TrueAttack[0].ToString()+"/"+ StaticPlayer.FakeAttack[0].ToString()+ "/" + StaticPlayer.Block[0].ToString()+ "/" + StaticPlayer.CounterAttack[0].ToString());

        }
        catch
        {
            Debug.Log("BugTalesVariables");
        }
    }
    public void Debugamento()
    {
        try
        {
            Debug.Log("TrueAttack:" + StaticPlayer.TrueAttack[0].ToString());
            Debug.Log("FakeAttack:" + StaticPlayer.FakeAttack[0].ToString());
            Debug.Log("Block:" + StaticPlayer.Block[0].ToString());
            Debug.Log("CounterAttack:" + StaticPlayer.CounterAttack[0].ToString());
        }
        catch
        {
            Debug.Log("Falto Skill");
        }
    }
    public void MasterAction()
    {


        Instructions.TaleSwitch(Tales[TaleSelect].instruction[Index]);

        Index += 1;

    }
    public void SetTale(int TaleS)
    {
        //Eu odeio essa função, eu não entendo essa porra, em alguns momentos eu vou ter que aumentar o index inicial outras vezes não e eu esqueci porque que essa droga é assim tomanocu 
        //Eu acho que comecei a entender, no final da Master Action o index aumenta. Se você mudar de tale via button instruction terá que aumentar o index manualmente
        Index = 0;

        if(TaleSelect!= TaleS)
        {
            IlusControler.IlustrationChange = true;
        }
        TaleSelect = TaleS;
       



        IlusControler.SetCenario(Tales[TaleSelect].Cenario);


        MasterAction();        
        Index = 0;
    }
    public void SetCenario()
    {

    }
    public void ShowText()
    {
        int language;
        language = PlayerPrefs.GetInt("Language");
        if (language == 0)
        {
            TaleText.text = Tales[TaleSelect].Dialogue[Index];
        }
        if (language == 1)
        {
            TaleText.text = Tales[TaleSelect].DialogueBR[Index];
        }
        if (language == 2)
        {
            TaleText.text = Tales[TaleSelect].DialogueES[Index];
        }


        try
        {
            
            IlusControler.SetFaceName(Tales[TaleSelect].idchara[Index]);
        }
        catch
        {
            Debug.Log("Sem Face");
        }

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
        else if (IdList == 1)
        {
            Tales = TalesWilliamWFight2;
        }
        else if (IdList == 2)
        {
            if(StaticPlayer.PlayerId[0] == 29)
            {
                Tales = TalesWilliamMaduin2;

            }
            if (StaticPlayer.PlayerId[0] == 28)
            {
                Tales = TalesWilliamWBard2;
            }
        }
        else if (IdList == 3)
        {
            Tales = TalesWilliamWBook;
        }
        else if (IdList == 4)
        {
            Tales = TalesCustonRoute;
        }
        else if (IdList == 5)
        {
            Tales = TalesDeath;
        }
        else if (IdList == 6)
        {
            Tales = TalesWilliamWFight2AS;
        }
        else if (IdList == 7)
        {
            Tales = TalesCustonRouteAS;
        }
        else if (IdList == 8)
        {
            Tales = TalesPray;
        }
    }
    public void SetPrayTale()
    {
        int Type;
        int indexT;
        Type= PlayerPrefs.GetInt("SType");
        indexT = PlayerPrefs.GetInt("SIndex");
        if (Type == 1)
        {
            Tales = TalesCustonRouteAS;
        }
        if (Type == 2)
        {
            Tales = TalesCustonRoute;
        }
        SetTale(indexT);

    }
    public void SetGodTale()
    {
        Index = 0;
        Tales = TaleGod;
        TaleSelect = 0;
        IlusControler.IlustrationChange = true;
        IlusControler.SetCenario(Tales[TaleSelect].Cenario);


        MasterAction();
        Index = 0;
    }
    public void EndScene(int FINAL)
    {
        if (FINAL == 1)
        {
            PlayerPrefs.SetInt("Final1", 1);
        }
        if (FINAL == 2)
        {
            PlayerPrefs.SetInt("Final2", 1);
        }
        if (FINAL == 3)
        {
            PlayerPrefs.SetInt("Final3", 1);
        }
        if (FINAL == 4)
        {
            PlayerPrefs.SetInt("Final4", 1);
        }
        if (FINAL == 5)
        {
            PlayerPrefs.SetInt("Final5", 1);
        }
        if (FINAL == 6)
        {
            PlayerPrefs.SetInt("Final6", 1);
        }
        if (FINAL == 7)
        {
            PlayerPrefs.SetInt("Final7", 1);
        }
        if (FINAL == 8)
        {
            PlayerPrefs.SetInt("Final8", 1);
        }
        if (FINAL == 9)
        {
            PlayerPrefs.SetInt("Final9", 1);
        }
        if (FINAL == 10)
        {
            PlayerPrefs.SetInt("Final10", 1);
        }
        if (FINAL == 11)
        {
            PlayerPrefs.SetInt("Final11", 1);
        }
        if (FINAL == 12)
        {
            PlayerPrefs.SetInt("Final12", 1);
        }

        FinalInt[0] = PlayerPrefs.GetInt("Final1");
        FinalInt[1] = PlayerPrefs.GetInt("Final2");
        FinalInt[2] = PlayerPrefs.GetInt("Final3");
        FinalInt[3] = PlayerPrefs.GetInt("Final4");
        FinalInt[4] = PlayerPrefs.GetInt("Final5");
        FinalInt[5] = PlayerPrefs.GetInt("Final6");
        FinalInt[6] = PlayerPrefs.GetInt("Final7");
        FinalInt[7] = PlayerPrefs.GetInt("Final8");
        FinalInt[8] = PlayerPrefs.GetInt("Final9");
        FinalInt[9] = PlayerPrefs.GetInt("Final10");
        FinalInt[10] = PlayerPrefs.GetInt("Final11");
        FinalInt[11] = PlayerPrefs.GetInt("Final12");

        for (int x = 0; x < FinalInt.Count; x = x + 1)
        {
            if (FinalInt[x] == 1)
            {
                FinalImage[x].color = new Color(FinalImage[x].color.r, FinalImage[x].color.g, FinalImage[x].color.b, 1);

            }
            if (FINAL == x+1)
            {
                FinalBlue[x].SetActive(true);
            }
        }


    }
}
