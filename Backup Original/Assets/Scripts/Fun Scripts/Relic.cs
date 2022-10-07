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
    [TextArea]
    public string DescriptionBR;
    public string Name;
    public string NameBR;
    public int Type;
    
}
