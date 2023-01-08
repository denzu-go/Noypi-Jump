using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public static int level;
    public static float time;


    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
      

    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.P) && level >= 1)
        {
           
            SceneManager.LoadScene(19);
        }

    }

    //MENU
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Cuztomize()
    {
        SceneManager.LoadScene(2);
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
     
    }

    public void QuitGame(){
        Debug.Log("Quit");
        Application.Quit(); 
    }

    //OptionInGame

    public void Resume()
    {
        level--;
    
        SceneManager.LoadScene(3);
    }

 
}
