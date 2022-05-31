using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseGame(){
        Debug.Log("Pause clicked");
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

   public void ResumeGame(){
       Debug.Log("Resume clicked");
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void RetryGame(){
        SceneManager.LoadScene(0);
    }
}
