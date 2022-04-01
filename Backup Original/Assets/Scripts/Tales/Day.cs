using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Day : MonoBehaviour
{
    public int day;
    public TalesVariables TalesVariables;
    public void SelectDay()
    {
        day = StaticPlayer.Day;
        if (day == 1)
        {
           RandomIntro();
        }
        if (day == 2)
        {

        }
        if (day == 3)
        {

        }
        if (day == 4)
        {


        }
        if (day == 5)
        {

        }
        if (day == 6)
        {

        }
        if (day == 7)
        {

        }
        if (day == 8)
        {

        }
        if (day == 9)
        {

        }
        if (day == 10)
        {

        }
    }

    public void RandomIntro()
    {
        int caos;
        caos = Random.Range(0, 5);
        TalesVariables.Tales = TalesVariables.TalesIntro;
        TalesVariables.SetTale(caos);
        TalesVariables.Index += 1;
    }



}
