using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
   // public GameObject impactEffect;
    private float life = 60f;
    // Start is called before the first frame update

     private void OnTriggerEnter2D(Collider2D collision)
    {
       //ContactPoint contact = collision.contacts[0];
      //   Instantiate(impactEffect,contact.point,Quaternion.LookRotation(contact.normal));
        if(collision.gameObject.name == "EnemyPlayer" ){
           EnemyPlayer script = collision.transform.gameObject.GetComponent<EnemyPlayer>();
           if(script != null){
            script.ApplyLife(life);
           }
            //Animator enemyAnimator = script.GetComponent<Animator>();
           // enemyAnimator.SetBool("isDying",true);
            Destroy(gameObject);
        }
        
    }
  
}
