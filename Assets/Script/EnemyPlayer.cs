using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlayer : MonoBehaviour
{

     Rigidbody2D rb;
     //public PolygonCollider2D box;
    public float walkSpeed= 1f;


    public float health = 100f;
    public GameObject deadEffect;

     private bool created = false;
    //private Animator enemyAnimator ;


    public void ApplyLife(float amount){
        health -= Mathf.Abs(amount);

        if(health <= 0){
            if(!created){
                Instantiate(deadEffect,transform.position,Quaternion.identity);
                 Destroy(gameObject);
                created = true;
            }

           
        }

    }

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }


    void Update(){
            if(gameObject.name=="SnowwhiteEnemy"){
               rb.AddForce(new Vector2(0, 2f)); 
            }
        
            if(isFacingRight()){
                rb.velocity = new Vector2(walkSpeed,0f);
            }else{
                rb.velocity = new Vector2(-walkSpeed,0f);
            }
    }

   private bool isFacingRight(){
       return transform.localScale.x > Mathf.Epsilon;
    }


    private void OnTriggerEnter2D(Collider2D collision){
        Debug.Log(collision.gameObject);
         transform.localScale = new Vector2(-(Mathf.Sign(rb.velocity.x)),transform.localScale.y);
    }

    //   public float speed;
    // public float distance;

    // private bool movingRight = true;

    // public Transform groundDetection;

    // private void Update()
    // {
    //     transform.Translate(Vector2.right * speed * Time.deltaTime);

    //     RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
    //     if (groundInfo.collider == false)
    //     {
    //         if (movingRight == true)
    //         {
    //             transform.eulerAngles = new Vector3(0, -180, 0);
    //             movingRight = false;
    //         }
    //         else
    //         {
    //             transform.eulerAngles = new Vector3(0, 0, 0);
    //             movingRight = true;
    //         }
    //     }
    // }
//     [HideInInspector]
//     public bool mustPatrol, mustTurn;
//     public Rigidbody2D rb;
//     public float walkSpeed;

    
//     public Transform groundCheck;
//     public LayerMask groundLayer;
//     // Start is called before the first frame update
//     void Start()
//     {
//      mustPatrol = true;   
//     }

//     // Update is called once per frame
//     void Update()
//     {
       
//        if(mustPatrol){
//            Patrol();
//        } 
//     }

// //    private void FixedUpdate(){
// //        if(mustPatrol){
// //            mustTurn = !Physics2D.OverlapCircle(groundCheck.position,0.1f,groundLayer);
// //        }
// //    }
//    void Patrol(){
//        if(mustTurn){
//            Flip();
//        }
//        rb.velocity = new Vector2(walkSpeed * Time.deltaTime, rb.velocity.y);
//     }

//     void Flip(){
//         mustPatrol = false;
//        transform.localScale = new Vector2(transform.localScale.x * -1,transform.localScale.y);
//        walkSpeed *= -1;
//        mustPatrol = true;
//        mustTurn = false;
//     }
}
