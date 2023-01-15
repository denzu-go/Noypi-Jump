using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update

    
    public static float time;

    public static GameObject[] musicObj;

    public void Awake()
    {
        musicObj = GameObject.FindGameObjectsWithTag("Music");
        if (musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
      

    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.P) && LevelButtons.level >= 1)
        {
           
            SceneManager.LoadScene(25);
        }

    }

    //MENU
    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }

    public void Cuztomize()
    {
        SceneManager.LoadScene(3);
    }

    

    public void QuitGame(){
        Debug.Log("Quit");
        Application.Quit(); 
    }


  

 
}
