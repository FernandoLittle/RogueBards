using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Tale", menuName = "Tale")]
public class Tales : ScriptableObject
{
    public int id;
    [TextArea]
    public List <string> Dialogue;
    [TextArea]
    public List<string> DialogueBR;
    [TextArea]
    public List<string> DialogueES;
    public List<int> idchara;
    public List<int> instruction;
    public int Cenario;
    // Start is called before the first frame update

}
