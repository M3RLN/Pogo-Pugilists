﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int livesp1;
    public int livesp2;
    public Text livesTextp1;
    public Text livesTextp2;
    


    // Start is called before the first frame update
    void Start()
    {
        livesTextp1.text = "Player 1 Lives: " + livesp1;
        livesTextp2.text = "Player 2 Lives: " + livesp2;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void UpdatePlyer1Lives(int p1)
    {
        livesp1 = p1;
        livesTextp1.text = "Player 1 Lives: " + livesp1;
    }

    public void UpdatePlyer2Lives(int p2)
    {
        livesp2 = p2;
        livesTextp2.text = "Player 2 Lives: " + livesp2;
    }

}
