using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillA : MonoBehaviour
{
    public G G1;
    public G G2;
    public D d;

    public List<int> Tier1AF;
    public List<int> Tier2AF;
    public List<int> Tier1AR;
    public List<int> Tier2AR;
    public List<int> Tier1Block;
    public List<int> Tier2Block;
    public List<int> Tier1Dodge;
    public List<int> Tier2Dodge;
    public int NewIdSkill;
    public int OldIdSkill;
    public int TypeSkill;
    public GameObject GainSkill;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Replace()
    {
        if (TypeSkill == 1)
        {
            StaticPlayer.TrueAttack[0]= NewIdSkill;
        }
        if (TypeSkill == 2)
        {
            StaticPlayer.FakeAttack[0] = NewIdSkill;
        }
        if (TypeSkill == 3)
        {
            StaticPlayer.Block[0] = NewIdSkill;
        }
        if (TypeSkill == 4)
        {
            StaticPlayer.CounterAttack[0] = NewIdSkill;
        }
        GainSkill.SetActive(false);
    }
    public void NotReplace()
    {
        GainSkill.SetActive(false);
    }
    public void SelecTSkill(int type)
    {
        int chaos;
        GainSkill.SetActive(true);
        if (type == 1)
        {
            chaos=Random.Range(0, Tier1AF.Count);
            NewIdSkill = Tier1AF[chaos];
            TypeSkill = 1;
            OldIdSkill = StaticPlayer.TrueAttack[0];
        }
        if (type == 2)
        {
            chaos = Random.Range(0, Tier1AR.Count);
            NewIdSkill = Tier1AR[chaos];
            TypeSkill = 2;
            OldIdSkill = StaticPlayer.FakeAttack[0];
        }
        if (type == 3)
        {
            chaos = Random.Range(0, Tier1Block.Count);
            NewIdSkill = Tier1Block[chaos];
            TypeSkill = 3;
            OldIdSkill = StaticPlayer.Block[0];
        }
        if (type == 4)
        {
            chaos = Random.Range(0, Tier1Dodge.Count);
            NewIdSkill = Tier1Dodge[chaos];
            TypeSkill = 4;
            OldIdSkill = StaticPlayer.CounterAttack[0];
        }
        if (type == 5)
        {
            chaos = Random.Range(0, Tier2AF.Count);
            NewIdSkill = Tier2AF[chaos];
            TypeSkill = 1;
            OldIdSkill = StaticPlayer.TrueAttack[0];
        }
        if (type == 6)
        {
            chaos = Random.Range(0, Tier2AR.Count);
            NewIdSkill = Tier2AR[chaos];
            TypeSkill = 2;
            OldIdSkill = StaticPlayer.FakeAttack[0];
        }
        if (type == 7)
        {
            chaos = Random.Range(0, Tier2Block.Count);
            NewIdSkill = Tier2Block[chaos];
            TypeSkill = 3;
            OldIdSkill = StaticPlayer.Block[0];
        }
        if (type == 8)
        {
            chaos = Random.Range(0, Tier2Dodge.Count);
            NewIdSkill = Tier2Dodge[chaos];
            TypeSkill = 4;
            OldIdSkill = StaticPlayer.CounterAttack[0];
        }
        EyeSkill();
    }
    public void EyeSkill()
    {
        G1.il.SetActive(true);
        G2.il.SetActive(true);

        //



        if (TypeSkill == 1)
        {
            d.ScaleT1.text = d.AttackS[NewIdSkill].scale.ToString();
            G1.il1.sprite = d.AttackS[NewIdSkill].sprite;
            G1.t0.text = d.AttackS[NewIdSkill].Texto0;
            G1.SetKeyword(d.AttackS[NewIdSkill]);


            G2.d.ScaleT1.text = d.AttackS[OldIdSkill].scale.ToString();
            G2.il1.sprite = d.AttackS[OldIdSkill].sprite;
            G2.t0.text = d.AttackS[OldIdSkill].Texto0;
            G2.SetKeyword(d.AttackS[OldIdSkill]);


        }
        if (TypeSkill == 2)
        {
            d.ScaleT1.text = d.AttackQ[NewIdSkill].scale.ToString();
            G1.il1.sprite = d.AttackQ[NewIdSkill].sprite;
            G1.t0.text = d.AttackQ[NewIdSkill].Texto0;
            G1.SetKeyword(d.AttackQ[NewIdSkill]);



            G2.d.ScaleT1.text = d.AttackQ[OldIdSkill].scale.ToString();
            G2.il1.sprite = d.AttackQ[OldIdSkill].sprite;
            G2.t0.text = d.AttackQ[OldIdSkill].Texto0;
            G2.SetKeyword(d.AttackQ[OldIdSkill]);
        }
        if (TypeSkill == 3)
        {
            d.ScaleT1.text = d.Block[NewIdSkill].scale.ToString();
            G1.il1.sprite = d.Block[NewIdSkill].sprite;
            G1.t0.text = d.Block[NewIdSkill].Texto0;
            G1.SetKeyword(d.Block[NewIdSkill]);



            G2.d.ScaleT1.text = d.Block[OldIdSkill].scale.ToString();
            G2.il1.sprite = d.Block[OldIdSkill].sprite;
            G2.t0.text = d.Block[OldIdSkill].Texto0;
            G2.SetKeyword(d.Block[OldIdSkill]);

        }
        if (TypeSkill == 4)
        {
            d.ScaleT1.text = d.Dodge[NewIdSkill].scale.ToString();
            G1.il1.sprite = d.Dodge[NewIdSkill].sprite;
            G1.t0.text = d.Dodge[NewIdSkill].Texto0;
            G1.SetKeyword(d.Dodge[NewIdSkill]);



            G2.d.ScaleT1.text = d.Dodge[OldIdSkill].scale.ToString();
            G2.il1.sprite = d.Dodge[OldIdSkill].sprite;
            G2.t0.text = d.Dodge[OldIdSkill].Texto0;
            G2.SetKeyword(d.Dodge[OldIdSkill]);

        }

        G1.t[0].SetActive(true);
        G2.t[0].SetActive(true);




    }

  
}