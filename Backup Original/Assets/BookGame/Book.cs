using System.Collections;
using System.Collections.Generic;
using UnityEngine;




[CreateAssetMenu(fileName = "New Book", menuName = "Book")]
public class Book : ScriptableObject
{
    public Sprite BookSprite;
    [TextArea]
    public string NameBook;
    public string Question;
    public string Answer1;
    public string Answer2;
    public string Answer3;
    public string Answer4;
    public int CorrectAnswer;
    public int UltraCorrectAnswer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
