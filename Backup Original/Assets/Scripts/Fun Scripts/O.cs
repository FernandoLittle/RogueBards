using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O : MonoBehaviour
{
    public int a;
    public List<B> Zone;
    public int Chaos;
    public int Chaos1;
    //Move button.
    public E e;
    //Combat button;
    public E e1;
    //Pass Button
    public E e2;
    //Campeões Aliados que podem ser selecionados
    public List<int> Champ1;
    //Zonas que podem ser selecionadas
    public List<int> Champ2;
    public F f;
    public GameObject Tuto1;
    public Tutorial Tuto;
    public D d;
    public GameObject Disable;
    public A AA;
    public I NexusE;
    public Q Q;
    public List<int> Allys;
    public List<int> Enemys;
    public int ally;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void A()
    {
        Debug.Log("IA");

        //a*=-1;
        //if (a == 1)
        if (Q.a.Count == 0 && AA.offline==true)
        {
            Debug.Log("IA2");
            Debug.Log(NexusE.id * NexusE.side);

            if (NexusE.id * NexusE.side < 0)
            {
                Debug.Log("IA3");
                SelectIA();

               /* AA.DisableA(true);
                e.EnemyV = true;
                e1.EnemyV = true;
                //Select allied champ
                Champ1.Clear();
                for (int x = 1; x < Zone.Count; x = x + 1)
                {
                    if (Zone[x].idcard1 > 0)
                    {
                        Champ1.Add(x);
                    }
                }
                Chaos = Random.Range(0, Champ1.Count);
                Chaos = Champ1[Chaos];
                Zone[Chaos].anime.Play("AI1");
                //Select target zone
                //Invoke("B",1);
                Champ2.Clear();
                if (Chaos == 1)
                {
                    Champ2.Add(7);
                    Champ2.Add(6);
                    Champ2.Add(2);
                    Champ2.Add(5);

                }
                if (Chaos == 2)
                {
                    Champ2.Add(6);
                    Champ2.Add(1);
                    Champ2.Add(5);
                    Champ2.Add(4);
                    Champ2.Add(3);

                }
                if (Chaos == 3)
                {
                    Champ2.Add(8);
                    Champ2.Add(4);
                    Champ2.Add(2);
                    Champ2.Add(5);

                }
                if (Chaos == 4)
                {
                    Champ2.Add(9);
                    Champ2.Add(3);
                    Champ2.Add(5);
                    Champ2.Add(2);

                }
                if (Chaos == 5)
                {
                    Champ2.Add(3);
                    Champ2.Add(4);
                    Champ2.Add(2);
                    Champ2.Add(1);
                    Champ2.Add(6);


                }
                if (Chaos == 6)
                {
                    Champ2.Add(10);
                    Champ2.Add(1);
                    Champ2.Add(5);
                    Champ2.Add(2);

                }
                if (Chaos == 7)
                {
                    Champ2.Add(1);
                    Champ2.Add(2);

                }
                if (Chaos == 8)
                {
                    Champ2.Add(2);
                    Champ2.Add(3);

                }
                if (Chaos == 9)
                {
                    Champ2.Add(4);
                    Champ2.Add(5);

                }
                if (Chaos == 10)
                {
                    Champ2.Add(5);
                    Champ2.Add(6);

                }
                for (int x = Champ2.Count - 1; x >= 0; x = x - 1)
                {
                    if (Zone[Champ2[x]].Code[5] == true)
                    {
                        Champ2.Remove(Champ2[x]);
                    }
                }
                if (Champ2.Count == 0)
                {
                    F();
                }
                e.Lyoko0.Clear();

                for (int x = 0; x < Zone[Chaos].Lyoko.Count; x = x + 1)
                {
                    e.Lyoko0.Add(Zone[Chaos].Lyoko[x]);
                }
                //Invoke("B", 1);
                //StartCoroutine("Select1");
               */
            }
               
        }
               


    }
    public void SelectAlly()
    {
        if (NexusE.id * NexusE.side < 0)
        {

            AA.AnimeFight(ally);
        }
    }
    public void ActiveSkills()
    {
        Debug.Log("IA");
        if (NexusE.id * NexusE.side < 0)
        {
            Debug.Log("IA2");
            AA.Skills[2].SetActive(true);
            AA.Skills[3].SetActive(true);
            AA.Skills[4].SetActive(true);
            AA.Skills[5].SetActive(true);

            AA.Blue[7].SetActive(true);
            AA.Blue[8].SetActive(true);
            AA.Blue[9].SetActive(true);
            AA.Blue[10].SetActive(true);

            AA.Blue[6].SetActive(false);
            AA.Blue[5].SetActive(false);
            AA.Blue[4].SetActive(false);
            AA.Blue[3].SetActive(false);
            AA.Blue[2].SetActive(false);
            AA.Blue[1].SetActive(false);
            AA.ib[0].enabled = true;
            //Blue[11].SetActive(true);

            AA.Orientation.text = "Select Skill";
            AA.DD.SetInfo();
            AA.DD.Normalizator();
            AA.DisableO.SetActive(false);
            AA.NormalizatorAnimation();
        }


        //a.F.card1 = idcard2;
    }
    public void SelectIA()
    {

        int SelectAlly;
        int SelectEnemy;
        Allys.Clear();
        Enemys.Clear();
        for (int x = 1; x < 4; x = x + 1)
        {
            if (AA.Zone[x+3].side > 0 && AA.Zone[x+3].Lyoko[0]>0)
            {
                Allys.Add(AA.Zone[x+3].idzone1);
            }
            if (AA.Zone[x].side < 0 && AA.Zone[x].Lyoko[0] > 0)
            {
                Enemys.Add(AA.Zone[x].idzone1);
            }
        }
        SelectAlly = Allys[Random.Range(0, Allys.Count)];
        ally = SelectAlly;
        SelectEnemy = Enemys[Random.Range(0, Enemys.Count)];
        PlayerPrefs.SetInt("A", AA.Zone[SelectAlly].idcard1);
        PlayerPrefs.SetInt("A1", AA.Zone[SelectEnemy].idcard1);
        AA.F.z = SelectEnemy;
        AA.F.y = SelectAlly;
        AA.AnimeFight(SelectEnemy);




    }
    public void B()
    {

        Chaos1 = Random.Range(0, Champ2.Count);
        Chaos1 = Champ2[Chaos1];
        Zone[Chaos1].anime.Play("AI2");
        //Invoke("C", 1);
       // StartCoroutine("Select2");
    }
    public void C()
    {

        e.idcard1 = Zone[Chaos1].idcard1;
        e.idcard2 = Zone[Chaos].idcard1;
        e.idzone1 = Zone[Chaos1].idzone1;
        e.idzone2 = Zone[Chaos].idzone1;
        e.Zonesprite0 = Zone[Chaos1].Zonesprite0;

        f.y = Zone[Chaos1].idzone1;
        f.z = Zone[Chaos].idzone1;
        f.card1 = Zone[Chaos1].idcard1;
        f.card2 = Zone[Chaos].idcard1;
        e1.idcard1 = Zone[Chaos].idcard1 * -1;
        e1.idcard2 = Zone[Chaos1].idcard1;
        e1.idzone1 = Zone[Chaos].idzone1;
        e1.idzone2 = Zone[Chaos1].idzone1;
        e1.Zonesprite0 = Zone[Chaos].Zonesprite0;


        e.Lyoko1.Clear();

        for (int x = 0; x < Zone[Chaos1].Lyoko.Count; x = x + 1)
        {
            e.Lyoko1.Add(Zone[Chaos1].Lyoko[x]);
        }

        if (Zone[Chaos].idcard1 * Zone[Chaos1].idcard1 >= 0)
        {

            D();
        }
        else
        {

            E();
        }
    }
    public void D()
    {
        PlayerPrefs.SetInt("A", Zone[Chaos1].idcard1 * -1);
        PlayerPrefs.SetInt("B", Zone[Chaos1].idzone1);

        e.B();
        a *= -1;
       // Invoke("A", 1);
        if (Tuto.tf == 1)
        {
            if (Tuto.ax == 1)
                Tuto.ax += 1;
        }

    }
    public void E()
    {

        PlayerPrefs.SetInt("A", Zone[Chaos1].idcard1 * -1);
        PlayerPrefs.SetInt("B", Zone[Chaos1].idzone1);


        e1.A();
    }
    public void F()
    {




        e2.F();
    }
    IEnumerator Select1()
    {

        yield return new WaitForSeconds(1);
        B();
    }
    IEnumerator Select2()
    {
        yield return new WaitForSeconds(1);
        C();
    }
}
