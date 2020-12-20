﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public GameObject player, minimap, can;
    // Start is called before the first frame update
    void Start()
    {
        can.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider Player)
    {
        player.SetActive(false);
        minimap.SetActive(false);
        can.SetActive(true);


    }
}
