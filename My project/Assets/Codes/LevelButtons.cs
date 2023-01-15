using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelButtons : MonoBehaviour
{
    // Start is called before the first frame update\

    public static int level;
  
    public GameObject Music;
    private AudioSource kagome;

    void Start()
    {
        Music = GameObject.FindWithTag("Music");
        kagome = Music.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Button1()
    {
       kagome.Play();
        SceneManager.LoadScene(4);

        level = 1;

    }

    public void Button2()
    {
        kagome.Play();
        SceneManager.LoadScene(4);

        level = 3;

    }

    public void Button3()
    {
        kagome.Play();
        SceneManager.LoadScene(4);

        level = 4;

    }

    public void Button4()
    {
        kagome.Play();
        SceneManager.LoadScene(4);

        level = 5;

    }

    public void Button5()
    {
        kagome.Play();
        SceneManager.LoadScene(4);

    level = 6;

    }

    public void Button6()
    {
        kagome.Play();
        SceneManager.LoadScene(4);

        level = 7;

    }

    public void Button7()
    {
        kagome.Play();
        SceneManager.LoadScene(4);

        level = 9;

    }

    public void Button8()
    {
        kagome.Play();
        SceneManager.LoadScene(4);

        level = 10;

    }

    public void Button9()
    {
        kagome.Play();
        SceneManager.LoadScene(4);

        level = 11;

    }

    public void Button10()
    {
        kagome.Play();
        SceneManager.LoadScene(4);

        level = 12;

    }

    public void Button11()
    {
        kagome.Play();
        SceneManager.LoadScene(4);

        level = 13;

    }

    public void Button12()
    {
        kagome.Play();
        SceneManager.LoadScene(4);

       level = 15;

    }

    public void Button13()
    {
        kagome.Play();
        SceneManager.LoadScene(4);

       level = 16;

    }

    public void Button14()
    {
        kagome.Play();
        SceneManager.LoadScene(4);

        level = 17;

    }

    public void Button15()
    {
        kagome.Play();
        SceneManager.LoadScene(4);

        level = 18;

    }

    public void Back()
    {

        SceneManager.LoadScene(1);

    }
}
