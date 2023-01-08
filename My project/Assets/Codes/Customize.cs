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


    public GameObject Text;
    public GameObject Character;


    public List<Sprite> Heads = new List<Sprite>();
    public List<Sprite> Bodys = new List<Sprite>();
    public List<Sprite> Rarms = new List<Sprite>();
    public List<Sprite> Larms = new List<Sprite>();
    public List<Sprite> Rlegs = new List<Sprite>();
    public List<Sprite> Llegs = new List<Sprite>();

    private int currentOption = 0;

    private void Start()
    {
        Name = "Caloocan Boy";
        Text.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = Name + "";
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

        if (currentOption == 0)
        {
            Name = "Caloocan Boy";
            Text.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = Name + "";
        }
        if (currentOption == 1)
        {
            Name = "BULALORD";
            Text.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = Name + "";
        }
        if (currentOption == 2)
        {
            Name = "Cardo Dalisay";
            Text.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = Name + "";
        }
        if (currentOption == 3)
        {
            Name = "ED Caluag";
            Text.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = Name + "";
        }
        if (currentOption == 4)
        {
            Name = "OTLUM";
            Text.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = Name + "";
        }
        if (currentOption == 5)
        {
            Name = "Queen Yasmin";
            Text.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = Name + "";
        }

    }




}

