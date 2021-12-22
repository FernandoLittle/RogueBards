using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetStuff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddTrueAttack(int idcard)
    {
        StaticPlayer.TrueAttack.Add(idcard);
    }
    public void AddFakeAttack(int idcard)
    {
        StaticPlayer.FakeAttack.Add(idcard);
    }
    public void AddBlock(int idcard)
    {
        StaticPlayer.Block.Add(idcard);
    }
    public void AddCounterAttack(int idcard)
    {
        StaticPlayer.CounterAttack.Add(idcard);
    }
    public void Play()
    {
        SceneManager.LoadScene("Battle");
    }
}
