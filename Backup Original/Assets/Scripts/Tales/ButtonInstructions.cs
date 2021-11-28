using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInstructions : MonoBehaviour
{
    public TalesVariables TalesVariables;
    // Start is called before the first frame update
    public void EffectsButton(int a)
    {
        switch (a)
        {
   
            case -5:
                Debug.Log("EAE");
                break;
            case -6:
                Debug.Log("PAU");
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
        }
    }
    //Only Work Index<11
    public void SetTale(int b)
    {
        TalesVariables.Index = b - 1000;
        TalesVariables.MasterAction();

    }
}
