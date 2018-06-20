﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Slider heathUI;
    public Image playerImage;
    public Text playerName;
    public Text lives;

    private Player player;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<Player>();
        heathUI.maxValue = player.maxHealth;
        heathUI.value = heathUI.maxValue;
        playerName.text = player.playerName;
        playerImage.sprite = player.playerImage;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateHealth(int amount)
    {
        heathUI.value = amount;
    }

    

}
