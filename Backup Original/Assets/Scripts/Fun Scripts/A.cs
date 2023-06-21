using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;

[System.Serializable]
public class A : MonoBehaviourPunCallbacks
{
    //1-Shuá
    //2-Lyoko
    //3-Akasha
    //4-Maná


    public int player1;
    public int player2;
    public Listinha decklist;
    public Listinha evolution;




    public List<Image> zone;
    public List<B> zoneid;
    public List<B> Zone;
    public List<Image> ZoneIm;
    public List<Sprite> f;
    public List<Guild> guild;
    public List<Image> iguilda;
    public List<I> i;
    public List<Button> ib;
    public List<Card> g;
    public int m;
    public List<Button> j;
    public GameObject Fight;
    public GameObject Cancel;
    public int turn;
    public int round;
    public int end;
    public int NIVEL;
    public List<GameObject> ev;
    public int x1;
    public List<GameObject> Heart;
    public List<GameObject> Mold;
    public List<Text> LifeT;
    public List<int> n;
    public List<GameObject> Bluej;
    public List<GameObject> MoldB;
    public List<GameObject> MoldR;
    public O O;
    public int DamageA;
    public int DamageE;
    public GameObject DanoA;
    public GameObject DanoE;
    public List<GameObject> Stun;
    public F F;


    public Text DamageTA;
    public Text DamageTE;
    public Round Round;
    public int k;
    public Q q;
    public Sprite Eggnivia;
    public Sprite Anivia;
    public GameObject Eye;
    public List<Text> EyeT;
    public List<int> Strategy;
    public Tutorial Tuto;
    public GameObject Tuto1;
    public K k1;
    public int Level1;

    public List<GameObject> Blue;
    public List<I> I;
    public List<Button> ZoneButton;
    public GameObject DisableO;
    public D DD;
    public List<int> Cards;
    public List<Animator> Anime;

    public List<RectTransform> Size;
    public List<RectTransform> SizeMB;
    public List<RectTransform> SizeMR;
    public static A Master;
    public E e;
    public E e1;
    public E e2;
    public int offlineint;
    public bool offline;
    public Generic Generic;
    //Test Variables
    public Text test;
    public int testint;
    public bool Atacante;
    public GameObject DisableOnline;
    public Text WaitingT;
    bool GetAttacking1;
    bool GetAttacking2;
    bool GetAttacking3;
    public CollectionF CollectionF;
    public Text DebugText;
    public List<GameObject> Skills;
    public Text Orientation;
    //Eye
    public GameObject ilz;
    public Image ilz1;
    public List<Text> EyeTZ;
    public List<GameObject> EyeIconsz;

    public GameObject ilx;
    public Image ilx1;
    public List<Text> EyeTx;
    public List<GameObject> EyeIcons;
    public List<Image> SkillsImage;
    public Text EyeNameRight;
    public Text EyeNameLeft;
    public Text EyeName;



    public List<Animator> AnimeSkills;
    public List<RectTransform> SkillsTransform;
    public List<Image> EnablerEye;
    public SetFight SetFight;
    public Dialogues Dialogues;
    public List<Animator> BunecosAnimados;
    public ControllerAnimation ControllerAnimation;
    public RelicSystem RelicSystem;
    public DeckSystem DeckSystem;
    public int FinalTurn;
    public GameObject ProtoVictory;
    public GameObject ProtoDefeat;
    public StaticData StaticData;
    public List<GameObject> ZoneObject;
    public List<GameObject> CharaObject;
    public Skin Skin;
    public GameObject GateGO;
    public Interface Interface;
    public bool X1Lixo;
    public int SkillAttack;
    public Combat Combat;
    public RelicEffects RelicEffects;
    public List<Sprite> CenarioSprite;
    public Image Cenario;
    public Image CenarioAnimado;
    public GameObject TrueDisabler;
    public Stuff Stuff;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("IntCena",2);
        Stuff.Cards = DD.Chara;
        SetCenario();
        if (StaticPlayer.Adventure == false)
        {


            //Offline/OnlineMode
            SetOnline();

            GetAttacking1 = false;
            GetAttacking2 = false;
            end = 10;
            turn = 0;
            round = 1;
            Round.A();
            for (int x = 0; x < 10; x = x + 1)
            {
                j[x].enabled = false;
            }
            PlayerPrefs.SetInt("1", 0);
            PlayerPrefs.SetInt("0", 1);
            player1 = PlayerPrefs.GetInt("0");
            player2 = PlayerPrefs.GetInt("1");
            Cards[3] = PlayerPrefs.GetInt("Card1");
            Cards[4] = PlayerPrefs.GetInt("Card2");
            Cards[5] = PlayerPrefs.GetInt("Card3");
            Cards[0] = PlayerPrefs.GetInt("Card4");
            Cards[1] = PlayerPrefs.GetInt("Card5");
            Cards[2] = PlayerPrefs.GetInt("Card6");

            if (offline == false)
            {
                photonView.RPC("DistributionRequest", RpcTarget.OthersBuffered);
            }
            else
            {
                Distribution();
            }


            iguilda[0].sprite = guild[player2].sprite;
            iguilda[1].sprite = guild[player1].sprite;
            i[0].id = guild[player2].id * -1;
            i[1].id = guild[player1].id;
            i[0].life = guild[player2].life;
            i[1].life = guild[player1].life;
            ib[0].enabled = false;
            ib[1].enabled = false;

        }
        //Adventure=true
            StaticData.Set();

            offline = true;

            SetFight.SetFighto();
            Round.A();
        
    }
    private void Awake()
    {

        Master = this;
        //PhotonNetwork.OfflineMode = offline;
    }
    [PunRPC]
    public void MoveNetwork0(int idzone1, int idcard1)
    {
        PlayerPrefs.SetInt("A", idcard1);
        PlayerPrefs.SetInt("B", idzone1);
        e.Lyoko0.Clear();
        idzone1 = Generic.MirrorConversor(idzone1);

        for (int x = 0; x < Zone[idzone1].Lyoko.Count; x = x + 1)
        {
            e.Lyoko0.Add(Zone[idzone1].Lyoko[x]);
        }
    }
    [PunRPC]
    public void MoveNetwork(int idcard1, int idcard2, int idzone1, int idzone2)
    {
        e.Lyoko1.Clear();
        idzone1 = Generic.MirrorConversor(idzone1);
        idzone2 = Generic.MirrorConversor(idzone2);
        for (int x = 0; x < Zone[idzone1].Lyoko.Count; x = x + 1)
        {
            e.Lyoko1.Add(Zone[idzone1].Lyoko[x]);
        }



        e.idcard1 = idcard1;
        e.idcard2 = idcard2;
        e.idzone1 = idzone1;
        e.idzone2 = idzone2;


        e1.idcard1 = idcard1;
        e1.idcard2 = idcard2;
        e1.idzone1 = idzone1;
        e1.idzone2 = idzone2;

    }
    [PunRPC]
    public void FightNetwork(int idcard1, int idcard2, int idzone1, int idzone2)
    {
        idzone1 = Generic.MirrorConversor(idzone1);
        idzone2 = Generic.MirrorConversor(idzone2);
        F.y = idzone1;
        F.z = idzone2;
        F.card1 = idcard2;
        F.card2 = idcard1;

        e2.idcard1 = idcard2;
        e2.idcard2 = idcard1;
        e2.idzone1 = idzone2;
        e2.idzone2 = idzone1;


    }

    [PunRPC]
    public void DistributionRequest()
    {
        //Cards[3],Cards[4],Cards[5] are the allied cards, Cards[0],Cards[1],Cards[2] are the enemy cards
        Cards[3] = PlayerPrefs.GetInt("Card1");
        Cards[4] = PlayerPrefs.GetInt("Card2");
        Cards[5] = PlayerPrefs.GetInt("Card3");
        photonView.RPC("DistributionRequest2", RpcTarget.Others, Cards[3], Cards[4], Cards[5]);
    }
    [PunRPC]
    public void DistributionRequest2(int card1, int card2, int card3)
    {
        Cards[0] = card1;
        Cards[1] = card2;
        Cards[2] = card3;
        Distribution();

    }

    [PunRPC]
    public void Attacking(bool minhapica)
    {
        
        if (minhapica == false)
        {
            test.text = "<color=red>Opponent's Turn</color>";
            Atacante = false;
            if (X1Lixo == false)
            {
                DisableO.SetActive(true);
            }

        }
        else
        {
            test.text = " <color=blue>Your Turn</color>";
            Atacante = true;
            DisableO.SetActive(false);
        }

        GetAttacking2 = true;
        GetAttacking();


    }
    public void Distribution()
    {
        if (PhotonNetwork.IsMasterClient == true)
        {
            testint = Random.Range(0, 2);
            if (testint == 0)
            {
                Attacking(true);
                photonView.RPC("Attacking", RpcTarget.Others, false);

            }
            else
            {
                Attacking(false);
                photonView.RPC("Attacking", RpcTarget.Others, true);

            }

        }



        Cards[3] = PlayerPrefs.GetInt("Card1");
        Cards[4] = PlayerPrefs.GetInt("Card2");
        Cards[5] = PlayerPrefs.GetInt("Card3");
        PlayerPrefs.SetInt("1", 0);
        PlayerPrefs.SetInt("0", 1);
        player1 = PlayerPrefs.GetInt("0");
        player2 = PlayerPrefs.GetInt("1");
        decklist.deck[0].card.Add(DD.Chara[Cards[0]]);
        decklist.deck[0].card.Add(DD.Chara[Cards[1]]);
        decklist.deck[0].card.Add(DD.Chara[Cards[2]]);
        decklist.deck[1].card.Add(DD.Chara[Cards[3]]);
        decklist.deck[1].card.Add(DD.Chara[Cards[4]]);
        decklist.deck[1].card.Add(DD.Chara[Cards[5]]);
        if (decklist.deck[player1].card.Count > 1)
        {
            for (int x = 0; x < decklist.deck[player1].card.Count; x = x + 1)
            {
                j[x + 3].enabled = true;
                MoldB[x + 3].SetActive(true);
                MoldR[x + 3].SetActive(false);
                Bluej[x + 3].SetActive(true);
                zone[x + 3].sprite = decklist.deck[player1].card[x].sprite;
                zoneid[x + 3].idcard1 = decklist.deck[player1].card[x].id;

                /*if (Atacante == false && offline == false)
                {
                    zoneid[x + 3].idcard1 *= -1;
                }
                */
                zoneid[x + 3].Lyoko[0] = decklist.deck[player1].card[x].Vida;
                zoneid[x + 3].Lyoko[1] = decklist.deck[player1].card[x].Ataque;
                zoneid[x + 3].Lyoko[2] = decklist.deck[player1].card[x].Defesa;
                zoneid[x + 3].Lyoko2.Add(decklist.deck[player1].card[x].Vida);
                zoneid[x + 3].Lyoko2.Add(decklist.deck[player1].card[x].Ataque);
                zoneid[x + 3].Lyoko2.Add(decklist.deck[player1].card[x].Defesa);
                zoneid[x + 3].idPersonagem = decklist.deck[player1].card[x].idPersonagem;


                zoneid[x + 3].Mana = decklist.deck[player1].card[x].Level;
                zoneid[x + 3].Mana1 = decklist.deck[player1].card[x].Level;

                zoneid[x + 3].Lyoko1.Add(0);
                zoneid[x + 3].Lyoko1.Add(0);
                zoneid[x + 3].Lyoko1.Add(0);
                zoneid[x + 3].side = 1;
                Heart[x + 4].SetActive(true);

                LifeT[x + 4].text = zoneid[x + 3].Lyoko[0].ToString();

            }
        }
        else
        {
            j[4].enabled = true;
            MoldB[4].SetActive(true);
            MoldR[4].SetActive(false);
            Bluej[4].SetActive(true);
            zone[4].sprite = decklist.deck[player1].card[0].sprite;
            zoneid[4].idcard1 = decklist.deck[player1].card[0].id;
            /* if (Atacante == false && offline == false)
             {
                 zoneid[4].idcard1 *= -1;
             }
            */
            zoneid[4].Lyoko[0] = decklist.deck[player1].card[0].Vida;
            zoneid[4].Lyoko[1] = decklist.deck[player1].card[0].Ataque;
            zoneid[4].Lyoko[2] = decklist.deck[player1].card[0].Defesa;
            zoneid[4].Lyoko2.Add(decklist.deck[player1].card[0].Vida);
            zoneid[4].Lyoko2.Add(decklist.deck[player1].card[0].Ataque);
            zoneid[4].Lyoko2.Add(decklist.deck[player1].card[0].Defesa);
            zoneid[4].idPersonagem = decklist.deck[player1].card[0].idPersonagem;


            zoneid[4].Mana = decklist.deck[player1].card[0].Level;
            zoneid[4].Mana1 = decklist.deck[player1].card[0].Level;

            zoneid[4].Lyoko1.Add(0);
            zoneid[4].Lyoko1.Add(0);
            zoneid[4].Lyoko1.Add(0);
            zoneid[4].side = 1;
            Heart[5].SetActive(true);

            LifeT[5].text = zoneid[4].Lyoko[0].ToString();

        }
        if (decklist.deck[player2].card.Count > 1)
        {
            for (int x = 0; x < decklist.deck[player2].card.Count; x = x + 1)
            {
                j[x].enabled = false;
                MoldB[x].SetActive(false);
                MoldR[x].SetActive(true);
                Bluej[x].SetActive(false);
                zone[x].sprite = decklist.deck[player2].card[x].sprite;
                zoneid[x].idcard1 = decklist.deck[player2].card[x].id * -1;
                zoneid[x].Lyoko[0] = decklist.deck[player2].card[x].Vida;
                zoneid[x].Lyoko[1] = decklist.deck[player2].card[x].Ataque;
                zoneid[x].Lyoko[2] = decklist.deck[player2].card[x].Defesa;
                zoneid[x].Lyoko2.Add(decklist.deck[player2].card[x].Vida);
                zoneid[x].Lyoko2.Add(decklist.deck[player2].card[x].Ataque);
                zoneid[x].Lyoko2.Add(decklist.deck[player2].card[x].Defesa);
                zoneid[x].idPersonagem = decklist.deck[player2].card[x].idPersonagem;


                zoneid[x].Mana = decklist.deck[player2].card[x].Level;
                zoneid[x].Mana1 = decklist.deck[player2].card[x].Level;

                zoneid[x].Lyoko1.Add(0);
                zoneid[x].Lyoko1.Add(0);
                zoneid[x].Lyoko1.Add(0);
                zoneid[x].side = -1;
                Heart[x + 1].SetActive(true);

                LifeT[x + 1].text = zoneid[x].Lyoko[0].ToString();
            }
            if (offline == false)
            {
                GetAttacking1 = true;
                GetAttacking();
            }
        }
        else
        {
            DebugText.text = "cu";
            j[1].enabled = false;
            MoldB[1].SetActive(false);
            MoldR[1].SetActive(true);
            Bluej[1].SetActive(false);
            zone[1].sprite = decklist.deck[player2].card[0].sprite;
            zoneid[1].idcard1 = decklist.deck[player2].card[0].id * -1;

            zoneid[1].Lyoko[0] = decklist.deck[player2].card[0].Vida;
            zoneid[1].Lyoko[1] = decklist.deck[player2].card[0].Ataque;
            zoneid[1].Lyoko[2] = decklist.deck[player2].card[0].Defesa;
            zoneid[1].Lyoko2.Add(decklist.deck[player2].card[0].Vida);
            zoneid[1].Lyoko2.Add(decklist.deck[player2].card[0].Ataque);
            zoneid[1].Lyoko2.Add(decklist.deck[player2].card[0].Defesa);
            zoneid[1].idPersonagem = decklist.deck[player2].card[0].idPersonagem;

            zoneid[1].Mana = decklist.deck[player2].card[0].Level;
            zoneid[1].Mana1 = decklist.deck[player2].card[0].Level;
            zoneid[1].Lyoko1.Add(0);
            zoneid[1].Lyoko1.Add(0);
            zoneid[1].Lyoko1.Add(0);
            zoneid[1].side = 1;
            Heart[2].SetActive(true);

            LifeT[2].text = zoneid[1].Lyoko[0].ToString();

            if (offline == false)
            {
                GetAttacking1 = true;
                GetAttacking();
            }
        }
        StartofGameEffects();
        O.a = 1;
        O.A();
    }
    [PunRPC]
    public void Debugando(string a)
    {
        Debug.Log(a);
    }
    //This void will be called twice, the second time it will make the card ids of the defending player negative.
    public void GetAttacking()
    {

        if (GetAttacking1 == true && GetAttacking2 == true && GetAttacking3 == false)
        {
            GetAttacking3 = true;
            if (Atacante == false && offline == false)
            {
                for (int x = 1; x < Zone.Count; x = x + 1)
                {
                    photonView.RPC("Debugando", RpcTarget.All, Zone[x].idcard1.ToString());
                    Zone[x].idcard1 *= -1;
                    photonView.RPC("Debugando", RpcTarget.All, Zone[x].idcard1.ToString());

                }
            }
        }

    }



    // Update is called once per frame
    void Update()
    {

    }
    public void B()
    {

        round += 1;
        turn = 0;
        DamageA = 0;
        DamageE = 0;


        k1.tutorial = 4;


        //End of round effects

        for (int x = 1; x < 11; x = x + 1)
        {
            if (Zone[x].idcard1 == 21)
            {
                Zone[x].Code[11] = true;
            }
            if (Zone[x].Code[10] == true)
            {
                Zone[x].Lyoko[0] = Zone[x].Lyoko2[0];
                Zone[x].Lyoko[1] = Zone[x].Lyoko2[1];
                Zone[x].Lyoko[2] = Zone[x].Lyoko2[2];
                Zone[x].Mana = Zone[x].Mana1;
                ZoneIm[x].sprite = Anivia;
                q.UpT[x].text = Zone[x].Lyoko2[0].ToString();
                q.Up[x].SetActive(true);
                q.UPTA[x].text = ("Life = ");
            }
            //Dano ao Nexus

            if (Zone[x].side == 1)
            {
                if (Zone[x].Lyoko[0] < Zone[x].Lyoko2[0])
                {
                    DamageA += (Zone[x].Lyoko2[0] - Zone[x].Lyoko[0]);
                }
            }
            if (Zone[x].side == -1)
            {
                if (Zone[x].Lyoko[0] < Zone[x].Lyoko2[0])
                {
                    DamageE += (Zone[x].Lyoko2[0] - Zone[x].Lyoko[0]);
                }
            }






            if (Zone[x].idcard1 != 0)
            {
                if (Zone[x].Code[0] == true)
                {
                    Zone[x].lv1 += 1;
                    Zone[x].Code[0] = false;
                }
                //Efeitos de status perdidos no fim do round
                Zone[x].Code[5] = false;
                Zone[x].Code[2] = false;

                NIVEL = Zone[x].lv + Zone[x].lv1;
                //ZoneIm[x].sprite = evolution.deck[Zone[x].idPersonagem].card[lv].sprite;

                Zone[x].Lyoko[0] = evolution.deck[Zone[x].idPersonagem].card[NIVEL].Vida + Zone[x].Lyoko1[0];

                Zone[x].Lyoko[1] = evolution.deck[Zone[x].idPersonagem].card[NIVEL].Ataque + Zone[x].Lyoko1[1];
                Zone[x].Lyoko[2] = evolution.deck[Zone[x].idPersonagem].card[NIVEL].Defesa + Zone[x].Lyoko1[2];

                //Zone[x].Level = evolution.deck[Zone[x].idPersonagem].card[NIVEL].Level;
                //Zone[x].Level1 = evolution.deck[Zone[x].idPersonagem].card[NIVEL].Level;



                //Zone[x].idcard1 = evolution.deck[Zone[x].idPersonagem].card[lv].id;
                Zone[x].lv1 = 0;
                if (Zone[x].up == 1)
                {
                    Zone[x].up = 0;
                    ev[x].SetActive(true);
                }
                Zone[x].lv = NIVEL;
            }
            Zone[x].lv1 = 0;
            //Regenerate
            if (Zone[x].idcard1 != 0)
            {
                Zone[x].Lyoko[0] = Zone[x].Lyoko1[0] + Zone[x].Lyoko2[0];
                Zone[x].Lyoko[1] = Zone[x].Lyoko1[1] + Zone[x].Lyoko2[1];
                Zone[x].Lyoko[2] = Zone[x].Lyoko1[2] + Zone[x].Lyoko2[2];
                Zone[x].Mana = Zone[x].Mana1 + Zone[x].Mana2;
                LifeT[x].text = Zone[x].Lyoko[0].ToString();
                if (Zone[x].Lyoko[1] < 0)
                {
                    Zone[x].Lyoko[1] = 0;
                }
                if (Zone[x].Lyoko[2] < 0)
                {
                    Zone[x].Lyoko[2] = 0;
                }
            }

        }

        i[0].life -= DamageE;
        i[1].life -= DamageA;
        if (DamageA > 0)
        {
            DanoA.SetActive(true);

            DamageTA.text = DamageA.ToString();
        }
        if (DamageE > 0)
        {
            DanoE.SetActive(true);
            DamageTE.text = DamageE.ToString();
        }


        //Fim do round


        for (int x = 1; x < 11; x = x + 1)
        {
            k = x;
            StartOfRoundEffects();
        }
        CounterEnd();
    }
    public void CounterEnd()
    {
        for (int x = 1; x < 11; x = x + 1)
        {
            Zone[x].Counter[2] = 0;
            Zone[x].Counter[5] = 0;
            Zone[x].Code[5] = false;
        }
    }
    public void C()
    {
        NIVEL = Zone[x1].lv + Zone[x1].lv1;
        ZoneIm[x1].sprite = evolution.deck[Zone[x1].idPersonagem].card[NIVEL].sprite;
    }
    //Efeitos no Fim do combate
    public void D()
    {
        for (int x = 0; x < n.Count; x = x + 1)
        {
            if (n[x] == 1)
            {
            }
            if (n[x] == 0)
            {

            }
            if (n[x] == 0)
            {

            }
            if (n[x] == 0)
            {

            }
            if (n[x] == 0)
            {

            }
        }

    }
    public void TurnUp()
    {
        
        turn += 1;



        StartofTurnEffects();

    }
    public void END1()
    {
        int ScoreAlly;
        int ScoreEnemy;
        ScoreAlly = Zone[4].Lyoko[0] + Zone[5].Lyoko[0] + Zone[6].Lyoko[0];
        ScoreEnemy = Zone[1].Lyoko[0] + Zone[2].Lyoko[0] + Zone[3].Lyoko[0];
        PlayerPrefs.SetInt("Batalha", 1);
        if (ScoreAlly >= ScoreEnemy)
        {
            PlayerPrefs.SetInt("Tale", DD.FightParameters[StaticData.Fight].TaleVictory);
            PlayerPrefs.SetInt("IdList", DD.FightParameters[StaticData.Fight].TaleTypeV);
        }
        else
        {
            PlayerPrefs.SetInt("Tale", DD.FightParameters[StaticData.Fight].TaleDefeat);
            PlayerPrefs.SetInt("IdList", DD.FightParameters[StaticData.Fight].TaleTypeD);
        }
        PlayerPrefs.SetInt("AllyLife", ScoreAlly);
        PlayerPrefs.SetInt("EnemyLife", ScoreEnemy);
        GateGO.SetActive(true);


    }
    public void END()
    {

        if (X1Lixo == true)
        {
            ActiveSkills();
        }
        Interface.SetStatos();

        if (FinalTurn > 0)
        {
            if (turn > FinalTurn)
            {
                END1();
            }
            else
            {


                if (Zone[5].Lyoko[0] <= 0 || Zone[2].Lyoko[0] <= 0)
                {
                  
                    END1();
                }
            }
        }

    }
    public void Victory()
    {
        SceneManager.LoadScene("Result");
    }
    public void StartofTurnEffects()
    {
        Interface.index = 0;
     
        if (Atacante == true)
        {

            Attacking(false);
        }
        else
        {

            Attacking(true);

        }
        Combat.ManaSpendA = 0;
        Combat.ManaSpendE = 0;
        Combat.ManaA = Zone[5].Mana;
        Combat.ManaE = Zone[2].Mana;

        Combat.Calculus();
        Combat.FantasyRivalsIA.TotalManaA = Combat.ManaA;
        Combat.FantasyRivalsIA.TotalManaE = Combat.ManaE;
     


    }
    //Effects Start of Game
    public void StartofGameEffects()
    {

        RelicSystem.AddRelic2();
        DeckSystem.AddCard();
        RelicEffects.StartEffectRelic();
    }
    //Start of Round Effects
    public void StartOfRoundEffects()
    {




    }
    public void ChangeControl()
    {
    
        for (int x = 1; x < Blue.Count; x = x + 1)
        {
            Blue[x].SetActive(false);
        }
        for (int x = 1; x < 11; x = x + 1)
        {

            Zone[x].idcard1 *= -1;
        }
        I[0].id *= -1;
        I[1].id *= -1;
        //....



    }
    [PunRPC]
    public void DisableMultiplayer(bool x)
    {

        DisableOnline.SetActive(x);
        if (x == true)
        {
            WaitingT.text = "Waiting opponent...";
        }
        else
        {
            if (Atacante == true)
            {

                WaitingT.text = "Your turn!";
            }
            else
            {
                WaitingT.text = "Waiting opponent...";
            }
        }
    }
    public void DisableA(bool x)
    {

        DisableO.SetActive(x);

    }
    public void ActiveBlue(int idzo, bool active)
    {
        if (Zone[idzo].idcard1 != 0)
        {
            Blue[idzo].SetActive(active);
        }

    }
    public void Recall()
    {
        if (Strategy[0] == 2)
        {
            //The strategy activates only once in the match
            Strategy[0] = 0;
            //Search all allies
            for (int x = 1; x < 11; x = x + 1)
            {
                if (Zone[x].side == 1)
                {
                    //Ally gains life without exceeding maximum life
                    Zone[x].Lyoko[0] += 2;
                    if (Zone[x].Lyoko[0] > Zone[x].Lyoko1[0] + Zone[x].Lyoko2[0])
                    {
                        Zone[x].Lyoko[0] = Zone[x].Lyoko1[0] + Zone[x].Lyoko2[0];
                    }
                    // Q
                    SetEffectValue(7, x, 2);

                }

            }
        }
    }
    public void SetEffectValue(int a, int idzone1, int Value)
    {
        q.a.Add(a);
        q.idzone1.Add(idzone1);
        q.Value.Add(Value);
    }
    public void Normalizator()
    {
        DD.Normalizator();
        if (X1Lixo == false)
        {
            for (int x = 0; x < 8; x = x + 1)
            {
                Skills[x].SetActive(false);
            }
        }


       // Anime[1].Play("Normal1");
       // Anime[2].Play("Normal2");
        //Anime[3].Play("Normal3");
        //Anime[4].Play("Normal4");
       // Anime[5].Play("Normal5");
       // Anime[6].Play("Normal6");
        //Anime[7].Play("Normal7");
        // Anime[8].Play("Normal8");
        // Anime[9].Play("Normal9");
        //Anime[10].Play("Normal10");
        //for (int x = 1; x < 11; x = x + 1)
        // {
        //     Anime[x].Play("Normal"+x);
        // }






        for (int x = 0; x < 8; x = x + 1)
        {

        }
    }
    public void SetOnline()
    {
        offlineint = PlayerPrefs.GetInt("Offline");
        if (offlineint == 1)
        {
            offline = true;
        }
        if (offlineint == 0)
        {
            offline = false;
        }
    }

    [PunRPC]
    public void OnlineDamage(int damage)
    {
        I[1].OnlineDamageB(damage);
    }
    public void EnableMove()
    {
        photonView.RPC("EnableMoveOnline", RpcTarget.Others);
    }
    [PunRPC]
    public void EnableMoveOnline()
    {
        CollectionF.DisableMove(false);
    }
    public void EnableOnline()
    {
        if (offline == false)
        {
            photonView.RPC("DisableMultiplayer", RpcTarget.Others, false);
        }
    }
    public void AnimeFight(int idz)
    {


        if (idz == 1)
        {
            BunecosAnimados[3].Play("Run3");
            Zone[idz].anime.Play("Fight1");
        }
        if (idz == 2)
        {
            BunecosAnimados[2].Play("Run2");
            Zone[idz].anime.Play("Fight2");
        }
        if (idz == 3)
        {
            BunecosAnimados[1].Play("Run1");
            Zone[idz].anime.Play("Fight3");
        }
        if (idz == 4)
        {
            BunecosAnimados[6].Play("Run6");
            Zone[idz].anime.Play("Fight4");
        }
        if (idz == 5)
        {
            BunecosAnimados[5].Play("Run5");
            Zone[idz].anime.Play("Fight5");

        }
        if (idz == 6)
        {
            BunecosAnimados[4].Play("Run4");
            Zone[idz].anime.Play("Fight6");
        }

    }
    public void NormalizatorAnimation()
    {
        AnimeSkills[0].Play("standar1");
        AnimeSkills[1].Play("standar2");
        AnimeSkills[2].Play("standar1");
        AnimeSkills[3].Play("standar2");
        AnimeSkills[4].Play("standar3");
        AnimeSkills[5].Play("standar4");
        AnimeSkills[6].Play("standar3");
        AnimeSkills[7].Play("standar4");

    }
    public void SetSentimento1(int ally, int enemy)
    {
        if (DD.Chara[Generic.Module(Zone[ally].idcard1)].SentimentoType == 0)
        {


            if (Zone[ally].Lyoko[0] + Zone[ally].Mana >= Zone[enemy].Lyoko[0] + Zone[enemy].Mana )
            {
                Zone[ally].sentimento = 0;
                //Vida alta = calma
            }


            else 
            {
                Zone[ally].sentimento = 1;
                //Vida baixa = medo
            }

            
            if (0 > 1)
            {
                //Compaixão
                Zone[F.y].sentimento = 4;

            }

        }
        if (DD.Chara[Generic.Module(Zone[ally].idcard1)].SentimentoType == 1)// Type1 = medroso
        {
            Zone[ally].sentimento = 1;
        }
        RelicEffects.ChangeFellingRelic(ally);//Muda sentimento via rrlc ou status
    }
    public void SetSentimento()
    {

        if (F.y == 0 || F.z == 0)
        {
            Zone[2].sentimento = -1;
            Zone[5].sentimento = -1;

        }
        else
        {
            SetSentimento1(F.y, F.z);
            SetSentimento1(F.z, F.y);
        }


    }
    public void ActiveSkills()
    {

        if (SkillAttack % 2 == 0)
        {
            Skills[0].SetActive(true);
            Skills[1].SetActive(true);
            Skills[6].SetActive(true);
            Skills[7].SetActive(true);

            Skills[2].SetActive(false);
            Skills[3].SetActive(false);
            Skills[4].SetActive(false);
            Skills[5].SetActive(false);

        }
        if (SkillAttack % 2 == 1)
        {
            Skills[2].SetActive(true);
            Skills[3].SetActive(true);
            Skills[4].SetActive(true);
            Skills[5].SetActive(true);


            Skills[0].SetActive(false);
            Skills[1].SetActive(false);
            Skills[6].SetActive(false);
            Skills[7].SetActive(false);
        }
        Blue[7].SetActive(true);
        Blue[8].SetActive(true);
        Blue[9].SetActive(true);
        Blue[10].SetActive(true);
        DisableO.SetActive(false);
        SkillAttack += 1;
    }
    public void SetCenario()
    {
        int a;
        a = Random.Range(0, CenarioSprite.Count);
        Cenario.sprite = CenarioSprite[a];
        CenarioAnimado.sprite = CenarioSprite[a];
    }
}
