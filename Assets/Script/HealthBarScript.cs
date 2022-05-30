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
        if(playerLife!=null)
        playerLife.currentHP = playerLife.maxHP;
    }


    void Update() { 
         if(playerLife != null)
            percentage = (float) playerLife.currentHP/playerLife.maxHP;
            fill.fillAmount = percentage;
    }

}
