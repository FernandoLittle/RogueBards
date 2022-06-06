using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigerar : MonoBehaviour
{
    public Alma Alma;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        Alma.TrigerYes();
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        Alma.TrigerNo();
    }
}
