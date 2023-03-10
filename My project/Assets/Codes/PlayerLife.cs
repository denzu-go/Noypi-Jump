using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;




public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    public AudioSource deathsound;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
   
    }
    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        this.gameObject.GetComponent<Animator>().SetTrigger("Death");
        deathsound.Play();
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}
