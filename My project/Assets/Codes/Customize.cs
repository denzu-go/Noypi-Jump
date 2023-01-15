using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

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
    public List<String> CharacterName = new List<String>();  
  
    private static int currentOption = 0;


    private void Start()
    {  
       Name = "Caloocan Boy";
        MySelectedCharacter(PlayerPrefs.GetInt("MySelectedCharacter_Int"));
        
        Debug.Log("Num : "+currentOption);
    }
    public void NextOption()
    {
        if (currentOption >= Heads.Count)
        {
            currentOption = 0;
        }
        else
        {
            currentOption+=1;
           
            
            PlayerPrefs.SetInt("MySelectedCharacter_Int", currentOption);
            PlayerPrefs.Save();
        }
       

        Head.sprite = Heads[currentOption];
        Body.sprite = Bodys[currentOption];
        Rarm.sprite = Rarms[currentOption];
        Larm.sprite = Larms[currentOption];
        Rleg.sprite = Rlegs[currentOption];
        Lleg.sprite = Llegs[currentOption];
       // Name = CharacterName[currentOption];

     
    }


    
    public void MySelectedCharacter(int thisOption)
    {   
        if(SceneManager.GetActiveScene().name != "Customize")
        {
            Head.sprite = Heads[thisOption];
            Body.sprite = Bodys[thisOption];
            Rarm.sprite = Rarms[thisOption];
            Larm.sprite = Larms[thisOption];
            Rleg.sprite = Rlegs[thisOption];
            Lleg.sprite = Llegs[thisOption];
            Name = CharacterName[thisOption];
        }
     
    }


    public void submit()
    { 
            SceneManager.LoadScene(1);
     
    }

}

