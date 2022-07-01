using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prayer : MonoBehaviour
{
    public bool Voar;
    public Rigidbody2D Playor;
    public int force;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            Voar = true;
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {

            Voar = false;
        }
    }
    void FixedUpdate()
    {
        if (Voar == true)
        {
            Playor.AddForce(new Vector2(0, force));
        }
    }
}
