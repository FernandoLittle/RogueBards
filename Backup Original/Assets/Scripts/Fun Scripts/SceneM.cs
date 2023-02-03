using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneM : MonoBehaviour
{
    public GodCube GodCube;//x


    public void Tales()
    {
        GodCube.TakeScreenshot("Tales");
        //SceneManager.LoadScene("Tales");
    }
}
