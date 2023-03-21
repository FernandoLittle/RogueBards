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

    public List<int> ShuaSkills;
    public List<int> LyokoSkills;
    public List<int> AkashaSkills;
    public List<int> ManaSkills;
    public int NewIdSkill;
    public int OldIdSkill;
    public int TypeSkill;
    public GameObject GainSkill;
    public List<int> ShuaRelic;
    public List<int> LyokoRelic;
    public List<int> AkashaRelic;
    public List<int> ManaRelic;
    public List<int> RelicRelic;
    public int RelicId;
    public GameObject RelicObject;
    public Text RelicText;
    public Image RelicImage;
    public Text RelicName;
    public Text SkillName1;
    public Text SkillName2;
    public Text ScaleT1;
    public Text ScaleT2;


    //TrueSkills
    public List<int> TrueShuaSkills;
    public List<int> TrueLyokoSkills;
    public List<int> TrueAkashaSkills;
    public List<int> TrueManaSkills;
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
        OldSkill();
        NewSkill();
       
        GainSkill.SetActive(false);
    }
    public void NotReplace()
    {
        GainSkill.SetActive(false);
    }
    public void SpecificRelicReward(int idRelic)
    {
        RelicId = idRelic;
        GainRelic(RelicId);
        EyeRelic(RelicId);
    }
    public void RelicReward()
    {
        /*
        int God;
        int chaos;
        God = PlayerPrefs.GetInt("God");
        if (God == 1)
        {
            chaos = Random.Range(0,ShuaRelic.Count);
            RelicId = ShuaRelic[chaos];
        }
        if (God == 2)
        {
            chaos = Random.Range(0, LyokoRelic.Count);
            RelicId = LyokoRelic[chaos];
        }
        if (God == 3)
        {
            chaos = Random.Range(0, AkashaRelic.Count);
            RelicId = AkashaRelic[chaos];
        }
        if (God == 4)
        {
            chaos = Random.Range(0, ManaRelic.Count);
            RelicId = ManaRelic[chaos];
        }
        */
        int chaos;
        chaos= Random.Range(0, RelicRelic.Count);
        RelicId = RelicRelic[chaos];
        GainRelic(RelicId);
        EyeRelic(RelicId);
    }
    public void RelicRewardDagger()
    {

        RelicId = 19;
        GainRelic(RelicId);
        EyeRelic(RelicId);
    }
    public void RelicRewardSword()
    {

        RelicId = 1;
        GainRelic(RelicId);
        EyeRelic(RelicId);
    }
    public void EyeRelic(int id)
    {
        RelicName.text = d.Relics[id].Name;
        RelicObject.SetActive(true);
        RelicText.text = d.Relics[id].Description;
        RelicImage.sprite = d.Relics[id].SpriteRelic;
        int language;
        language = PlayerPrefs.GetInt("Language");
        if (language == 0)
        {
            RelicName.text = d.Relics[id].Name;
            RelicText.text = d.Relics[id].Description;
        }
        if (language == 1)
        {
            RelicName.text = d.Relics[id].NameBR;
            RelicText.text = d.Relics[id].DescriptionBR;
        }
    }
    public void GainRelic(int a)
    {
        Debug.Log("GainRelic");
        try
        {
            StaticPlayer.RelicsAlly.Add(a);
        }
        catch
        {
            Debug.Log("Sem Relíquia");
        }

    }
    public void TrueTrueGodReward()
    {
        int chaos;
        chaos = Random.Range(1, 5);
        PlayerPrefs.SetInt("God",chaos);
        TrueGodReward();
    }
    public void TrueGodReward()
    {
        int God;
        God = PlayerPrefs.GetInt("God");

        if (God == 1)
        {
            SelecTSkill(10);
        }
        if (God == 2)
        {
            SelecTSkill(11);
        }
        if (God == 3)
        {
            SelecTSkill(12);
        }
        if (God == 4)
        {
            SelecTSkill(13);
        }
    }
    public void RewardTale(int id, int type)
    {

        GainSkill.SetActive(true);
        OldSkill();
      


        NewIdSkill = id;
        TypeSkill = type;


        
        EyeSkill();
    }
    public void GodReward1()
    {
        // Não use esse lixo. Use o True God Reward
        int God;
        God= PlayerPrefs.GetInt("God");
        
        if (God == 1)
        {
            SelecTSkill(10);
        }
        if (God == 2)
        {
            SelecTSkill(11);
        }
        if (God == 3)
        {
            SelecTSkill(12);
        }
        if (God == 4)
        {
            SelecTSkill(13);
        }
    }
    public void SetTypeId(int id)
    {
        TypeSkill = id / 100;
        if (TypeSkill == 1)
        {
            NewIdSkill = id - 100;
        }
        if (TypeSkill == 2)
        {
            NewIdSkill = id - 200;
        }
        if (TypeSkill == 3)
        {
            NewIdSkill = id - 300;
        }
        if (TypeSkill == 4)
        {
            NewIdSkill = id - 400;
        }
    }
    public void TrueSelectSkill(int type)
    {
        int chaos;
        GainSkill.SetActive(true);
        OldSkill();        
        if (type == 10)//ShuáSkill
        {
            chaos = Random.Range(0, TrueShuaSkills.Count);

            SetTypeId(ShuaSkills[chaos]);
            


        }
        if (type == 11)//LyokoSkill
        {
            chaos = Random.Range(0, TrueLyokoSkills.Count);

            SetTypeId(ShuaSkills[chaos]);


        }
        if (type == 12)//AkashaSkill
        {
            chaos = Random.Range(0, TrueAkashaSkills.Count);

            SetTypeId(ShuaSkills[chaos]);


        }
        if (type == 13)//ManaSkill
        {
            chaos = Random.Range(0, TrueManaSkills.Count);

            SetTypeId(ShuaSkills[chaos]);


        }
        EyeSkill();
    }
    public void SelecTSkill(int type)
    {
        int chaos;
        GainSkill.SetActive(true);
        OldSkill();
        if (type == 1)
        {
            chaos=Random.Range(0, Tier1AF.Count);
            NewIdSkill = Tier1AF[chaos];
            TypeSkill = 1;

        }
        if (type == 2)
        {
            chaos = Random.Range(0, Tier1AR.Count);
            NewIdSkill = Tier1AR[chaos];
            TypeSkill = 2;

        }
        if (type == 3)
        {
            chaos = Random.Range(0, Tier1Block.Count);
            NewIdSkill = Tier1Block[chaos];
            TypeSkill = 3;

        }
        if (type == 4)
        {
            chaos = Random.Range(0, Tier1Dodge.Count);
            NewIdSkill = Tier1Dodge[chaos];
            TypeSkill = 4;

        }
        if (type == 5)
        {
            chaos = Random.Range(0, Tier2AF.Count);
            NewIdSkill = Tier2AF[chaos];
            TypeSkill = 1;

        }
        if (type == 6)
        {
            chaos = Random.Range(0, Tier2AR.Count);
            NewIdSkill = Tier2AR[chaos];
            TypeSkill = 2;

        }
        if (type == 7)
        {
            chaos = Random.Range(0, Tier2Block.Count);
            NewIdSkill = Tier2Block[chaos];
            TypeSkill = 3;

        }
        if (type == 8)
        {
            chaos = Random.Range(0, Tier2Dodge.Count);
            NewIdSkill = Tier2Dodge[chaos];
            TypeSkill = 4;

        }
        if (type == 10)//ShuáSkill
        {
            chaos = Random.Range(0, ShuaSkills.Count);

            NewIdSkill = ShuaSkills[chaos];
            TypeSkill = Random.Range(1, 5);

            
        }
        if (type == 11)//LyokoSkill
        {
            chaos = Random.Range(0, LyokoSkills.Count);

            NewIdSkill = LyokoSkills[chaos];
            TypeSkill = Random.Range(1, 5);


        }
        if (type == 12)//AkashaSkill
        {
            chaos = Random.Range(0, AkashaSkills.Count);

            NewIdSkill = AkashaSkills[chaos];
            TypeSkill = Random.Range(1, 5);


        }
        if (type == 13)//ManaSkill
        {
            chaos = Random.Range(0, ManaSkills.Count);

            NewIdSkill = ManaSkills[chaos];
            TypeSkill = Random.Range(1, 5);


        }
        EyeSkill();
    }
    public void NewSkill()
    {
        if (TypeSkill == 1)
        {
            StaticPlayer.TrueAttack[0] = NewIdSkill;
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
    }
    public void OldSkill()
    {
        if (TypeSkill == 1)
        {
            OldIdSkill = StaticPlayer.TrueAttack[0];
        }
        if (TypeSkill == 2)
        {
            OldIdSkill = StaticPlayer.FakeAttack[0];
        }
        if (TypeSkill == 3)
        {
            OldIdSkill = StaticPlayer.Block[0];
        }
        if (TypeSkill == 4)
        {
            OldIdSkill = StaticPlayer.CounterAttack[0];
        }
    }
    public void EyeSkill()
    {
        G1.il.SetActive(true);
        G2.il.SetActive(true);

        //



        if (TypeSkill == 1)
        {
            ScaleT1.text = d.AttackS[NewIdSkill].scale.ToString();
            G1.il1.sprite = d.AttackS[NewIdSkill].sprite;
            G1.t0.text = d.AttackS[NewIdSkill].Texto0;
            G1.SetKeyword(d.AttackS[NewIdSkill]);


            G2.d.ScaleT1.text = d.AttackS[OldIdSkill].scale.ToString();
            G2.il1.sprite = d.AttackS[OldIdSkill].sprite;
            G2.t0.text = d.AttackS[OldIdSkill].Texto0;
            G2.SetKeyword(d.AttackS[OldIdSkill]);

            SkillName1.text = d.AttackS[NewIdSkill].Name;
            SkillName2.text = d.AttackS[OldIdSkill].Name;
        }
        if (TypeSkill == 2)
        {
            ScaleT1.text = d.AttackQ[NewIdSkill].scale.ToString();
            G1.il1.sprite = d.AttackQ[NewIdSkill].sprite;
            G1.t0.text = d.AttackQ[NewIdSkill].Texto0;
            G1.SetKeyword(d.AttackQ[NewIdSkill]);



            ScaleT2.text = d.AttackQ[OldIdSkill].scale.ToString();
            G2.il1.sprite = d.AttackQ[OldIdSkill].sprite;
            G2.t0.text = d.AttackQ[OldIdSkill].Texto0;
            G2.SetKeyword(d.AttackQ[OldIdSkill]);



            SkillName1.text = d.AttackQ[NewIdSkill].Name;
            SkillName2.text = d.AttackQ[OldIdSkill].Name;
        }
        if (TypeSkill == 3)
        {
            ScaleT1.text = d.Block[NewIdSkill].scale.ToString();
            G1.il1.sprite = d.Block[NewIdSkill].sprite;
            G1.t0.text = d.Block[NewIdSkill].Texto0;
            G1.SetKeyword(d.Block[NewIdSkill]);



            ScaleT2.text = d.Block[OldIdSkill].scale.ToString();
            G2.il1.sprite = d.Block[OldIdSkill].sprite;
            G2.t0.text = d.Block[OldIdSkill].Texto0;
            G2.SetKeyword(d.Block[OldIdSkill]);



            SkillName1.text = d.Block[NewIdSkill].Name;
            SkillName2.text = d.Block[OldIdSkill].Name;
        }
        if (TypeSkill == 4)
        {
            ScaleT1.text = d.Dodge[NewIdSkill].scale.ToString();
            G1.il1.sprite = d.Dodge[NewIdSkill].sprite;
            G1.t0.text = d.Dodge[NewIdSkill].Texto0;
            G1.SetKeyword(d.Dodge[NewIdSkill]);



            ScaleT2.text = d.Dodge[OldIdSkill].scale.ToString();
            G2.il1.sprite = d.Dodge[OldIdSkill].sprite;
            G2.t0.text = d.Dodge[OldIdSkill].Texto0;
            G2.SetKeyword(d.Dodge[OldIdSkill]);



            SkillName1.text = d.Dodge[NewIdSkill].Name;
            SkillName2.text = d.Dodge[OldIdSkill].Name;
        }
        int language;
        language = PlayerPrefs.GetInt("Language");
        if (language == 0)
        {
            if (TypeSkill == 1)
            {
                G1.t0.text = d.AttackS[NewIdSkill].Texto0;




                G2.t0.text = d.AttackS[OldIdSkill].Texto0;


                SkillName1.text = d.AttackS[NewIdSkill].Name;
                SkillName2.text = d.AttackS[OldIdSkill].Name;
            }
            if (TypeSkill == 2)
            {

                G1.t0.text = d.AttackQ[NewIdSkill].Texto0;





                G2.t0.text = d.AttackQ[OldIdSkill].Texto0;




                SkillName1.text = d.AttackQ[NewIdSkill].Name;
                SkillName2.text = d.AttackQ[OldIdSkill].Name;
            }
            if (TypeSkill == 3)
            {

                G1.t0.text = d.Block[NewIdSkill].Texto0;




                G2.t0.text = d.Block[OldIdSkill].Texto0;




                SkillName1.text = d.Block[NewIdSkill].Name;
                SkillName2.text = d.Block[OldIdSkill].Name;
            }
            if (TypeSkill == 4)
            {

                G1.t0.text = d.Dodge[NewIdSkill].Texto0;



                G2.t0.text = d.Dodge[OldIdSkill].Texto0;




                SkillName1.text = d.Dodge[NewIdSkill].Name;
                SkillName2.text = d.Dodge[OldIdSkill].Name;
            }
        }
        if (language == 1)
        {
            if (TypeSkill == 1)
            {
                G1.t0.text = d.AttackS[NewIdSkill].Texto0br;




                G2.t0.text = d.AttackS[OldIdSkill].Texto0br;


                SkillName1.text = d.AttackS[NewIdSkill].NameBR;
                SkillName2.text = d.AttackS[OldIdSkill].NameBR;
            }
            if (TypeSkill == 2)
            {

                G1.t0.text = d.AttackQ[NewIdSkill].Texto0br;





                G2.t0.text = d.AttackQ[OldIdSkill].Texto0br;




                SkillName1.text = d.AttackQ[NewIdSkill].NameBR;
                SkillName2.text = d.AttackQ[OldIdSkill].NameBR;
            }
            if (TypeSkill == 3)
            {

                G1.t0.text = d.Block[NewIdSkill].Texto0br;




                G2.t0.text = d.Block[OldIdSkill].Texto0br;




                SkillName1.text = d.Block[NewIdSkill].NameBR;
                SkillName2.text = d.Block[OldIdSkill].NameBR;
            }
            if (TypeSkill == 4)
            {

                G1.t0.text = d.Dodge[NewIdSkill].Texto0br;



                G2.t0.text = d.Dodge[OldIdSkill].Texto0br;




                SkillName1.text = d.Dodge[NewIdSkill].NameBR;
                SkillName2.text = d.Dodge[OldIdSkill].NameBR;
            }
        }

        G1.t[0].SetActive(true);
        G2.t[0].SetActive(true);




    }
    public void OkRelic()
    {
        RelicObject.SetActive(false);
    }
  
}