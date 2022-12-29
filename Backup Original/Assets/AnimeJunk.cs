using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimeJunk : MonoBehaviour
{
    public Dio Dio;
    public int Disableint;
    public void A()
    {
        if (Disableint == 1)
        {
            Dio.DisableAll();
            Disableint = 0;
        }

    }
    public void B()
    {
        Disableint = 1;
    }
}
