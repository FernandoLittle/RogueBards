using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneT : MonoBehaviour
{
    public GodCube GodCube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TBattle()
    {
        GodCube.TakeScreenshot("Select");
        //SceneManager.LoadScene("Select");
    }
    public void AhShitHereWeGoAgain()
    {
        GodCube.TakeScreenshot("Adventure");
        //SceneManager.LoadScene("Adventure");
    }
}
