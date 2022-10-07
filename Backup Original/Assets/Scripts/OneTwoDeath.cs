using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneTwoDeath : MonoBehaviour
{
    public GameObject Efemero;
    private void OnEnable()
    {
        OneTwo();

    }
    public void OneTwo()
    {
        Efemero.SetActive(true);
        Invoke("Death", 0.2f);
    }
    public void Death()
    {
        Efemero.SetActive(false);
    }
}
