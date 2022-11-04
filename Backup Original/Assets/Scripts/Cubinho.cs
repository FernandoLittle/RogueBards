using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Cubinho : MonoBehaviour
{
    public List<int> Quadrados;
    public List<Sprite> QuadradoSprite;
    public List<SpriteRenderer> Faces;
    public int chaos;
    public Animator anime;
    public GameObject Textin;
    public GameObject Monster;

    public void SetFirstIllustration()
    {
        AddNumber();
        Face0();
        Face1();
        Face2();
        Face3();
        Face4();
        Face5();
    }
    public void NextAnime()
    {
        anime.Play("CuboAnimation");
    }
    public void AddNumber()
    {
        for (int x = 0; x < QuadradoSprite.Count; x = x + 1)
        {
            Quadrados.Add(x);
        }
    }
    public void SetChaos()
    {
        chaos = Random.Range(0, Quadrados.Count);
    }
    public void SetFace(int a)
    {
        Faces[a].sprite = QuadradoSprite[Quadrados[chaos]];
    }
    public void Face0()
    {

        if (Quadrados.Count > 0)
        {
            SetChaos();
            SetFace(0);
            Debug.Log(chaos);
            Quadrados.RemoveAt(chaos);
        }
        else
        {
            AddNumber();
            chaos = Random.Range(0, Quadrados.Count);
            Faces[0].sprite = QuadradoSprite[Quadrados[chaos]];
            Quadrados.RemoveAt(chaos);
        }
    }
    public void Face1()
    {
       
        if (Quadrados.Count > 0)
        {

            SetChaos();
            Debug.Log(chaos);
            SetFace(1);
            Debug.Log(chaos);
            Quadrados.RemoveAt(chaos);
        }
        else
        {
            AddNumber();
            chaos = Random.Range(0, Quadrados.Count);
            Faces[1].sprite = QuadradoSprite[Quadrados[chaos]];
            Quadrados.RemoveAt(chaos);
        }
    }
    public void Face2()
    {

        if (Quadrados.Count > 0)
        {
            SetChaos();
            SetFace(2);
            Debug.Log(chaos);
            Quadrados.RemoveAt(chaos);
        }
        else
        {
            AddNumber();
            SetChaos();
            Faces[2].sprite = QuadradoSprite[Quadrados[chaos]];
            Quadrados.RemoveAt(chaos);
        }
    }
    public void Face3()
    {

        if (Quadrados.Count > 0)
        {
            SetChaos();
            SetFace(3);
            Debug.Log(chaos);
           Quadrados.RemoveAt(chaos);
        }
        else
        {
            AddNumber();
            chaos = Random.Range(0, Quadrados.Count);
            Faces[3].sprite = QuadradoSprite[Quadrados[chaos]];
            Quadrados.RemoveAt(chaos);
        }
    }
    public void Face4()
    {
        if (Quadrados.Count > 0)
        {
            SetChaos();
            SetFace(4);
            Debug.Log(chaos);
            Quadrados.RemoveAt(chaos);
        }
        else
        {
            AddNumber();
            chaos = Random.Range(0, Quadrados.Count);
            Faces[4].sprite = QuadradoSprite[Quadrados[chaos]];
            Quadrados.RemoveAt(chaos);
        }
    }
    public void Face5()
    {
        if (Quadrados.Count > 0)
        {
            SetChaos();
            SetFace(5);
            Debug.Log(chaos);
            Quadrados.RemoveAt(chaos);
        }
        else
        {
            AddNumber();
            chaos = Random.Range(0, Quadrados.Count);
            Faces[5].sprite = QuadradoSprite[Quadrados[chaos]];
           Quadrados.RemoveAt(chaos);
        }
    }
    public void Textinho()
    {
        Textin.SetActive(true);
    }
    public void MonsterActive()
    {
        Monster.SetActive(true);
    }
    public void AdventureGOGOGO()
    {
        SceneManager.LoadScene("Adventure");
    }

}
