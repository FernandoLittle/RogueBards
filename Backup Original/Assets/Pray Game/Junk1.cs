using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Junk1 : MonoBehaviour
{
    public int id;
    public SoulPray SoulPray;
    public void A()
    {
        if (id == 1)
        {
            SoulPray.Background1();
        }
        if (id == 2)
        {
            SoulPray.Background2();
        }
        if (id == 3)
        {
            SoulPray.NextWord();
        }
    }
}
