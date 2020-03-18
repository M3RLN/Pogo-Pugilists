using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectionScript : MonoBehaviour
{
    public bool p1;
    public bool p2;
    public Text selectionText;
    public StaticItemSelection sis;
    public GameObject myOb;
    // Start is called before the first frame update
    void Start()
    {
        p1 = true;
        p2 = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!p1 && !p2)
        {
            DontDestroyOnLoad(myOb);
            SceneManager.LoadScene("SampleScene");
        }
        if (p1)
        {
            selectionText.text = "Player 1 Choose your PowerUp";
        }
        else if (p2)
        {
            selectionText.text = "Player 2 Choose your PowerUp";
        }
        
    }

    public void choice1Selected()
    {
        if (p1)
        {
            sis.choice1p1();
            p1 = false;
            p2 = true;
        }
        else
        {
            sis.choice1p2();
            p2 = false;
        }
    }

    public void choice2Selected()
    {
        if (p1)
        {
            sis.choice2p1();
            p1 = false;
            p2 = true;
        }
        else
        {
            sis.choice2p2();
            p2 = false;
        }
    }
    public void choice3Selected()
    {
        if (p1)
        {
            sis.choice3p1();
            p1 = false;
            p2 = true;
        }
        else
        {
            sis.choice3p2();
            p2 = false;
        }
    }

}
