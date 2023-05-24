using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioSource AudioduBem;
    public List<AudioClip> abelhinhaLyoko;
    public List<AudioClip> abelhinhaMana;
    public List<AudioClip> abelhinhaAkasha;
    public List<AudioClip> abelhinhaShua;
    public List<AudioClip> abelhinhaTale;
    public List<AudioClip> abelhinhaInicio;
    public int GodMusic;
    public int indexMusic;
    public int time;
    public int intCena;
    public int OldIntCena;
    public Animator AnimeMusic;
    public static int OnlyOneMusic;
    public GameObject MusicJunker;
    public GameObject Menu;
    public bool TrueAudio;
    private void Start()
    {

        if (OnlyOneMusic == 0)
        {
            TrueAudio = true;
            PlayerPrefs.SetInt("IntCena",0);
            DontDestroyOnLoad(gameObject);
            DontDestroyOnLoad(MusicJunker);
            DontDestroyOnLoad(Menu);
            AudioduBem.Play();
            OnlyOneMusic = 1;
        }
       
    }
    private void FixedUpdate()
    {
        time += 1;
        if (time > 50)
        {
            time = 0;
            ChangeMusic();
        }
        if (AudioduBem.isPlaying == false)
        {
            if (TrueAudio == true)
            {

                NewMusic();
            }

        }
    }
    public void ChangeMusic()
    {
        intCena = PlayerPrefs.GetInt("IntCena");
        if (intCena != OldIntCena || AudioduBem.isPlaying==false)
        {
            Debug.Log(intCena);
            Debug.Log(OldIntCena);
            Debug.Log(AudioduBem.isPlaying);
            OldIntCena = intCena;
            GodMusic = intCena;
            AnimeMusic.Play("AudioAnimeChange");
        }
        
    }
    public void NewMusic()
    {
        if (GodMusic == 0)
        {
            //nada
        }
        if (GodMusic == 1)
        {
            indexMusic = Random.Range(0, abelhinhaTale.Count);
            AudioduBem.clip = abelhinhaTale[indexMusic];
        }
        if (GodMusic == 2)
        {
            indexMusic = Random.Range(0, abelhinhaLyoko.Count);
            AudioduBem.clip = abelhinhaLyoko[indexMusic];
        }
        if (GodMusic == 3)
        {
            indexMusic = Random.Range(0, abelhinhaMana.Count);
            AudioduBem.clip = abelhinhaMana[indexMusic];
        }
        if (GodMusic == 4)
        {
            indexMusic = Random.Range(0, abelhinhaAkasha.Count);
            AudioduBem.clip = abelhinhaAkasha[indexMusic];
        }
        if (GodMusic == 5)
        {
            indexMusic = Random.Range(0, abelhinhaShua.Count);
            AudioduBem.clip = abelhinhaShua[indexMusic];
        }
        AudioduBem.Play();
    }
}
