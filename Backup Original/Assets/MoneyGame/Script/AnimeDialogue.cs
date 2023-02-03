using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimeDialogue : MonoBehaviour
{
    public Dio Dio;
    public int id;
    public Animator anime;
    public void A()
    {
        if (id == 0)
        {
            Dio.AnimeExecution();
        }
       
    }
    public void B()
    {
        if (id == 0)
        {
            Dio.DialoguePower(Dio.DialogueInstruction[0]);
        }
           
    }
    public void C()
    {
        gameObject.SetActive(false);
    }
    public void D()
    {
        if (id == 1)
        {
            anime.Play("DialogueEnd");
        }
    }
}
