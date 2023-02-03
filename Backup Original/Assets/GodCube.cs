using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GodCube : MonoBehaviour
{



    public Texture2D HI;
    public Sprite YEEE;
    public List <SpriteRenderer> FaceGod;
    public ChangeCube ChangeCube;
    public GameObject Cube;
    public List<GameObject> Tudo;

    public void TakeScreenshot(string SceneS)
    {
        HI = ScreenCapture.CaptureScreenshotAsTexture();
        YEEE = Sprite.Create(HI, new Rect(0, 0, HI.width, HI.height), new Vector2(0.5f, 0.5f));
        FaceGod[0].sprite = YEEE;
        ChangeCube.SceneString = SceneS;
        Cube.SetActive(true);
        for (int x = 0; x < Tudo.Count; x = x + 1)
        {
            Tudo[x].SetActive(false);
        }

    }



}
