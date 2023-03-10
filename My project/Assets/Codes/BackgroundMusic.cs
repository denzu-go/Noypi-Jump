using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cinemachine.DocumentationSortingAttribute;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class BackgroundMusic : MonoBehaviour
{


    public GameObject Music;
    private AudioSource kagome;

    private void Start()
    {
        Music = GameObject.FindWithTag("Music");
        kagome = Music.GetComponent<AudioSource>();
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.P) && LevelButtons.level >= 1)
        {

            SceneManager.LoadScene(19);
        }

    }


    public void Resume()
    {
        LevelButtons.level--;

        SceneManager.LoadScene(4);
    }
    public void PlayGame()
    {
        kagome.Stop();
        SceneManager.LoadScene(2);
        LevelButtons.level = 0; 
    }

  

    public void Back()
    {
        kagome.Stop();
        SceneManager.LoadScene(1);

    }

  


  
}
