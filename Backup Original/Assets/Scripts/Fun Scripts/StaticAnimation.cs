using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticAnimation : MonoBehaviour
{
    public ControllerAnimation ControllerAnimation;
    public int id;
    public int Style;
    public F F;
    public bool Ally;
    // Start is called before the first frame update
    public void A()
    {
        ControllerAnimation.SetPosition(id);
    }
    public void B()
    {
        ControllerAnimation.SetPosition1(id);


    }
    public void C()
    {
        ControllerAnimation.Pain(Ally);
    }
    public void D()
    {
        ControllerAnimation.BasicAttack();
    }
    public void E()
    {
        ControllerAnimation.ChangeBar();
    }
    public void CallF()
    {
        F.C();
    }
}
