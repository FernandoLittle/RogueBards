using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTale : MonoBehaviour
{
    public TalesVariables TalesVariables;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextTale()
    {
        if (StaticPlayer.PlayerId[0] == 27)
        {
            if (StaticPlayer.Fight == 1)
            {
                TalesVariables.SetTale(0);
            }
        }
    }
}
