using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int coins = 0;
    int eggs = 0;

    public Text coinTxt;
    public Text eggTxt;
     GunScript gunScript;
    [SerializeField] AudioSource collectionSound;



        void Start(){
            gunScript = GetComponent<GunScript>();
        }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject);
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;
            coinTxt.text = coins.ToString();
            PlayerPrefs.SetInt("coins",coins);
            collectionSound.Play();
        }else if (other.gameObject.CompareTag("Egg"))
        {
            Destroy(other.gameObject);
            gunScript.bulletAmount ++;
            eggs = gunScript.bulletAmount;
            eggTxt.text = eggs.ToString();
           
            collectionSound.Play();
            
        }

        
    }
}
