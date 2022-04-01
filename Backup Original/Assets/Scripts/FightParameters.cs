using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Fight", menuName = "FightParameter")]
public class FightParameters : ScriptableObject
{
    public int IdFight;
    public List<int> IdChara;
    [TextArea]
    public List<string> Dialogue1;
    [TextArea]
    public List<string> Dialogue2;
    [TextArea]
    public List<string> Dialogue3;
    [TextArea]
    public List<string> Dialogue4;
    public List<int> IdDialogue1;
    public List<int> IdDialogue2;
    public List<int> IdDialogue3;
    public List<int> IdDialogue4;
    public int TaleVictory;
    public int TaleDefeat;
    public int Cenário;
    public int TaleTypeV;
    public int TaleTypeD;

}
