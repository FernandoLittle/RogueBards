using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public int id;
    public Animator GateA;
    public A A;
    public GameObject But;
    public Result Result;
    private void OnEnable()
    {
        if (id == 0)
        {
            GateA.Play("Gate");
        }
        else
        {
            GateA.Play("Gate2");
        }
    }
    //anime void
    public void B()
    {
        A.Victory();
    }
    public void C()
    {
        But.SetActive(true);
        Result.SetResult();
    }
}
