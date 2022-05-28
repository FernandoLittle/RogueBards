using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M : MonoBehaviour
{
    public F f;
    public GameObject a;

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
        gameObject.SetActive(false);
        Debug.Log("Script M");
        //f.C();
    }
    public void B()
    {
        a.SetActive(true);
    }
}
