using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Status", menuName = "Status")]
public class Status : ScriptableObject
{
    public Sprite Icon;
    public Sprite BigIcon;
    public int id;
    [TextArea]
    public string description;
    public string Name;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
