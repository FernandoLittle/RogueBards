﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Generic : MonoBehaviour
{
    public List<GameObject> b;
    public float a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public int Desc(int a)
    {
        if (a < 0)
        {
            return a * -1;
        }
        else if(a>0&& a<1000)
        {
            return a;
        }
        else if(a>1000)
        {
            return a - 1000;
        }
       else
        {
            return 0;
        }
            
        

    }
    public int Module(int a)
    {
        if (a < 0)
        {
            return a * -1;
        }
        else
        {
            return a;
        }
        
    }
    public int Smaller(int a, int b)
    {
        if (a > b)
        {
            return b;
        }
        else
        {
            return a;
        }
    }
   public int MirrorConversor(int zone){
        if (zone == 1)
        {
            return 4;
        }
        if (zone == 2)
        {
            return 5;
        }
        if (zone == 3)
        {
            return 6;
        }
        if (zone == 4)
        {
            return 1;
        }
        if (zone == 5)
        {
            return 2;
        }
        if (zone == 6)
        {
            return 3;
        }
        if (zone == 7)
        {
            return 9;
        }
        if (zone == 8)
        {
            return 10;
        }
        if (zone == 9)
        {
            return 7;
        }
        else
        {
            return 8;
        }


    }
    public string CodeLyoko(string a, int b)
    {
        return a.Split('\t')[b];
    }
    public int Buneco(int a)
    {
        if (a == 1)
        {
            return 3;
        }
        if (a == 2)
        {
            return 2;
        }
        if (a == 3)
        {
            return 1;
        }
        if (a == 4)
        {
            return 6;
        }
        if (a == 5)
        {
            return 5;
        }
        if (a == 6)
        {
            return 4;
        }
        else
        {
            return 0;
        }

    }
}
