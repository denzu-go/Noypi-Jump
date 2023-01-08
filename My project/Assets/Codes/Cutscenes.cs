using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Cutscenes : MonoBehaviour
{
    // Start is called before the first frame update

    public static float time = 7f;
    private int index = 1;


    public void Awake()
    {
     
    }
    void Start()
    {
        StartCoroutine(TimeDelay(time));
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(index);
        }
    }   

    public IEnumerator TimeDelay( float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(index);
    }
}
