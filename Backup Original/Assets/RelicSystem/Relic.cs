using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Relic", menuName = "Relic")]
public class Relic : ScriptableObject
{
    public int IdRelic;
    public Sprite SpriteRelic;
    [TextArea]
    public string Description;
    public string Name;
    public int Type;
    
}
