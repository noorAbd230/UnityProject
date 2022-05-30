using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] AudioSource deathSound;
    public GameObject winMenu;
    public int currentHP = 100;
    public int maxHP = 100;
    bool dead = false;

    void Awake(){
        currentHP = 100;
        maxHP = 100;
    }
    private void Update()
    {
        if (transform.position.y < -4f && !dead)
        {
            Die();
        }

        if(currentHP<=0){
            Die();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("thron"))
        {
            currentHP-=10;
        }else

        if (collision.gameObject.CompareTag("Apple"))
        {
            Destroy(collision.gameObject);
            currentHP-=10;
        }else

        if (collision.gameObject.CompareTag("Heart"))
        {
            Destroy(collision.gameObject);
            currentHP+=10;
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            currentHP-=20;
        }

        if (collision.gameObject.CompareTag("End"))
        {
            winMenu.SetActive(true);
        }
    }

    void Die()
    { 
        Invoke(nameof(ReloadLevel), 1.3f);
        dead = true;
        currentHP=0;
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
