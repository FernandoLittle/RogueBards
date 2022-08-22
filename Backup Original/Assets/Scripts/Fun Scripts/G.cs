using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class G : MonoBehaviour
{
    public int id;
    public F f;
    public GameObject il;
    public Image il1;
    public GameObject il2;
    public Image Zonesprite0;
    public D d;
    public int id1;
    public Text t0;

    public List<GameObject> t;
    public Animator anime;
    public int e;
    public GameObject h;
    public Image Fantasy;
    public Combat Combat;
    public List<bool> NoDuplicates;

    public Button a;
    public Text EyeName;
    public List<GameObject> Keywords;
    public Transform TextTransform;
    public List<Transform> KeywordTransform;
    // Start is called before the first frame update


    public void Result()
    {
        Combat.Victory2();
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
        f.x1 = id;
        f.x2 = 0;
        f.x3 = 0;
        f.x4 = 0;
        f.b1 = 1;
        f.b2 = 0;
        f.b3 = 0;
        f.b4 = 0;
        d.SkillId = 1;
        d.CardSelect();
        Fantasy.sprite = Zonesprite0.sprite;
        Combat.SkillIDA = id1;
    }
    public void B()
    {
        f.x2 = id;
        f.x1 = 0;
        f.x3 = 0;
        f.x4 = 0;

        f.b2 = 1;
        f.b1 = 0;
        f.b3 = 0;
        f.b4 = 0;
        d.SkillId = 2;
        d.CardSelect();
        Fantasy.sprite = Zonesprite0.sprite;
        Combat.SkillIDA = id1;

    }
    public void C()
    {
        f.x3 = id;
        f.x4 = 0;
        f.x1 = 0;
        f.x2 = 0;
        f.b1 = 0;
        f.b2 = 0;
        f.b3 = 1;
        f.b4 = 0;
        d.SkillId = 3;
        d.CardSelect();
        Fantasy.sprite = Zonesprite0.sprite;
        Combat.SkillIDA = id1;
    }
    public void D()
    {
        f.x4 = id;
        f.x3 = 0;
        f.x1 = 0;
        f.x2 = 0;
        f.b2 = 0;
        f.b1 = 0;
        f.b4 = 1;
        f.b3 = 0;
        d.SkillId = 4;
        d.CardSelect();
        Fantasy.sprite = Zonesprite0.sprite;
        Combat.SkillIDA = id1;
    }
    public void E()
    {

        
        il.SetActive(true);
        il1.sprite = Zonesprite0.sprite;
        il2.SetActive(false);
        if (id1 == 1)
        {
            d.ScaleT1.text = d.AttackS[id].scale.ToString();
            t0.text = d.AttackS[id].Texto0;
            SetKeyword(d.AttackS[id]);

            EyeName.text = d.AttackS[id].Name;
        }
        if (id1 == 2)
        {
            d.ScaleT1.text = d.AttackQ[id].scale.ToString();
            t0.text = d.AttackQ[id].Texto0;
            SetKeyword(d.AttackQ[id]);



            EyeName.text = d.AttackQ[id].Name;
        }
        if (id1 == 3)
        {
            d.ScaleT1.text = d.Block[id].scale.ToString();
            t0.text = d.Block[id].Texto0;
            SetKeyword(d.Block[id]);



            EyeName.text = d.Block[id].Name;
        }
        if (id1 == 4)
        {
            d.ScaleT1.text = d.Dodge[id].scale.ToString();
            t0.text = d.Dodge[id].Texto0;
            SetKeyword(d.Dodge[id]);



            EyeName.text = d.Dodge[id].Name;
        }

        t[0].SetActive(true);




    }
    public void F()
    {
        il.SetActive(false);
    }
    public void A1()
    {
        if (e == 1)
        {
            anime.Play("A1B");
        }
        if (e == 0)
        {
            anime.Play("A1E");
        }
    }
    public void A2()
    {
        if (e == 0)
        {
            anime.Play("A2B");
        }
        if (e == 1)
        {
            anime.Play("A2E");
        }
    }
    public void A3()
    {
        if (e == 0)
        {
            anime.Play("B1Fx");
        }
        if (e == 1)
        {
            anime.Play("B1Rx");
        }
    }
    public void A4()
    {
        if (e == 0)
        {
            anime.Play("B2Rx");
        }
        if (e == 1)
        {
            anime.Play("B2Fx");
        }
    }
    public void A5()
    {
        if (e == 0)
        {
            anime.Play("A1Ex");
        }
        if (e == 1)
        {
            anime.Play("A1Bx");
        }
    }
    public void A6()
    {
        if (e == 0)
        {
            anime.Play("A2Bx");
        }
        if (e == 1)
        {
            anime.Play("A2Ex");
        }
    }
    public void A7()
    {
        if (e == 0)
        {
            anime.Play("B1F");
        }
        if (e == 1)
        {
            anime.Play("B1R");
        }
    }
    public void A8()
    {
        if (e == 0)
        {
            anime.Play("B2R");
        }
        if (e == 1)
        {
            anime.Play("B2F");
        }
    }
    public void A9()
    {
        d.E();
    }
    public void H()
    {
        h.SetActive(false);
    }
    public void I()
    {
        f.B();
    }
    public void I1()
    {
        f.E();
    }
    public void Anime1()
    {
        if (Combat.Win == 0)
        {
            anime.Play("A1B");
        }
        else
        {
            anime.Play("A1E");
        }
    }
    public void Anime2()
    {
        if (Combat.Win == 0)
        {
            anime.Play("A2E");
        }
        else
        {
            anime.Play("A2B");
        }
    }
    public void Anime3()
    {
        if (Combat.Win == 0)
        {
            anime.Play("B1Rx");
        }
        else
        {
            anime.Play("B1Fx");
        }
    }
    public void Anime4()
    {
        if (Combat.Win == 0)
        {
            anime.Play("B2Fx");
        }
        else
        {
            anime.Play("B2Rx");
        }
    }
    public void Anime5()
    {
        if (Combat.Win == 0)
        {
            anime.Play("A1Ex");
        }
        else
        {
            anime.Play("A1Bx");
        }
    }
    public void Anime6()
    {
        if (Combat.Win == 0)
        {
            anime.Play("A2Bx");
        }
        else
        {
            anime.Play("A2Ex");
        }

    }
    public void Anime7()
    {
        if (Combat.Win == 0)
        {
            anime.Play("B1F");
        }
        else
        {
            anime.Play("B1R");
        }
    }
    public void Anime8()
    {
        if (Combat.Win == 0)
        {
            anime.Play("B2R");
        }
        else
        {
            anime.Play("B2F");
        }
    }
    public void SetKeyword(Action action)
    {

        //Active Keywords
        for (int x = 0; x < 6; x = x + 1)
        {
            d.Keywords[x].SetActive(false);
        }
        for (int x = 0; x < action.KeywordId.Count; x = x + 1)
        {
            d.Keywords[x].SetActive(true);
        }
        //Set Position of Keywords
        if (action.KeywordId.Count == 0)
        {
            d.TextTransform.localPosition = new Vector3(3, -90, 0);

            d.TextRTransform.sizeDelta = new Vector2(164, 86);
        }
        if (action.KeywordId.Count == 1)
        {
            d.KeywordTransform[0].localPosition = new Vector3(0.5f, -50, 0);
            d.TextTransform.localPosition = new Vector3(3, -96, 0);
            d.TextRTransform.sizeDelta = new Vector2(164, 58);
        }
        if (action.KeywordId.Count == 2)
        {
            d.KeywordTransform[0].localPosition = new Vector3(-43, -50, 0);
            d.KeywordTransform[1].localPosition = new Vector3(44, -50, 0);
            d.TextTransform.localPosition = new Vector3(3, -96, 0);
            d.TextRTransform.sizeDelta = new Vector2(164, 58);
        }
        if (action.KeywordId.Count == 3)
        {
            d.KeywordTransform[0].localPosition = new Vector3(-43, -45, 0);
            d.KeywordTransform[1].localPosition = new Vector3(44, -45, 0);
            d.KeywordTransform[2].localPosition = new Vector3(0.5f, -72, 0);

            d.TextTransform.localPosition = new Vector3(3, -110, 0);
            d.TextRTransform.sizeDelta = new Vector2(164, 48);

        }
        if (action.KeywordId.Count == 4)
        {
            d.KeywordTransform[0].localPosition = new Vector3(-43, -45, 0);
            d.KeywordTransform[1].localPosition = new Vector3(44, -45, 0);
            d.KeywordTransform[2].localPosition = new Vector3(-43, -72, 0);
            d.KeywordTransform[3].localPosition = new Vector3(44, -72, 0);

            d.TextTransform.localPosition = new Vector3(3, -110, 0);
            d.TextRTransform.sizeDelta = new Vector2(164, 48);
        }
        if (action.KeywordId.Count == 5)
        {
            d.KeywordTransform[0].localPosition = new Vector3(-43, -38, 0);
            d.KeywordTransform[1].localPosition = new Vector3(44, -38, 0);
            d.KeywordTransform[2].localPosition = new Vector3(-43, -64, 0);
            d.KeywordTransform[3].localPosition = new Vector3(44, -64, 0);
            d.KeywordTransform[4].localPosition = new Vector3(0.5f, -90, 0);
            d.TextTransform.localPosition = new Vector3(3, -117, 0);
            d.TextRTransform.sizeDelta = new Vector2(164, 26);

        }
        if (action.KeywordId.Count == 6)
        {
            d.KeywordTransform[0].localPosition = new Vector3(-43, -38, 0);
            d.KeywordTransform[1].localPosition = new Vector3(44, -38, 0);
            d.KeywordTransform[2].localPosition = new Vector3(-43, -64, 0);
            d.KeywordTransform[3].localPosition = new Vector3(44, -64, 0);
            d.KeywordTransform[4].localPosition = new Vector3(-43, -90, 0);
            d.KeywordTransform[5].localPosition = new Vector3(44, -90, 0);
            d.TextTransform.localPosition = new Vector3(3, -117, 0);
            d.TextRTransform.sizeDelta = new Vector2(164, 26);
        }

        SetDescription(action);

    }
    public void SetDescription(Action action)
    {
        d.Description.text = "";
        NoDuplicates[0] = false;
        NoDuplicates[1] = false;
        NoDuplicates[2] = false;
        for (int x = 0; x < action.KeywordId.Count; x = x + 1)
        {
            if (d.Generic.Desc(action.KeywordId[x]) == 0)
            {
                d.Description.text += "Reality is an illusion the universe is a hologram buy gold.\n";
                d.KeywordsT[x].text = "I see you";
            }
            if (d.Generic.Desc(action.KeywordId[x]) == 1)
            {
                d.Description.text += "<color=red>Strike</color>: Deals damage equal to your human's attack.\n";
                d.KeywordsT[x].text = "<color=red>Strike</color>";
            }
            if (d.Generic.Desc(action.KeywordId[x]) == 2)
            {
                d.Description.text += "<color=#FF2900>Double Strike</color>: Deals damage equal to your human's attack twice.\n";
                d.KeywordsT[x].text = "<color=#FF2900>Double Strike</color>";
            }
            if (d.Generic.Desc(action.KeywordId[x]) == 3)
            {
                d.Description.text += "<color=#FF2900>Damage</color>: Does damage, I think.\n";
                d.KeywordsT[x].text = "<color=#FF2900>Damage</color> ";
            }
            if (d.Generic.Desc(action.KeywordId[x]) == 4)
            {
                d.Description.text += "<color=#FF2900>True Damage</color>: Deals damage that is not reduced by the opponent's defense.\n";
                d.KeywordsT[x].text = "<color=#FF2900>True Damage</color> ";
            }
            if (d.Generic.Desc(action.KeywordId[x]) == 5)
            {
                d.Description.text += "<color=#00C8FF>Frozen</color>: Reduces opponent's mana.\n";
                d.KeywordsT[x].text = "<color=#00C8FF>Frozen</color> ";
            }
            if (d.Generic.Desc(action.KeywordId[x]) == 6)
            {
                d.Description.text += "<color=#FF2900>Triple Strike</color>: Deals damage equal to your human's attack three times.\n";
                d.KeywordsT[x].text = "<color=#FF2900>Triple Strike</color>";

            }
            if (d.Generic.Desc(action.KeywordId[x]) == 7)
            {

            }
            if (d.Generic.Desc(action.KeywordId[x]) == 8)
            {

            }
            if (d.Generic.Desc(action.KeywordId[x]) == 9)
            {

            }
            if (d.Generic.Desc(action.KeywordId[x]) == 10)
            {
                d.Description.text += "<color=#7300FF>Defense -</color>: Reduces the opponent's defense, until the end of the turn.\n";
                d.KeywordsT[x].text = "<color=#7300FF>Defense -</color> ";

            }
            if (d.Generic.Desc(action.KeywordId[x]) == 11)
            {
                d.Description.text += "<color=#00FF00>Life Buff</color>: Recovers and increases your hero's maximum life.\n";
                d.KeywordsT[x].text = "<color=#00FF00>Life Buff</color> ";

            }
            if (d.Generic.Desc(action.KeywordId[x]) == 12)
            {
                d.Description.text += "<color=#7300FF>Life Debuff</color>: Deals true damage and reduces the opponent's maximum life.\n";
                d.KeywordsT[x].text = "<color=#7300FF>Life Debuff</color> ";

            }
            if (d.Generic.Desc(action.KeywordId[x]) == 13)
            {
                d.Description.text += "<color=#00FF00>Regeneration</color>: Recovers your hero's life.\n";
                d.KeywordsT[x].text = "<color=#00FF00>Regeneration</color> ";

            }
            if (d.Generic.Desc(action.KeywordId[x]) == 14)
            {
                d.Description.text += "<color=#FF2900>Nexus Strike</color>: Damages the opponent's nexus.\n";
                d.KeywordsT[x].text = "<color=#FF2900>Nexus Strike</color> ";

            }
            if (d.Generic.Desc(action.KeywordId[x]) == 15)
            {
                d.Description.text += "<color=#FF2900>Global True Damage</color>: Deals damage that is not reduced by the opponent's defense on all opponents.\n";
                d.KeywordsT[x].text = "<color=#FF2900>Global True Damage</color> ";

            }
            if (d.Generic.Desc(action.KeywordId[x]) == 16)
            {
                d.Description.text += "<color=#FF00F0>Fortify</color>: Increases your power.\n";
                d.KeywordsT[x].text = "<color=#FF00F0>Fortify</color> ";

            }
            if (d.Generic.Desc(action.KeywordId[x]) == 17)
            {
                d.Description.text += "<color=#C200C6>Weaken</color>: Reduces the opponent's power.\n";
                d.KeywordsT[x].text = "<color=#C200C6>Weaken</color> ";

            }
            if (d.Generic.Desc(action.KeywordId[x]) == 18)
            {
                d.Description.text += "<color=#FF00F0>Level Up</color>: Increases the level of your skill.\n";
                d.KeywordsT[x].text = "<color=#FF00F0>Level Up</color> ";

            }
            if (d.Generic.Desc(action.KeywordId[x]) == 19)
            {
                d.Description.text += "<color=#C200C6>Level Down</color>: Reduces the opponent's skill level.\n";
                d.KeywordsT[x].text = "<color=#C200C6>Level Down</color> ";
            }
            if (d.Generic.Desc(action.KeywordId[x]) == 20)
            {
                d.Description.text += "<color=#FF00F0>Copy Level</color>: The level of your skill becomes the same as your opponent's original skill level.\n";
                d.KeywordsT[x].text = "<color=#FF00F0>Copy Level</color>";
            }
            if (d.Generic.Desc(action.KeywordId[x]) == 21)
            {
                d.Description.text += "<color=#00B700>Poison</color>: The opponent takes true damage at the end of each turn.\n";
                d.KeywordsT[x].text = "<color=#00B700>Poison</color> ";
            }
            if (d.Generic.Desc(action.KeywordId[x]) == 22)
            {
                d.Description.text += "<color=#D90000>Sacrifice</color>: Takes true damage.\n";
                d.KeywordsT[x].text = "<color=#D90000>Sacrifice</color> ";
            }
            if (d.Generic.Desc(action.KeywordId[x]) == 23)
            {
                d.Description.text += "<color=#00FF00>Attack + </color>: Increases your attack.\n";
                d.KeywordsT[x].text = "<color=#00FF00>Attack + </color> ";
            }
            if (d.Generic.Desc(action.KeywordId[x]) == 24)
            {
                d.Description.text += "<color=#00FF00>Defense + </color>: Increases your defense.\n";
                d.KeywordsT[x].text = "<color=#00FF00>Defense + </color> ";
            }
            if (d.Generic.Desc(action.KeywordId[x]) == 25)
            {
                d.Description.text += "<color=#7300FF>Attack Downgrade</color>: Reduces the opponent's attack.\n";
                d.KeywordsT[x].text = "<color=#7300FF>Attack Downgrade</color> ";
            }
            if (d.Generic.Desc(action.KeywordId[x]) == 26)
            {
                d.Description.text += "<color=#7300FF>Defense - </color>: Reduces the opponent's defense.\n";
                d.KeywordsT[x].text = "<color=#7300FF>Defense - </color> ";
            }
            if (d.Generic.Desc(action.KeywordId[x]) == 27)
            {
                d.Description.text += "<color=#FF62B4>Altruism</color>: Both humans gain life.\n";
                d.KeywordsT[x].text = "<color=#7300FF>Altruism</color> ";
            }
            if (d.Generic.Desc(action.KeywordId[x]) == 28)
            {
                d.Description.text += "<color=#FF62B4>Life + </color>: Gain life.\n";
                d.KeywordsT[x].text = "<color=#7300FF>Life + </color> ";
            }
            if (d.Generic.Desc(action.KeywordId[x]) == 29)
            {
                d.Description.text += "<color=#67B2FF>Wisdom</color>: Gain mana when your skill wins.\n";
                d.KeywordsT[x].text = "<color=#67B2FF>Wisdom</color> ";
            }


            if (d.Generic.Desc(action.KeywordId[x]) == 30)
            {
                d.Description.text += "<color=#FF62B4>Bravery</color>: Gains 2 attack if the human has less mana than the opponent at the end of the turn.\n";
                d.KeywordsT[x].text = "<color=#7300FF>Bravery</color> ";
            }
            if (d.Generic.Desc(action.KeywordId[x]) == 31)
            {
                d.Description.text += "<color=#00C2FF>Willpower</color>: Gains mana if you have 0 mana at end of turn.\n";
                d.KeywordsT[x].text = "<color=#00C2FF>Willpower /color> ";
            }
            if (d.Generic.Desc(action.KeywordId[x]) == 32)
            {
                d.Description.text += "<color=#FF009C>Passion</color>:  Gains 2 life whenever you activate the sentimental bonuses.\n";
                d.KeywordsT[x].text = "<color=#FF009C>Passion/color> ";
            }
            if (d.Generic.Desc(action.KeywordId[x]) == 33)
            {
                d.Description.text += "<color=#D90000>Sacrifice Attack</color>: Reduces your own attack.\n";
                d.KeywordsT[x].text = "<color=#D90000>Sacrifice Attack</color> ";
            }
            if (d.Generic.Desc(action.KeywordId[x]) == 34)
            {
                d.Description.text += "<color=#D90000>Useless</color>: Begging for mercy is useless.\n";
                d.KeywordsT[x].text = "<color=#D90000>Useless</color> ";
            }
            if (d.Generic.Desc(action.KeywordId[x]) == 35)
            {
                d.Description.text += "<color=#D90000>Scar</color>: Opponent cannot gain life. This is very cruel.\n";
                d.KeywordsT[x].text = "<color=#D90000>Scar/color> ";
            }
            if (action.KeywordId[x] > 0 && action.KeywordId[x] < 1000 && NoDuplicates[0] == false)
            {
                NoDuplicates[0] = true;
                d.Description.text += "<color=#007CD9>Blue Keyword</color>: Activates when you have more power than your opponent <color=#007CD9>(Victory)</color>.\n";
                d.KeywordColor[x].color = new Color32(0, 255, 248, 255);
            }
            if (action.KeywordId[x] < 0 && NoDuplicates[1] == false)
            {
                NoDuplicates[1] = true;
                d.Description.text += "<color=#E0B900>Golden Keyword</color>: Activates regardless of whether you win or lose <color=#E0B900>(Passive)</color>.\n";
                d.KeywordColor[x].color = new Color32(255, 165, 0, 255);

            }
            if (action.KeywordId[x] > 1000 && NoDuplicates[2] == false)
            {
                NoDuplicates[2] = true;
                d.Description.text += "<color=#FF0000>Red Keyword</color>: Activates when you have less power than your opponent <color=#FF0000>(Defeat)</color>.\n";
                d.KeywordColor[x].color = new Color32(255, 48, 58, 255);
            }
            d.KeywordsT[x].text += action.KeywordValues[x];
            //Translate: Add (Replace "min")

        }
        AddNotes(action);

    }
    public void AddNotes(Action action)
    {
        for (int x = 0; x < action.NotesId.Count; x = x + 1)
        {
            if (action.NotesId[x] == -1)
            {
                d.Description.text += "<color=#FAFF1E>Ambush</color>: The effect is not activated if your hero has moved or attacked in a previous turn.\n";
            }
            if (action.NotesId[x] == -2)
            {
                d.Description.text += "<color=#FAFF1E>Duelist</color>: The effect is activated when your hero has no close allies.\n";
            }
            if (action.NotesId[x] == -3)
            {
                d.Description.text += "<color=#FAFF1E>Aggro</color>: The effect is activated in the first 10 turns of the game.\n";
            }
            if (action.NotesId[x] == -4)
            {
                d.Description.text += "<color=#FAFF1E>Pact</color>: The effect is activated if the ally who made a pact with you is alive.\n";
            }
            if (action.NotesId[x] == -5)
            {
                d.Description.text += "<color=#FF2900>Double Strike</color>: Deals damage equal to your hero's attack twice.\n";
            }
            if (action.NotesId[x] == -6)
            {
                d.Description.text += "<color=#FF2900>Triple Strike</color>: Deals damage equal to your hero's attack three times.\n";
            }



            if (d.Generic.Desc(action.NotesId[x]) == 9)
            {
                d.Description.text += "<color=#00FF00>Defense Buff</color>: Increases your hero's defense, until the end of the turn.\n";
            }
            if (d.Generic.Desc(action.NotesId[x]) == 16)
            {
                d.Description.text += "<color=#FF00F0>Fortify</color>: Increases your power.\n";
            }
            if (d.Generic.Desc(action.NotesId[x]) == 17)
            {
                d.Description.text += "<color=#C200C6>Weaken</color>: Reduces the opponent's power.\n";
            }
            if (d.Generic.Desc(action.NotesId[x]) == 18)
            {
                d.Description.text += "<color=#FF00F0>Level Up</color>: Increases the level of your skill.\n";
            }
            if (d.Generic.Desc(action.NotesId[x]) == 19)
            {
                d.Description.text += "<color=#C200C6>Level Down</color>: Reduces the opponent's skill level.\n";
            }
            if (d.Generic.Desc(action.NotesId[x]) == 20)
            {
                d.Description.text += "<color=#FF00F0>Copy Level</color>: The level of your skill becomes the same as your opponent's original skill level.\n";
            }
        }
    }
}
