using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statos : MonoBehaviour
{
    public int side;
    public Image self;
    public int id;
    public A A;
    public D D;
    public GameObject selfG;
    // Start is called before the first frame update

    public void EyeEnable()
    {
        if (side == 0)
        {
            ActiveEyeIcons(false, false, false, false);
            A.ilx.SetActive(true);
            A.ilx1.sprite = D.Status[id].BigIcon;
            A.EyeTx[0].text = D.Status[id].description;
        }
        if (side == 1)
        {
            ActiveEyeIconsZ(false, false, false, false);
            A.ilz.SetActive(true);
            A.ilz1.sprite = D.Status[id].BigIcon;
            A.EyeTZ[0].text = D.Status[id].description;
        }


    }
    public void EyeDesEnable()
    {
        if (side == 0)
        {
            ActiveEyeIcons(true, true, true, true);
            A.ilx.SetActive(false);
        }
       if (side == 1)
        {
            ActiveEyeIconsZ(true, true, true, true);
            A.ilz.SetActive(false);
        }
    }
    public void ActiveEyeIcons(bool mana, bool life, bool defense, bool attack)
    {
        A.EyeIcons[0].SetActive(mana);
        A.EyeIcons[1].SetActive(life);
        A.EyeIcons[2].SetActive(defense);
        A.EyeIcons[3].SetActive(attack);
    }
    public void ActiveEyeIconsZ(bool mana, bool life, bool defense, bool attack)
    {
        A.EyeIconsz[0].SetActive(mana);
        A.EyeIconsz[1].SetActive(life);
        A.EyeIconsz[2].SetActive(defense);
        A.EyeIconsz[3].SetActive(attack);
    }
}
