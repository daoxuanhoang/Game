﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hscore : MonoBehaviour
{
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = "Hight Score: " + player.Hscore;
    }
}
