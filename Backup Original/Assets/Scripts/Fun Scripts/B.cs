using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;


public class B : MonoBehaviourPunCallbacks
{
    public int idcard1;
    public int idcard2;
    public int idzone1;
    public int idzone2;
    public int idzone3;
    public int select;
    //Zonas próximas
    public List <int> idzone0;
    public List<B> Zone;
    public List<Image> Zonesprite;
    public Image Zonesprite0;
    public Image Zonesprite1;
    public List<Button> b;
    public A a;
    public E e;
    public E e1;
    public E e2;
    public E e3;
    public GameObject Move;
    public GameObject Cancel;
    public GameObject Study;
    public GameObject Pass;
    public int up;
    //Atributos
    public List<int> Lyoko;
    //Contadores Permanentes
    public List<int> Lyoko1;
    //Atributos Base
    public List<int> Lyoko2;
    public F f;
    public Animator anime;
    public List<GameObject> flash;

    //Variáveis de Evolução
    public int idPersonagem;
    public int lv;
    public int lv1;


    //Zonas Próximas
    public List<int> zp;
    //Ilustração
    public GameObject il;
    public Image il1;
    //Lista de Status
    //Code[5]Cannot be targeted
    //Code[7]DrainLife
    //Code[6]Pact
    //Code[8]Spear
    //Code[11]Ambush1
    public List<bool> Code;
    
    //Counter[5]=Poison
    public List<int> Counter;
    public List <GameObject> Blue;
    public O O;
    // Ally=1 Enemy=-1
    public int side;
    public Sprite nada;
    public List<I> i;
    public List <GameObject> Damage;
    public List <Text> DamageT;
    public bool Spear;
    public D d;
    //Current Mana.
    public int Mana;
    //Original Mana
    public int Mana1;
    //Permanent Mana Bonus
    public int Mana2;
    public int ManaSpend;
    public Button MovB;
    public Image MovI;
    public GameObject MovT;
    public Button FightB;
    public Image FightI;
    public GameObject FightT;
    public int sentimento;
    public List<int> Relics;
    public List <int> status;
    public List<Statos> statos;
    public bool SentimentalBool;
    public int SentimentalInt;


    //Calma 0 Medo 1 Fúria 2 Ódio 3 Compaixão 4




    // Start is called before the first frame update
    void Start()
    {


        PlayerPrefs.SetInt("A", 0);
        PlayerPrefs.SetInt("B", 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void X()
    {
        a.Eye.SetActive(false);
        idcard2 = PlayerPrefs.GetInt("A");
        idzone2 = PlayerPrefs.GetInt("B");
        idzone3 = PlayerPrefs.GetInt("C");
        

        //Se selecionar card já selecionado
        /*if (idzone2 == idzone1)
        {
            PlayerPrefs.SetInt("A", 0);
            PlayerPrefs.SetInt("B", 0);
            for (int x = 1; x < 11; x = x + 1)
            {
                if (Zone[x].idcard1 <= 0 || Zone[x].Code[2]==true)
                {
                    b[x].enabled = false;
                }
                else
                {
                    b[x].enabled = true;
                }
            }
            Study.SetActive(false);
            Cancel.SetActive(false);
            
}
        */
        //Se com seleção
        if (idzone2 != 0)
        {
            if (idzone1 == 1 || idzone1 == 2 || idzone1 == 3)
            {
 
               a.Skills[0].SetActive(true);
                a.Skills[1].SetActive(true);
               a.Skills[6].SetActive(true);
                a.Skills[7].SetActive(true);
                a.Skills[2].SetActive(false);
                a.Skills[3].SetActive(false);
                a.Skills[4].SetActive(false);
                a.Skills[5].SetActive(false);

                Blue[7].SetActive(true);
                Blue[8].SetActive(true);
                Blue[9].SetActive(true);
                Blue[10].SetActive(true);

                Blue[6].SetActive(false);
                Blue[5].SetActive(false);
                Blue[4].SetActive(false);
                Blue[3].SetActive(false);
                Blue[2].SetActive(false);
                Blue[1].SetActive(false);
                a.ib[0].enabled = true;
                //Blue[11].SetActive(true);
                a.Orientation.text = "Select Skill";
                PlayerPrefs.SetInt("A1", idcard1);


                a.F.z = idzone1;
                //a.F.card1 = idcard2;
                a.DD.SetInfo();

            }
            if (idzone1 == 4 || idzone1 == 5 || idzone1 == 6)
            {

                a.Skills[0].SetActive(true);
                a.Skills[1].SetActive(true);
                a.Skills[6].SetActive(true);
                a.Skills[7].SetActive(true);

                Blue[7].SetActive(true);
                Blue[8].SetActive(true);
                Blue[9].SetActive(true);
                Blue[10].SetActive(true);

                Blue[6].SetActive(false);
                Blue[5].SetActive(false);
                Blue[4].SetActive(false);
                Blue[3].SetActive(false);
                Blue[2].SetActive(false);
                Blue[1].SetActive(false);
                a.ib[0].enabled = true;
                Blue[11].SetActive(true);
                a.Orientation.text = "Select Skill";
                PlayerPrefs.SetInt("A", idcard1);


                a.F.y = idzone1;
                //a.F.card1 = idcard2;
                a.DD.SetInfo();

            }
            b[1].enabled = true;
            b[2].enabled = true;
            b[3].enabled = true;
            b[4].enabled = true;
            b[5].enabled = true;
            b[6].enabled = true;

            a.EnablerEye[1].raycastTarget = false;
            a.EnablerEye[2].raycastTarget = false;
            a.EnablerEye[3].raycastTarget = false;
            a.EnablerEye[4].raycastTarget = false;
            a.EnablerEye[5].raycastTarget = false;
            a.EnablerEye[6].raycastTarget = false;
        }
        //Se sem seleção
        if (idzone2 == 0)
        {
            a.Orientation.text = "Select Enemy";
           // anime.Play("a");
            //select = 1;
            //Memoriza os atributos da zona
            A0();
            //Define quais zonas podem ser selecionadas
            if (idzone1 == 4 || idzone1 == 5 || idzone1 == 6)
            {

                b[1].enabled = true;
                b[2].enabled = true;
                b[3].enabled = true;
                b[4].enabled = false;
                b[5].enabled = false;
                b[6].enabled = false;
                a.EnablerEye[1].raycastTarget = false;
                a.EnablerEye[2].raycastTarget = false;
                a.EnablerEye[3].raycastTarget = false;
                a.EnablerEye[4].raycastTarget = true;
                a.EnablerEye[5].raycastTarget = true;
                a.EnablerEye[6].raycastTarget = true;
                Blue[4].SetActive(false);
                Blue[5].SetActive(false);
                Blue[6].SetActive(false);

                a.ActiveBlue(1, true);
                a.ActiveBlue(2, true);
                a.ActiveBlue(3, true);



                PlayerPrefs.SetInt("A", idcard1);

                a.F.y = idzone1;

            }

        }
        //Se outro card tiver sido selecionado
        if (idzone2 != 0 && idzone2 != idzone1)
        {
            if (idzone3 != idzone2 && idzone3!=0)
            {
                //Zone[idzone3].anime.Play("b");
                b[idzone3].enabled = true;
                a.EnablerEye[idzone3].raycastTarget = false;
                //Blue[idzone3].SetActive(true);
                Zone[idzone3].select = 0;
            }
            PlayerPrefs.SetInt("C", idzone1);
            //anime.Play("a");
            select = 1;
            //b[idzone1].enabled = false;
            Blue[idzone1].SetActive(false);
            if (idcard1 * idcard2 >= 0)
            {

                A();
            }


            else
            {
                //Memoriza o id do aliado e do defensor
                f.y = idzone2;
                f.z = idzone1;
                f.card1 = idcard2;
                f.card2 = idcard1;

                //a.Fight.SetActive(true);
                FightB.enabled = true;
                FightT.SetActive(true);
                FightI.enabled = true;
                //Move.SetActive(false);
                MovB.enabled = false;
                MovI.enabled = false;
                MovT.SetActive(false);
                a.Cancel.SetActive(true);
                Study.SetActive(false);


                e2.idcard1 = idcard1;
                e2.idcard2 = idcard2;
                e2.idzone1 = idzone1;
                e2.idzone2 = idzone2;
                e2.Zonesprite0 = Zonesprite0;

                //coe
                if (a.offline == false)
                {
                    a.photonView.RPC("FightNetwork", RpcTarget.Others, idcard1, idcard2, idzone1, idzone2);
                }
                    

            }
            b[1].enabled = false;
            b[2].enabled = false;
            b[3].enabled = false;
            b[4].enabled = false;
            b[5].enabled = false;
            b[6].enabled = false;
            a.EnablerEye[1].raycastTarget = true;
            a.EnablerEye[2].raycastTarget = true;
            a.EnablerEye[3].raycastTarget = true;
            a.EnablerEye[4].raycastTarget = true;
            a.EnablerEye[5].raycastTarget = true;
            a.EnablerEye[6].raycastTarget = true;
            a.SetSentimento();
            a.NormalizatorAnimation();

        }

        a.AnimeFight(idzone1);


    }
   

    public void A0() {
        
        PlayerPrefs.SetInt("A", idcard1);
        PlayerPrefs.SetInt("B", idzone1);
        e.Lyoko0.Clear();

        for (int x = 0; x < Lyoko.Count; x = x + 1)
        {
            e.Lyoko0.Add(Lyoko[x]);
        }
        //coe2
        if (a.offline == false)
        {
            a.photonView.RPC("MoveNetwork0", RpcTarget.Others, idzone1, idcard1);
        }
        

    }
    public void A()
    {
        e.Lyoko1.Clear();

        for (int x = 0; x < Lyoko.Count; x = x + 1)
        {
            e.Lyoko1.Add(Lyoko[x]);
        }


        e.idcard1 = idcard1;
        e.idcard2 = idcard2;
        e.idzone1 = idzone1;
        e.idzone2 = idzone2;
        e.Zonesprite0 = Zonesprite0;

        e1.idcard1 = idcard1;
        e1.idcard2 = idcard2;
        e1.idzone1 = idzone1;
        e1.idzone2 = idzone2;
        e1.Zonesprite0 = Zonesprite0;
        if (a.offline == false)
        {
            a.photonView.RPC("MoveNetwork", RpcTarget.Others, idcard1, idcard2, idzone1, idzone2);
        }


        Study.SetActive(false);
        MovB.enabled = true;
        MovI.enabled = true;
        MovT.SetActive(true);
        //Move.SetActive(true);
        //a.Fight.SetActive(false);
        Cancel.SetActive(true);
        /*troca de id/troca de sprite
        Zone[idzone2].idcard1 = idcard1;
            Zonesprite1.sprite = Zonesprite[idzone2].sprite;

            Zonesprite[idzone2].sprite = Zonesprite0.sprite;
            Zonesprite0.sprite = Zonesprite1.sprite;
            idcard1 = idcard2;
            PlayerPrefs.SetInt("A", 0);
            PlayerPrefs.SetInt("B", 0);

            for (int x = 1; x < 11; x = x + 1)
            {
                if (Zone[x].idcard1 == 0)
                {
                    b[x].enabled = false;
                }
                else
                {
                    b[x].enabled = true;
                }
            }
        */

    }
    public void C()
    {
        if(idPersonagem==0|| idPersonagem == 1|| idPersonagem == 4)
        {
            if (idzone2 == 0)
            {
                Study.SetActive(true);
                Cancel.SetActive(true);
                e3.idzone1 = idzone1;
            }
            
        }
    }
    public void SentimentoTextBR()
    {
        string unknown;
        string calm;
        string fear;
        string rage;
        string hate;
        string compassion;
        string calm1;
        string fear1;
        string rage1;
        string hate1;
        string compassion1;
        a.SetSentimento();
        unknown = "O sentimento do humano é desconhecido, mas quando ele fica cara a cara com outro humano seus sentimentos vão despertar.";

        calm = "<color=#00B2FF>Calma</color>: O humano <i>provavelmente</i> gastará pouca mana. \n Causa: O humano acha que está ganhando essa luta, isso o acalma.";
        fear = "<color=purple>Medo</color>: O humano <i>provavelmente</i> gastará muita mana. \n Causa: O humano acha que está perdendo essa luta, isso o assusta.";

        rage = "?";
        hate = "?";
        compassion = "<color=#FF0080>Compaixão</color>: Isso é estranho.";
        calm1 = "<color=#00B2FF>Calma</color>: Seu <color=#00B2FF>bônus sentimental</color> é ativado quando você gasta pouca mana (menos de 5). \n Causa: O humano acha que está ganhando essa luta, isso o acalma.";
        fear1 = "<color=purple>Medo</color>: Seu <color=#00B2FF>bônus sentimental</color> é ativado quando você gasta muita mana (mais de 4). \n Causa: O humano acha que está perdendo essa luta, isso o assusta.";
        rage1 = "?";
        hate1 = "?";
        compassion1 = "<color=#FF0080>Compassion</color>: Você não deveria estar sentindo isso.";

        if (sentimento == -1)
        {
            a.EyeT[0].text = unknown;
            a.EyeTx[0].text = unknown;
        }
        if (sentimento == 0)
        {
            a.EyeT[0].text = calm;
            a.EyeTx[0].text = calm1;
        }
        if (sentimento == 1)
        {
            a.EyeT[0].text = fear;
            a.EyeTx[0].text = fear1;
        }
        if (sentimento == 2)
        {
            a.EyeT[0].text = rage;
            a.EyeTx[0].text = rage1;
        }
        if (sentimento == 3)
        {
            a.EyeT[0].text = hate;
            a.EyeTx[0].text = hate1;
        }
        if (sentimento == 4)
        {
            a.EyeT[0].text = compassion;
            a.EyeTx[0].text = compassion1;
        }

    }
    public void SentimentoText()
    {
        string unknown;
        string calm;
        string fear;
        string rage;
        string hate;
        string compassion;
        string calm1;
        string fear1;
        string rage1;
        string hate1;
        string compassion1;
        a.SetSentimento();
        unknown= "The human's feeling is unknown, but when he comes face to face with another human his feelings will awaken.";
        calm = "<color=#00B2FF>Calm</color>: The human will <i>probably</i> spend a small amount of mana. \n Cause: The human thinks he is winning this fight, it calms him down.";
        fear = "<color=purple>Fear</color>: The human will <i>probably</i>  spend a large amount of mana. \n Cause: The human thinks he is losing this fight, it scares him.";

        rage = "?";
        hate = "?";
        compassion = "<color=#FF0080>Compassion</color>: This is weird.";
        calm1 = "<color=#00B2FF>Calm</color> Your <color=#00B2FF>sentimental bonus</color> is activated when you spend a small amount of mana (less than 5). \n Cause: The human thinks he is winning this fight, it calms him down.";
        fear1 = "<color=purple>Fear</color>:Your <color=#00B2FF>sentimental bonus</color> is activated when you spend large amount of mana (more than 4). \n Cause: The human thinks he is losing this fight, it scares him.";
        rage1 = "?";
        hate1 = "?";
        compassion1 = "<color=#FF0080>Compassion</color>: You shouldn't be feeling this.";

        if (sentimento == -1)
        {
            a.EyeT[0].text = unknown;
            a.EyeTx[0].text = unknown;
        }
        if (sentimento == 0)
        {
            a.EyeT[0].text = calm;
            a.EyeTx[0].text = calm1;
        }
        if (sentimento == 1)
        {
            a.EyeT[0].text = fear;
            a.EyeTx[0].text = fear1;
        }
        if (sentimento == 2)
        {
            a.EyeT[0].text = rage;
            a.EyeTx[0].text = rage1;
        }
        if (sentimento == 3)
        {
            a.EyeT[0].text = hate;
            a.EyeTx[0].text = hate1;
        }
        if (sentimento == 4)
        {
            a.EyeT[0].text = compassion;
            a.EyeTx[0].text = compassion1;
        }


    }
    public void D()
    {
        int language;
        language = PlayerPrefs.GetInt("Language");
        if (language == 0)
        {
            SentimentoText();
        }
        if (language == 1)
        {
            SentimentoTextBR();
        }

        a.EyeNameLeft.text = d.Chara[a.Generic.Module(idcard1)].Name;
        a.EyeNameRight.text = d.Chara[a.Generic.Module(idcard1)].Name;
        if (idzone1==1|| idzone1 == 2 || idzone1 == 3)
        {
            if (idcard1 != 0)
            {
                il.SetActive(true);
            
            }

            if (idcard1 > 0)
            {

                //  a.EyeT[0].text = d.Chara[idcard1].Passive;
                il1.sprite = d.Chara[idcard1].sprite;
            }
            if (idcard1 < 0)
            {
                il1.sprite = d.Chara[idcard1*-1].sprite;
            }
            a.EyeT[1].text = Lyoko[0].ToString();
            a.EyeT[2].text = Lyoko[1].ToString();
            a.EyeT[3].text = Lyoko[2].ToString();
            a.EyeT[4].text = Mana.ToString();
            //a.EyeT[4].text = mov.ToString();
            //a.EyeT[5].text = act.ToString();

        }
        if (idzone1 == 4 || idzone1 == 5 || idzone1 == 6)
        {
            if (idcard1 != 0)
            {
                a.ilx.SetActive(true);
            }

            if (idcard1 > 0)
            {

                a.ilx1.sprite = d.Chara[idcard1].sprite;
            }
            if (idcard1 < 0)
            {
              //  a.EyeTx[0].text = d.Chara[idcard1 * -1].Passive;
                a.ilx1.sprite = d.Chara[idcard1*-1].sprite;
            }
            a.EyeTx[1].text = Lyoko[0].ToString();
            a.EyeTx[2].text = Lyoko[1].ToString();
            a.EyeTx[3].text = Lyoko[2].ToString();
            a.EyeTx[4].text = Mana.ToString();
            //a.EyeT[4].text = mov.ToString();
            //a.EyeT[5].text = act.ToString();
        }




    }
    public void E()
    {
        if (idzone1 == 4 || idzone1 == 5 || idzone1 == 6)
        {
            a.ilx.SetActive(false);
        }
        if (idzone1 == 1 || idzone1 == 2 || idzone1 == 3)
        {
            il.SetActive(false);
        }

    }
    public void F()
    {
        flash[0].SetActive(true);
        flash[1].SetActive(true);

    }
    public void G()
    {
;
        O.B();
    }
    public void H()
    {

        O.C();
    }
    public void I()
    {
        //Champion Death






            if (side == -1)
            {
                i[0].life -= Lyoko2[0];
                Damage[0].SetActive(true);
                DamageT[0].text = Lyoko2[0].ToString();
            }
            if (side == 1)
            {
                i[1].life -= Lyoko2[0];
                Damage[1].SetActive(true);
                DamageT[1].text = Lyoko2[0].ToString();

                //Split Strategy
                if (a.Strategy[0] == 3)
                {
                    //The strategy activates only once in the match
                    a.Strategy[0] = 0;
                    //Deals 8 damage to the enemy nexus
                    i[0].life -= 8;
                    //Ativa Q
                    a.SetEffectValue(6, 11, 8);
                    a.q.a.Add(6);
                    a.q.idzone1.Add(11);
                    a.q.Value.Add(8);
                }
            }


            idcard1 = 0;
            idPersonagem = 0;
            Zonesprite0.sprite = nada;
            Blue[idzone1].SetActive(false);
            a.MoldB[idzone1 - 1].SetActive(false);
            a.MoldR[idzone1 - 1].SetActive(false);
            b[idzone1].enabled = false;
            a.EnablerEye[idzone1].raycastTarget = true;

            a.Heart[idzone1].SetActive(false);
            side = 0;
            for (int x = 0; x < Counter.Count; x = x + 1)
            {
                Counter[x] = 0;
            }
            for (int x = 0; x < Code.Count; x = x + 1)
            {
                Code[x] = false;
            }

        

    }
    public void MoveAlly()
    {

        O.SelectAlly();
    }
    public void ActiveSkills()
    {
        O.ActiveSkills();
    }
}
