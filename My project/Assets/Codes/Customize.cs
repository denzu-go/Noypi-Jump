using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Customize : MonoBehaviour

{

   
    
    public SpriteRenderer Head;
    public SpriteRenderer Body;
    public SpriteRenderer Rarm;
    public SpriteRenderer Larm;
    public SpriteRenderer Rleg;
    public SpriteRenderer Lleg;

    public string Name;


   
    public GameObject Character;



    public List<Sprite> Heads = new List<Sprite>();
    public List<Sprite> Bodys = new List<Sprite>();
    public List<Sprite> Rarms = new List<Sprite>();
    public List<Sprite> Larms = new List<Sprite>();
    public List<Sprite> Rlegs = new List<Sprite>();
    public List<Sprite> Llegs = new List<Sprite>();

    private static int currentOption = 0;

    private void Start()
    {
        Name = "Caloocan Boy";
        
    }
    public void NextOption()
    {
        currentOption++;
        if (currentOption >= Heads.Count)
        {
            currentOption = 0;
        }

        Head.sprite = Heads[currentOption];
        Body.sprite = Bodys[currentOption];
        Rarm.sprite = Rarms[currentOption];
        Larm.sprite = Larms[currentOption];
        Rleg.sprite = Rlegs[currentOption];
        Lleg.sprite = Llegs[currentOption];

     
    }


    public void submit()
    {

        
            SceneManager.LoadScene(1);
     
    }

}

