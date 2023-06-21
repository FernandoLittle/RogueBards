using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class D : MonoBehaviour
{
    //public Dictionary<int, Action> AtaqueForte1= new Dictionary<int, Action>();
    //public Dictionary<int, Action> AtaqueRápido1 = new Dictionary<int, Action>();
    //public Dictionary<int, Action> Bloqueio1 = new Dictionary<int, Action>();
    //public Dictionary<int, Action> Esquiva1 = new Dictionary<int, Action>();
    public List<int> b;
    //probablilidade
    public List<int> AFp;
    public List<int> ARp;
    public List<int> Blp;
    public List<int> Esp;
    public Image AF;
    public Image AR;
    public Image Bl;
    public Image Es;
    public G AFx;
    public G ARx;
    public G Blx;
    public G Esx;
    public Image AF1;
    public Image AR1;
    public Image Bl1;
    public Image Es1;
    public G AF1x;
    public G AR1x;
    public G Bl1x;
    public G Es1x;
    public List<B> Zone;
    public List<Text> LifeT;
    public List<I> Guild;
    public List<Button> bt;
    public A a;
    //Remover
    public Card h;
    //Randomico
    public int h1;
    //Personagens
    public int Ally;
    public int Enemy;
    public List<Card> Chara;
    public Image AllyIm;
    public Image EnemyIm;

    public List<Action> AttackQ;
    public int a1;
    public int a11;

    public List<Action> AttackS;
    public int a2;
    public int a21;

    public List<Action> Dodge;
    public int a3;
    public int a31;

    public List<Action> Block;
    public int a4;
    public int a41;

    public GameObject Fight;
    public GameObject Cancel;
    //attack counter
    public int c;
    //defense counter
    public int c1;
    public GameObject C1;
    public GameObject C2;
    public GameObject Dark;
    public List<Animator> anime;
    public F f;
    //Ally and Enemy Scripts
    public List<L> L;
    public List<Text> at;
    public List<Sprite> s;
    public Image Rift;
    public Image Rift1;
    public int summ;

    public GameObject i1;
    public GameObject i2;
    public List<GameObject> Blue;

    public int p1;
    public int p2;
    public Izanami Izanami;
    public Tutorial Tuto;
    public GameObject Tuto1;
    public List<Animator> Typ;
    public Text ScaleSA;
    public Text ScaleQA;
    public Text ScaleBA;
    public Text ScaleEA;
    public Text ScaleSE;
    public Text ScaleQE;
    public Text ScaleBE;
    public Text ScaleEE;
    public int SkillId;
    public Combat Combat;
    public Text ScaleT;
    public List<GameObject> Fantasy;
    public FantasyRivalsIA FantasyRivalsIA;
    //Ally=1, Enenmy=0
    public int Attacking;
    public List<GameObject> Skills;
    public GameObject DisableO;
    public Sprite FantasyBack;
    public GameObject PowerMod;
    public GameObject PowerMod1;
    public Generic Generic;


    public List<GameObject> ScaleM;
    public Text ManaAT;
    public Text ManaET;
    public List<GameObject> Keywords;
    public List<Text> KeywordsT;
    public Transform TextTransform;
    public RectTransform TextRTransform;
    public List<Transform> KeywordTransform;
    public Text Description;
    public List<Image> KeywordColor;
    public List<Relic> Relics;
    public List<Status> Status;
    public List<FightParameters> FightParameters;
    public Text ScaleT1;
    // Start is called before the first frame update
    private void OnEnable()
    {
        
    }
    public void SetNewCards()
    {
        Debug.Log("SetNewCards");

        if (a.DeckSystem.TrueAttack.Count > 0)
        {
            Debug.Log("TrueAttack");
            Debug.Log(a.DeckSystem.TrueAttack[0]);
            if (a.DeckSystem.TrueAttack[0] != 0)
            {
                a1= a.DeckSystem.TrueAttack[0];
                AF.sprite = AttackS[a.DeckSystem.TrueAttack[0]].sprite;
                AFx.id = a.DeckSystem.TrueAttack[0];
                //Scale heritage
                ScaleSA.text = AttackS[a.DeckSystem.TrueAttack[0]].scale.ToString();
            }

        }


        if (a.DeckSystem.FakeAttack.Count > 0)
        {

            Debug.Log(a.DeckSystem.FakeAttack[0]);
            if (a.DeckSystem.FakeAttack[0] != 0)
            {
                a2= a.DeckSystem.FakeAttack[0];
                AR.sprite = AttackQ[a.DeckSystem.FakeAttack[0]].sprite;
                ARx.id = a.DeckSystem.FakeAttack[0];
                ScaleQA.text = AttackQ[a.DeckSystem.FakeAttack[0]].scale.ToString();
            }

        }


        if (a.DeckSystem.Block.Count > 0)
        {

            Debug.Log(a.DeckSystem.Block[0]);
            if (a.DeckSystem.Block[0] != 0)
            {
                a3 = a.DeckSystem.Block[0];
                Bl.sprite = Block[a.DeckSystem.Block[0]].sprite;
                Blx.id = a.DeckSystem.Block[0];
                ScaleBA.text = Block[a.DeckSystem.Block[0]].scale.ToString();
            }

        }

        if (a.DeckSystem.CounterAttack.Count > 0)
        {


            if (a.DeckSystem.CounterAttack[0] != 0)
            {
                a4= a.DeckSystem.CounterAttack[0];
                Es.sprite = Dodge[a.DeckSystem.CounterAttack[0]].sprite;
                Esx.id = a.DeckSystem.CounterAttack[0];
                ScaleEA.text = Dodge[a.DeckSystem.CounterAttack[0]].scale.ToString();
            }

        }



    }
    public void SetInfo()
    {
    
        Combat.NoRepeatKey = false;
        Combat.AllyConfirm = false;
        Combat.EnemyConfirm = false;

        //ManaAT.text = Combat.ManaA.ToString();
        //ManaET.text = Combat.ManaE.ToString();
        //a.DisableA(false);
        //DisableA(false);
        if (a.offline == false)
        {

          //  a.DisableOnline.SetActive(true);
            //a.WaitingT.text = "Waiting opponent...";
        }
        PowerMod.SetActive(false);
        PowerMod1.SetActive(false);
        //Normalizator();
        //a.Normalizator();
        for (int x = 0; x < 8; x = x + 1)
        {
            ScaleM[x].SetActive(true);
        }

        /*
                if (a.Atacante == true)
                {
                    Skills[0].SetActive(true);
                    Skills[1].SetActive(true);
                    Skills[6].SetActive(true);
                    Skills[7].SetActive(true);
                    Skills[2].SetActive(false);
                    Skills[3].SetActive(false);
                    Skills[4].SetActive(false);
                    Skills[5].SetActive(false);

                    Blue[0].SetActive(true);
                    Blue[1].SetActive(true);
                    Blue[2].SetActive(false);
                    Blue[3].SetActive(false);
                }
                if (a.Atacante == false)
                {
                    Skills[2].SetActive(true);
                    Skills[3].SetActive(true);
                    Skills[4].SetActive(true);
                    Skills[5].SetActive(true);
                    Skills[0].SetActive(false);
                    Skills[1].SetActive(false);
                    Skills[6].SetActive(false);
                    Skills[7].SetActive(false);

                    Blue[2].SetActive(true);
                    Blue[3].SetActive(true);
                    Blue[0].SetActive(false);
                    Blue[1].SetActive(false);

                }
        */
        Combat.ManaSpendA = 0;
        Combat.ManaSpendE = 0;

        /* if (Tuto.tf == 1)
         {
             if (Tuto.ax == 0)
             {
                 Tuto1.SetActive(true);
                 Tuto.C(1);
                 Tuto.ax += 1;
             }
             if (Tuto.ax == 2)
             {
                 Tuto1.SetActive(true);
                 Tuto.C(5);
             }

         }
        */



        /* for (int x = 0; x < Blue.Count; x = x + 1)
         {
             Blue[x].SetActive(true);
         }
        */
        if (a.X1Lixo == true)
        {
            PlayerPrefs.SetInt("A1", a.Zone[2].idcard1);
            PlayerPrefs.SetInt("A", a.Zone[5].idcard1);
        }


        Ally = PlayerPrefs.GetInt("A");
        Enemy = PlayerPrefs.GetInt("A1");
        if (Ally < 0)
        {
            Ally *= -1;
        }
        if (Enemy < 0)
        {
            Enemy *= -1;
        }

        //summ = PlayerPrefs.GetInt("Rift");
        //Rift.sprite = s[summ];
        Rift1.sprite = FantasyBack;
        AllyIm.sprite = Chara[Ally].sprite;
        EnemyIm.sprite = Chara[Enemy].sprite;

        f.G();

        L[0].at[0] = Zone[p1].Lyoko[0];
        L[0].at[1] = Zone[p1].Lyoko[1];
        L[0].at[2] = Zone[p1].Lyoko[2];
        L[0].id = Generic.Module(Zone[p1].idcard1);


        L[0].at[5] = Zone[p1].Mana;
        Combat.ManaA = Zone[p1].Mana;
        FantasyRivalsIA.TotalManaA = Zone[p1].Mana;

        L[1].at[0] = Zone[p2].Lyoko[0];
        L[1].at[1] = Zone[p2].Lyoko[1];
        L[1].at[2] = Zone[p2].Lyoko[2];
        L[1].id = Generic.Module(Zone[p2].idcard1);


        L[1].at[5] = Zone[p2].Mana;
        Combat.ManaE = Zone[p2].Mana;
        FantasyRivalsIA.TotalManaE = Zone[p2].Mana;



        at[0].text = Zone[p1].Lyoko[0].ToString();
        at[1].text = Zone[p1].Lyoko[1].ToString();
        at[2].text = Zone[p1].Lyoko[2].ToString();
        at[3].text = Zone[p1].Mana.ToString();

        at[5].text = Zone[p2].Lyoko[0].ToString();
        at[6].text = Zone[p2].Lyoko[1].ToString();
        at[7].text = Zone[p2].Lyoko[2].ToString();
        at[8].text = Zone[p2].Mana.ToString();



        //Sorteio das habilidades
        h1 = Random.Range(0, Chara[Ally].AtaqueForte.Count);
        a1 = Chara[Ally].AtaqueForte[h1];

        h1 = Random.Range(0, Chara[Enemy].AtaqueForte.Count);
        a11 = Chara[Enemy].AtaqueForte[h1];


        h1 = Random.Range(0, Chara[Ally].AtaqueRápido.Count);
        a2 = Chara[Ally].AtaqueRápido[h1];

        h1 = Random.Range(0, Chara[Enemy].AtaqueRápido.Count);
        a21 = Chara[Enemy].AtaqueRápido[h1];



        h1 = Random.Range(0, Chara[Ally].Bloqueio.Count);
        a3 = Chara[Ally].Bloqueio[h1];

        h1 = Random.Range(0, Chara[Enemy].Bloqueio.Count);
        a31 = Chara[Enemy].Bloqueio[h1];



        h1 = Random.Range(0, Chara[Ally].Esquiva.Count);
        a4 = Chara[Ally].Esquiva[h1];

        h1 = Random.Range(0, Chara[Enemy].Esquiva.Count);
        a41 = Chara[Enemy].Esquiva[h1];

        //Heritage Skill ID IA
        FantasyRivalsIA.SkillIDA[0] = a1;
        FantasyRivalsIA.SkillIDA[1] = a2;
        FantasyRivalsIA.SkillIDA[2] = a3;
        FantasyRivalsIA.SkillIDA[3] = a4;
        FantasyRivalsIA.SkillIDE[0] = a11;
        FantasyRivalsIA.SkillIDE[1] = a21;
        FantasyRivalsIA.SkillIDE[2] = a31;
        FantasyRivalsIA.SkillIDE[3] = a41;


        //Sprites das habilidades
        AF.sprite = AttackS[a1].sprite;
        AFx.id = a1;
        //Scale heritage
        ScaleSA.text = AttackS[a1].scale.ToString();


        AR.sprite = AttackQ[a2].sprite;
        ARx.id = a2;
        ScaleQA.text = AttackQ[a2].scale.ToString();


        Bl.sprite = Block[a3].sprite;
        Blx.id = a3;
        ScaleBA.text = Block[a3].scale.ToString();

        Es.sprite = Dodge[a4].sprite;
        Esx.id = a4;
        ScaleEA.text = Dodge[a4].scale.ToString();

        AF1.sprite = AttackS[a11].sprite;
        AF1x.id = a11;
        ScaleSE.text = AttackS[a11].scale.ToString();


        AR1.sprite = AttackQ[a21].sprite;
        AR1x.id = a21;
        ScaleQE.text = AttackQ[a21].scale.ToString();

        Bl1.sprite = Block[a31].sprite;
        Bl1x.id = a31;
        ScaleBE.text = Block[a31].scale.ToString();

        Es1.sprite = Dodge[a41].sprite;
        Es1x.id = a41;
        ScaleEE.text = Dodge[a41].scale.ToString();



        SetNewCards();
        /* Debug.Log(AtaqueForte1.Count);
         h1 = Random.Range(0, AFp.Count);
         AF.sprite = AtaqueForte1[AFp[h1]].sprite;
         h1 = Random.Range(0, ARp.Count);
         AR.sprite = AtaqueRápido1[ARp[h1]].sprite;
         h1 = Random.Range(0, Blp.Count);
         Bl.sprite = Bloqueio1[Blp[h1]].sprite;
         h1 = Random.Range(0, Esp.Count);
         Es.sprite = Esquiva1[Esp[h1]].sprite;*/
        c = 0;
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void A()
    {
        c = 1;
        A2();
    }
    public void A1()
    {
        c1 = 1;
        A2();

    }
    public void A2()
    {
        if (c == 1 && c1 == 1)
        {
            Fight.SetActive(true);
            Cancel.SetActive(true);
        }
        Fantasy[0].SetActive(true);
        Fantasy[1].SetActive(true);

    }
    public void Return()
    {
        Fantasy[0].SetActive(false);
        Fantasy[1].SetActive(false);
    }
    public void B()
    {
        Izanami.A();
        PlayerPrefs.SetInt("A", 0);
        PlayerPrefs.SetInt("B", 0);
        //Hide Types
        /*for (int x = 0; x < Typ.Count; x = x + 1)
        {
            Typ[x].Play("Spec");
        }*/


        a.ChangeControl();
        for (int x = 1; x < 11; x = x + 1)
        {
            LifeT[x].text = Zone[x].Lyoko[0].ToString();
        }
        a.TurnUp();
        if (a.turn == a.end)
        {


            a.B();
        }
        // C1.SetActive(true);
        // C2.SetActive(false);
       // anime[8].Play("draco");
        //anime[9].Play("draco");
        i1.SetActive(false);
        i2.SetActive(false);
        if (f.b1 == 0)
        {
            //anime[0].Play("draco0");
        }
        if (f.b2 == 0)
        {
           // anime[1].Play("draco0");

        }
        if (f.b3 == 0)
        {
           // anime[2].Play("draco0");
        }
        if (f.b4 == 0)
        {
         //   anime[3].Play("draco0");
        }
        if (f.b5 == 0)
        {
         //   anime[4].Play("draco0");
        }
        if (f.b6 == 0)
        {
          //  anime[5].Play("draco0");
        }
        if (f.b7 == 0)
        {
         //   anime[6].Play("draco0");
        }
        if (f.b8 == 0)
        {
          //  anime[7].Play("draco0");
        }

        if (f.b1==1 && f.b7 == 1)
        {
            AFx.e = 1;
            Bl1x.e = 0;
            //anime[0].Play("A1");
           // anime[6].Play("B1e");
        }
        if (f.b1 == 1 && f.b8 == 1)
        {
            AFx.e = 0;
            Es1x.e = 1;
          //  anime[0].Play("A1");
           // anime[7].Play("B2e");
        }
        if (f.b2 == 1 && f.b7 == 1)
        {
            ARx.e = 0;
            Bl1x.e = 1;
           // anime[1].Play("A2");
           // anime[6].Play("B1e");
        }
        if (f.b2 == 1 && f.b8 == 1)
        {
            ARx.e = 1;
            Es1x.e = 0;
          //  anime[1].Play("A2");
          //  anime[7].Play("B2e");
        }
        Fight.SetActive(false);
        Cancel.SetActive(false);
        //Dark.SetActive(true);
    }
    public void C()
    {
        c = 0;
        Fight.SetActive(false);
        Cancel.SetActive(false);
    }
    public void E()
    {


        if (f.b3 == 1 && f.b5 == 1)
        {
            Blx.e = 0;
            AF1x.e = 1;
            anime[2].Play("B1");
            anime[4].Play("A1x");
        }
        if (f.b4 == 1 && f.b5 == 1)
        {
            Esx.e = 1;
            AF1x.e = 0;
            anime[3].Play("B2");
            anime[4].Play("A1x");
        }
        if (f.b3 == 1 && f.b6 == 1)
        {
            AR1x.e = 0;
            Blx.e = 1;
            anime[2].Play("B1");
            anime[5].Play("A2x");
        }
        if (f.b4 == 1 && f.b6 == 1)
        {
            AR1x.e = 1;
            Esx.e = 0;
            anime[3].Play("B2");
            anime[5].Play("A2x");
        }
    }
    public void CardSelect()
    {
        if (SkillId == 1)
        {
            Combat.ScaleA = AttackS[a1].scale;
        }
        if (SkillId == 2)
        {
            Combat.ScaleA = AttackQ[a2].scale;
        }
        if (SkillId == 3)
        {
            Combat.ScaleA = Block[a3].scale;
        }
        if (SkillId == 4)
        {
            Combat.ScaleA = Dodge[a4].scale;
        }
        ScaleT.text = Combat.ScaleA.ToString();
        Combat.Calculus();
    }
    public void LevelChange(int module, bool ally)
    {
        if (ally == true)
        {
            Zone[p1].Mana += 1 * module;
        }
        if (ally == false)
        {
            Zone[p2].Mana += 1 * module;
        }

    }
    public void DisableA(bool x)
    {

        DisableO.SetActive(x);

    }
    public void Normalizator()
    {


       anime[0].Play("standar1");
        anime[1].Play("standar2");
        anime[2].Play("standar1");
        anime[3].Play("standar2");
        anime[4].Play("standar3");
        anime[5].Play("standar4");
        anime[6].Play("standar3");
        anime[7].Play("standar4");


    }
 
}
