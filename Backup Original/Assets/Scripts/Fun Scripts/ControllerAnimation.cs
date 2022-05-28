using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerAnimation : MonoBehaviour
{
    public A A;
    public Combat Combat;
    public F F;
    public Generic Generic;
    public int idchara;
    public List<Transform> CharaTransform;
    public List<StaticAnimation> Charas;
    public int x;
    public int debuga;
    public List <GameObject> Gambiarra; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            Debug.Log("Anime");
            Gambiarra[5].SetActive(false);
            Gambiarra[5].SetActive(true);

            A.BunecosAnimados[5].Play("DaggerAttack2");
        }
    }
    public void AnimationSkill(int Ally, int TypeAttack)
    {
        if (Ally == 1)
        {
            idchara = Generic.Buneco(F.y);
        }
        else
        {
            idchara = Generic.Buneco(F.z);
        }


        
        AttackClass(idchara, TypeAttack);
    }
    public void AnimationAttack()
    {
     /*  if (F.AllyWin == 1)
        {
            idchara = Generic.Buneco(F.y);
            //Futuro adiciona classes
            if (Combat.SkillIDA == 1)
            {

                AttackClass(idchara, 1);
            }
            if (Combat.SkillIDA == 2)
            {

                AttackClass(idchara, 2);
            }
            if (Combat.SkillIDA == 3)
            {

                AttackClass(idchara, 3);
            }
            if (Combat.SkillIDA == 4)
            {

                AttackClass(idchara, 4);
            }
        }
        else
        {
            idchara = Generic.Buneco(F.z);
            if (Combat.SkillIDE == 1)
            {

                AttackClass(idchara, 1);
            }
            if (Combat.SkillIDE == 2)
            {

                AttackClass(idchara, 2);
            }
            if (Combat.SkillIDE == 3)
            {

                AttackClass(idchara, 3);
            }
            if (Combat.SkillIDE == 4)
            {

                AttackClass(idchara, 4);
            }
        }


        Debug.Log("Animação");
     */

    }
    public void SetPosition(int chara)
    {
        x = chara;
        A.BunecosAnimados[chara].Play("CharacterBase0");

    }
    public void SetPosition1(int chara)
    {
        if (x == chara)
        {
            if (x > 3)
            {
                CharaTransform[chara].localPosition = new Vector3(232.6f, 158.3f, 0);
            }
            else
            {
                CharaTransform[chara].localPosition = new Vector3(275.6f, 158.3f, 0);
            }
            x = 0;
            
        }
    }
    public void teste()
    {
        Debug.Log("IIIIIIII");
        A.BunecosAnimados[idchara].Play("DaggerAttack2");
        Debug.Log(idchara);
    }
    public void AttackClass(int id, int attack)
    {
        Debug.Log("debug");
        Debug.Log(debuga);
        debuga += 1;

        if (Charas[id].Style == 1 && attack==1)
        {
            Debug.Log("AAAAAAAAAAAAAA");
            Gambiarra[5].SetActive(false);
            Gambiarra[5].SetActive(true);
            A.BunecosAnimados[id].Play("DaggerAttack2");
        }
        if (Charas[id].Style == 1 && attack == 2)
        {

            A.BunecosAnimados[idchara].Play("SuperAttack");
        }
        if (Charas[id].Style == 1 && attack == 3)
        {
            A.BunecosAnimados[idchara].Play("BlockAnim");
        }
        if (Charas[id].Style == 1 && attack == 4)
        {
            A.BunecosAnimados[idchara].Play("CounterAttack");
        }
        if (Charas[id].Style == 1 && attack == 5)
        {
            Debug.Log("EEEEEEEEEEEE");
            Invoke("teste", 1);
            //A.BunecosAnimados[idchara].Play("DaggerAttack1");
        }
    }
    public void BasicAttack()
    {
        if (F.AllyWin == 1)
        {
            idchara = Generic.Buneco(F.z);
        }
        else
        {
            idchara = Generic.Buneco(F.y);
        }
        if (Charas[idchara].Style == 1)
        {
            A.BunecosAnimados[idchara].Play("DaggerAttack1");
        }
            
    }
    public void Pain(bool Ally)
    {
        if (Ally == true)
        {
            A.BunecosAnimados[2].Play("Pain");
        }
        else
        {
            A.BunecosAnimados[5].Play("Pain");
        }



    }
    public void NormalizeChara()
    {
        for (int x = 1; x < 7; x = x + 1)
        {
                


            A.BunecosAnimados[x].Play("CharacterBase0");
        }
        CharaTransform[1].localPosition = new Vector3(310.9f, 195.2f, 0);
        CharaTransform[2].localPosition = new Vector3(360.5f, 158.3f, 0);
        CharaTransform[3].localPosition = new Vector3(401.4f, 103.5f, 0);
        CharaTransform[4].localPosition = new Vector3(159.1f, 195.2f, 0);
        CharaTransform[5].localPosition = new Vector3(114.5f, 158.3f, 0);
        CharaTransform[6].localPosition = new Vector3(65.7f, 103.5f, 0);
    }
}
