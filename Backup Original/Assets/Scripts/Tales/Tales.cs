using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Tale", menuName = "Tale")]
public class Tales : ScriptableObject
{
    [TextArea]
    public List <string> Dialogue;
    public List<int> idchara;
    public List<int> instruction;
    // Start is called before the first frame update

}
