using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitStatic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StaticPlayer.TrueAttack = new List<int>();
        StaticPlayer.FakeAttack = new List<int>();
        StaticPlayer.Block = new List<int>();
        StaticPlayer.CounterAttack = new List<int>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
