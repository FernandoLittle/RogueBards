using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interface : MonoBehaviour
{
    public int DefenseAlly;
    public int AttackAlly;
    public int ManaAlly;
    public int LifeAlly;
    public int DefenseEnemy;
    public int AttackEnemy;
    public int ManaEnemy;
    public int LifeEnemy;
    public int DefenseAllyOld;
    public int AttackAllyOld;
    public int ManaAllyOld;
    public int LifeAllyOld;
    public int DefenseEnemyOld;
    public int AttackEnemyOld;
    public int ManaEnemyOld;
    public int LifeEnemyOld;
    public B Ally;
    public B Enemy;
    public Text DefenseAllyT;
    public Text AttackAllyT;
    public Text ManaAllyT;
    public Text LifeAllyT;
    public Text DefenseEnemyT;
    public Text AttackEnemyT;
    public Text ManaEnemyT;
    public Text LifeEnemyT;
    public BarControl BarAllyLife;
    public BarControl BarAllyMana;
    public BarControl BarEnemyLife;
    public BarControl BarEnemyMana;
    public List<GameObject> ChangeAllyO;
    public List<GameObject> ChangeEnemyO;
    public List<Text> ChangeAllyT;
    public List<Text> ChangeEnemyT;
    public bool SkipFirstTurn;
    // Start is called before the first frame update
    public void SetStatos()
    {



        DefenseAlly = Ally.Lyoko[2];
        AttackAlly = Ally.Lyoko[1];
        LifeAlly = Ally.Lyoko[0];
        ManaAlly = Ally.Mana;
        DefenseEnemy = Enemy.Lyoko[2];
        AttackEnemy = Enemy.Lyoko[1];
        LifeEnemy = Enemy.Lyoko[0];
        ManaEnemy = Enemy.Mana;






        BarAllyLife.NewInt = LifeAlly*10;
        BarAllyMana.NewInt = ManaAlly*10;

        BarEnemyLife.NewInt = LifeEnemy*10;
        BarEnemyMana.NewInt = ManaEnemy*10;


        BarAllyLife.Change = true;
        BarAllyMana.Change = true; 

        BarEnemyLife.Change = true; 
        BarEnemyMana.Change = true;

        DefenseAllyT.text = DefenseAlly.ToString();
        AttackAllyT.text = AttackAlly.ToString();
        LifeAllyT.text = "Life "+ LifeAlly.ToString();
        ManaAllyT.text = "Mana " + ManaAlly.ToString();
        DefenseEnemyT.text = DefenseEnemy.ToString();
        AttackEnemyT.text = AttackEnemy.ToString();
        LifeEnemyT.text = "Life " + LifeEnemy.ToString();
        ManaEnemyT.text = "Mana "+ ManaEnemy.ToString();
        ActiveChange();

    }
    public void ActiveChange()
    {
        Debug.Log("YEEEEE");

            ActiveChange1(LifeAllyOld, LifeAlly, ChangeAllyT[0], ChangeAllyO[0]);
            ActiveChange1(AttackAllyOld, AttackAlly, ChangeAllyT[1], ChangeAllyO[1]);
            ActiveChange1(DefenseAllyOld, DefenseAlly, ChangeAllyT[2], ChangeAllyO[2]);
            ActiveChange1(ManaAllyOld, ManaAlly, ChangeAllyT[3], ChangeAllyO[3]);

            ActiveChange1(LifeEnemyOld, LifeEnemy, ChangeEnemyT[0], ChangeEnemyO[0]);
            ActiveChange1(AttackEnemyOld, AttackEnemy, ChangeEnemyT[1], ChangeEnemyO[1]);
            ActiveChange1(DefenseEnemyOld, DefenseEnemy, ChangeEnemyT[2], ChangeEnemyO[2]);
            ActiveChange1(ManaEnemyOld, ManaEnemy, ChangeEnemyT[3], ChangeEnemyO[3]);


    }
    public void ActiveChange1(int OldAttribute, int NewAttribute, Text ValueText, GameObject Stuff)
    {
        int Difference;
        Difference = NewAttribute - OldAttribute;
        if (Difference !=0)
        {
         
            Stuff.SetActive(true);
            if (Difference > 0)
            {
                ValueText.text = "<color=green>"+Difference.ToString()+"</color>";
            }
            else
            {
                ValueText.text =  "<color=red>" + "- " + Difference.ToString() + "</color>";

            }
        }
    }
    public void SetStatosOld()
    {
        Debug.Log("Setado");
        DefenseAllyOld = DefenseAlly;
        AttackAllyOld = AttackAlly;
        LifeAllyOld = LifeAlly;
        ManaAllyOld = ManaAlly;
        DefenseEnemyOld = DefenseEnemy;
        AttackEnemyOld = AttackEnemy;
        LifeEnemyOld = LifeEnemy;
        ManaEnemyOld = ManaEnemy;
    }
}
