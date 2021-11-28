using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Adventure : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Roy()
    {
        StaticPlayer.Adventure = true;
        StaticPlayer.Fight = 1;
        StaticPlayer.PlayerId[0] = 27;
        StaticPlayer.PlayerLife[0] = 3;
        StaticPlayer.ManaRegen[0] = 0;
        StaticPlayer.Mana[0] = 0;
        StaticPlayer.Defense[0] = 0;
        StaticPlayer.PlayerMaxLife[0] = 0;
        StaticPlayer.Attack[0] = 0;
        SceneManager.LoadScene("Tales");
    }
}
