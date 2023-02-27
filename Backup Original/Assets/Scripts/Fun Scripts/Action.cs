using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Action", menuName = "Action")]
public class Action : ScriptableObject
{
    public string Name;
    public string NameBR;
    public string GodText;
    public string GodTextBR;
    public Sprite sprite;
    public int id;
    [TextArea]
    public string Texto0;

    [TextArea]
    public string Texto0br;

    public int scale;
    public int IAturn;
    public List <int> KeywordId;
    /*
     * Positive:Blue Keyword.
     * Negative:Golden Keyword.
     * Over 1000: Red Keyword.
     * 1:Strike.
     * 2:Double Strike
     * 3:Damage
     * 4:True Damage
     * 5:Frozen (Mana Drain)
     * 6:Triple Attack
     * 7:Attack Buff
     * 8:Attack Debuff
     * 9:Defense Buff
     * 10:Defense Debuff
     * 11:Life Buff 
     * 12:Life Debuff
     * 13:Regeneration
     * 14:Nexus Strike
     * 15:Global True Damage
     * 16:Fortify (+Power)
     * 17:Weaken (-Power)
     * 18:Level Up 
     * 19:Level Down
     * 20:Copy Level
     * 21:Poison
     * 22:Sacrifice
     * 
     *  
     *
     *
     *
     *
     *
     *
     *
     *
     * 33:Sacrifice Attack
     * 34:Useless
     * 35:Scar
     * 
     * 
     * 
     * 
     */
    public List<string> KeywordValues;
    public List<int> NotesId;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
