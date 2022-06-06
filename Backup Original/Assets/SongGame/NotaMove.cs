using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotaMove : MonoBehaviour
{
    public SpriteRenderer SelfImage;
    public SpriteRenderer ShineImage;
    public int IntColor;
    public Rigidbody2D PrayerBod;
    public int velocity;
    public int DestroyCounter;
    public GameObject Brilho;
    // Start is called before the first frame update
    void Start()
    {
        PrayerBod.velocity = new Vector2(-velocity, 0);
        IntColor = Random.Range(0, 7);
        if (IntColor == 0)
        {
            //Red
            SelfImage.color = new Color(1, 0, 0);
            ShineImage.color= new Color(0.9f,0.3f,0.3f);
        }
        if (IntColor == 1)
        {
            //Blue
            SelfImage.color = new Color(0, 0, 1);
            ShineImage.color = new Color(0.3f, 0.3f, 0.9f);
        }
        if (IntColor == 2)
        {
            //Green
            SelfImage.color = new Color(0, 1, 0);
            ShineImage.color = new Color(0.3f, 0.9f, 0.3f);
        }
        if (IntColor == 3)
        {
            //?
            SelfImage.color = new Color(1, 1, 0);
            ShineImage.color = new Color(0.9f, 0.9f, 0.3f);
        }
        if (IntColor == 4)
        {
            //?
            SelfImage.color = new Color(1, 0, 1);
            ShineImage.color = new Color(0.9f, 0.3f, 0.9f);
        }
        if (IntColor == 5)
        {
            //?
            SelfImage.color = new Color(0, 1, 1);
            ShineImage.color = new Color(0.3f, 0.9f, 0.9f);
        }
        if (IntColor == 6)
        {
            //?
            SelfImage.color = new Color(1, 1, 1);
            ShineImage.color = new Color(0.9f, 0.9f, 0.9f);
        }
    }
    private void FixedUpdate()
    {
        DestroyCounter += 1;
        if (DestroyCounter > 500)
        {
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name =="NotaPlayer")
        {
            Brilho.SetActive(true);
        }
 
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "NotaPlayer")
        {
            Brilho.SetActive(false);
        }
    }
}
