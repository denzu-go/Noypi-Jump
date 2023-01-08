using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Delay : MonoBehaviour
{
    public static int loadIndex;
    public int addLevel;



    void Start()
    {

        loadIndex = MainMenu.level;
        MainMenu.level++;
        StartCoroutine(TimeDelay());

    }

    void Update()
    {
        
    }


    public IEnumerator TimeDelay()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + (loadIndex));
    }

}
