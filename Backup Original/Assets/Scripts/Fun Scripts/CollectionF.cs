using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionF : MonoBehaviour
{
    public A A;
    public GameObject DisableM;
    //A Collection of Functions
    public void DisableMove(bool x)
    {
        if (x == false)
        {
            A.WaitingT.text = "Your turn!";
        }
        if (x == true)
        {
            A.WaitingT.text = "Waiting opponent...";
         
        }
        DisableM.SetActive(x);
    }

}
