using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTale : MonoBehaviour
{
    public TalesVariables TalesVariables;
    public int Taleid;
    public int Batalha;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextTale()
    {
        if (StaticPlayer.PlayerId[0] == 27)
        {
            TalesVariables.Tales = TalesVariables.TalesRoy;
            Taleid = PlayerPrefs.GetInt("Tale");
            TalesVariables.SetTale(Taleid);
            TalesVariables.Index += 1;

        }
        if (StaticPlayer.PlayerId[0] == 28)
        {
            Batalha = PlayerPrefs.GetInt("Batalha");
            PlayerPrefs.SetInt("Batalha",0);
            if (Batalha == 0)
            {
                TalesVariables.Day.SelectDay();
            }
            else
            {
                TalesVariables.SelectListTale();
                Taleid = PlayerPrefs.GetInt("Tale");
                TalesVariables.SetTale(Taleid);
                TalesVariables.Index += 1;
            }
            

        }
        if (StaticPlayer.PlayerId[0] == 29)
        {
            TalesVariables.Day.SelectDay();
        }
    }
}
