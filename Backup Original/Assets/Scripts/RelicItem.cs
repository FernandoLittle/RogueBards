using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelicItem : MonoBehaviour
{
    public A A;
    public int RelicId;
    public D D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EyeEnable()
    {
        A.EyeNameRight.text = D.Relics[RelicId].Name;
        A.ilx.SetActive(true);
        A.ilx1.sprite = D.Relics[RelicId].SpriteRelic;
        A.EyeTx[0].text = D.Relics[RelicId].Description;
        ActiveEyeIcons(false, false, false, false);
        int language;
        language = PlayerPrefs.GetInt("Language");
        if (language == 0)
        {
            A.EyeNameRight.text = D.Relics[RelicId].Name;
            A.EyeTx[0].text = D.Relics[RelicId].Description;
        }
        if (language == 1)
        {
            A.EyeNameRight.text = D.Relics[RelicId].NameBR;
            A.EyeTx[0].text = D.Relics[RelicId].DescriptionBR;
        }
    }
    public void EyeDesEnable()
    {

        ActiveEyeIcons(true, true, true, true);
        A.ilx.SetActive(false);
       
    }
    public void ActiveEyeIcons(bool mana, bool life, bool defense, bool attack)
    {
        A.EyeIcons[0].SetActive(mana);
        A.EyeIcons[1].SetActive(life);
        A.EyeIcons[2].SetActive(defense);
        A.EyeIcons[3].SetActive(attack);
    }
}
