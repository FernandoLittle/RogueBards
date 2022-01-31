using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticData : MonoBehaviour
{
    public List<int> TrueAttack;
    public List<int> FakeAttack;
    public List<int> Block;
    public List<int> CounterAttack;




    public bool Adventure;
    public int[] PlayerId;
    public int[] PlayerLife;
    public int[] ManaRegen;
    public int[] Mana;
    public int[] Defense;
    public int[] PlayerMaxLife;
    public int[] Attack;
    public List<int> RelicsAlly;
    public int Fight;
    public void Set()
    {
        PlayerId = new int[6];
        PlayerLife = new int[6];
        ManaRegen = new int[6];
        Mana = new int[6];
        Defense = new int[6];
        PlayerMaxLife = new int[6];
        Attack = new int[6];
        Fight = StaticPlayer.Fight;
        if (StaticPlayer.TrueAttack.Count > 0)
        {
            for (int x = 0; x < StaticPlayer.TrueAttack.Count; x = x + 1)
            {
                TrueAttack.Add(StaticPlayer.TrueAttack[x]);
            }
        }
        if (StaticPlayer.FakeAttack.Count > 0)
        {
            for (int x = 0; x < StaticPlayer.FakeAttack.Count; x = x + 1)
            {
                FakeAttack.Add(StaticPlayer.FakeAttack[x]);
            }
        }

        if (StaticPlayer.Block.Count > 0)
        {
            for (int x = 0; x < StaticPlayer.Block.Count; x = x + 1)
            {
                Block.Add(StaticPlayer.Block[x]);
            }
        }
        if (StaticPlayer.CounterAttack.Count > 0)
        {
            for (int x = 0; x < StaticPlayer.CounterAttack.Count; x = x + 1)
            {
                CounterAttack.Add(StaticPlayer.CounterAttack[x]);
            }
        }
        if (StaticPlayer.RelicsAlly.Count > 0)
        {
            for (int x = 0; x < StaticPlayer.RelicsAlly.Count; x = x + 1)
            {
                RelicsAlly.Add(StaticPlayer.RelicsAlly[x]);
            }
        }

        for (int x = 0; x < 6; x = x + 1)
        {
            PlayerId[x] = StaticPlayer.PlayerId[x];
            PlayerLife[x] = StaticPlayer.PlayerLife[x];
            ManaRegen[x] = StaticPlayer.ManaRegen[x];
            Mana[x] = StaticPlayer.Mana[x];
            Defense[x] = StaticPlayer.Defense[x];
            PlayerMaxLife[x] = StaticPlayer.PlayerMaxLife[x];
            Attack[x] = StaticPlayer.Attack[x];
        }
    }
}
