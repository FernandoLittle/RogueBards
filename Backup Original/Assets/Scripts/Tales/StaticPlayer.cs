using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticPlayer : MonoBehaviour
{
    public static int Day;
    public static List<int> TrueAttack;
    public static List<int> FakeAttack;
    public static List<int> Block;
    public static List<int> CounterAttack;




    public static bool Adventure;
    public static int[] PlayerId;
    public static int[] PlayerLife;
    public static int[] ManaRegen;
    public static int[] Mana;
    public static int[] Defense;
    public static int[] PlayerMaxLife;
    public static int[] Attack;
    public static List<int> RelicsAlly;
    public static int [,] PlayerKeyword = new int [8,6];
    public static int Fight;
    // Start is called before the first frame update
    void Start()
    {

        TrueAttack = new List<int>();
        FakeAttack = new List<int>();
        Block = new List<int>();
        CounterAttack = new List<int>();
        RelicsAlly=new List<int>();

        PlayerId =new int[6];
        PlayerLife = new int[6];
        ManaRegen=new int[6];
        Mana= new int[6];
        Defense= new int[6];
        PlayerMaxLife= new int[6];
        Attack= new int[6];
        //Temporário
        TrueAttack.Add(20);
        FakeAttack.Add(20);
        Block.Add(20);
        CounterAttack.Add(20);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
