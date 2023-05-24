using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class F : MonoBehaviour
{
    public List<B> Zone;
    //Aliado
    public int y;
    public int y0;
    //Inimigo
    public int z;
    public int z0;
    public GameObject Dark;
    //Inimigos próximos
    //public List <int> z1;


    public List<int> LifeAlly;

    public List<int> AttackAlly;

    public List<int> DefenseAlly;

    public List<int> ManaAlly;

    public List<int> LifeEnemy;

    public List<int> AttackEnemy;

    public List<int> DefenseEnemy;

    public List<int> ManaEnemy;









    //Id Efeito
    public int x1;
    public int x2;
    public int x3;
    public int x4;
    public int x5;
    public int x6;
    public int x7;
    public int x8;

    public int x10;
    public int x20;
    public int x30;
    public int x40;
    public int x50;
    public int x60;
    public int x70;
    public int x80;


    // Tipo da habilidade
    public int b1;
    public int b2;
    public int b3;
    public int b4;
    public int b5;
    public int b6;
    public int b7;
    public int b8;

    public int b10;
    public int b20;
    public int b30;
    public int b40;
    public int b50;
    public int b60;
    public int b70;
    public int b80;


    //Se inimigo for o atacante = 1
    public int Attacking;

    //Dano
    public int Damage;

    //Caos;
    public int Caos;

    //Identificador de Aliados
    public int e = 1;
    public int e1 = -1;
    public int e0;

    //Vida
    public List<int> c1;
    //Ataque
    public List<int> c2;
    //Defesa
    public List<int> c3;
    //Velocidade

    //Energia
    public List<int> c5;
    //Animações
    public List<int> c6;

    //Sprites
    public List<int> c8;
    //Aliado\Inimigo
    public List<int> c9;
    //Valor
    public List<int> c10;
    //Tipo da Carta
    public List<int> c11;
    //Alvo do Efeito
    public List<int> c12;
    public List<int> AttackId;

    public D D;
    public int k;
    public Image Eye;
    public GameObject Eye1;
    public Text Eye2;
    public List<GameObject> anime;
    public List<GameObject> anime1;
    public List<Text> AllyT;
    public List<Text> EnemyT;
    public List<Text> Value;
    public List<Text> Value1;
    public int target;
    //Temp
    public int sla;
    public List<int> al;
    //Negate
    public int Vlad;
    public int Devil;

    public GameObject i1;
    public GameObject i2;
    public List<Animator> t;
    public List<GameObject> t1;
    public List<GameObject> Stun;
    public Q q;
    public int anivia;
    public int card1;
    public int card2;
    public int card10;
    public int card20;
    public int Win;
    public int AllyWin;
    public int EnemyWin;
    public A a;
    public O o;
    public bool duelist;
    public int pact;
    public Generic Generic;


    public void SlowEffects()
    {
        //Fast Effects (Efeitos ativados após os outros)
        k = 0;

        Debug.Log("SlowEffects");

        for (int x = 0; x < 2; x = x + 1)//SlowEffects
        {
            ExChange(x);


            if (x10 == 55)// Olho por Olho
            {
                if (Zone[y0].Lyoko[0] <= 0)
                {
                    NormalDamage(30);
                }
                else
                {
                    TrueDamageAlly(30);
                }
            }
            if (x30 == 58)// Sorriso Misterioso 
            {
                if (Zone[y0].Lyoko[0] < 3)
                {
                    TrueDamage(6);
                }
            }
            if (x40 == 58)// Ataque Cruel 
            {
                //Victory Mana +4 Vitória: Se você tiver menos que 3 de vida, ganhe 8 de vida. 

                if (Win == 1)
                {
                    if (Zone[y0].Lyoko[0] < 3)
                    {
                        UpLife(8);
                    }

                }

            }
            a.RelicEffects.EndTurnEffectRelic(y0);
            Debug.Log("FY0" + "=" + y0);
            StatusEffect();
        }
    }
    public void PassiveEffects()

    {

        k = 0;



        for (int x = 0; x < 2; x = x + 1)//Fast Effects (Criado para aumentar defesa antes dos ataques acontecerem)
        {
            ExChange(x);
            a.RelicSystem.BonusSentimento(y0, z0, x);

            if (x10 == 38)//Postura Defensiva
            {

                UpAttribute(5,2,true);

            }

            if (x10 == 52)// Duelo da Amizade
            {
                if (Win == 0)
                {
                    UpAttribute(3, 2, true);
                }
            }

            if (x10 == 59)//Origem de Belmont 
            {
                //Defense = 0;

                SacrificeAttribute(Zone[y0].Lyoko[2], 2, true);

            }

            if (x10 == 60)//Som da Gratidão
            {
                // Passive Mana Attack Derrota: (Mana Regen) Regenere toda a mana que você gastou nessa habilidade. Derrota Defense +2

                if (Win == 0)
                {
                    UpAttribute(2, 2, true);
                }
               

            }

            if (x20 == 38)//Postura Defensiva
            {

                UpAttribute(5, 2, true);

            }
            if (x20 == 54)//Último Beijo
            {
                //Triple Attack, Seu ataque, defesa e vida torna-se igual a 1.

                //SacrificeDefenseFast
                SacrificeAttribute(Zone[y0].Lyoko[2] - 1, 2, true);

            }

            if (x20 == 56)//Silêncio do Guerreiro
            {
                //Se você tiver 0 mana, ganha 4 de defesa. 
                if (Zone[y0].Mana == 0)
                {
                    UpAttribute(4, 2, true);
                }
            }

            if (x20 == 58)// Compaixão de Lyoko
            {
                //Se você gastar 0 de mana, ganhe 2 de defesa. 

                //Gain Defense
                if (y0 == 5)
                {
                    if (D.Combat.ManaSpendA == 0)
                    {
                        UpAttribute(2, 2, true);
                    }

                       

                }
                else
                {

                    if (D.Combat.ManaSpendE == 0)
                    {
                        UpAttribute(2, 2, true);
                    }
                }

            }


            if (x30 == 1)//Shua Protects
            {
                if (Zone[y0].Lyoko[0] > 11)
                {
                    UpAttribute(3, 2, true);
                }


            }
            if (x30 == 28)//Orgulho de William
            {
                if (Win == 0)
                {
                    UpAttribute(1, 2, true);
                }
                


            }
            if (x30 == 38)//Postura Ofensiva
            {

                SacrificeAttribute(5, 2, true);

            }
            if (x30 == 59)// Beleza da Lua
            {
                //Victory: Mana Attack Passive Defense +2 
                UpAttribute(2, 2, true);
                //Defense+2

            }

            if (x40 == 15)//TeemoE
            {
                if (Zone[y0].Code[11] == true)
                {
                    //UpAttribute(2, 2, false);
                }
            }
            if (x40 == 19)//LeeE
            {
                if (a.round == 1)
                {
                    //UpAttribute(1, 2, false);
                }
            }
            if (x30 == 20) //FioraB
            {
                DuelistF(y0);
                if (duelist == true)
                {
                    //UpAttribute(1, 2, false);
                }
            }


            if (x40 == 38)//Postura Ofensiva
            {

                SacrificeAttribute(5, 2, true);

            }
            if (x40 == 55)//Liberdade Fútil
            {
                //Strike Sua Defesa se torna igual a 0 Vitória: Mana + 3
                SacrificeAttribute(Zone[y0].Lyoko[2],2, true);

            }
        }
    }
    public void A()

    {

        if (o.NexusE.id * o.NexusE.side < 0)
        {
            Attacking = 1;
        }
        else
        {
            Attacking = 0;
        }

        k = 0;

        //Lista de fases/ Fase 1: Efeitos que não podem ser negados/ Fase 2: Efeitos de negação/ Fase 3: Efeitos que não variam em função de um atributo/ Fase 4 Efeitos que variam em função de um atributo/

        for (int x = 0; x < 2; x = x + 1)
        {

            ExChange(x);



            //Ataques Fortes Ally
            if (x10 == 1)//Shuá Sofre
            {


                if (Zone[y0].Lyoko[0] > 15)
                {
                    TrueDamage(10);
                }


            }
            if (x10 == 2)//Tese Akashica
            {


                if (Win == 1)
                {
                    //Se jogador tiver sabedoria (status=1), golpe triplo, else: Golpe duplo.
                    if (Generic.HaveInt(Zone[y0].status, 1))
                    {
                        TripleAttack();
                    }
                    else
                    {
                        DoubleAttack();
                    }

                }


            }
            if (x10 == 3)//Doutrina de Lyoko
            {



                if (Win == 1)
                {
                    //Se jogador tiver coragem (status=2), golpe duplo, else: Golpe.
                    if (Generic.HaveInt(Zone[y0].status, 2))
                    {
                        DoubleAttack();
                    }
                    else
                    {
                        Attack();
                    }
                    //if 0 mana, mana+=4
                    ForceofWill(4);

                }


            }

            if (x10 == 4)//Liberar Maná
            {


                if (Win == 1)
                {
                    if (Zone[y0].SentimentalBool == true && Generic.HaveInt(Zone[y0].status, 3))
                    {
                        TripleAttack();
                    }
                    else if (Zone[y0].SentimentalBool == true)
                    {
                        DoubleAttack();
                    }
                    else
                    {
                        Attack();
                    }
                }


            }
            if (x10 == 5)
            {

            }
            if (x10 == 6)
            {


            }
            if (x10 == 7)
            {



            }
            if (x10 == 8)
            {



            }
            if (x10 == 9)
            {


            }
            if (x10 == 10)//Um Fim (Bardo)
            {

                if (Win == 1)
                {
                    TripleAttack();
                }
                

            }
            if (x10 == 11)
            {




            }
            if (x10 == 12)//Jiri
            {
                if (Win == 1)
                {
                    TrueDamage(10);
                }
            }
            if (x10 == 13)//Brad
            {
                if (Win == 1)
                {
                    Attack();
                }
            }
            if (x10 == 14)//Noji
            {
                UpAttribute(4, 1, true);
                if (Win == 1)
                {
                    Attack();
                }
            }
            if (x10 == 15)//Varys
            {
                if (Win == 0)
                {
                    UpAttribute(-4, 1, true);
                }
                if (Win == 1)
                {
                    Attack();
                }
            }
            if (x10 == 16)//Mirio
            {
                if (Win == 1)
                {
                    TripleAttack();
                }
            }
            if (x10 == 17)//Klaus
            {
                Attack();
            }
            if (x10 == 18)
            {

            }

            if (x10 == 21)
            {
                if (Win == 1)
                {

                    Attack();
                    AddStatus(0, -1);
                }

            }

            //LoL
            if (x10 == 22)//TeemoAF
            {

                if (Win == 1)
                {
                    Attack();
                    Zone[z0].Counter[5] += 1;
                }



            }
            if (x10 == 23)//AniviaAF
            {

                {
                    if (Win == 1)
                    {


                        for (int w = 1; w < Zone.Count; w = w + 1)
                        {

                            if (Zone[w].idcard1 * card10 /* * e0 */ < 0)
                            {
                                a.SetEffectValue(0, w, 2);

                                Zone[w].Code[4] = true;

                                a.SetEffectValue(4, w, 1);
                            }
                        }



                    }
                }
            }
            if (x10 == 24)//KalistaAF
            {


                if (Win == 1)
                {
                    Attack();
                    DamageAttribute(1, 2, true);
                }



            }

            if (x10 == 25)//VladAF
            {

                if (Win == 1)
                {
                    if (Zone[y0].Counter[2] == 0)
                    {
                        Zone[y0].Counter[2] += 1;
                    }


                }



            }
            if (x10 == 26)//LeeAF
            {


                if (Win == 1)
                {
                    Attack();
                    Attack();
                }



            }
            if (x10 == 27)//Fim da Fome
            {

                if (Win == 1)
                {
                    TrueDamage(6);
                }





            }
            if (x10 == 28)//Fúria de William
            {
                if (Win == 1)
                {
                    DoubleAttack();
                }

            }
            if (x10 == 30)//Durma Bem, Bobo
            {
                if (Win == 1)
                {
                    TrueDamage(678);
                }

            }

            if (x10 == 31)//Ataque Fraco
            {
                if (Win == 1)
                {
                    TripleAttack();
                }

            }

            if (x10 == 32)//Sabedoria dos Tolos
            {
                
                if (Zone[y0].Mana< Zone[z0].Mana)
                {
                    UpAttribute(3, 1, true);
                    UpMana(3);
                }
                if (Win == 1)
                {
                    Attack();
                }

            }

            if (x10 == 36)//Calma Selvagem
            {
                UpLife(2);

                if (Win == 1)
                {
                    Attack();
                    if (Zone[y0].Lyoko[0] > 10)
                    {
                        Attack();
                    }
                }

            }
            if (x10 == 37)//Punição
            {

                if (Win == 0)
                {
                    TrueDamage(6);
                }

            }
            if (x10 == 38)//Postura Defensiva
            {

                if (Win == 1)
                {
                    TrueDamage(6);
                }

            }
            if (x10 == 39)//Iniciativa Poderosa
            {

                if (Win == 1)
                {
                    TripleAttack();
                }
                if (Win ==0)
                {
                    SacrificeAttribute(1, 1, true);
                }

            }
            if (x10 == 41)//Fúria Selvagem
            {

                TrueDamageAlly(2);

                if (Win == 1)
                {
                    Attack();
                    if (Zone[y0].Lyoko[0] < 10)
                    {
                        Attack();
                    }
                }

            }
            if (x10 == 42)//Tolice dos Sábios
            {

                if (Zone[y0].Mana > Zone[z0].Mana)
                {
                    UpAttribute(2, 1, true);
                    UpMana(2);
                }
                if (Win == 1)
                {
                    Attack();
                }

            }












            if (x10 == 50)//Pacifismo
            {
                // Pacifismo
                AddStatus(5, 1);

            }
            if (x10 == 51)//Oração Redentora
            {
                if (Win == 1)
                {
                    TrueDamageAlly(5);
                }
                UpAttribute(5, 0, true);

            }
            if (x10 == 52)//Duelo da Amizade
            {
                // Altruísmo 4, derrota: Defesa +3.

                //Defense+3
                Altruism(4);

            }

            if (x10 == 53)//Estética da Vontade
            {
                //Derrota: Você ganha 3 de vida para cada mana que gastar. 
                if (Win == 0)
                {
                    if (y0 == 5)
                    {
                    
                            UpAttribute(D.Combat.ManaSpendA*3, 0, true);
                        
                    }
                    else
                    {

                        UpAttribute(D.Combat.ManaSpendE * 3, 0, true);
                    }
                }


            }
            if (x10 == 54)//Justiçs Engraçada
            {

                //Passive: O oponente ganha 5 de defesa. True Damage 8. 
                UpOppAttribute(5, 2);
                if (Win == 1)
                {
                    TrueDamage(8);
                }
                

            }
            if (x10 == 55)//Olho por Olho
            {

                //Mana Sacrifice Passive: Life + 8. Se você tiver 0 de vida ou menos, cause 30 de dano no oponente. Caso contrário receba 30 de dano 

                ManaSacrifice();
                UpAttribute(8, 0, true);
               //Verifica vida no Slow Effects
               
            }
            if (x10 == 56)//Bem sobre o Mal
            {

                //Triple Attack, Defeat Sacrifice 20.
                if (Win == 1)
                {
                    TripleAttack();
                }
                if (Win == 0)
                {
                    TrueDamageAlly(20);
                }


            }
            if (x10 == 57)//ArgumentoRuim
            {
                //Sacrifice 4 Triple Strike. 


                TrueDamageAlly(4);
                if (Win == 1)
                {
                    TripleAttack();
                }


            }
            if (x10 == 58)//Heroísmo
            {
                //No fim de cada turno, cause 5 de dano se você tiver menos mana que seu oponente. 
                if (Win == 1)
                {
                    AddStatus(6, 1);
                }
              
                //heroísmo


            }
            if (x10 == 59)//Origem de Belmont 
            {
                // Strike. Mana + 2 Passive Defense= 0

                //-Defense
                if (Win == 1)
                {
                    UpMana(2);
                    Attack();
                }


            }
            if (x10 == 60)//Som da Gratidão
            {
                // Passive Mana Attack Derrota: (Mana Regen) Regenere toda a mana que você gastou nessa habilidade. Derrota Defense +2

                //Defense+2
                if (y0 == 5)
                {
                    NormalDamage(D.Combat.ManaSpendA);
                }
                else
                {
                    NormalDamage(D.Combat.ManaSpendE);
                }
                if (Win == 0)
                {
                    ManaRecover();
                }


            }
            if (x10 == 61)//Completude Real
            {
                // Mana sacrifice. Strike. Vitória: Recupere uma quantidade de mana igual a que você gastou(Mana recover)


                ManaSacrifice();
                ManaRecover();

                if (Win == 1)
                {
                    Attack();
                }


            }


          






            //Ataques Rápidos Ally

            if (x20 == 1)//Shua Bless
            {

                Altruism(4);
                if (Win == 1)
                {
                    UpLife(4);
                }

            }
            if (x20 == 2)//Estudo Akashico
            {
                AddStatus(1, 1);
                if (Win == 1)
                {
                    UpAttribute(2, 1, true);
                    Attack();

                }


            }
            if (x20 == 3)//Virtude de Lyoko
            {
                if (Win == 1)
                {
                    AddStatus(3, 1);
                }
                NormalDamage(4);

            }

            if (x20 == 4)//Elevar o Maná
            {

                if (Win == 1)
                {
                    AddStatus(3, 1);
                }
                UpAttribute(2, 1, true);
            }
            if (x20 == 5)
            {

            }
            if (x20 == 6)
            {



            }

            if (x20 == 7)
            {



            }
            if (x20 == 8)
            {




            }
            if (x20 == 10)//Pior do que a morte
            {

                if (Win == 1)
                {
                    TrueDamage(9);
                }
            }

            if (x20 == 12)//Jiri
            {

                if (Win == 1)
                {
                    TrueDamage(10);
                }


            }
            if (x20 == 13)//Brad
            {

                if (Win == 1)
                {
                    Attack();
                }


            }
            if (x20 == 14)//Noji
            {
                UpAttribute(4, 1, true);
                if (Win == 1)
                {
                    Attack();
                }


            }
            if (x20 == 15)//Varys
            {
                if (Win == 0)
                {
                    UpAttribute(-4, 1, true);
                }
                if (Win == 1)
                {
                    Attack();
                }


            }
            if (x20 == 16)//Mirio
            {

                if (Win == 1)
                {
                    TripleAttack();
                }


            }


            if (x20 == 17)//Klaus
            {
                Attack();


            }
            if (x20 == 18)
            {


            }
            if (x20 == 19)//TeemoAF
            {


                if (Win == 1)
                {

                    Attack();
                    DamageAttribute(1, 1, false);
                }


            }
            if (x20 == 20)//Anivia AF
            {
                if (Win == 1)
                {

                    if (Zone[z0].Mana == 0)
                    {
                        NormalDamage((Zone[y0].Lyoko[1] - Zone[z0].Lyoko[2]) * 2);
                    }
                    else
                    {
                        Attack();
                    }


                }

            }
            if (x20 == 21)//KalistaAR
            {

                {
                    if (Win == 1)
                    {
                        if (Zone[y0].Mana == 0)
                        {
                            NormalDamage(10);
                        }
                        else
                        {
                            NormalDamage(8);
                        }


                    }
                }
            }
            if (x20 == 22)//VladAR
            {


                if (Win == 1)
                {

                    Attack();
                    UpAttribute(2, 1, true);

                }

            }
            if (x20 == 23)//LeeAR
            {
                if (Win == 1)
                {


                    if (Zone[y0].side == 1)
                    {

                        a.SetEffectValue(8, 11, Zone[y0].Lyoko[1]);

                    }

                    if (Zone[y0].side == -1)
                    {

                        a.SetEffectValue(9, 12, Zone[y0].Lyoko[1]);


                    }
                    Attack();

                }

            }
            if (x20 == 27)//Ganância de Roy
            {

                if (Win == 1)
                {
                    DoubleAttack();
                }

            }
            if (x20 == 28)//Determinação de William
            {


                if (Win == 1)
                {
                    TrueDamage(7);
                }




            }
            if (x20 == 30)//Durma Bem, Bobo
            {
                if (Win == 1)
                {
                    TrueDamage(678);
                }

            }


            if (x20 == 31)//Ataque Fraco
            {
                if (Win == 1)
                {
                    TripleAttack();
                }

            }
            if (x20 == 32)//Sabedoria dos Tolos
            {

                if (Zone[y0].Mana < Zone[z0].Mana)
                {
                    UpAttribute(3, 1, true);
                    UpMana(3);
                }
                if (Win == 1)
                {
                    Attack();
                }

            }
            if (x20 == 36)//Calma Selvagem
            {
                UpLife(2);

                if (Win == 1)
                {
                    Attack();
                    if (Zone[y0].Lyoko[0] > 10)
                    {
                        Attack();
                    }
                }

            }
            if (x20 == 37)//Punição
            {

                if (Win == 0)
                {
                    TrueDamage(6);
                }

            }
            if (x20 == 38)//Postura Defensiva
            {

                if (Win == 1)
                {
                    TrueDamage(6);
                }

            }
            if (x20 == 39)//Iniciativa Poderosa
            {

                if (Win == 1)
                {
                    TripleAttack();
                }
                if (Win == 0)
                {
                    SacrificeAttribute(1, 1, true);
                }

            }
            if (x20 == 41)//Fúria Selvagem
            {

                TrueDamageAlly(2);

                if (Win == 1)
                {
                    Attack();
                    if (Zone[y0].Lyoko[0] < 10)
                    {
                        Attack();
                    }
                }

            }
            if (x20 == 42)//Tolice dos Sábios
            {

                if (Zone[y0].Mana > Zone[z0].Mana)
                {
                    UpAttribute(2, 1, true);
                    UpMana(2);
                }
                if (Win == 1)
                {
                    Attack();
                }

            }



            if (x20 == 50)//Lágrima de um Pai
            {
                //Altruísmo 3, Se você tiver menos que 10 de vida, ganha vida igual a metade da vida do seu oponente. 

                Altruism(3);
                if (Zone[y0].Lyoko[0] < 10)
                {
                    UpAttribute((Zone[z0].Lyoko[0]/2), 0, true);
                }


            }
            if (x20 == 51)// Last Desire
            {
                //Vitória: Se a vida do oponente for maior que 15 o ataque do seu oponente e o seu tornam-se iguais a 0.

                if (Zone[z0].Lyoko[0] > 15)
                {
                    SacrificeAttribute(Zone[y0].Lyoko[1], 1, true);
                    DamageAttribute(Zone[z0].Lyoko[1], 1, true);
                }


            }
            if (x20 == 52)//Conselho Engraçado
            {
                //Vitória Altruísmo 3: Se você tiver 15 de vida ou mais, ganhe 3 mana.

                if (Win == 1)
                {
                    Altruism(3);
                }

                if (Zone[y0].Lyoko[0] >= 15)
                {
                    UpMana(3);
                }


            }
            if (x20 == 53)//Adubo Patriótico
            {
                // Passive: O oponente ganha 5 de ataque. Double Strike.

                UpOppAttribute(5, 1);

                if (Win == 1)
                {
                    DoubleAttack();
                }

            }
            if (x20 == 54)//Último Beijo
            {
                //Triple Attack, Seu ataque, defesa e vida torna-se igual a 1.
               


                if (Win == 1)
                {
                   TripleAttack();
                }
                TrueDamageAlly(Zone[y0].Lyoko[0] - 1);
                SacrificeAttribute(Zone[y0].Lyoko[1] - 1, 1, true);
                //SacrificeDefenseFast
  
            }
            if (x20 == 55)//Last Attack
            {
                //Double Strike Seu ataque torna-se igual a 0. 



                if (Win == 1)
                {
                    DoubleAttack();
                }
                SacrificeAttribute(Zone[y0].Lyoko[1], 1, true);

            }
            if (x20 == 56)//Silêncio do Guerreiro
            {
                //Se você tiver 0 mana, ganha 4 de defesa. 


            }
            if (x20 == 57)// Lei Acima de Tudo
            {
                //Strike, Se você tiver 0 mana, ganha 5 de Mana.
                if (Win == 1)
                {
                    Attack();
                }
                if (Zone[y0].Mana == 0)
                {
                    UpMana(5);
                }

            }
            //xxxxxxxxxxxxxxxxxxxxxxxx

            if (x20 == 58)// Compaixão de Lyoko
            {
                //Se você gastar 0 de mana, ganhe 2 de defesa. 

                //Gain Defense

            }
       
            if (x20 == 59)//  Confiança Tola 
            {
                //Strike Mana+5 Passive Life = 1
                if (Win == 1)
                {
                    Attack();
                    UpMana(5);
                }
                TrueDamageAlly(Zone[y0].Lyoko[0]-1);


            }
            if (x20 == 60)// Vento Frio
            {
                //Causa dano igual a diferença de mana entre você e seu oponente.

                NormalDamage(Generic.Module(Zone[y0].Mana- Zone[z0].Mana));

            }
            if (x20 == 61)// Compaixão de Mana
            {
                //Se você gastar 0 de mana, ganha 3 de mana.

                if (y0 == 5)
                {
                    if (D.Combat.ManaSpendA == 0)
                    {
                        UpMana(3);
                    }



                }
                else
                {

                    if (D.Combat.ManaSpendE == 0)
                    {
                        UpMana(3);
                    }
                }
            }



            //Bloqueios Ally

            if (x30 == 1)//Shuá Protege
            {
                if (Win == 1)
                {
                    Altruism(4);
                }

            }
            if (x30 == 2)//Ceticismo Akashico
            {

                if (Win == 1)
                {
                    AddStatus(1, 1);
                    UpAttribute(2, 2, true);
                    TrueDamage(5);
                }


            }

            if (x30 == 3)//Direito de Lyoko
            {

                if (Win == 1)
                {
                    AddStatus(2, 1);
                }
                ForceofWill(4);
            }

            if (x30 == 4)//Controlar o Mana
            {
                AddStatus(3, 1);
                if (Win == 1)
                {
                    UpAttribute(2, 2, true);
                }

            }
            if (x30 == 5)
            {

            }
            if (x30 == 10)//Você é patético
            {
                if (Win == 0)
                {
                    UpAttribute(6, 0, true);
                }
            }

            if (x30 == 12)//Jiri
            {
                if (Win == 0)
                {
                    TrueDamage(2);
                }
            }
            if (x30 == 13)//Brad
            {
                if (Win == 1)
                {
                    TrueDamage(10);
                }
            }
            if (x30 == 14)//Noji
            {
                UpAttribute(4, 1, true);
                if (Win == 1)
                {
                    Attack();
                }
            }

            if (x30 == 15)//Varys
            {
                if (Win == 0)
                {
                    UpAttribute(-4, 1, true);
                }
                if (Win == 1)
                {
                    Attack();
                }
            }

            if (x30 == 16)
            {
                if (Win == 1)//Mirio
                {
                    TripleAttack();
                }
            }

            if (x30 == 17)//Klaus
            {
                Attack();
            }
            if (x30 == 18)//KalistaB
            {

                if (Win == 1)
                {
                    for (int w = 1; w < Zone.Count; w = w + 1)
                    {
                        if (Zone[w].Code[6] == true && (Zone[y0].side * Zone[w].side > 0))
                        {
                            NormalDamage(Zone[w].Lyoko[1]);
                        }

                    }

                }


            }

            if (x30 == 19)//LeeB
            {

                Zone[y0].Code[7] = true;


            }

            if (x30 == 20)//Fiora
            {


                if (Win == 1)
                {

                    TrueDamage(1);
                    if (Zone[y0].Mana == 0)
                    {
                        DamageMana(3);
                    }
                    else
                    {
                        DamageMana(1);
                    }
                }




            }
            if (x30 == 22)//VladB
            {
                if (Win == 1)
                {
                    TrueDamage(1);
                }
            }
            if (x30 == 27)//Por Favor Não me Mate
            {
                //Nada
            }
            if (x30 == 28)//Orgulho de William
            {
                //Aumenta Defesa (Fast Effect)
            }
            if (x30 == 30)//Durma Bem, Bobo
            {
                if (Win == 1)
                {
                    TrueDamage(678);
                }

            }


            if (x30 == 31)//Ataque Fraco
            {
                if (Win == 1)
                {
                    TripleAttack();
                }

            }
            if (x30 == 32)//Sabedoria dos Tolos
            {

                if (Zone[y0].Mana < Zone[z0].Mana)
                {
                    UpAttribute(3, 1, true);
                    UpMana(3);
                }
                if (Win == 1)
                {
                    Attack();
                }

            }
            if (x30 == 36)//Calma Selvagem
            {
                UpLife(2);

                if (Win == 1)
                {
                    Attack();
                    if (Zone[y0].Lyoko[0] > 10)
                    {
                        Attack();
                    }
                }

            }
            if (x30 == 37)//Punição
            {

                if (Win == 0)
                {
                    TrueDamage(6);
                }

            }
            if (x30 == 38)//Postura Ofensiva
            {

                if (Win == 1)
                {
                    TrueDamage(8);
                }

            }
            if (x30 == 39)//Iniciativa Poderosa
            {

                if (Win == 1)
                {
                    TripleAttack();
                }
                if (Win == 0)
                {
                    SacrificeAttribute(1, 1, true);
                }

            }
            if (x30 == 41)//Fúria Selvagem
            {

                TrueDamageAlly(2);

                if (Win == 1)
                {
                    Attack();
                    if (Zone[y0].Lyoko[0] < 10)
                    {
                        Attack();
                    }
                }

            }
            if (x30 == 42)//Tolice dos Sábios
            {

                if (Zone[y0].Mana > Zone[z0].Mana)
                {
                    UpAttribute(2, 1, true);
                    UpMana(2);
                }
                if (Win == 1)
                {
                    Attack();
                }

            }





            if (x30 == 50)//Compaixão de Shuá
            {
                //y0==5 significa que é aliado, verifica mana aliado, se igual a 0 ativa efeito
                if (y0 == 5)
                {
                    if (D.Combat.ManaSpendA == 0)
                    {
                        UpAttribute(5, 0, true);
                    }
                }
                else
                {
                    if (D.Combat.ManaSpendE == 0)
                    {
                        UpAttribute(5, 0, true);
                    }
                }
            }
    
            if (x30 == 51)// História de ninar
            {
                //Compaixão: Dobra sua vida se gastar pelo menos 10 de mana.
                AddStatus(7, 1);
                if (y0 == 5)
                {
                    if (D.Combat.ManaSpendA >= 10)
                    {
                        UpLife(Zone[y0].Lyoko[0]);
                    }
                }
                if (y0 == 2)
                {
                    if (D.Combat.ManaSpendE >= 10)
                    {
                        UpLife(Zone[y0].Lyoko[0]);
                    }
                }
                //Status

            }
            if (x30 == 52)// Lágrima de um Filho
            {
                //Vitória: O oponente ganha 4 de ataque, defesa e vida: Vitória: Ganhe 12 de vida. 
                if (Win == 1)
                {
                    UpOppAttribute(4, 1);
                    UpOppAttribute(4, 2);
                    UpOppAttribute(4, 0);
                    UpLife(12);
                }

            }
            if (x30 == 53)// Lei da Força 
            {
                //Defeat: Mana Regen Mana Regen .  
                if (Win == 0)
                {
                    ManaRecover();
                    ManaRecover();
                }

            }
            if (x30 == 54)// Troca Animal 
            {
                // Passive: Troque o seu ataque e defesa com o ataque e defesa do seu oponente. Double Strike. 
                SwampAttributes();
                if (Win == 1)
                {
                    DoubleAttack();
                }
              
            }
            if (x30 == 55)// Muro Cruel
            {
                if (Win == 1)
                {
                    TrueDamage(8);
                    UpMana(3);
                }
                SacrificeAttribute(Zone[y0].Lyoko[1], 1, true);
                //True Damage 6, Mana +3 Passive Attack= 0.


            }
            if (x30 == 56)// Vida pela Nação 
            {
                if (Win == 1)
                {
                    NormalDamage(Generic.Module(Zone[y0].Lyoko[0] - Zone[z0].Lyoko[0]));
                }
               
                //Causa dano igual a diferença de vida entre você e seu oponente.


            }
            if (x30 == 57)// Surra Misteriosa
            {
                //Sacrifice 4 True Damage 10 . 
                TrueDamageAlly(4);
                if (Win == 1)
                {
                    TrueDamage(10);
                }
                

            }
            if (x30 == 58)// Sorriso Misterioso 
            {
                if (Win == 1)
                {
                    UpMana(4);
                }
               //SlowDamage 6;

                //Victory Mana +4 Vitória: Se você tiver menos que 3 de vida, Cause 6 de dano verdadeiro. 


            }


            if (x30 == 59)// Beleza da Lua
            {
                //Victory: Mana Attack Passive Defense +2 
                if (Win == 1)
                {
                    if (y0 == 5)
                    {
                        NormalDamage(D.Combat.ManaSpendA);
                    }
                    else
                    {
                        NormalDamage(D.Combat.ManaSpendE);
                    }
                    
                   
                }
                //Defense+2

            }
            if (x30 == 60)//  Idioma Nobre
            {
                //Obliterar 10. Cause dano verdadeiro no oponente se você tiver o dobro do poder dele. Mana Sacrifice. Mana Regen
                if (Win == 1)
                {
                    Obliterar(10);


                }
                ManaSacrifice();
                ManaRecover();
            }
            if (x30 == 61)// Limite da mana
            {
                //Regenere vida igual a quantidade de mana gasta     Obliterar 10


                if (Win == 1)
                {
                    Obliterar(10);


                }
                if (y0 == 5)
                {
                    UpLife(D.Combat.ManaSpendA);
                }
                else
                {
                    UpLife(D.Combat.ManaSpendE);
                }
            }




            //Esquivas Ally
            if (x40 == 1)//Shuá Chora
            {

                if (Zone[z0].Lyoko[0] > 20)
                {
                    NormalDamage(100);
                }
                TrueDamageAlly(3);



            }
            if (x40 == 2)//Refutação Akashica
            {

                if (Generic.HaveInt(Zone[y0].status, 1))
                {
                    TrueDamage(Zone[y0].Lyoko[2]);
                }
                if (Win == 1)
                {
                    Attack();
                }

            }
            if (x40 == 3)//Lei de Lyoko
            {

                if (Generic.HaveInt(Zone[y0].status, 2))
                {
                    UpLife(a.Combat.ManaSpendA);
                }
                if (Win == 1)
                {
                    Attack();
                }

            }
            if (x40 == 4)//Transformar o Mana
            {

                if (Win == 1)
                {
                    UpLife(Zone[y0].SentimentalInt * 4);
                }

            }
            if (x40 == 5)
            {



            }
            if (x40 == 10)//Você é patético
            {
                if (Win == 0)
                {
                    UpAttribute(6, 0, true);
                }
            }
            if (x40 == 11)
            {


            }

            if (x40 == 12)//Jiri
            {

                if (Win == 0)
                {
                    TrueDamage(2);
                }
            }
            if (x40 == 13)//Brad
            {

                if (Win == 1)
                {
                    TrueDamage(10);
                }
            }
            if (x40 == 14)//Noji
            {
                UpAttribute(4, 1, true);
                if (Win == 1)
                {
                    Attack();
                }

            }
            if (x40 == 15)
            {
                if (Win == 0)
                {
                    UpAttribute(-4, 1, true);
                }
                if (Win == 1)
                {
                    Attack();
                }

            }
            if (x40 == 16)//Mirio
            {

                if (Win == 1)
                {
                    TripleAttack();
                }

            }
            if (x40 == 17)//Klaus
            {
                Attack();


            }

            if (x40 == 18)
            {



            }

            if (x40 == 19)
            {





            }
            if (x40 == 20)
            {




            }

            if (x40 == 28)//Vingança de William
            {
                //Conquista Steam -->if opponent bardo Conquista: Use a vingança de William Contra o Bardo. Ativa efeito extra Attack +4 if win

                if (Win == 1)
                {
                    TripleAttack();
                }

            }
            if (x40 == 30)//Durma Bem, Bobo
            {
                if (Win == 1)
                {
                    TrueDamage(678);
                }

            }



            if (x40 == 31)//Ataque Fraco
            {
                if (Win == 1)
                {
                    TripleAttack();
                }

            }


            if (x40 == 32)//Sabedoria dos Tolos
            {

                if (Zone[y0].Mana < Zone[z0].Mana)
                {
                    UpAttribute(3, 1, true);
                    UpMana(3);
                }
                if (Win == 1)
                {
                    Attack();
                }

            }
            if (x40 == 36)//Calma Selvagem
            {
                UpLife(2);

                if (Win == 1)
                {
                    Attack();
                    if (Zone[y0].Lyoko[0] > 10)
                    {
                        Attack();
                    }
                }

            }
            if (x40 == 37)//Punição
            {

                if (Win == 0)
                {
                    TrueDamage(6);
                }

            }
            if (x40 == 38)//Postura Ofensiva
            {

                if (Win == 1)
                {
                    TrueDamage(8);
                }

            }
            if (x40 == 39)//Iniciativa Poderosa
            {

                if (Win == 1)
                {
                    TripleAttack();
                }
                if (Win == 0)
                {
                    SacrificeAttribute(1, 1, true);
                }

            }
            if (x40 == 41)//Fúria Selvagem
            {

                TrueDamageAlly(2);

                if (Win == 1)
                {
                    Attack();
                    if (Zone[y0].Lyoko[0] < 10)
                    {
                        Attack();
                    }
                }

            }

            if (x10 == 42)//Tolice dos Sábios
            {

                if (Zone[y0].Mana > Zone[z0].Mana)
                {
                    UpAttribute(2, 1, true);
                    UpMana(2);
                }
                if (Win == 1)
                {
                    Attack();
                }

            }

            if (x40 == 50)// Pergunta Triste
            {
                //Compaixão. Vitória, ganha vida igual ao dobro do seu ataque. Seu ataque torna-se igual a 0. 
                //Status
                AddStatus(7, 1);
                if (Win == 1)
                {
                    UpLife(Zone[y0].Lyoko[1] * 2);
                }
              
                SacrificeAttribute(Zone[y0].Lyoko[1],1,true);
            }
            if (x40 == 51)// Fazenda Solitária
            {
                // Ganha vida igual a metade da sua vida mais a vida do seu oponente (Max 12). 
                if (Win == 1)
                {
                    if((Zone[y0].Lyoko[0] + Zone[z0].Lyoko[0]) / 2 > 12)
                    {
                        UpLife(12);
                    }
                    else
                    {
                        UpLife((Zone[y0].Lyoko[0] + Zone[z0].Lyoko[0]) / 2);
                    }
                    
                }
                

            }
            if (x40 == 52)//  Amor Shuano 
            {
                //Vitória Se você tiver 15 de vida ou mais, ganhe vida igual a metade da vida do oponente
                if (Zone[y0].Lyoko[0] >= 15)
                {
                    UpLife(Zone[z0].Lyoko[0] / 2);
                }

            }
            if (x40 == 53)// Troca Racional
            {
                //Passive: Troque o seu ataque e defesa com o ataque e defesa do seu oponente. Strike.
                SwampAttributes();
                if (Win == 1)
                {
                    Attack();
                }
           

            }
            if (x40 == 54)// Compaixão de Akasha
            {
                //Se você gastar 0 de mana ganhe nada.
                

            }
            if (x40 == 55)//Liberdade Fútil
            {
                //Strike Sua Defesa se torna igual a 0 Vitória: Mana + 3
                if (Win == 1)
                {
                    Attack();
                    UpMana(3);
                }
                
            }
            if (x40 == 56)// Sacrifício de Lyoko
            {
                //Passive: Sacrifice 4, Attack+3, Defense+2, Mana+1.
                TrueDamageAlly(4);
                UpAttribute(3, 1, true);
                UpAttribute(2, 2, true);
                UpMana(1);

            }
            if (x40 == 57)//Liberdade de Lyoko 
            {
                //Causa dano verdadeiro igual ao seu ataque + sua defesa.
                if (Win == 1)
                {
                    TrueDamage(Zone[y0].Lyoko[1] + Zone[y0].Lyoko[2]);

                }
                

            }
            if (x40 == 58)// Ataque Cruel 
            {
                //Victory Mana +4 Vitória: Se você tiver menos que 3 de vida, ganhe 8 de vida. 

                if (Win == 1)
                {
                    UpMana(4);

                    //Slow Effect Life
                }

            }
            if (x40 == 59)// Paixão Noturna
            {
                // Defeat: Mana Attack 2x 
                if (Win == 0)
                {
                    if (y0 == 5)
                    {
                        NormalDamage(D.Combat.ManaSpendA);
                        NormalDamage(D.Combat.ManaSpendA);
                    }
                    else
                    {
                        NormalDamage(D.Combat.ManaSpendE);
                        NormalDamage(D.Combat.ManaSpendE);
                    }

                }

            }
            if (x40 == 60)// Nome Maldito
            {
                //Victory: Mana Attack Vitória: Ganhe 1 de vida para cada mana que você possuir.
                if (Win == 1)
                {
                    if (y0 == 5)
                    {
                        NormalDamage(D.Combat.ManaSpendA);
                        
                    }
                    else
                    {
                        NormalDamage(D.Combat.ManaSpendE);
                    }
                    UpLife(Zone[y0].Mana);
                }

            }
            if (x40 == 61)// Limite da mana 
            {
                //Regenere vida igual a quantidade de mana gasta Obliterar 10
                if (y0 == 5)
                {
                    UpLife(D.Combat.ManaSpendA);

                }
                else
                {
                    UpLife(D.Combat.ManaSpendE);
                }
                if (Win == 1)
                {
                    Obliterar(10);
                }

            }

           

        }
        SlowEffects();
        D.B();
    }
    public void AnimeSkill()
    {

        a.ControllerAnimation.AnimationSkill(c9[k], AttackId[k]);


    }
    public void B()
    {


        i1.SetActive(true);
        i2.SetActive(true);
        if (k + 1 <= c1.Count)
        {




            AnimeSkill();



            int language;
            language = PlayerPrefs.GetInt("Language");
            if (language == 0)
            {
                if (c11[k] == 1)
                {
                    Eye.sprite = D.AttackS[c8[k]].sprite;
                    Eye2.text = D.AttackS[c8[k]].Texto0;

                }
                if (c11[k] == 2)
                {
                    Eye.sprite = D.AttackQ[c8[k]].sprite;
                    Eye2.text = D.AttackQ[c8[k]].Texto0;

                }
                if (c11[k] == 3)
                {
                    Eye.sprite = D.Block[c8[k]].sprite;
                    Eye2.text = D.Block[c8[k]].Texto0;

                }
                if (c11[k] == 4)
                {
                    Eye.sprite = D.Dodge[c8[k]].sprite;
                    Eye2.text = D.Dodge[c8[k]].Texto0;


                }
                if (c11[k] == 5)
                {
                    Eye.sprite = D.Relics[c8[k]].SpriteRelic;
                    Eye2.text = D.Relics[c8[k]].Description;


                }
            }
            if (language == 1)
            {
                if (c11[k] == 1)
                {
                    Eye.sprite = D.AttackS[c8[k]].sprite;
                    Eye2.text = D.AttackS[c8[k]].Texto0br;

                }
                if (c11[k] == 2)
                {
                    Eye.sprite = D.AttackQ[c8[k]].sprite;
                    Eye2.text = D.AttackQ[c8[k]].Texto0br;

                }
                if (c11[k] == 3)
                {
                    Eye.sprite = D.Block[c8[k]].sprite;
                    Eye2.text = D.Block[c8[k]].Texto0br;

                }
                if (c11[k] == 4)
                {
                    Eye.sprite = D.Dodge[c8[k]].sprite;
                    Eye2.text = D.Dodge[c8[k]].Texto0br;


                }
                if (c11[k] == 5)
                {
                    Eye.sprite = D.Relics[c8[k]].SpriteRelic;
                    Eye2.text = D.Relics[c8[k]].DescriptionBR;


                }
            }
            //Eye1.SetActive(true);
          
            if (c9[k] == 1)
            {
                anime[c6[k]].SetActive(true);
                if (c10[k] > 0)
                {
                    Value[c6[k]].text = c10[k].ToString();
                }
            }
            if (c9[k] == -1)
            {
                anime1[c6[k]].SetActive(true);
                if (c10[k] > 0)
                {
                    Value1[c6[k]].text = c10[k].ToString();
                }
            }
        }
        else
        {

            c1.Clear();
            c2.Clear();
            c3.Clear();

            c5.Clear();
            c6.Clear();
            c8.Clear();
            c9.Clear();
            c10.Clear();
            c11.Clear();
            c12.Clear();
            AttackId.Clear();

            ClearAttributes();


            k = 0;
            Dark.SetActive(true);
        }
    }
    public void ClearAttributes()
    {
        LifeAlly.Clear();
        AttackAlly.Clear();
        DefenseAlly.Clear();
        ManaAlly.Clear();

        LifeEnemy.Clear();
        AttackEnemy.Clear();
        DefenseEnemy.Clear();
        ManaEnemy.Clear();


    }
    public void SetAttributes()
    {
        LifeAlly.Add(Zone[5].Lyoko[0]);
        AttackAlly.Add(Zone[5].Lyoko[1]);
        DefenseAlly.Add(Zone[5].Lyoko[2]);
        ManaAlly.Add(Zone[5].Mana);
        LifeEnemy.Add(Zone[2].Lyoko[0]);
        AttackEnemy.Add(Zone[2].Lyoko[1]);
        DefenseEnemy.Add(Zone[2].Lyoko[2]);
        ManaEnemy.Add(Zone[2].Mana);
    }
    public void C()
    {
        if (c12[k] == 1)
        {
            AllyT[0].text = c1[k].ToString();
            AllyT[1].text = c2[k].ToString();
            AllyT[2].text = c3[k].ToString();

            AllyT[4].text = c5[k].ToString();
        }
        if (c12[k] == -1)
        {
            EnemyT[0].text = c1[k].ToString();
            EnemyT[1].text = c2[k].ToString();
            EnemyT[2].text = c3[k].ToString();

            EnemyT[4].text = c5[k].ToString();
        }
        k += 1;
        B();
    }
    public void X1()
    {
        SetAttributes();
        if (target == 1)
        {
            c1.Add(Zone[y0].Lyoko[0]);
            c2.Add(Zone[y0].Lyoko[1]);
            c3.Add(Zone[y0].Lyoko[2]);

            c5.Add(Zone[y0].Mana);
        }
        if (target == -1)
        {
            c1.Add(Zone[z0].Lyoko[0]);
            c2.Add(Zone[z0].Lyoko[1]);
            c3.Add(Zone[z0].Lyoko[2]);

            c5.Add(Zone[z0].Mana);
        }

        c8.Add(x10);
        c9.Add(e0);
        c10.Add(Damage);
        c11.Add(1);
        c12.Add(e0 * target);

    }
    public void X2()
    {
        SetAttributes();
        if (target == 1)
        {
            c1.Add(Zone[y0].Lyoko[0]);
            c2.Add(Zone[y0].Lyoko[1]);
            c3.Add(Zone[y0].Lyoko[2]);

            c5.Add(Zone[y0].Mana);
        }
        if (target == -1)
        {
            c1.Add(Zone[z0].Lyoko[0]);
            c2.Add(Zone[z0].Lyoko[1]);
            c3.Add(Zone[z0].Lyoko[2]);

            c5.Add(Zone[z0].Mana);
        }

        c8.Add(x20);
        c9.Add(e0);
        c10.Add(Damage);
        c11.Add(2);
        c12.Add(e0 * target);

    }
    public void X3()
    {
        SetAttributes();
        if (target == 1)
        {
            c1.Add(Zone[y0].Lyoko[0]);
            c2.Add(Zone[y0].Lyoko[1]);
            c3.Add(Zone[y0].Lyoko[2]);

            c5.Add(Zone[y0].Mana);
        }
        if (target == -1)
        {
            c1.Add(Zone[z0].Lyoko[0]);
            c2.Add(Zone[z0].Lyoko[1]);
            c3.Add(Zone[z0].Lyoko[2]);

            c5.Add(Zone[z0].Mana);
        }

        c8.Add(x30);
        c9.Add(e0);
        c10.Add(Damage);
        c11.Add(3);
        c12.Add(e0 * target);

    }
    public void X4()
    {
        SetAttributes();
        if (target == 1)
        {
            c1.Add(Zone[y0].Lyoko[0]);
            c2.Add(Zone[y0].Lyoko[1]);
            c3.Add(Zone[y0].Lyoko[2]);

            c5.Add(Zone[y0].Mana);
        }
        if (target == -1)
        {
            c1.Add(Zone[z0].Lyoko[0]);
            c2.Add(Zone[z0].Lyoko[1]);
            c3.Add(Zone[z0].Lyoko[2]);

            c5.Add(Zone[z0].Mana);
        }

        c8.Add(x40);
        c9.Add(e0);
        c10.Add(Damage);
        c11.Add(4);
        c12.Add(e0 * target);

    }
    public void E()
    {
        a.ControllerAnimation.AnimationAttack();
        t1[0].SetActive(true);
        t1[1].SetActive(true);
        t[0].Play("draca");
        t[1].Play("draca");
    }
    public void G()
    {
        if (a.X1Lixo == true)
        {
            y = 5;
            z = 2;
        }

        D.p1 = y;
        D.p2 = z;
    }
    public void ExChange(int x)
    {
        if ((Attacking + x) % 2 == 0)
        {
            x10 = x1;
            x20 = x2;
            x30 = x3;
            x40 = x4;
            x50 = x5;
            x60 = x6;
            x70 = x7;
            x80 = x8;

            /*b10 = b1;
            b20 = b2;
            b30 = b3;
            b40 = b4;
            b50 = b5;
            b60 = b6;
            b70 = b7;
            b80 = b8;
            */

            y0 = y;
            z0 = z;
            card10 = card1;
            card20 = card2;
            e0 = e;
            Win = AllyWin;
        }
        if ((Attacking + x) % 2 == 1)
        {
            x10 = x5;
            x20 = x6;
            x30 = x7;
            x40 = x8;
            x50 = x1;
            x60 = x2;
            x70 = x3;
            x80 = x4;

            /*b10 = b5;
            b20 = b6;
            b30 = b7;
            b40 = b8;
            b50 = b1;
            b60 = b2;
            b70 = b3;
            b80 = b4;
            */
            y0 = z;
            z0 = y;
            card10 = card2;
            card20 = card1;
            e0 = e1;
            Win = EnemyWin;
        }
    }


    public void Attack()
    {
        Damage = Zone[y0].Lyoko[1] - Zone[z0].Lyoko[2];
        if (Damage > 0)
        {
            Zone[z0].Lyoko[0] -= Damage;
            Zone[z0].Code[4] = true;

            c6.Add(1);
            AttackId.Add(1);
            target = -1;
            X();
            DrainLife();
        }
        else
        {
            Damage = 0;
        }

    }
    public void DoubleAttack()
    {
        Damage = Zone[y0].Lyoko[1] - Zone[z0].Lyoko[2];
        for (int x = 0; x < 2; x = x + 1)
        {
            if (Damage > 0)
            {
                Zone[z0].Lyoko[0] -= Damage;
                Zone[z0].Code[4] = true;

                c6.Add(1);
                AttackId.Add(1);
                target = -1;
                X();
                DrainLife();
            }
            else
            {
                Damage = 0;
            }
        }


    }
    public void TripleAttack()
    {
        Damage = Zone[y0].Lyoko[1] - Zone[z0].Lyoko[2];
        for (int x = 0; x < 3; x = x + 1)
        {
            if (Damage > 0)
            {
                Zone[z0].Lyoko[0] -= Damage;
                Zone[z0].Code[4] = true;

                c6.Add(1);
                AttackId.Add(1);
                target = -1;
                X();
                DrainLife();
            }
            else
            {
                Damage = 0;
            }
        }

    }
    public void AttackTrue()
    {
        Damage = Zone[y0].Lyoko[1];

        if (Damage > 0)
        {
            Zone[z0].Lyoko[0] -= Damage;
            Zone[z0].Code[4] = true;

            c6.Add(1);
            AttackId.Add(2);
            target = -1;
            X1();
            DrainLife();
        }
        else
        {
            Damage = 0;
        }

    }

    public void DrainLife()
    {
        if (Zone[y0].Code[7] == true)
        {
            Zone[y0].Lyoko[0] += Damage;
            if (Zone[y0].Lyoko[0] > Zone[y0].Lyoko1[0] + Zone[y0].Lyoko2[0])
            {
                Zone[y0].Lyoko[0] = Zone[y0].Lyoko1[0] + Zone[y0].Lyoko2[0];
            }
            c6.Add(6);
            AttackId.Add(2);
            target = 1;
            X();
        }
    }
    public void TrueDamage(int a)
    {
        Damage = a;

        if (Damage > 0)
        {
            Zone[z0].Lyoko[0] -= Damage;
            Zone[z0].Code[4] = true;

            c6.Add(1);
            AttackId.Add(2);
            target = -1;
            X();
            DrainLife();
        }
        else
        {
            Damage = 0;
        }
    }
    public void Obliterar(int a)
    {
        if (y0 == 5)
        {
            if (D.Combat.AttackA >= (D.Combat.AttackE * 2))
            {
                Damage = a;
            }
            else
            {
                Damage = 0;
            }
        }
        else
        {
            if (D.Combat.AttackE >= (D.Combat.AttackA * 2))
            {
                Damage = a;
            }
            else
            {
                Damage = 0;
            }
        }

        if (Damage > 0)
        {
            Zone[z0].Lyoko[0] -= Damage;
            Zone[z0].Code[4] = true;

            c6.Add(1);
            AttackId.Add(2);
            target = -1;
            X();
            DrainLife();
        }
        else
        {
            Damage = 0;
        }
    }
    public void TrueDamageAlly(int a)
    {
        Damage = a;

        if (Damage > 0)
        {
            Zone[y0].Lyoko[0] -= Damage;
            Zone[y0].Code[4] = true;

            c6.Add(11);
            AttackId.Add(3);
            target = 1;
            X();
        }
        else
        {
            Damage = 0;
        }
    }
    public void ManaSacrifice()
    {

        if (y0 == 5)
        {
            Damage=D.Combat.ManaSpendA;
        }
        else
        {
            Damage = D.Combat.ManaSpendE;
        }
      

        if (Damage > 0)
        {
            Zone[y0].Lyoko[0] -= Damage;
            Zone[y0].Code[4] = true;

            c6.Add(11);
            AttackId.Add(3);
            target = 1;
            X();
        }
        else
        {
            Damage = 0;
        }
    }
    public void SacrificeAttribute(int a, int attribute, bool permanent)
    {

        Damage = a;
        if (Damage != 0)
        {
            Zone[y0].Lyoko[attribute] -= Damage;
            if (Zone[y0].Lyoko[attribute] < 0)
            {
                Zone[y0].Lyoko[attribute] = 0;
            }
            if (permanent == true)
            {
                Zone[y0].Lyoko1[attribute] -= Damage;
            }
            if (attribute == 0)
            {
                c6.Add(6);
                AttackId.Add(3);
            }
            if (attribute == 1)
            {
                c6.Add(8);
                AttackId.Add(3);
            }
            if (attribute == 2)
            {
                c6.Add(7);
                AttackId.Add(3);
            }

            target = 1;
            X();
        }
    }
    public void SacrificeAttributeRelic(int a, int attribute, bool permanent, int idrelic)
    {

        Damage = a;
        if (Damage != 0)
        {
            Zone[y0].Lyoko[attribute] -= Damage;
            if (Zone[y0].Lyoko[attribute] < 0)
            {
                Zone[y0].Lyoko[attribute] = 0;
            }
            if (permanent == true)
            {
                Zone[y0].Lyoko1[attribute] -= Damage;
            }
            if (attribute == 0)
            {
                c6.Add(6);
                AttackId.Add(3);
            }
            if (attribute == 1)
            {
                c6.Add(8);
                AttackId.Add(3);
            }
            if (attribute == 2)
            {
                c6.Add(7);
                AttackId.Add(3);
            }

            target = 1;
            XRelic(idrelic);
        }
    }
    public void NormalDamage(int a)
    {
        Damage = a - Zone[z0].Lyoko[2];

        if (Damage > 0)
        {
            Zone[z0].Lyoko[0] -= Damage;
            Zone[z0].Code[4] = true;

            c6.Add(1);
            AttackId.Add(5);
            target = -1;
            X();
            DrainLife();
        }
        else
        {
            Damage = 0;
        }
    }
    public void AddStatus(int IdStatus, int targ)
    {
        //Sabedoria 1
        // Coragem 2
        //Paixão 3
        //Scar 4
        //Pacifismo5
        //Heroísmo6
        //Compaixão 7
        int indexo = 0;

        Damage = 0;
        if (Zone[y0].status[0] == 0)
        {
            indexo = 0;
        }
        else if (Zone[y0].status[1] == 0)
        {
            indexo = 1;
        }
        else if (Zone[y0].status[2] == 0)
        {
            indexo = 2;
        }
        else if (Zone[y0].status[3] == 0)
        {
            indexo = 3;
        }
        target = targ;
        if (target == 1)
        {
            Zone[y0].status[indexo] = IdStatus;
            Zone[y0].statos[indexo].id = IdStatus;
            Zone[y0].statos[indexo].self.sprite = D.Status[IdStatus].Icon;
            Zone[y0].statos[indexo].selfG.SetActive(true);
        }
        if (target == -1)
        {
            Zone[z0].status[indexo] = IdStatus;
            Zone[z0].statos[indexo].id = IdStatus;
            Zone[z0].statos[indexo].self.sprite = D.Status[IdStatus].Icon;
            Zone[z0].statos[indexo].selfG.SetActive(true);
        }
    }

    public void UpAttribute(int a, int attribute, bool permanent)
    {
        Damage = a;
        if (Damage != 0)
        {
            Zone[y0].Lyoko[attribute] += Damage;
            if (permanent == true)
            {
                Zone[y0].Lyoko1[attribute] += Damage;
            }
            if (attribute == 0)
            {
                c6.Add(6);
                AttackId.Add(3);
            }
            if (attribute == 1)
            {
                c6.Add(8);
                AttackId.Add(3);
            }
            if (attribute == 2)
            {
                c6.Add(7);
                AttackId.Add(3);
            }

            target = 1;
            X();
        }
        else
        {
            Damage = 0;
        }
    }
    public void UpMana(int a)
    {
        Debug.Log("ManaUP");
        Damage = a;
        if (Damage > 0)
        {
            Zone[y0].Mana += Damage;
            c6.Add(10);
            AttackId.Add(3);
            target = 1;
            X();
        }
        else
        {
            Damage = 0;
        }
    }
    public void ManaRecover()
    {
        if (y0 == 5)
        {

            Damage= D.Combat.ManaSpendA;

        }
        else
        {

            Damage = D.Combat.ManaSpendE;
        }
        if (Damage > 0)
        {
            Zone[y0].Mana += Damage;
            c6.Add(10);
            AttackId.Add(3);
            target = 1;
            X();
        }
        else
        {
            Damage = 0;
        }
    }
    public void Altruism(int a)
    {
        Damage = a;

        Zone[z0].Lyoko[0] += Damage;

        c6.Add(1);
        AttackId.Add(3);
        target = -1;
        X();

        Zone[y0].Lyoko[0] += Damage;

        c6.Add(1);
        AttackId.Add(3);
        target = 1;
        X();
    }
    public void SwampAttributes()
    {
        int Swamp;
        Swamp = Zone[y0].Lyoko[1];
        Zone[y0].Lyoko[1] = Zone[z0].Lyoko[1];
        Zone[z0].Lyoko[1] = Swamp;
        Swamp = Zone[y0].Lyoko[2];
        Zone[y0].Lyoko[2] = Zone[z0].Lyoko[2];
        Zone[z0].Lyoko[2] = Swamp;

        c6.Add(1);
        AttackId.Add(3);
        target = -1;
        X();



        c6.Add(1);
        AttackId.Add(3);
        target = 1;
        X();
    }
    public void UpOppAttribute(int a, int attribute)
    {
        Damage = a;

        Zone[z0].Lyoko[attribute] += Damage;

        c6.Add(1);
        AttackId.Add(3);
        target = -1;
        X();

      
    }
    public void UpLife(int a)
    {
        Damage = a;

        Zone[y0].Lyoko[0] += Damage;

        c6.Add(1);
        AttackId.Add(3);
        target = 1;
        X();
    }
    public void UpAttributeRelic(int a, int attribute, bool permanent, int idrelic)
    {
        Damage = a;
        if (Damage != 0)
        {
            Zone[y0].Lyoko[attribute] += Damage;
            if (permanent == true)
            {
                Zone[y0].Lyoko1[attribute] += Damage;
            }
            if (attribute == 0)
            {
                c6.Add(6);
                AttackId.Add(3);
            }
            if (attribute == 1)
            {
                c6.Add(8);
                AttackId.Add(3);
            }
            if (attribute == 2)
            {
                c6.Add(7);
                AttackId.Add(3);
            }

            target = 1;
            XRelic(idrelic);
        }
        else
        {
            Damage = 0;
        }
    }
    public void TrueDamageRelic(int a, int idrelic)
    {

        Damage = a;
        if (Damage > 0)
        {
            Zone[z0].Lyoko[0] -= Damage;
            Zone[z0].Code[4] = true;

            c6.Add(1);
            AttackId.Add(2);
            target = -1;
            XRelic(idrelic);
        }
        else
        {
            Damage = 0;
        }
    }
    public void TrueDamageAllyRelic(int a, int idrelic)
    {

        Damage = a;
        if (Damage > 0)
        {
            Zone[y0].Lyoko[0] -= Damage;
            Zone[y0].Code[4] = true;

            c6.Add(11);
            AttackId.Add(3);
            target = 1;
            XRelic(idrelic);
        }
        else
        {
            Damage = 0;
        }
    }
    public void UpManaRelic(int a, int idrelic)
    {
        Debug.Log("ManaUP");
        Damage = a;
        if (Damage > 0)
        {
            Zone[y0].Mana += Damage;
            c6.Add(10);
            AttackId.Add(3);
            target = 1;
            XRelic(idrelic);
        }
        else
        {
            Damage = 0;
        }
    }
    public void AltruismRelic(int a, int idrelic)
    {
        Damage = a;

        Zone[z0].Lyoko[0] += Damage;

        c6.Add(1);
        AttackId.Add(3);
        target = -1;
        XRelic(idrelic);

        Zone[y0].Lyoko[0] += Damage;

        c6.Add(1);
        AttackId.Add(3);
        target = 1;
        XRelic(idrelic);
    }
    public void DamageAttribute(int a, int attribute, bool permanent)
    {
        Damage = a;
        if (permanent == true)
        {
            Zone[z0].Lyoko1[attribute] -= Damage;
        }
        if (Damage > Zone[z0].Lyoko[attribute])
        {
            Damage = Zone[z0].Lyoko[attribute];
        }
        if (Damage > 0)
        {
            Zone[z0].Lyoko[attribute] -= Damage;

            if (attribute == 0)
            {
                c6.Add(1);
                AttackId.Add(4);
            }
            if (attribute == 1)
            {
                c6.Add(3);
                AttackId.Add(4);
            }
            if (attribute == 2)
            {
                c6.Add(2);
                AttackId.Add(4);
            }

            target = -1;
            X();
        }
        else
        {
            Damage = 0;
        }
    }
    public void DamageMana(int a)
    {
        Damage = a;
        if (Damage > Zone[z0].Mana)
        {
            Damage = Zone[z0].Mana;
        }
        if (Damage > 0)
        {
            Zone[z0].Mana -= Damage;


            c6.Add(5);
            AttackId.Add(4);


            target = -1;
            X();
        }
        else
        {
            Damage = 0;
        }
    }
    public void ForceofWill(int a)
    {
        Damage = a;
        //if mana = 0 + a mana
        if (Zone[y0].Mana <= 0)
        {
            Zone[y0].Mana += Damage;


            c6.Add(5);
            AttackId.Add(3);


            target = 1;
            X();
        }

    }
    public void DuelistF(int a)
    {
        duelist = true;
        for (int x = 0; x < Zone[a].idzone0.Count; x = x + 1)
        {
            if (Zone[Zone[a].idzone0[x]].idcard1 * Zone[a].idcard1 > 0)
            {
                duelist = false;
            }

        }
    }
    public void PactF(int a)
    {
        pact = 0;
        for (int x = 1; x < 11; x = x + 1)
        {
            if (Zone[x].Code[6] == true && Zone[x].idcard1 * Zone[a].idcard1 > 0)
            {
                pact += 1;
            }
        }
    }
    public void X()
    {
        if (x10 > 0)
        {
            X1();
        }
        else if (x20 > 0)
        {
            X2();
        }
        else if (x30 > 0)
        {
            X3();
        }
        else if (x40 > 0)
        {
            X4();
        }
    }
    public void XRelic(int a)
    {

        SetAttributes();
        Debug.Log("Xrelic");
        if (target == 1)
        {
            c1.Add(Zone[y0].Lyoko[0]);
            c2.Add(Zone[y0].Lyoko[1]);
            c3.Add(Zone[y0].Lyoko[2]);

            c5.Add(Zone[y0].Mana);
        }
        if (target == -1)
        {
            c1.Add(Zone[z0].Lyoko[0]);
            c2.Add(Zone[z0].Lyoko[1]);
            c3.Add(Zone[z0].Lyoko[2]);

            c5.Add(Zone[z0].Mana);
        }
        Debug.Log(e0);
        Debug.Log(e0 * target);

        c8.Add(a);
        c9.Add(e0);
        c10.Add(Damage);
        c11.Add(5);
        c12.Add(e0 * target);

    }
    public void StatusEffect()
    {
        for (int x = 0; x < 4; x = x + 1)
        {
            if (Zone[y0].status[x] == 1)//Sabedoria
            {
                if (Win == 1)
                {
                    Debug.Log("Bugou");
                    UpManaRelic(2, 1);
                    Debug.Log("Não Bugou");
                }
            }
            if (Zone[y0].status[x] == 2)//Coragem
            {
                if (Zone[y0].Mana < Zone[z0].Mana)
                {
                    UpAttributeRelic(3, 1, true, 1);

                }
            }
            if (Zone[y0].status[x] == 3)//Paixão
            {
                if (Zone[y0].SentimentalBool == true)
                {
                    UpAttributeRelic(3, 0, true, 1);
                }
            }
            if (Zone[y0].status[x] == 4)//Scar
            {

            }
            if (Zone[y0].status[x] == 5)//Pacifismo
            {

                //Se no final da partida você estiver vivo e o oponente tiver pelo menos 15 de vida a mais que você, ganhe 40 de vida.
                if (a.turn > 2 && Zone[y0].Lyoko[0]>0)
                {
                    if (Zone[z0].Lyoko[0] - Zone[y0].Lyoko[0] >= 15)
                    {
                        Zone[y0].Lyoko[0] += 40;
                    }
                }
            }
            if (Zone[y0].status[x] == 6)//Heroísmo
            {
                //No fim de cada turno, cause 5 de dano se você tiver menos mana que seu oponente. 
                if (Zone[y0].Mana< Zone[z0].Mana)
                {
                    TrueDamage(5);
                }
            }
            if (Zone[y0].status[x] == 7)//Compaixão
            {
                //Seu sentimento torna-se compaixão
                //SetSentimento() if status==7 sentimento = compaixão

            }
        }
    }
}
