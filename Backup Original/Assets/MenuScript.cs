using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MenuScript : MonoBehaviour
{
    public bool MenuActive;
    public Animator MenuAnime;
    public List <Text> TextMenu;
    public AudioMixer AudioMixer;
    public AudioSource AudioS;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (MenuActive == true)
            {
                MenuAnime.Play("MenuCima");
                MenuActive = false;
                //animeup
            }
            else
            {
                MenuActive = true;
                MenuAnime.Play("Menubaixo");
                
            }
        }
    }
    public void UpMenu()
    {
        MenuAnime.Play("MenuCima");
        MenuActive = false;
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void EnglishTranslate()
    {
        PlayerPrefs.SetInt("Language", 0);
        TextMenu[0].text = "Volume";
        TextMenu[1].text = "Language";
        TextMenu[2].text = "Continue Game";
        TextMenu[3].text = "Exit Game";

    }
    public void BRTranslate()
    {
        PlayerPrefs.SetInt("Language", 1);
        TextMenu[0].text = "Volume";
        TextMenu[1].text = "Idioma";
        TextMenu[2].text = "Continuar o jogo";
        TextMenu[3].text = "Sair do jogo";
    }
    public void SliderVolume(float a)
    {
        //AudioMixer.SetFloat("volume",a);
        AudioS.outputAudioMixerGroup.audioMixer.SetFloat("volume", Mathf.Log10(a) * 20);
    }
}
