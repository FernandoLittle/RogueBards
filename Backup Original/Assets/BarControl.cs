using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarControl : MonoBehaviour
{
    public int OldInt;
    public int NewInt;
    public bool Change;
    public Slider Slider;


    private void FixedUpdate()
    {
        if (Change == true)
        {
            if (OldInt > NewInt)
            {
                OldInt -= 1;
            }
            else if(OldInt< NewInt)
            {
                OldInt += 1;
            }
            else
            {
                Change = false;
            }
            Slider.value = OldInt;
        }
    }


}
