using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckSystem : MonoBehaviour
{
    public List<int> TrueAttack;
    public List<int> FakeAttack;
    public List<int> Block;
    public List<int> CounterAttack;
    public D D;
    public A A;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddCard()
    {

        TrueAttack.Clear();
        FakeAttack.Clear();
        Block.Clear();
        CounterAttack.Clear();
        try
        {
            for (int x = 0; x < StaticPlayer.TrueAttack.Count; x = x + 1)
            {
                TrueAttack.Add(StaticPlayer.TrueAttack[x]);
            }
        }
        catch
        {
            Debug.Log("SemTrueAttack");
        }
        try
        {
            for (int x = 0; x < StaticPlayer.FakeAttack.Count; x = x + 1)
            {
                FakeAttack.Add(StaticPlayer.FakeAttack[x]);
            }
        }
        catch
        {
            Debug.Log("SemFakeAttack");
        }
        try
        {
            for (int x = 0; x < StaticPlayer.Block.Count; x = x + 1)
            {
                Block.Add(StaticPlayer.Block[x]);
            }
        }
        catch
        {
            Debug.Log("SemBlock");
        }
        try
        {
            for (int x = 0; x < StaticPlayer.CounterAttack.Count; x = x + 1)
            {
                CounterAttack.Add(StaticPlayer.CounterAttack[x]);
            }
        }
        catch
        {
            Debug.Log("SemCounterAttack");
        }
        AddCard2();
       // Exemplo: D.Chara[0].AtaqueForte.Add(3);
        //Add cards
        /*for (int x = 0; x < Relics.Count; x = x + 1)
        {
            A.zoneid[4].Relics.Add(Relics[x]);
        }*/
    }
    public void AddCard2()
    {
  
            for (int x = 0; x < TrueAttack.Count; x = x + 1)
            {
                //D.Chara[A.zoneid[4].idcard1].AtaqueForte.Add(TrueAttack[x]);

            }
        


            for (int x = 0; x < FakeAttack.Count; x = x + 1)
            {
               // D.Chara[A.zoneid[4].idcard1].AtaqueRápido.Add(FakeAttack[x]);

            }
        


            for (int x = 0; x < Block.Count; x = x + 1)
            {
                //D.Chara[A.zoneid[4].idcard1].Bloqueio.Add(Block[x]);

            }



            for (int x = 0; x < CounterAttack.Count; x = x + 1)
            {
               // D.Chara[A.zoneid[4].idcard1].Esquiva.Add(CounterAttack[x]);

            }


    }
    


}
