using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  StaticItemSelection : MonoBehaviour
{
    public static bool[] p1choices = new bool[3];
    public static bool[] p2choices = new bool[3];
    
    public static bool[] getP1()
    {
        return p1choices;
    }

    public static bool[] getP2()
    {
        return p2choices;
    }


    public void choice1p1()
    {
        p1choices[0] = true;
        p1choices[1] = false;
        p1choices[2] = false;
    }

    public void choice1p2()
    {
        p2choices[0] = true;
        p2choices[1] = false;
        p2choices[2] = false;
    }

    public void choice2p1()
    {
        p1choices[0] = false;
        p1choices[1] = true;
        p1choices[2] = false;
    }

    public void choice2p2()
    {
        p2choices[0] = false;
        p2choices[1] = true;
        p2choices[2] = false;
    }

    public void choice3p1()
    {
        p1choices[0] = false;
        p1choices[1] = false;
        p1choices[2] = true;
    }

    public void choice3p2()
    {
        p2choices[0] = false;
        p2choices[1] = false;
        p2choices[2] = true;
    }
}
