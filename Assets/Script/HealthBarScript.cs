using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{

    public PlayerLife playerLife;
   

    float percentage;
	 Image fill;


    void Start() {
        fill = GetComponent<Image>();
        playerLife = GameObject.Find("MainPlayer").GetComponent<PlayerLife>();
        playerLife.currentHP = playerLife.maxHP;
    }


    void Update() { 
            percentage = (float) playerLife.currentHP/playerLife.maxHP;
            fill.fillAmount = percentage;
    }

}
