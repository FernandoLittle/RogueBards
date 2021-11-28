using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instructions : MonoBehaviour
{
    public TalesVariables TalesVariables;
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
        switch (a)
        {
            case 0:
                TalesVariables.ShowText();
                break;
            case 11:
                SetButtonST("You don't go to hell", "Die, regicide", "", "", "");
                SetButton( 1001, 1002, 0, 0, 0);
                TalesVariables.ShowText();
                break;
            case 12:
                SetButtonST("I can", "I can't", "", "", "");
                SetButton(1001, 1002, 0, 0, 0);
                TalesVariables.ShowText();
                break;

            case 13:
                SetButtonST("Decline offer", "It's not up to me to make this decision.", "", "", "");
                SetButton(1001, 1002, 0, 0, 0);
                TalesVariables.ShowText();
                break;
            case 14:
                StaticPlayer.PlayerId[1] = 11;
                StaticPlayer.PlayerLife[0] = 3;
                SceneManager.LoadScene("Battle");
                break;





            case -1:
                SetButtonST("Cu", "Eae", "Pau", "", "");
                SetButton( -4, -5, -6, 0, 0);
                break;
        }
    }



    public void SetButton( int id1, int id2, int id3, int id4, int id5)
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
}
