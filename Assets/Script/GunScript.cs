using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunScript : MonoBehaviour
{

    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    
    private float speed = 200f;
    public int bulletAmount = 5;
    public Text eggTxt;
    [SerializeField] AudioSource collectionSound;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown( "space")){
          if(bulletAmount != 0){
            bulletAmount --;
            eggTxt.text = bulletAmount.ToString();
            GameObject bullet =  Instantiate(bulletPrefab,bulletSpawnPoint.position,bulletSpawnPoint.rotation);
                bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.right * speed;
                Destroy(bullet,.5f);
                collectionSound.Play();
          }
          

        }
    }
}
