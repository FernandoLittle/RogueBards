using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonInstructions : MonoBehaviour
{
    public TalesVariables TalesVariables;
    public SkillA SkillA;
    // Start is called before the first frame update
    public void EffectsButton(int a)
    {
        switch (a)
        {
   
            case -5:
                
                break;
            case -6:
                
                break;
            //1300 Set MiniGame
            case 1301:
                PlayerPrefs.SetInt("God", 1);//Shuá
                SceneManager.LoadScene("Song");
                break;
            case 1302:
                PlayerPrefs.SetInt("God", 2);//Maná
                SceneManager.LoadScene("Song");
                break;
            case 1303:
                PlayerPrefs.SetInt("God", 3);//Lyoko
                SceneManager.LoadScene("Song");
                break;
            case 1304:
                PlayerPrefs.SetInt("God", 4);//Akasha
                SceneManager.LoadScene("Song");
                break;
            //1400 Set Tale for other List
            case 1401:
                TalesVariables.Tales = TalesVariables.TalesWilliamWFight;
                TalesVariables.SetTale(0);
                break;
            case 1402:
                TalesVariables.Tales = TalesVariables.TalesWilliamWFight;
                TalesVariables.SetTale(1);
                break;
            case 1403:
                TalesVariables.Tales = TalesVariables.TalesWilliamWFight;
                TalesVariables.SetTale(2);
                break;
            case 1404:
                TalesVariables.Tales = TalesVariables.TalesWilliamWFight;
                TalesVariables.SetTale(3);
                break;
            case 1405:
                TalesVariables.Tales = TalesVariables.TalesWilliamWFight;
                TalesVariables.SetTale(4);
                break;
            case 1406:
                TalesVariables.Tales = TalesVariables.TalesWilliamWFight;
                TalesVariables.SetTale(5);
                break;
            case 1407:
                TalesVariables.Tales = TalesVariables.TalesWilliamWFight;
                TalesVariables.SetTale(6);
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





            case 1001:
                SetTale(a);
                break;
            case 1002:
                SetTale(a);
                break;
            case 1003:
                SetTale(a);
                break;
            case 1004:
                SetTale(a);
                break;
            case 1005:
                SetTale(a);
                break;
            case 1006:
                SetTale(a);
                break;
            case 1007:
                SetTale(a);
                break;
            case 1008:
                SetTale(a);
                break;
            case 1009:
                SetTale(a);
                break;
            case 1010:
                SetTale(a);
                break;
            case 1013:
                SetTale(a);
                break;
            case 1014:
                SetTale(a);
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

}
