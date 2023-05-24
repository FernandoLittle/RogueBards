using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeCube : MonoBehaviour
{
    public string SceneString;
    public List<Sprite> SpriteScene;
    public SpriteRenderer FaceScene;
    public GameObject Loading;
    public void A()
    {
        Loading.SetActive(true);
        SceneManager.LoadScene(SceneString);

    }
    public void B()
    {
        if (SceneString =="Adventure")
        {
            FaceScene.sprite = SpriteScene[0];
        }
        if (SceneString == "Battle")
        {
            FaceScene.sprite = SpriteScene[1];
        }
        if (SceneString == "BookGame")
        {
            FaceScene.sprite = SpriteScene[2];
        }
        if (SceneString == "Cubo")
        {
            FaceScene.sprite = SpriteScene[7];
        }
        if (SceneString == "Money")
        {
            FaceScene.sprite = SpriteScene[3];
        }
        if (SceneString == "Pray")
        {
            FaceScene.sprite = SpriteScene[4];
        }
        if (SceneString == "Song")
        {
            FaceScene.sprite = SpriteScene[5];
        }
        if (SceneString == "Tales")
        {
            FaceScene.sprite = SpriteScene[6];
        }
    }
}
